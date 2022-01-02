using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Controllers.Dtos
{
    public class CategoryDto
    {
        public Guid? Id { get; set; }
        public string CategoryTitle { get; set; }

        //Category Can Have Many Products
       // public List<ProductDto> Products { get; set; }
    }
}
