namespace vet_manager.Application.Consultations.DTOs;

public class ConsultationTypeListItemDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ConsultationCategoryId { get; set; }
    public ConsultationCategoryDTO ConsultationCategory { get; set; }
    public string FullName 
    { 
        get
        {
            return string.Format("{0} ({1})", Name, ConsultationCategory.CategoryName);
        }
    }
}
