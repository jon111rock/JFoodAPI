using System.Collections.Generic;
using JFoodAPI.Models;

namespace JFoodAPI.Data
{
  public interface IProductRepo
  {
    bool SaveChanges();

     IEnumerable<Product> GetAllProducts();
     Product GetProductById(int id);
     void CreateProduct(Product product);
     void DeleteProduct(int id);
  }
}