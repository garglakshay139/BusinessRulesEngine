using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    internal class BookPayment : IPayment
    {
        public int PaymentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PaymentEntity Payment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ISlip iSlip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ProcessPayment()
        {
            GenerateRoyalitySlip();
        }

        private void GenerateRoyalitySlip()
        { 
        
        }
    }
}
