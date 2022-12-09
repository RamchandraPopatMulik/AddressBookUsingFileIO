namespace AddressBookUsing_File_IO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Read Data From CSV and Write Data in CSV ");
            CsvHandler csvDataHandling = new CsvHandler();
            csvDataHandling.ImplementCvsDataHandling();
        }
        
    }
}