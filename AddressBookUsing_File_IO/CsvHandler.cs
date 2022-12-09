using CsvHelper;
using MaxMind.Db;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsing_File_IO
{
    public class CsvHandler
    {
        private TextReader reader;
        private TextWriter writer;
        public void ImplementCvsDataHandling()
        {
            string importfilepath = @"E:\Basic Core Program\AddressBookUsing_File_IO\AddressBookUsingFileIO\AddressBookUsing_File_IO\Address.csv";
            string exportfilepath = @"E:\Basic Core Program\AddressBookUsing_File_IO\AddressBookUsingFileIO\AddressBookUsing_File_IO\Export.csv";

            using (var reader = new StreamReader(importfilepath)) ;
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read Data Successfully From Address.csv File");
                foreach (Contact addressData in records)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.Address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.ZipCode);
                    Console.Write("\n");
                }
                Console.WriteLine("Now Reading From Csv File Write to Csv ");
                using (var writer = new StreamWriter(exportfilepath)) ;
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
