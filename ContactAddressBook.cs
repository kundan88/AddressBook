using System;
namespace addcontact
{
    class AddressBook
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
        public string PhoneNumber;
        public string EmailId;

        public void AdresBook(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string EmailId)

        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("welcome to address book system");
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

        }

    }
}


