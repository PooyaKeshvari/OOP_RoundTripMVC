using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Models.DomainModels.Services
{
    public class CategoryService
    {

        #region [-Ctor-]
        public CategoryService()
        {

        }
        #endregion

        #region [-Tasks-]

        #region [-SelectCategory()-]
        public List<Aggregations.CategoryAggregate.Category> Select()
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    var q = context.Category.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [-Insert(Category category)-]
        public void Insert(Aggregations.CategoryAggregate.Category category)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    context.Category.Add(category);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [-Update(Category category)-]
        public void Update(Aggregations.CategoryAggregate.Category category)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [-Delete(Guid id)-]
        public void Delete(Guid id)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    var target = context.Category.Find(id);
                  //context.Remove(target);
                    context.Entry(target).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [-Find(Guid? id)-]
        public Aggregations.CategoryAggregate.Category Find(Guid? id)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    var target = context.Category.ToList().Find(c => c.Id == id);
                    return target;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

      
        #endregion


    }
}
