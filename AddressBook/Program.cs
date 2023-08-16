using System;
namespace AddressBook
{
    class Program
    {
        static string FilePath = @"D:\gittestrep\AddressBook\AddressBook\AddressBookData.json";
        static string TextFile = @"D:\gittestrep\AddressBook\AddressBook\Contact.txt";
        static void Main(string[] args)
        {


            bool flag = true;
            string key = null, input = null;
            AddressBook address = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Enter the option to proceed\n 1.Create Contact\n 2.Add to Dictionary\n " + "3.Edit Contact\n 4.Delete Contact\n 5. Sort" +"\n 6.Display Contact\n 7.Add to Json\n 8.Search by state or city \n 9.Syream Reader\n 10.Stream Writer\n 11.Exit");
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
                        key = Console.ReadLine();
                        Console.WriteLine("Enter name to edit:");
                        input = Console.ReadLine();
                        address.EditContact(key, input);
                        break;
                    case 4:
                        Console.WriteLine("Enter key:");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter the name of contact details to be deleted ");
                        input = Console.ReadLine();
                        address.DeleteContact(key, input);
                        break;
                    case 5:
                        address.Sorting();
                       
                        break;
                    case 6:
                        address.display();
                       
                        break;
                    case 7:
                        address.WriteToJsonFile(FilePath);
                       
                        break;
                    case 8:
                        address.SearchByState();
                      
                        break;
                    case 9:
                        address.Stream_Reader(TextFile); 
                        break;
                    case 10:
                        address.Stream_Writer(TextFile);
                        break;
                    case 11:
                        flag = false;
                        break;
                    default:
                        break;

                }
            }

        }
    }
}