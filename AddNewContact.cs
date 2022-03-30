using System;
using System.Collections;
using System.Collections.Generic;


    class ContactDetails
    {
        public string firstName;
        public string lastName;
        public string address;
        public string email;
        public string city;
        public int phoneNumber;
        public string state;
        public int zip;

        public ContactDetails(string firstName, string lastName, string address, string email,string city, int phoneNumber, string state, int zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.email = email;
            this.city = city;
            this.phoneNumber = phoneNumber;
            this.state = state;
            this.zip = zip;
            
            
        }
        public string ToString()
        {
            return " Details Of " + firstName + " " + lastName + " are:" + "address:" + address + "City:" + city + "\n"
                                + "    " + "state" + state + "zip" + zip + "\n"
                                + "    " + "phoneNumber :" + phoneNumber + "\n"
                                + "   " + "email:" + email;
        }
        class Program
        {
            private ArrayList contactDetailsList;
            private Dictionary<string, ContactDetails> contactDetailsMap;
            public Program()
            {
                contactDetailsList = new ArrayList();
                contactDetailsMap = new Dictionary<string, ContactDetails>();

            }
            public void AddDetails(string firstName, string lastName, string address, string city, string state, int zip, int phoneNumber, string email)
            {
                ContactDetails contactDetails = new ContactDetails(firstName, lastName, address,email, city, phoneNumber, state, zip);
                contactDetailsList.Add(contactDetails);
                contactDetailsMap.Add(firstName, contactDetails);
            }
       

        public void ComputeDetails()
            {
                foreach(ContactDetails contact in contactDetailsList)
                {
                    Console.WriteLine(contact.ToString());
                }
            }

        static void Main(string[] args)
            {
                Console.WriteLine("welcome to address book system");
                Program details = new Program();

                Console.WriteLine("enter first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("enter last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("enter address");
                string address = Console.ReadLine();

                Console.WriteLine("enter city");
                string city = Console.ReadLine();

                Console.WriteLine("enter state");
                string state = Console.ReadLine();

                Console.WriteLine("enter zip");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter phone Number");
                int phoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter email");
                string email = Console.ReadLine();
                details.AddDetails(firstName, lastName, address, city, state, zip, phoneNumber, email);

                details.ComputeDetails();


            }
        }
    }

