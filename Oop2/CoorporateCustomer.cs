using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class CoorporateCustomer : Customer //CoorporateCustomer'da Customer'dır. 
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
