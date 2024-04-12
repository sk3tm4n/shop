using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using System.Data;

namespace StoreManager.Repository;

internal class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
{
    public PurchaseRepository(IDbConnection connection, IDbTransaction? transaction = null) : base(connection, transaction)
    {
        
    }
}
