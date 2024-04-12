using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using System.Data;

namespace StoreManager.Repository;

internal class SaleDetailRepository : BaseRepository<SaleDetail>, ISaleDetailRepository
{
    public SaleDetailRepository(IDbConnection connection, IDbTransaction? transaction = null) : base(connection, transaction)
    {
        
    }
}
