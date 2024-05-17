using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Application.Consultations;

public class ConsultationDirector
{
    private readonly IConsultationBuilder _builder;

    public ConsultationDirector(IConsultationBuilder builder)
    {
        _builder = builder;
    }

    public async Task<Consultation> BuildConsultation(int typeId, int petId, string desc, decimal cost)
    {
        _builder.BuildConsultationType(typeId);
        _builder.BuildPet(petId);
        _builder.BuildDescription(desc);
        await _builder.BuildOperation(cost);
        return _builder.Get();
    }
}
