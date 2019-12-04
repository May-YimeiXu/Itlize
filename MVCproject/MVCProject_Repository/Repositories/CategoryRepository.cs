using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface ICategory : IRepository<Category>
    {
    }
    public class CategoryRepository : ICategory
    {
        private DbContext context;

        public CategoryRepository(DbContext context)
        {
            this.context = context;

        }
        DbSet<Category> entities => context.Set<Category>();
        public void Delete(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(Category entity)
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