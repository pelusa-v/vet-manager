namespace vet_manager.Application.Consultations.DTOs;

public class ConsultationDTO
{
    public Guid Id { get; set; }
    
    public Guid? ParentConsultationId { get; set; }
    public ConsultationDTO ParentConsultation { get; set; }
    public ICollection<ConsultationDTO> RelatedConsultations { get; set; }

    public Guid OperationId { get; set; }
    // public Operation Operation { get; set; }

    public int ConsultationTypeId { get; set; }
    // public ConsultationType ConsultationType { get; set; }

    public int PetId { get; set; }
    // public Pet Pet { get; set; }

    public string Description { get; set; }
    public string Diagnosis { get; set; }
    public decimal TotalAmmount { get; set; }
    public decimal TotalCost { get; set; }
}
