using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CategoryOfProduct:BaseEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public virtual Product? Product { get; set; }//Navigation Property
        public virtual Category? Category { get; set; }//Navigation Property
    }
}
