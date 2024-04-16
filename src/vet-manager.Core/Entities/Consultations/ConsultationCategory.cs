using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Core;

public class ConsultationCategory
{
    public int Id { get; set; }
    public string CategoryName { get; set; }

    public ICollection<ConsultationType> ConsultationTypes { get; set; }
}
