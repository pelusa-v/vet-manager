using vet_manager.Core.Entities.Money;
using vet_manager.DataAccess.Repositories.Impl;
using vet_manager.DataAccess.Repositories.Money;

namespace vet_manager.DataAccess;

public class OperationRepository : SimpleRepository<OperationAdditional>, IOperationAdditionalRepository
{
    public OperationRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
