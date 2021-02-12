using System.Collections.Generic;
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

    public ProductTypeController(IProductTypeRepo repository)
    {
          _repository=repository;
    }

    //GET api/producttypes
    [HttpGet]
    public ActionResult <IEnumerable<ProductType>> GetAllProductTypes()
    {
      return Ok(_repository.GetAllProductTypes());
    }

    //GET api/producttypes/{id}
    [HttpGet("{id}")]
    public ActionResult <ProductType> GetProductById(int Id)
    {
      var productType = _repository.GetProductTyoe(Id);

      return Ok(productType);
    }
    
  }
}