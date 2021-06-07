using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category, ShopContext>, ICategoryDal
    {
        //EFCoreGenericRepo sayesinde alltakilere gerek kalmamıs oldu yukardada ıProductDal ı sildik gerek kalmadı
        //ShopContext db = new ShopContext();
        //public void Create(Product entity)
        //{
        //    db.Products.Add(entity);
        //    db.SaveChanges();
        //}

        //public void Delete(Product entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product GetOne(Expression<Func<Product, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Product> GetPopularProduct()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Product entity)
        //{
        //    throw new NotImplementedException();
        //}

        //ShopContext db = new ShopContext();
        //public void Create(Category entity)
        //{
        //    db.Categories.Add(entity);
        //    db.SaveChanges();
        //}

        //public void Delete(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category GetOne(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Category entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
