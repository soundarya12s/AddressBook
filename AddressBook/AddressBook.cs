using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        public void CreateContact()
        {
            Console.WriteLine("Enter the details\n1.First Name\n2.Last Name\n3.Address\n4.city\n5.State\n6.Zip\n7.Phone Number\n8.Email");
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Console.ReadLine(),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
            };
            Console.WriteLine("Entered details: \n"+contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            addressBook.Add(contact);
        }
        public void EditContact(string name)
        {
            
            foreach (var contact in addressBook)
            {
                if(contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    Console.WriteLine("Enter the option to Edit\n1.First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Zip\n7.Phone Number\n8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            contact.Zip = Console.ReadLine();
                            break;
                        case 7:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }

        public void DeleteContact(string name)
        {
            Contact contact= new Contact();
            foreach(var data in addressBook)
            {
                if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    contact = data;
                }
            }
            addressBook.Remove(contact);
        }
        public void display()
        {
            foreach(var data in addressBook)
            {
                Console.WriteLine(data.FirstName+"\n"+data.LastName+"\n"+data.Address+"\n"+data.City+"\n"+data.State+"\n"+data.Zip+"\n"+data.PhoneNumber+"\n"+data.Email);
            }
        }
       
    }
}
