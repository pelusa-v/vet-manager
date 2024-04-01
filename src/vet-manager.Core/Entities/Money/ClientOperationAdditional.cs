using vet_manager.Core.Entities.Clients;
using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Core.Entities.Money;

public abstract class ClientOperationAdditional
{
    public int Id { get; set; }
    public int Times { get; set; }
    public bool Always { get; set; }
    public decimal? Ammount { get; set; }
    public decimal? Percentage { get; set; }
    public bool IsPercentage { get; set; } = true;

    public int ConsultationTypeId { get; set; }
    public ConsultationType ConsultationType { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
}
