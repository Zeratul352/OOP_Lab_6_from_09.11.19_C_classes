using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class EmailContainer : IEnumerable // mail container
    {
        List <Email> emails;
      
        

        public IEnumerator GetEnumerator()
        {
           return emails.GetEnumerator();
        }

       public EmailContainer()
        {
            emails = new List<Email>();
            
        }
       public EmailContainer(List<Email> mail) 
        {
            //emails = new List<Email>();
            
            emails = mail;
            
        }
       public void AddEmail()
        {
            string mail = Console.ReadLine();
            string dom = Console.ReadLine();
            Email A = new Email(mail, dom);
            emails.Add(A);
        }
       
       public void RemoveEmail(int index)
        { emails.Remove(emails[index]); }
       public void Sort()
        {
            Email tempmail = new Email();
            Telephone temptelephone = new Telephone();
            for(int i = 0; i < emails.Count;i++)
            {
                for(int j = 0; j < emails.Count - i - 1; j++)
                {
                    if(string.Compare(emails[j].ToString(), emails[j + 1].ToString()) > 0)
                    {
                        tempmail = emails[j];
                        emails[j] = emails[j + 1];
                        emails[j + 1] = tempmail;
                    }
                
                }
            }
            
        }

    }

    class TelephoneContainer : IEnumerable
    {
        

        List <Telephone> telephones;

        public IEnumerator GetEnumerator()
        {
            return telephones.GetEnumerator();
        }

        public TelephoneContainer()
        {
            telephones = new List<Telephone>();
            
        }
        public TelephoneContainer(List<Telephone> phones)
        {
            telephones = new List<Telephone>();
            
            telephones = phones;
            
        }
        public void AddTelephone()
        {
            string code = Console.ReadLine();
            string num = Console.ReadLine();
            string strana = Console.ReadLine();
            Telephone A = new Telephone(num, code, strana);
            telephones.Add(A);
        }

        public void RemoveEmail(int index)
        { telephones.Remove(telephones[index]); }
        public void Sort()
        {
            Telephone temptelephone = new Telephone();
            for(int i = 0; i < telephones.Count; i++)
            {
                for(int j = 0; j < telephones.Count - i - 1; j++)
                {
                    if(string.Compare(telephones[j].ToString(), telephones[j + 1].ToString()) > 0)
                    {
                        temptelephone = telephones[j];
                        telephones[j] = telephones[j + 1];
                        telephones[j + 1] = temptelephone;
                    }
                }
            }
        }

    }
}
