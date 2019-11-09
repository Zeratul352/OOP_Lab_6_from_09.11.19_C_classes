using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class Container
    {
        List <Email> emails;
        List <Telephone> telephones;
        
       public Container()
        {
            emails = new List<Email>();
            telephones = new List<Telephone>();
        }
       public Container(List<Email> mail, List<Telephone> phone) 
        {
            emails = new List<Email>();
            telephones = new List<Telephone>();
            emails = mail;
            telephones = phone;
        }
       public void AddEmail(Email mail)
        { emails.Add(mail); }
       public void AddTelephone(Telephone phone)
        { telephones.Add(phone);}
       public void RemoveEmail(int index)
        { emails.Remove(emails[index]); }
       public void RemoveTelephone(int index) { telephones.Remove(telephones[index]); }
       public void Sort()
        {
            Email tempmail = new Email();
            Telephone temptelephone = new Telephone();
            for(int i = 0; i < emails.Count;i++)
            {
                for(int j = 0; j < emails.Count - i - 1; j++)
                {
                    if(string.Compare(emails[j].toString(), emails[j + 1].toString()) > 0)
                    {

                    }
                
                }
            }
        }
    }
}
