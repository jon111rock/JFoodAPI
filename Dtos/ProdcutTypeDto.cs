using System.ComponentModel.DataAnnotations;

namespace JFoodAPI.Models{
  public class ProductTypeDto{
    
    public int Id { get; set; }  

    public string Name { get; set; }

    public int State { get; set; }

  }
}