using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Payment Type");
            Console.WriteLine("Enter 1 for Physical Product");
            Console.WriteLine("Enter 2 for Book Product");
            Console.WriteLine("Enter 3 for Availing Membership");
            Console.WriteLine("Enter 4 for Upgrading the memberSHip");
            Console.WriteLine("Enter 5 for MemberShip or Upgrade");
            Console.WriteLine("Enter 6 for Video");
            Console.WriteLine("Enter 7 for Physical Product or a Book");

            int paymentType = Convert.ToInt32(Console.ReadLine());

           IPayment paymentProcessing =  PaymentFactory.GetThePaymentprocessingFlow(paymentType);

            paymentProcessing.ProcessPayment();
        }
    }
}
