using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PaymentOrder:BaseEntity
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        public Payment MyProperty { get; set; }
    }
}
