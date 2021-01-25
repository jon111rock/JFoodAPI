using System.Collections.Generic;
using JFoodAPI.Models;

namespace JFoodAPI.Data
{
  public interface IProductRepo
  {
     IEnumerable<Product> GetAllProducts();
     Product GetProductById(int id);
  }
}