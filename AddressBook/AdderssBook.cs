using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
        class AddressBook
        {
            public string FirstName;
            public string LastName;
            public string Address;
            public string City;
            public string State;
            public string zipcode;
            public string PhoneNumber;
            public string EmailId;

            public void AdressBook(string FirstName, string LastName, string Address, string City, string State, string Zipcode, string PhoneNumber, string EmailId)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Address = Address;
                this.City = City;
                this.State = State;
                this.zipcode = Zipcode;
                this.PhoneNumber = PhoneNumber;
                this.EmailId = EmailId;

            }
        }

}

