using vet_manager.Core.Entities.Consultations;
using vet_manager.Core.Entities.Products;

namespace vet_manager.Core.Entities.Money;

public class Operation
{
    public Guid Id { get; set; }
    public decimal Cost { get; set; }
    public decimal Ammount { get; set; }

    public Consultation? Consultation { get; set; }

    public ICollection<OperationAdditional> Additionals { get; set; }

    public Operation(decimal cost)
    {
        Cost = cost;
    }
}
