using System;
using System.Collections.Generic;

namespace DemoModel.Api.Models.Interfaces
{
    public interface IContactRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id); 
        TEntity Insert(TEntity entity);
    }
}
