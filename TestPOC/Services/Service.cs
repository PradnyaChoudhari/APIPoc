using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPOC.Repository;

namespace TestPOC.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> m_Repository;

        public Service(IRepository<TEntity> repository)
        {
            m_Repository = repository;
        }

        public IEnumerable<TEntity> Get()
        {
            return m_Repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return m_Repository.GetItem(id);
        }

        public IEnumerable<TEntity> GetSteelGrade()
        {
            return m_Repository.GetAll();
        }
        public int Insert(TEntity entity)
        {
            if (entity != null)
            {
                return m_Repository.Insert(entity);
            }
            return 0;
        }
        public void Update(int id, TEntity entity)
        {
            m_Repository.Update(id, entity);

        }

        public void Delete(int id)
        {
            m_Repository.Delete(id);
        }

    }
}
