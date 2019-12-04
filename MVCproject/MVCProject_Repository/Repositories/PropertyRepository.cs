using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IProperty : IRepository<Property>
    {
    }
    public class PropertyRepository : IProperty
    {
        private DbContext context;

        public PropertyRepository(DbContext context)
        {
            this.context = context;

        }
        DbSet<Property> entities => context.Set<Property>();
        public void Delete(Property entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Property> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(Property entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(Property entity)
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