using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using System.Data;

namespace StoreManager.Repository;

internal class PurchaseDetailRepository : BaseRepository<PurchaseDetail>, IPurchaseDetailRepository
{
    public PurchaseDetailRepository(IDbConnection connection, IDbTransaction? transaction = null) : base(connection, transaction)
    {
        
    }
}
