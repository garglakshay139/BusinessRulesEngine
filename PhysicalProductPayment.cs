using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    internal class PhysicalProductPayment : IPayment
    {
        public int PaymentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PaymentEntity Payment  { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ProcessPayment()
        {
            GeneratePackingSlip();
            //throw new NotImplementedException();
        }

        private void GeneratePackingSlip()
        {
            var packageSlipInfo = new Package()
            {
                PackageType = PackageTypeEnum.Standard,
                DeliveryAddress = new Address()
                {
                    AddressLine1 = "AddressLine1",
                    PinCode = "pincode"
                }
            };
        }
    }
}
