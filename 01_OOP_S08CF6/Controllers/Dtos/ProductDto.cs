using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_OOP_S08CF6.Controllers.Dtos
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public Guid CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }

        public virtual CategoryDto Category { get; set; }
    }
}
