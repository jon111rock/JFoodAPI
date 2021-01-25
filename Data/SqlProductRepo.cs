using System.Collections.Generic;
using System.Linq;
using JFoodAPI.Models;

namespace JFoodAPI.Data{
  public class SqlProductRepo : IProductRepo
  {
    private readonly ProductContext _context;

    public SqlProductRepo(ProductContext context)
    {
        _context = context;
    }
    public IEnumerable<Product> GetAllProducts()
    {
      return _context.Products.ToList();
    }

    public Product GetProductById(int id)
    {
      var product=_context.Products.SingleOrDefault(p=>p.Id == id);

      return product;
    }
  }
}