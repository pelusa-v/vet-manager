namespace vet_manager.Application.Consultations.DTOs;

public class ConsultationListItemDTO
{
    public Guid Id { get; set; }
    public Guid? ParentConsultationId { get; set; }
    public Guid OperationId { get; set; }
    public int ConsultationTypeId { get; set; }
    public int PetId { get; set; }
    public string Description { get; set; }
    public string Diagnosis { get; set; }
    public decimal TotalAmmount { get; set; }
    public decimal TotalCost { get; set; }
}
