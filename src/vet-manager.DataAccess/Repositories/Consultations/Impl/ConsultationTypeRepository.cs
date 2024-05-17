using vet_manager.Core.Entities.Consultations;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess.Repositories.Consultations.Impl;

public class ConsultationTypeRepository : SimpleRepository<ConsultationType>, IConsultationTypeRepository
{
    public ConsultationTypeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
