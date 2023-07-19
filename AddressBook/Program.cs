using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            bool flag = true;
            string key = null, input = null;
            AddressBook address = new AddressBook();
            address.getData();
            while (flag)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.CreateContact();
                            break;
                    case 2:
                        address.AddAddressBookToDictionary();
                        break;
                    case 3:
                        Console.WriteLine("enter key:");
                        key= Console.ReadLine();
                        Console.WriteLine("Enter name to edit:");
                        input = Console.ReadLine();
                        address.EditContact(key,input);
                        break;
                    case 4:
                        Console.WriteLine("Enter key:");
                        key=Console.ReadLine();
                        Console.WriteLine("Enter the name of contact details to be deleted ");
                        input = Console.ReadLine();
                        address.DeleteContact(key, input);
                        break;
                    case 5:
                        address.display();
                        break;
                    case 6:
                        flag = false;
                        break;

                }
            }
           
        }
    }
}