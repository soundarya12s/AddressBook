using Newtonsoft.Json;

namespace AddressBook
{
    public class AddressBook
    {
        int count = 0;
        Contact contact = new Contact();
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();

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
            foreach (var data in dict)
            {
                foreach (var item in data.Value)
                {
                    if (item.FirstName.Equals(contact.FirstName))
                    {
                        Console.WriteLine("Name already exists\n Add Different contact");
                        CreateContact();
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                addressBook.Add(contact);
            }
        }
        public void SearchBycity()
        {
            Console.WriteLine("Enter the city to search");
            string city = Console.ReadLine();
            List<Contact> contact = new List<Contact>();
            foreach (var data in dict)
            {
                contact = data.Value.Where(x => x.City.Equals(city)).ToList();
                foreach (var Contact in contact)
                {
                    Console.WriteLine(Contact.FirstName + " " + Contact.LastName);
                }
            }
        }
        public void SearchByState()
        {
            Console.WriteLine("Enter the State to search");
            string state = Console.ReadLine();
            List<Contact> contact1 = new List<Contact>();
            int count = 0;
            foreach (var data in dict)
            {
                contact1 = data.Value.Where(x => x.State.Equals(state)).ToList();
                foreach (var Contact in contact1)
                {
                    Console.WriteLine(Contact.FirstName + " " + Contact.LastName);
                }
            }
        }
        
            public void SearchByCityOrState()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.By City\n 2.By state\n 3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        SearchBycity();
                        break;
                    case 2:
                        SearchByState();
                        break;
                    case 3:
                        flag= false;
                        break;
                    default:
                        break;
                }

            }
        }

        public void AddAddressBookToDictionary()
        {
            Console.WriteLine("Enter the unique Name");
            string uniquename = Console.ReadLine();
            bool UniqueContact = false;
            dict.Add(uniquename, addressBook);

            addressBook = new List<Contact>();
        }
        public void WriteToJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(dict);
            File.WriteAllText(filePath, json);

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
