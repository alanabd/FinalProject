using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Set<Product>().SingleOrDefault(filter);
            }
            
        }

        public void Add(Product entity)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var addedEntity = northwindContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                northwindContext.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var deletedEntity = northwindContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                northwindContext.SaveChanges();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var uptatedEntity = northwindContext.Entry(entity);
                uptatedEntity.State = EntityState.Modified;
                northwindContext.SaveChanges();
            }
        }

        public List<Product> GetAllCategory(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
