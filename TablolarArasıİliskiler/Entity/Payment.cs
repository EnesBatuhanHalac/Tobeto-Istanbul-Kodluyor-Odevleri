using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Payment:BaseEntity
    {
        public int PaymentTypeId { get; set; }
        public string? CardNumber { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
