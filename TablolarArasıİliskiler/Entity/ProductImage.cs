using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductImage:BaseEntity
    {
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }//Navigation Property
    }
}
