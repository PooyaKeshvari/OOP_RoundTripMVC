using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_OOP_S08CF6.Controllers.Dtos;

namespace _01_OOP_S08CF6.Models.DomainModels.EFCoreDBContext
{
    public class ProductCategoryDBContext:DbContext
    {
        #region [-OnConfiguring(DbContextOptionsBuilder optionsBuilder)-]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = . ; database = OOP_S08CF6 ; Trusted_Connection = true ;");

        }
        #endregion

        #region [-DBSet<>-]
        public DbSet<Aggregations.ProductAggregate.Product> Product { get; set; }
        public DbSet<Aggregations.CategoryAggregate.Category> Category { get; set; }
        public DbSet<_01_OOP_S08CF6.Controllers.Dtos.ProductDto> ProductDto { get; set; }
        public DbSet<_01_OOP_S08CF6.Controllers.Dtos.CategoryDto> CategoryDto { get; set; }
        #endregion
    }
}
