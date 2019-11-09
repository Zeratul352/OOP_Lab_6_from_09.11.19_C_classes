using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class Email
    {
        string adress, ownername;
        
        public Email() { }
       public Email(string adr, string owner)
        {
            adress = adr;
            ownername = owner;
        }
       public void SetAdress(string adr) { adress = adr; }
       public void SetOwner(string owner) { ownername = owner; }
       public string GetAdress() { return adress; }
       public string GetOwner() { return ownername; }
       public string toString() { return adress + " " + ownername; }
    }

}
