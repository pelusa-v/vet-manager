using AutoMapper;
using vet_manager.Application.Consultations.DTOs;
using vet_manager.DataAccess.Repositories.Consultations;

namespace vet_manager.Application.Consultations.Services.Impl;

public class ConsultationService : IConsultationService
{
    public readonly IConsultationTypeRepository _consultationTypeRepository;
    public readonly IMapper _mapper;

    public ConsultationService(IConsultationTypeRepository consultationTypeRepository, IMapper mapper)
    {
        _mapper = mapper;
        _consultationTypeRepository = consultationTypeRepository;
    }

    public Task<List<ConsultationListItemDTO>> SearchConsultation()
    {
        throw new NotImplementedException();
    }

    public async Task<List<ConsultationTypeListItemDTO>> ListConsultationTypes()
    {
        var types = await _consultationTypeRepository.List();
        return _mapper.Map<List<ConsultationTypeListItemDTO>>(types);
    }
}
