using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class Email
    {
        public string adress { get; set; }
        public string domen { get; set; }
        
        public Email() { }
       public Email(string adr, string dom)
        {
            adress = adr;
            domen = dom;
        }

        public override string ToString()
        {
            return $"{adress}@{domen}";
        }
    }

}
