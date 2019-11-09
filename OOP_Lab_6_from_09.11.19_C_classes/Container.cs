using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6_from_09._11._19_C_classes
{
    class EmailContainer : IEnumerator // вот так вот нельзя
    {
        List <Email> emails;
        //List <Telephone> telephones;
        
       public EmailContainer()
        {
            emails = new List<Email>();
            //telephones = new List<Telephone>();
        }
       public EmailContainer(List<Email> mail) 
        {
            emails = new List<Email>();
            //telephones = new List<Telephone>();
            emails = mail;
            //telephones = phone;
        }
       public void AddEmail(Email mail)
        { emails.Add(mail); }
       
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
            /*for(int i = 0; i < telephones.Count; i++)
            {
                for(int j = 0; j < telephones.Count - i - 1; j++)
                {
                    if(string.Compare(telephones[j].toString(), telephones[j + 1].toString()) > 0)
                    {
                        temptelephone = telephones[j];
                        telephones[j] = telephones[j + 1];
                        telephones[j + 1] = temptelephone;
                    }
                }
            }*/
        }

    }
   
}
