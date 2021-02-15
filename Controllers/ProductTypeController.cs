using System.Collections.Generic;
using AutoMapper;
using JFoodAPI.Data;
using JFoodAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JFoodAPI.Controllers
{
  [Route("api/producttypes")]
  [ApiController]
  public class ProductTypeController : ControllerBase
  {
    private readonly IProductTypeRepo _repository;
    private readonly IMapper _mapper;

    public ProductTypeController(IProductTypeRepo repository,IMapper mapper)
    {
          _repository=repository;
          _mapper=mapper;
    }

    //GET api/producttypes
    [HttpGet]
    public ActionResult <IEnumerable<ProductTypeReadDto>> GetAllProductTypes()
    {
      var productTypes=_repository.GetAllProductTypes();
      return Ok(_mapper.Map<IEnumerable<ProductTypeReadDto>>(productTypes));
    }

    //GET api/producttypes/{id}
    [HttpGet("{id}",Name="GetProductTypeById")]
    public ActionResult <ProductTypeReadDto> GetProductTypeById(int Id)
    {
      var productType = _repository.GetProductTyoe(Id);
      if(productType==null)return NotFound();

      return Ok(_mapper.Map<ProductTypeReadDto>(productType));
    }
    
    //POST api/producttypes 
    [HttpPost]
    public ActionResult <ProductTypeReadDto> CreateProductType(ProductTypeCreateDto productTypeCreateDto)
    {
      var productType=_mapper.Map<ProductType>(productTypeCreateDto);

      _repository.CreateProductType(productType);
      _repository.SaveChanges();

      var productTypeReadDto=_mapper.Map<ProductTypeReadDto>(productType);

      return CreatedAtRoute(nameof(GetProductTypeById), new {Id=productTypeReadDto.ProductTypeId}, productTypeReadDto);
    }
  }
}