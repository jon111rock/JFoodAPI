using AutoMapper;
using JFoodAPI.Dtos;
using JFoodAPI.Models;

namespace JFoodAPI.Profiles
{
  public class ProductsProfile: Profile
  {
    public ProductsProfile()
    {
        //Product
        CreateMap<ProductReadDto, Product>();
        CreateMap<Product,ProductReadDto>();
        CreateMap<ProductCreateDto, Product>();
        CreateMap<Product,ProductCreateDto>();
        CreateMap<ProductUpdateDto, Product>();

        //ProductType
        CreateMap<ProductType,ProductTypeReadDto>();
        CreateMap<ProductTypeReadDto,ProductType>();
        
        CreateMap<ProductTypeCreateDto,ProductType>();
        CreateMap<ProductType,ProductTypeCreateDto>();
        // CreateMap<ProductTypeCreateDto,ProductTypeReadDto>();
        // CreateMap<ProductTypeReadDto,ProductTypeReadDto>();
    }
  }
}