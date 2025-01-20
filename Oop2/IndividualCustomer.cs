using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //Customer sınıfı IndividualCustomer sınıfından miras alıyor yani Individual, Customer ın çocuğu gibi düşün.
    class IndividualCustomer : Customer  //Inheritance - miras 
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
