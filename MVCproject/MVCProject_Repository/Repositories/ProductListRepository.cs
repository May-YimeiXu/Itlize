using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IProductList : IRepository<ProductList>
    {
    }
    public class ProductListRepository : IProductList
    {
        private DbContext context;

        public ProductListRepository(DbContext context)
        {
            this.context = context;

        }
        DbSet<ProductList> entities => context.Set<ProductList>();
        public void Delete(ProductList entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<ProductList> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(ProductList entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(ProductList entity)
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