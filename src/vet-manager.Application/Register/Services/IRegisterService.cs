namespace vet_manager.Application.Register.Services;

public interface IRegisterService
{
    public Task RegisterConsultation();
    public Task RegisterPet();
    public Task RegisterClient();
}
