namespace vet_manager.Core.Entities.Consultations;

public class ConsultationType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }

    public int ConsultationCategoryId { get; set; }
    public ConsultationCategory ConsultationCategory { get; set; }
    
    public ICollection<Consultation> Consultations { get; set; }
}
