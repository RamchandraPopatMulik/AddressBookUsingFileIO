namespace AddressBookUsing_File_IO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease Enter Operation : \n1.Add Contact \n2.View Saved Contcat \n 3.Edit Existing Contact \n4.Delete Existing Contact.\n5.Duplicate Checker.\n6.Search Person.\n7.Find City/State.\n8.Find Number Of Persons..\n9.Sort Entries \n10.Exit Adress Book Application");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBook();


            switch (userInput)
            {
                case "1":
                    addressBook.StoreContact();
                    break;
                case "2":
                    addressBook.DisplayAllContact();
                    break;
                case "3":
                    addressBook.EditContact("");
                    break;
                case "4":
                    addressBook.DeleteContact();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("!!! Choose valid operation !!!");
                    break;

            }
        }
        
    }
}