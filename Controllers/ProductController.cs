using System.Collections.Generic;
using JFoodAPI.Data;
using JFoodAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JFoodAPI.Controllers
{
  [Route("api/products")]
  public class ProductsController :ControllerBase{
    
    private readonly IProductRepo _repository;

    public ProductsController(IProductRepo repository)
    {
        _repository=repository;
    }

    //GET api/pruducts
    [HttpGet]
    public ActionResult <IEnumerable<Product>> GetAllProducts(){
      return Ok(_repository.GetAllProducts());
    }

    //GET api/products/{id}
    [HttpGet("{id}")]
    public ActionResult <Product> GetProductsById(int id){

      return Ok(_repository.GetProductById(id));
    }
  }
}