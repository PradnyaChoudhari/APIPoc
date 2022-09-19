using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPOC.Services
{
    public interface IService<TEntity> 
    {
        IEnumerable<TEntity> Get();
        TEntity GetById(int id);
        int Insert(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
