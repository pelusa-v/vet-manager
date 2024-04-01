namespace vet_manager.Core.Entities.Clients;

public class Pet : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    
    public int AnimalId { get; set; }
    public Animal Animal { get; set; }

    public int RaceId { get; set; }
    public Race Race { get; set; }
}
