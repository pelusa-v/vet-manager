using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using vet_manager.Core;
using vet_manager.Core.Entities.Clients;
using vet_manager.Core.Entities.Consultations;

namespace vet_manager.DataAccess.Seed;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            if (!context.ConsultationCategories.Any())
            {
                context.ConsultationCategories.AddRange(
                    new ConsultationCategory
                    {
                        Id = 0,
                        CategoryName = "Estética",
                    },
                    new ConsultationCategory
                    {
                        Id = 1,
                        CategoryName = "Examen",
                    },
                    new ConsultationCategory
                    {
                        Id = 2,
                        CategoryName = "Intervención",
                    },
                    new ConsultationCategory
                    {
                        Id = 3,
                        CategoryName = "Cita",
                    }
                    // Add more data as needed
                );
            }

            // Look for any existing data
            if (!context.ConsultationTypes.Any())
            {
                context.ConsultationTypes.AddRange(
                    new ConsultationType
                    {
                        // Id = 0,
                        Name = "Baño",
                        Cost = 100,
                        ConsultationCategoryId = 1
                    },
                    new ConsultationType
                    {
                        // Id = 1,
                        Name = "Hemograma",
                        Cost = 100,
                        ConsultationCategoryId = 2
                    },
                    new ConsultationType
                    {
                        // Id = 2,
                        Name = "Extracción dental",
                        Cost = 100,
                        ConsultationCategoryId = 3
                    },
                    new ConsultationType
                    {
                        // Id = 3,
                        Name = "Esterilización",
                        Cost = 100,
                        ConsultationCategoryId = 3
                    },
                    new ConsultationType
                    {
                        // Id = 4,
                        Name = "Cirugía",
                        Cost = 100,
                        ConsultationCategoryId = 3
                    },
                    new ConsultationType
                    {
                        // Id = 5,
                        Name = "Consulta médica",
                        Cost = 100,
                        ConsultationCategoryId = 3
                    },
                    new ConsultationType
                    {
                        // Id = 6,
                        Name = "Control",
                        Cost = 100,
                        ConsultationCategoryId = 6
                    }
                );

            }

            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        EnrollmentDate = DateTime.Parse("2022-01-01")
                    },
                    new Client
                    {
                        FirstName = "Alice",
                        LastName = "Smith",
                        EnrollmentDate = DateTime.Parse("2022-02-01")
                    }
                );
            }

            if (!context.Breeds.Any())
            {
                context.Breeds.AddRange(
                    new Breed { Name = "Labrador Retriever" },
                    new Breed { Name = "German Shepherd" },
                    new Breed { Name = "Golden Retriever" },
                    new Breed { Name = "Persian" }
                    // Add more breeds as needed
                );
            }

            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                    new Animal { Name = "Dog" },
                    new Animal { Name = "Cat" },
                    new Animal { Name = "Bird" }
                    // Add more animals as needed
                );
            }

            if (!context.Pets.Any())
            {
                context.Pets.AddRange(
                    new Pet { Name = "Buddy", AnimalId = 1, BreedId = 1, ClientId = 1 },
                    new Pet { Name = "Max", AnimalId = 1, BreedId = 2, ClientId = 2 },
                    new Pet { Name = "Charlie", AnimalId = 2, BreedId = 3, ClientId = 1 }
                    // Add more pets as needed
                );
            }

            context.SaveChanges();
        }
    }
}