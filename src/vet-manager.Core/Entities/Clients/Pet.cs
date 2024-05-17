using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Core.Entities.Clients;

public class Pet : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    
    public int AnimalId { get; set; }
    public Animal Animal { get; set; }

    public int RaceId { get; set; }
    public Breed Breed { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }

    public ICollection<Consultation> Consultations { get; set; }
}
