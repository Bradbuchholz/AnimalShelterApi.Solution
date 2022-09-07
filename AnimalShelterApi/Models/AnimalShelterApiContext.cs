using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options) { }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Fluffy", PetType = "Cat", Breed = "Persian", Age = 3, Gender = "Female", Color = "White" },
          new Animal { AnimalId = 2, Name = "Skittles", PetType = "Cat", Breed = "Persian", Age = 5, Gender = "Male", Color = "White" },
          new Animal { AnimalId = 3, Name = "Burger", PetType = "Cat", Breed = "Scotish Fold", Age = 9, Gender = "Male", Color = "Grey" },
          new Animal { AnimalId = 4, Name = "Loki", PetType = "Dog", Breed = "Husky", Age = 8, Gender = "Male", Color = "Black and White" },
          new Animal { AnimalId = 5, Name = "Naiya", PetType = "Dog", Breed = "Husky", Age = 12, Gender = "Female", Color = "Black and White" },
          new Animal { AnimalId = 6, Name = "Copper", PetType = "Dog", Breed = "Husky", Age = 2, Gender = "Male", Color = "Red" },
          new Animal { AnimalId = 7, Name = "Peanut Butter", PetType = "Dog", Breed = "Corgi", Age = 1, Gender = "Male", Color = "Brown and White" },
          new Animal { AnimalId = 8, Name = "Cally", PetType = "Cat", Breed = "Calico", Age = 2, Gender = "Female", Color = "Brown and White" },
          new Animal { AnimalId = 9, Name = "Princess", PetType = "Dog", Breed = "Pomeranian", Age = 5, Gender = "Female", Color = "Black" },
          new Animal { AnimalId = 10, Name = "Pringles", PetType = "Cat", Breed = "Maine Coon", Age = 7, Gender = "Male", Color = "Black and Brown" }
        );
    }
  }
}