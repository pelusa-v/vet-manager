using vet_manager.Core.Entities.Clients;
using vet_manager.DataAccess.Repositories.Clients;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess;

public class PetRepository : SimpleRepository<Pet>, IPetRepository
{
    public PetRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
