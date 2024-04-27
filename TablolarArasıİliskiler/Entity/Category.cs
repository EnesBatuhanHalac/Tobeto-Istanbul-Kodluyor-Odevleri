using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CategoryOfProduct>? CategoryOfProduct { get; set; }//Navigation Property
    }
}
