using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your option to proceed:\n1.Create Contact\n2.Edit Contact\n3.Display Contact\n4.Exit ");
            bool flag = true;
            AddressBook address = new AddressBook();
            while (flag)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.CreateContact();
                            break;
                    case 2:
                        Console.WriteLine("Enter name to edit:");
                        string name= Console.ReadLine();
                        address.EditContact(name);
                        break;
                    case 3:
                        address.display();
                        break;
                    case 4:
                        flag = false;
                        break;


                }
            }
           
        }
    }
}