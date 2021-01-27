using System;
using System.Collections.Generic;
using AutoMapper;
using JFoodAPI.Data;
using JFoodAPI.Dtos;
using JFoodAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JFoodAPI.Controllers
{
  [Route("api/products")]
  [ApiController]
  public class ProductsController :ControllerBase
  {
    
    private readonly IProductRepo _repository;
    private readonly IMapper _mapper;

    public ProductsController(IProductRepo repository,IMapper mapper)
    {
        _repository=repository;
        _mapper=mapper;
    }

    //GET api/pruducts
    [HttpGet]
    public ActionResult <IEnumerable<ProductReadDto>> GetAllProducts(){

      var Products=_repository.GetAllProducts();

      return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(Products));
    }

    //GET api/products/{id}
    [HttpGet("{id}",Name="GetProductsById")]
    public ActionResult <ProductReadDto> GetProductsById(int id){

      var product=_repository.GetProductById(id);

      if(product==null){
        return NotFound();
      }
      
      return Ok(_mapper.Map<ProductReadDto>(product));
    }

    //POST api/products
    [HttpPost]
    public ActionResult <ProductReadDto> CreateProduct(ProductCreateDto productCreateDto)
    {

      var productModel=_mapper.Map<Product>(productCreateDto);
      _repository.CreateProduct(productModel);
      _repository.SaveChanges();

      var productReadDto=_mapper.Map<ProductReadDto>(productModel);

      return CreatedAtRoute(nameof(GetProductsById), new {Id=productReadDto.Id}, productReadDto);
      // return Ok(productModel);
    }

    //PUT api/product/{id}
    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id,ProductUpdateDto productUpdateDto)
    {
      var productInDB=_repository.GetProductById(id);
      if(productInDB==null)
      {
        return NotFound();
      }
      _mapper.Map(productUpdateDto, productInDB);
      _repository.SaveChanges();

      return NoContent();
    }
    
  }
}