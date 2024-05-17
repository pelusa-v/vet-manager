using vet_manager.Core.Entities.Consultations;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess.Repositories.Consultations.Impl;

public class ConsultationRepository : SimpleRepository<Consultation>, IConsultationRepository
{
    public ConsultationRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
