namespace vet_manager.Application.Register.DTOs;

public class RegisterConsultationDTO
{
    public int ConsultationTypeId { get; set; }
    public int PetId { get; set; }
    public string Description { get; set; }

    public void Deconstruct(out int typeId, out int petId, out string description)
    {
        typeId = ConsultationTypeId;
        petId = PetId;
        description = Description;
    }
}
