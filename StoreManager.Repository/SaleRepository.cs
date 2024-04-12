using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using System.Data;

namespace StoreManager.Repository;

internal class SaleRepository : BaseRepository<Sale>, ISaleRepository
{
    public SaleRepository(IDbConnection connection, IDbTransaction? transaction = null) : base(connection, transaction)
    {
        
    }
}
