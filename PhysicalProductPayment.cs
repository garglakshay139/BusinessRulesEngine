using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PhysicalProductPayment : IPayment
    {
        public ISlip iSlip { get; set; }
        public int PaymentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PaymentEntity Payment  { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PhysicalProductPayment()
        {
            iSlip = new Slip();
        }
        public void ProcessPayment()
        {
           var packageSlipInfo =  GeneratePackingSlip();
            iSlip.ProcessPackagingSlip(packageSlipInfo);
            //throw new NotImplementedException();
        }

        private Package GeneratePackingSlip()
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

            return packageSlipInfo;
        }
    }
}
