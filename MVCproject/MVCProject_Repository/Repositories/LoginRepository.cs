using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface ILogin : IRepository<Login>
    { 
    }
    public class LoginRepository : ILogin
    {
        private DbContext context;

        public LoginRepository(DbContext context)
        {
            this.context = context;
            
        }
        DbSet<Login> entities => context.Set<Login>();
        public void Delete(Login entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Login> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(Login entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(Login entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}