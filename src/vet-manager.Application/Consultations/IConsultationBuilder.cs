using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Application.Consultations;

public interface IConsultationBuilder
{
    Task BuildOperation(decimal cost);
    void BuildConsultationType(int consultationTypeId);
    void BuildPet(int petId);
    void BuildDescription(string description);
    Consultation Get();
}