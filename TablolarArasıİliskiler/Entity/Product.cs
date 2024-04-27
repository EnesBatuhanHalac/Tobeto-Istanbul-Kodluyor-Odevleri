using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<CategoryOfProduct>? CategoryOfProducts { get; set; }//Navigation Property
        public virtual ICollection<ProductSeller> ProductSellers { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductVideo>? ProductVideos { get; set; }
        public virtual ICollection<Favorites>? Favorites { get; set; }
    }
}
