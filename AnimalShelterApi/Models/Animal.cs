using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(25)]
    public string Name { get; set; }
    [Required]
    public string PetType { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    [Range(0, 25, ErrorMessage = "Age must be between 0 and 25.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
    public string Color { get; set; }
  }
}