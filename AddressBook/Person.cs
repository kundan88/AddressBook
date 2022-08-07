using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string emailId;
    }

    public class PersonDetail
    {
        List<Person> listgetDetail = new List<Person>();
        public void PersonAddress()   //get persons detail
        {
            Person person = new Person();
            Console.WriteLine("Enter first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter city");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter zipCode");
            person.zipCode = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter emaiId");
            person.emailId = Console.ReadLine();

            listgetDetail.Add(person);

        }
        public void DispalyAddressBook()   //show persons detail
        {
            foreach (Person person in listgetDetail)
            {
                Console.WriteLine("first Name: " + person.firstName);
                Console.WriteLine("last Name: " + person.lastName);
                Console.WriteLine("Address: " + person.address);
                Console.WriteLine("City: " + person.city);
                Console.WriteLine("State: " + person.state);
                Console.WriteLine("Zip code: " + person.zipCode);
                Console.WriteLine("PhoneNumber: " + person.phoneNumber);
                Console.WriteLine("EmailId: " + person.emailId);
            }
        }

        public void EditAddressBook(string firstname)  //modify person detail
        {

            foreach (Person person in listgetDetail)
            {
                if (firstname == person.firstName)
                {
                    Console.WriteLine("Enter first name");
                    person.firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    person.lastName = Console.ReadLine();
                    Console.WriteLine("Enter address");
                    person.address = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    person.city = Console.ReadLine();
                    Console.WriteLine("Enter state");
                    person.state = Console.ReadLine();
                    Console.WriteLine("Enter zipCode");
                    person.zipCode = Console.ReadLine();
                    Console.WriteLine("Enter phone number");
                    person.phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter emaiId");
                    person.emailId = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Contact not found!!");
                }
            }
        }
        public void DeleteAddressBook(string firstname)   //delete persons detail
        {
            int count = 0;
            int flag = 0; ;
            foreach (Person person in listgetDetail)
            {
                if (firstname == person.firstName)
                {
                    flag = 1;
                    break;
                }

                count++;  //count records in number
            }
            if (flag == 1)
            {
                listgetDetail.Remove(listgetDetail[count]);
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Contact not found!!");
            }

        }
    }
}
        
