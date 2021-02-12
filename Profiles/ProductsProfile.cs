using AutoMapper;
using JFoodAPI.Dtos;
using JFoodAPI.Models;

namespace JFoodAPI.Profiles
{
  public class ProductsProfile: Profile
  {
    public ProductsProfile()
    {
        CreateMap<ProductReadDto, Product>();
        CreateMap<Product,ProductReadDto>();
        CreateMap<ProductCreateDto, Product>();
        CreateMap<Product,ProductCreateDto>();
        CreateMap<ProductUpdateDto, Product>();

        CreateMap<ProductType,ProductTypeDto>();
    }
  }
}