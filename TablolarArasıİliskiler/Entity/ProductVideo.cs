using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductVideo:BaseEntity
    {
        public int VideoUrl { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
