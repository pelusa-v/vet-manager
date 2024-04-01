using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Core.Entities.Clients;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    
    public ICollection<Consultation> Consultations { get; set; }
}
