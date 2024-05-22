using Microsoft.EntityFrameworkCore;
using vet_manager.Core.Entities.Consultations;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess.Repositories.Consultations.Impl;

public class ConsultationTypeRepository : SimpleRepository<ConsultationType>, IConsultationTypeRepository
{
    private readonly AppDbContext _appDbContext;

    public ConsultationTypeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public override async Task<List<ConsultationType>> List()
    {
        return await _appDbContext.ConsultationTypes.Include(c => c.ConsultationCategory).ToListAsync();
    }
}
