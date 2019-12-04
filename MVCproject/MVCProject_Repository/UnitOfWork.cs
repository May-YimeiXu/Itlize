using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCProject_DAL;
using MVCProject_Repository.Repositories;

namespace MVCProject_Repository
{



    public class ApplicationContext : DbContext
    {
        private readonly DbContext context;
        
        public  ApplicationContext(DbContext context) 
        {
            this.context = context; 
        }

        public ILogin logins => new LoginRepository(context);
        public IUser users => new UserRepository(context);
        public ICategory category => new CategoryRepository(context);
        public ISubCategory subcategory => new SubCategoryRepository(context);
        public IProperty property => new PropertyRepository(context);
        public IProductList productlist => new ProductListRepository(context);
        public IProductProperty productproperty => new ProductPropertyRepository(context);


    }


}