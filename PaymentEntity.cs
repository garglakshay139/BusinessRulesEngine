using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class PaymentEntity
    {
        public int PaymentId { get; set; }
        public float TotalAmount { get; set; }
        public int PaymentType { get; set; }
    }
}
