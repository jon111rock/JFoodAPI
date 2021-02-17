using System.Collections.Generic;
using JFoodAPI.Models;

namespace JFoodAPI.Data
{
  public interface IProductTypeRepo
  { 
     IEnumerable<ProductType> GetAllProductTypes ();

     ProductType GetProductTyoe(int Id);

     void CreateProductType(ProductType productType); 

     void DeleteProductType(int Id);
     
     void SaveChanges();
  }
}