using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Models.DomainModels.Services
{
    public class ProductService
    {
        #region [-Ctor-]
        public ProductService()
        {

        }
        #endregion

        #region [-Tasks-]

        #region [-SelectProduct()-]
        public List<Aggregations.ProductAggregate.Product> Select()
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    var q = context.Product.Include(p=>p.Category).ToList();
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

        #region [-Insert(Propduct product)-]
        public void Insert(Aggregations.ProductAggregate.Product product)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    context.Add(product);
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

        #region [-Update()-]
        public void Update(Aggregations.ProductAggregate.Product product)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    context.Entry(product).State = EntityState.Modified;
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
                    var target = context.Product.Find(id);
                    context.Remove(target);
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
        public Aggregations.ProductAggregate.Product Find(Guid? id)
        {
            using (var context = new EFCoreDBContext.ProductCategoryDBContext())
            {
                try
                {
                    var target = context.Product.Include(p => p.Category).ToList().Find(p => p.Id == id);
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

        #region [-SelectCategroy()-]
        public List<Aggregations.CategoryAggregate.Category> SelectCategroy()
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

        #endregion




    }
}
