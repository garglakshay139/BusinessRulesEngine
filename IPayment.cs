using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public interface IPayment
    {
        ISlip iSlip { get; set; }
        int PaymentType { get; set; }
        
        PaymentEntity Payment { get; set; }

        void ProcessPayment();
    }
}
