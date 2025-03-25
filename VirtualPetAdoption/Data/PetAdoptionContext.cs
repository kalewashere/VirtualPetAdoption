using Microsoft.EntityFrameworkCore;
using VirtualPetAdoption.Models;

namespace VirtualPetAdoption.Data
{
    public class PetAdoptionContext : DbContext // parent/child inheritance 
    {
        public PetAdoptionContext(DbContextOptions<PetAdoptionContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; } // attributes of the DB context - must specify what object we are creating - in this context, pets
        public DbSet<User> Users { get; set; } // same as above but with users instead of pets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed with minimal pet data - can be anything (data types in mind ofc)
            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Fluffy",
                    Species = "Cat",
                    Description = "A playful and affectionate cat.",
                    ImageUrl = "/images/cat.png",
                    Playfulness = 4,
                    Affection = 5
                },
                new Pet
                {
                    Id = 2,
                    Name = "Rex",
                    Species = "Dog",
                    Description = "An energetic dog who loves to play.",
                    ImageUrl = "/images/dog.png",
                    Playfulness = 5,
                    Affection = 4
                },
                new Pet
                {
                    Id = 3,
                    Name = "Whiskers",
                    Species = "Cat",
                    Description = "A quiet and independent cat.",
                    ImageUrl = "/images/cat2.png",
                    Playfulness = 2,
                    Affection = 3
                }
            );
        }
    }
}