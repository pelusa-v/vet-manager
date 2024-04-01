using vet_manager.Core.Enums;

namespace vet_manager.Core.Entities.Money;

public class OperationAdditional
{
    public Guid Id { get; set; }
    public string Reason { get; set; }
    public decimal? Ammount { get; set; }
    public OperationAdditionalType Type { get; set; }
    
    public Guid OperationId { get; set; }
    public Operation Operation { get; set; }
}
