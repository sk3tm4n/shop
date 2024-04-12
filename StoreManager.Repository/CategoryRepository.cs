﻿using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using System.Data;

namespace StoreManager.Repository;

internal class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(IDbConnection connection, IDbTransaction? transaction = null) : base(connection, transaction)
    {

    }
}
