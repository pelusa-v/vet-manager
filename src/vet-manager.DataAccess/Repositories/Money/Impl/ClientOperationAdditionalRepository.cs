using vet_manager.Core.Entities.Money;
using vet_manager.DataAccess.Repositories.Impl;
using vet_manager.DataAccess.Repositories.Money;

namespace vet_manager.DataAccess;

public class ClientOperationAdditionalRepository : SimpleRepository<OperationAdditional>, IOperationAdditionalRepository
{
    public ClientOperationAdditionalRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
