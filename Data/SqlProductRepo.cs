using System;
using System.Collections.Generic;
using System.Linq;
using JFoodAPI.Models;
using Microsoft.EntityFrameworkCore;

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
      return _context.Products.Include(p=>p.ProductType).ToList();
    }

    public Product GetProductById(int id)
    {
      var product=_context.Products.SingleOrDefault(p=>p.Id == id);

      return product;
    }

    public void CreateProduct(Product product)
    {
      if(product == null)
      {
      throw new ArgumentNullException(nameof(product));
      }

      _context.Products.Add(product);

    }


    public bool SaveChanges()
    {
      return (_context.SaveChanges()>=0);
    }

    public void DeleteProduct(int id)
    {
      var productInDb=_context.Products.SingleOrDefault(p=>p.Id == id);
      if(productInDb==null)
      {
        throw new ArgumentNullException(nameof(productInDb));
      }
      _context.Products.Remove(productInDb);
    }
  }
}