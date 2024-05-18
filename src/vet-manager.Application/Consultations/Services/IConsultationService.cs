using vet_manager.Application.Consultations.DTOs;

namespace vet_manager.Application.Consultations.Services;

public interface IConsultationService
{
    public List<ConsultationListItemDTO> SearchConsultation();
}
