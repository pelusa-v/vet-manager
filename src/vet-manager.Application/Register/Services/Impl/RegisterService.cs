
using vet_manager.Application.Consultations;
using vet_manager.Application.Register.DTOs;
using vet_manager.Core.Entities.Clients;
using vet_manager.DataAccess.Repositories.Clients;
using vet_manager.DataAccess.Repositories.Consultations;
using vet_manager.DataAccess.Repositories.Money;

namespace vet_manager.Application.Register.Services.Impl;

public class RegisterService : IRegisterService
{
    private readonly IConsultationRepository _consultationRepo;
    private readonly IOperationRepository _operationRepo;
    private readonly IPetRepository _petRepo;

    public RegisterService(IConsultationRepository consultationRepo, IOperationRepository operationRepo, IPetRepository petRepo)
    {
        _consultationRepo = consultationRepo;
        _operationRepo = operationRepo;
        _petRepo = petRepo;
    }

    public Task RegisterClient()
    {
        throw new NotImplementedException();
    }

    public async Task RegisterConsultation(RegisterConsultationDTO dto)
    {
        var basicbuilder = new BasicConsultationBuilder(_operationRepo);
        var director = new ConsultationDirector(basicbuilder);
        var consultation = director.BuildConsultation(dto.ConsultationTypeId, dto.PetId, dto.Description);
        await _consultationRepo.Create(consultation);
    }

    public async Task RegisterPet(RegisterPetDTO dto)
    {
        var pet = new Pet(dto.Name, dto.AnimalId, dto.BreedId, dto.ClientId);
        await _petRepo.Create(pet);
    }
}
