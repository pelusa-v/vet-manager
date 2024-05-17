using vet_manager.Core;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess.Repositories.Consultations.Impl;

public class ConsultationCategoryRepository : SimpleRepository<ConsultationCategory>, IConsultationCategoryRepository
{
    public ConsultationCategoryRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}