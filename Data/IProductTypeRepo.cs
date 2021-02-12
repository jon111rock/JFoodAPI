using System.Collections.Generic;
using JFoodAPI.Models;

namespace JFoodAPI.Data
{
  public interface IProductTypeRepo
  { 
     IEnumerable<ProductType> GetAllProductTypes ();

     ProductType GetProductTyoe(int Id);
  }
}