using vet_manager.Core.Entities.Clients;
using vet_manager.DataAccess.Repositories.Clients;
using vet_manager.DataAccess.Repositories.Impl;

namespace vet_manager.DataAccess;

public class ClientRepository : SimpleRepository<Client>, IClientRepository
{
    public ClientRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
