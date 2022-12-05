﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsing_File_IO
{
    public class AddressBook
    {
        public List<Contact> list = new List<Contact>();
        public void AddContact(Contact addcontact)
        {
            list.Add(addcontact);
        }
        public Dictionary<string, Contact> DictName = new Dictionary<string, Contact>();
        public void StoreContact()
        {
            Console.WriteLine("Please Enter Unique Name to Your Addressbook : ");
            string addressbookName = Console.ReadLine();
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
            DictName.Add(addressbookName, newContact);
        }
        public void DisplayAllContact()
        {
            foreach (var element in DictName)
            {
                Console.WriteLine("\nAddressBook key :\n " + element.Key + " \nPerson Name :\n" + element.Value.FirstName + " " + element.Value.LastName + "\nAddress: " + element.Value.Address + "\nCity: " + element.Value.City + "\nState: " + element.Value.State + "\nZip Code: " + element.Value.ZipCode + "\nPhone Number: " + element.Value.PhoneNumber + "\nEmail: " + element.Value.Email);
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Available Addressbooks are:: ");
            foreach (var key in DictName)
            {
                Console.WriteLine(key.Key + "      ");
            }
            Console.WriteLine("\nPlease Enter Name of the AddressBook you want to edit:: ");
            string dictName = Console.ReadLine();

            foreach (var element in DictName)
            {
                if (element.Key == dictName)
                {
                    Console.WriteLine("Enter new First Name");
                    string newFirstName = Console.ReadLine();
                    element.Value.FirstName = newFirstName;
                    Console.WriteLine("Enter new Last Name:");
                    string newLastName = Console.ReadLine();
                    element.Value.LastName = newLastName;
                    Console.WriteLine("Enter new Address:");
                    string newAddress = Console.ReadLine();
                    element.Value.Address = newAddress;
                    Console.WriteLine("Enter new City:");
                    string newCity = Console.ReadLine();
                    element.Value.City = newCity;
                    Console.WriteLine("Enter new State:");
                    string newState = Console.ReadLine();
                    element.Value.State = newState;
                    Console.WriteLine("Enter new Zip Code:");
                    string newZipcode = Console.ReadLine();
                    element.Value.ZipCode = newZipcode;
                    Console.WriteLine("Enter new Phone Number:");
                    string newPhonenumber = Console.ReadLine();
                    element.Value.PhoneNumber = newPhonenumber;
                    Console.WriteLine("Enter new Email:");
                    string newEmail = Console.ReadLine();
                    element.Value.Email = newEmail;

                }
            }

        }
        public void DeleteContact()
        {
            Console.WriteLine("PLease Enter First Name of the Contact you want to Delete:");
            string name = Console.ReadLine();
            foreach (var contact in list)
            {
                if (contact.FirstName == name)
                {
                    list.Remove(contact);
                    break;
                }
            }
        }
        public void DuplicateChecker()
        {
            Console.WriteLine("Enter a unique name to your Addressbook:");
            string addressbookName = Console.ReadLine();
            Console.WriteLine("First Name:");
            string name = Console.ReadLine();

            foreach (var element in DictName)
            {
                if (element.Value.FirstName.Equals(name))
                {
                    Console.WriteLine("\nEntered Person Name already exist in Addressbook in AddressBook::\n" + element.Key + "       ");
                }
                else
                {
                    string newName = name;
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
                    var newContact = new Contact(newName, lastname, address, city, state, zipcode, phonenumber, email);
                    DictName.Add(addressbookName, newContact);
                    Console.WriteLine("\nDuplicate checker passed contact added successfully.\n");
                }
            }
        }
        public void SearchPerson()
        {
            Console.WriteLine("Please Enter City or State Which You Want to Search : ");
            string city = Console.ReadLine();
            foreach (var element in DictName)
            {
                if (element.Value.City.Equals(city))
                {
                    Console.WriteLine("Contact Found :" + city + " " + element.Value.FirstName);
                }
                else if (element.Value.State.Equals(city))
                {
                    Console.WriteLine("Contact Found :" + city + " " + element.Value.FirstName);
                }
                else
                {
                    Console.WriteLine("Sorry No such City or State in AddressBook !!!!!!!");
                }
            }
        }
        public void FindCityState()
        {
            Console.WriteLine("Enter First Name of a Person to View his City and State : ");
            string person = Console.ReadLine();
            foreach (var element in DictName)
            {
                if (element.Value.FirstName.Equals(person))
                {
                    Console.WriteLine("\n" + person + " lives in :: '" + element.Value.City + "' City and '" + element.Value.State + "' State.\n");
                }
                else
                {
                    Console.WriteLine("No such Person found in Addressbook.\n\nAvailable person in your addressbook are :: " + element.Value.FirstName + "\n");
                }
            }
        }
        public void FindNumOfPerson()
        {
            Console.WriteLine("Enter City or State ::");
            string cityState = Console.ReadLine();
            int countPerson = 0;
            foreach (var element in DictName)
            {
                if (element.Value.City.Equals(cityState))
                {
                    countPerson++;
                }
                if (element.Value.State.Equals(cityState))
                {
                    countPerson++;
                }
            }
            Console.WriteLine("\nNumber of Person found in " + cityState + " are " + countPerson);
        }
        public void ChooseSort()
        {
            Console.WriteLine("Sort By: ");
            Console.WriteLine("1.Name\n2.City\n3.State\n4.ZipCode");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Dictionary<string, Contact> sortList = DictName.OrderBy(x => x.Value.FirstName).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortList)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.PhoneNumber);
                    }
                    break;
                case "2":
                    Dictionary<string, Contact> sortCity = DictName.OrderBy(x => x.Value.City).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortCity)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.City + " " + element.Value.PhoneNumber);
                    }
                    break;
                case "3":
                    Dictionary<string, Contact> sortState = DictName.OrderBy(x => x.Value.State).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortState)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.State + " " + element.Value.PhoneNumber);
                    }
                    break;
                case "4":
                    Dictionary<string, Contact> sortZip = DictName.OrderBy(x => x.Value.ZipCode).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortZip)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.State + " " + element.Value.ZipCode + " " + element.Value.PhoneNumber);
                    }
                    break;
                default:
                    Console.WriteLine(" Choose valid operation !!!");
                    break;
            }
        }
    }
}