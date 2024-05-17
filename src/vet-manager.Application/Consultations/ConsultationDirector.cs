using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Application.Consultations;

public class ConsultationDirector
{
    private readonly IConsultationBuilder _builder;

    public ConsultationDirector(IConsultationBuilder builder)
    {
        _builder = builder;
    }

    public Consultation BuildConsultation(int typeId, int petId, string desc)
    {
        _builder.BuildConsultationType(typeId);
        _builder.BuildPet(petId);
        _builder.BuildDescription(desc);
        return _builder.Get();
    }
}
