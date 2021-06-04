using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public interface ISlip
    {
        void ProcessPackagingSlip(Package packageObj);
    }
}
