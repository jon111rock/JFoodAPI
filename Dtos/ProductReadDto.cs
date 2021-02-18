using JFoodAPI.Models;

namespace JFoodAPI.Dtos
{
  public class ProductReadDto
  {
    public string Id { get; set; }

    public string Name { get; set; }

    public string Price { get; set; }

    public string Description { get; set; }

    public int State { get; set; }

    public string PhotoUrl { get; set; }

    // public ProductTypeReadDto ProductType { get; set; }  

    public string ProductTypeId { get; set; }

  }
}