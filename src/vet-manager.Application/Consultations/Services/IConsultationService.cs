using vet_manager.Application.Consultations.DTOs;

namespace vet_manager.Application.Consultations.Services;

public interface IConsultationService
{
    public Task<List<ConsultationListItemDTO>> SearchConsultation();
    public Task<List<ConsultationTypeListItemDTO>> ListConsultationTypes();
}
