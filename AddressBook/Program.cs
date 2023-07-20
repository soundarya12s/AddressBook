using System;
namespace AddressBook
{
    class Program
    {
        static string ADDRESS_BOOK_FILE = @"D:\gittestrep\AddressBook\AddressBook\AddressBookData.json";
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
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name to edit contact details");
                        input = Console.ReadLine();
                        address.EditContact(key, input); 
                        break;
                    case 4:
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name of contact details to be deleted");
                        input = Console.ReadLine();
                        address.DeleteContact(key, input);
                        break;
                    case 5:
                        address.display();
                        break;
                    case 6:
                        address.WriteToJsonFile(ADDRESS_BOOK_FILE);
                        break;
                    case 7:
                        flag = false;
                        break;

                }
            }
           
        }
    }
}