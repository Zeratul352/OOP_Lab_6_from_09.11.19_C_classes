using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class Telephone
    {
        string number, opcode, country, ownername;
        
       public Telephone()  {}
       public Telephone(string num, string op, string coun, string owner)
        {
            number = num;
            opcode = op;
            country = coun;
            ownername = owner;
        }
       public string GetNumber()
        {return number;}
       public string GetCode()
        {return opcode;}
       public string GetCountry()
        {return country;}
       public string GetOwner()
        {return ownername;}
       public void SetNumber(string num) { number = num; }
       public void SetCode(string code) { opcode = code; }
      public  void SetCountry(string coun) { country = coun; }
       public void SetOwner(string owner) { ownername = owner; }
      public  string toString()
        {
            return opcode + number + " " + country + ownername;
        }
    }
}
