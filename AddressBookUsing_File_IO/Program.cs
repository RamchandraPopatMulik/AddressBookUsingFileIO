namespace AddressBookUsing_File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease Enter Operation : \n1.Add Contact \n2.View Saved Contcat \n 3.Edit Existing Contact \n4.Delete Existing Contact.\n5.Duplicate Checker.\n6.Search Person.\n7.Find City/State.\n8.Find Number Of Persons..\n9.Sort Entries \n10.Exit Adress Book Application");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBook();


            switch (userInput)
            {
                case "1":
                    Console.WriteLine("First Name:");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Last Name:");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("Address:");
                    string address = Console.ReadLine();
                    Console.WriteLine("City:");
                    string city = Console.ReadLine();
                    Console.WriteLine("State:");
                    string state = Console.ReadLine();
                    Console.WriteLine("Zip Code:");
                    string zipcode = Console.ReadLine();
                    Console.WriteLine("Phone Number:");
                    string phonenumber = Console.ReadLine();
                    Console.WriteLine("Email:");
                    string email = Console.ReadLine();
                    var newContact = new Contact(firstname, lastname, address, city, state, zipcode, phonenumber, email);
                    addressBook.AddContact(newContact);
                    break;
                case "2":
                    addressBook.DisplayAllContact();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Choose valid operation.");
                    break;

            }
        }
        
    }
}