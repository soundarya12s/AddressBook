using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();

        public void getData()
        {
            Console.WriteLine("\nEnter your option to proceed:\n1.Create Contact\n2.Add to Dictionary\n3.Edit Contact\n4.Delete Contact\n5.Display\n6.Exit ");
        }
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
            Console.WriteLine("\nEntered details:\n \n"+contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            addressBook.Add(contact);
            getData();
        }

        public void AddAddressBookToDictionary()
        {
            Console.WriteLine("Adding to dictionary!\n Enter the key you want to add:");
            string uniqueName= Console.ReadLine();
            dict.Add(uniqueName, addressBook);
            addressBook = new List<Contact>();
            getData();
        }
        public void EditContact(string name, string contactName)
        {
            
            foreach (var data in dict)
              
            {
                if (data.Key.Equals(name))
                {
                    if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
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
                else { Console.WriteLine("No contact has been found"); 
                }
                getData();
            }
        }

        public void DeleteContact(string name, string contactName)
        {
            Contact contact= new Contact();
            foreach(var data in dict)
            {
                if (data.Key.Equals(name))
                {
                    foreach(var item in data.Value)
                    {
                        if (item.FirstName.Equals(name) || item.LastName.Equals(name))
                        {
                            contact = item;
                        }
                    }
                    data.Value.Remove(contact);
                }
                else
                {
                    Console.WriteLine("No dictionary with key exits");
                }
            }
            getData();

           
        }
        public void display()
        {
            foreach(var data in dict)
            {
                Console.WriteLine(data.Key);

                foreach (var contact in data.Value)
                {
                    Console.WriteLine(contact.FirstName +"\n"+ contact.LastName  + "\n" + contact.Address  + "\n" + contact.City + "\n" + contact.State +"\n" + contact.Zip  + "\n" + contact.PhoneNumber  + "\n" + contact.Email);
                }
            }
        }
       
    }
}
