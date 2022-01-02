using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Models.DomainModels.Aggregations.CategoryAggregate
{
    public class Category
    {
        public Guid? Id { get; set; }
        public string CategoryTitle { get; set; }

        //Category Can Have Many Products
        public List<ProductAggregate.Product> Products { get; set; }
    }
}
