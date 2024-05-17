
using vet_manager.Core.Entities.Consultations;
using vet_manager.Core.Entities.Money;
using vet_manager.DataAccess.Repositories.Money;

namespace vet_manager.Application.Consultations;

public class BasicConsultationBuilder : IConsultationBuilder
{
    private Consultation _consultation;
    private readonly IOperationRepository _operationRepo;

    public BasicConsultationBuilder(IOperationRepository operationRepo)
    {
        _operationRepo = operationRepo;
        _consultation = new Consultation();
    }

    public void BuildConsultationType(int consultationTypeId)
    {
        _consultation.ConsultationTypeId = consultationTypeId;
    }

    public void BuildDescription(string description)
    {
        _consultation.Description = description;
    }

    public async Task BuildOperation(decimal cost)
    {
        var operation = new Operation(cost);
        await _operationRepo.Create(operation);
        _consultation.OperationId = operation.Id;
    }

    public void BuildPet(int petId)
    {
        _consultation.PetId = petId;
    }

    public Consultation Get()
    {
        return _consultation;
    }
}
