﻿using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using System.Data;

namespace StoreManager.Repository;

internal class RemainRepository : BaseRepository<Remain>, IRemainRepostory
{
    public RemainRepository(IDbConnection connection, IDbTransaction? transaction = null) : base(connection, transaction)
    {
        
    }
}
