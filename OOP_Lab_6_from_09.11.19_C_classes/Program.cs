using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailContainer Mailbox = new EmailContainer();
            for(int i = 0; i < 3; i++)// ввод, сортировка по возрастанию и вывод 3х мыл
            {
                Mailbox.AddEmail();
            }
            Mailbox.Sort();
            foreach(object item in Mailbox)
            {
                Console.WriteLine(item.ToString());
            }
            TelephoneContainer NumberBook = new TelephoneContainer();
            for(int i = 0; i < 2; i++)// ввод, сортировка по возрастанию и вывод 2х телефонов
            {
                NumberBook.AddTelephone();
            }
            NumberBook.Sort();
            foreach(object item in NumberBook)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
