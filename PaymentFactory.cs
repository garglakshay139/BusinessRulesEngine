using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class PaymentFactory
    {

       public static IPayment GetThePaymentprocessingFlow(int paymentType)
        {
            if (paymentType == 1)
            {
                return new PhysicalProductPayment();
            }
            if (paymentType == 2)
            {
                return new BookPayment();
            }
            if (paymentType == 3)
            {
                return new MembershipPayment();
            }
            if (paymentType == 4)
            {
                return new MembershipUpgradePayment();
            }
            if (paymentType == 5)
            {
                return new MembershipUpgradePayment();
            }
            if (paymentType == 6)
            {
                return new VideoPayment();
            }
            if (paymentType == 7)
            {
                return new PhysicalProductorBookPayment();
            }
            return null;
        }
    }
}
