using AutoMapper;
using vet_manager.Application.Consultations.DTOs;
using vet_manager.Core;
using vet_manager.Core.Entities.Consultations;

namespace vet_manager.Application.Mapper;

public class ConsultationProfile : Profile
{
    public ConsultationProfile()
    {
        CreateMap<ConsultationType, ConsultationTypeListItemDTO>();
        CreateMap<ConsultationCategory, ConsultationCategoryDTO>();
    }
}
