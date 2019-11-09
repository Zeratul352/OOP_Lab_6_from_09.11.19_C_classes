using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class Telephone
    {
        public string number { set; get; }
          public  string opcode { set; get; }
          public string country { set; get; }
        
       public Telephone()  {}
       public Telephone(string num, string op, string coun)
        {
            number = num;
            opcode = op;
            country = coun;
        }


        public override string ToString()
        {
            return $"{opcode}-{number}-{country}";
        }
    }
}
