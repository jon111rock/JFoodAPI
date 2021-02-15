using System;
using System.Collections.Generic;
using System.Linq;
using JFoodAPI.Models;

namespace JFoodAPI.Data
{
  public class SqlProductTypeRepo : IProductTypeRepo
  {
    private readonly ProductContext _context;

    public SqlProductTypeRepo(ProductContext context)
    {
        _context = context;
    }

    public IEnumerable<ProductType> GetAllProductTypes()
    {
      return _context.ProductTypes.ToList();
    }

    public ProductType GetProductTyoe(int Id)
    {
      var productType=_context.ProductTypes.SingleOrDefault(p=>p.ProductTypeId == Id);

      return productType;
    }

    public void CreateProductType(ProductType productType)
    {
      if(productType == null)
      {
        throw new ArgumentNullException(nameof(productType));
      }
      
      _context.ProductTypes.Add(productType);
    }

    public void SaveChanges()
    {
      _context.SaveChanges();
    }
  }
}