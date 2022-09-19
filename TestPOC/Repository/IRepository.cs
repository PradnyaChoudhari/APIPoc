using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPOC.Repository
{
    public interface IRepository<TEntity>
    {

  
        IEnumerable<TEntity> GetAll();
        TEntity GetItem(int id);
        int Insert(TEntity entity);
        void Update(int id, TEntity entity);      
        void Delete(int id);
    }
}

