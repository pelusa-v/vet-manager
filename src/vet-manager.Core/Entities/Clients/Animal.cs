namespace vet_manager.Core.Entities.Clients;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Pet> Pets { get; set; }
}
