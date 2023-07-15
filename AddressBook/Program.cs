using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddresBook Problem ");
            AddressBook address = new AddressBook();
            address.CreateContact();
        }
    }
}