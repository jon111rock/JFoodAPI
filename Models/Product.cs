using System.ComponentModel.DataAnnotations;

namespace JFoodAPI.Models
{
  public class Product
  {
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    public string Price { get; set; }

    [Required]
    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    public int State { get; set; }

    public string PhotoUrl { get; set; }

    public ProductType ProductType { get; set; }
  }
}