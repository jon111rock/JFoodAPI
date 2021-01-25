using System.Collections.Generic;
using JFoodAPI.Models;

namespace JFoodAPI.Data
{
  public class MockProductRepo : IProductRepo
  {
    public IEnumerable<Product> GetAllProducts()
    {
      var Products=new List<Product>{
        new Product{Id=0, Name="Item1", Price="100", Description="Test1"},
        new Product{Id=1, Name="Item2", Price="200", Description="Test2"},
        new Product{Id=2, Name="Item3", Price="300", Description="Test3"},
      };
      return Products;
    }

    public Product GetProductById(int id)
    {
      return new Product{Id=0, Name="Item1", Price="100", Description="Test1"};
    }
  }
}