using vet_manager.Application.Register.DTOs;

namespace vet_manager.Application.Register.Services;

public interface IRegisterService
{
    public Task RegisterConsultation(RegisterConsultationDTO dto);
    public Task RegisterPet(RegisterPetDTO dto);
    public Task RegisterClient();
}
