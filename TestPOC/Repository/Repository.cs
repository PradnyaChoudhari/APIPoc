using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPOC.Model;

namespace TestPOC.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly LoginContext m_Context;

        public Repository(LoginContext context)
        {
            m_Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return m_Context.Set<TEntity>();
        }

        public TEntity GetItem(int id)
        {
            return m_Context.Find<TEntity>(id);
        }

        public int Insert(TEntity entity)
        {
            if (entity == null) return 0;
            try
            {
                m_Context.Set<TEntity>().Add(entity);
                m_Context.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                //return false;
                return 0;

            }

            //return true;
        }
        public void Update(int id, TEntity entity)
        {
            try
            {
                var existing = m_Context.Entry(entity);
                existing.State = EntityState.Modified;

                m_Context.SaveChanges();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void Delete(int id)
        {
            try
            {
                var existing = m_Context.Entry(GetItem(id));
                existing.State = EntityState.Deleted;

                m_Context.SaveChanges();
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
