using System.ComponentModel.DataAnnotations;

namespace JFoodAPI.Models{
  public class ProductTypeReadDto{
    
    public int ProductTypeId { get; set; }

    public string Name { get; set; }  

    public int State { get; set; }

  }
}