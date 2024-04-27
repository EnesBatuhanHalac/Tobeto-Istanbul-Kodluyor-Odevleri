using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Seller:BaseEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string TaxtNumber { get; set; }
        public int UserAdressId { get; set; }
        public string CompanyType { get; set; }
        public virtual ICollection<ProductSeller>? ProductSellers { get; set; }

    }
}
