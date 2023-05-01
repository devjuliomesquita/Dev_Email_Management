using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContextOptions<Dev_Email_ManagementContext> _context;
        public RepositoryBase()
        {
            _context = new DbContextOptions<Dev_Email_ManagementContext>();
        }


        public void Add(TEntity entity)
        {
            using (var data = new Dev_Email_ManagementContext(_context))
            {
                data.Set<TEntity>().Add(entity);
                data.SaveChanges();
            }
                
        }

        public void Delete(TEntity entity)
        {
            using (var data = new Dev_Email_ManagementContext(_context))
            {
                data.Set<TEntity>().Remove(entity);
                data.SaveChanges();
            }
                
        }

        public void Dispose()
        {
            using (var data = new Dev_Email_ManagementContext(_context))
            {
                data.Dispose();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var data = new Dev_Email_ManagementContext(_context))
            {
                return data.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var data = new Dev_Email_ManagementContext(_context))
            {
                return data.Set<TEntity>().Find(id);
            }
        }
       
        public void Update(TEntity entity)
        {
            using (var data = new Dev_Email_ManagementContext(_context))
            {
                data.Entry(entity).State = EntityState.Modified;
                data.SaveChanges();
            }
                
        }
    }
}
