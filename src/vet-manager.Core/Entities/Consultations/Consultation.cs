using System.ComponentModel.DataAnnotations.Schema;
using vet_manager.Core.Entities.Clients;
using vet_manager.Core.Entities.Money;

namespace vet_manager.Core.Entities.Consultations;

public class Consultation : BaseEntity
{
    public Guid Id { get; set; }
    
    public Guid? ParentConsultationId { get; set; }
    public Consultation ParentConsultation { get; set; }
    public ICollection<Consultation> RelatedConsultations { get; set; }

    public Guid OperationId { get; set; }
    public Operation Operation { get; set; }

    public int ConsultationTypeId { get; set; }
    public ConsultationType ConsultationType { get; set; }

    public int PetId { get; set; }
    public Pet Pet { get; set; }

    public string Description { get; set; }
    public string Diagnosis { get; set; }

    [NotMapped]
    public decimal TotalAmmount
    {
        get
        {
            var total = RelatedConsultations.Sum(consultation => consultation.Operation.Ammount);
            return total += Operation.Ammount;
        }
    }

    [NotMapped]
    public decimal TotalCost
    {
        get
        {
            var total = RelatedConsultations.Sum(consultation => consultation.Operation.Cost);
            return total += Operation.Cost;
        }
    }
}
