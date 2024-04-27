using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductSeller:BaseEntity
    {
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public virtual Product? Product { get; set; }//Navigation Property
        public virtual Seller? Seller { get; set; }//Navigation Property
    }
}
