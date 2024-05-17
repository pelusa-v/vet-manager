using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Core.Entities.Clients;

public class Pet : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;
    
    public int AnimalId { get; set; }
    public Animal Animal { get; set; }

    public int BreedId { get; set; }
    public Breed Breed { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }

    public ICollection<Consultation> Consultations { get; set; }

    public Pet(string name, int animalId, int breedId, int clientId)
    {
        Name = name;
        AnimalId = animalId;
        BreedId = breedId;
        ClientId = clientId;
    }
}
