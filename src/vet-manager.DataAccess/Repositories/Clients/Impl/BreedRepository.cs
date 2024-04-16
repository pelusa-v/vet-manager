using vet_manager.Core.Entities.Clients;
using vet_manager.DataAccess.Repositories.Clients;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess;

public class BreedRepository : SimpleRepository<Breed>, IBreedRepository
{
    public BreedRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
