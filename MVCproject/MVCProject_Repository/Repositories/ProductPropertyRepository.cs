using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IProductProperty : IRepository<ProductProperty>
    {
    }
    public class ProductPropertyRepository : IProductProperty 
    {
        private DbContext context;

        public ProductPropertyRepository(DbContext context)
        {
            this.context = context;

        }
        DbSet<ProductProperty> entities => context.Set<ProductProperty>();
        public void Delete(ProductProperty entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<ProductProperty> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(ProductProperty entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(ProductProperty entity)
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