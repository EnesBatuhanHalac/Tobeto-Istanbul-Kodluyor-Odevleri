using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Orders:BaseEntity
    {
        public int OrderNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public bool StatusType { get; set; }
    }
}
