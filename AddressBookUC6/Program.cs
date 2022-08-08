namespace AddressBook;
class Program
{
        public static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Address book management system!");

        AddressBookCollection addressBookCollection = new AddressBookCollection();
        PersonDetail persongetDetail = new PersonDetail();
        persongetDetail.PersonAddress();
        int choice;
        do
        {
            Console.WriteLine("Enter your choice");

            Console.WriteLine("1) Add a new contact to address book");
            Console.WriteLine("2) Display address book");
            Console.WriteLine("3) Edit existing contact using persons first_name ");
            Console.WriteLine("4) Delete existing contact using persons first_name ");
            Console.WriteLine("5) Add new Address book");
            Console.WriteLine("6) List of address book");
            Console.WriteLine("7) Exit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    persongetDetail.PersonAddress();
                    break;
                case 2:
                    Console.WriteLine("Address book is ");
                    persongetDetail.DispalyAddressBook();
                    break;
                case 3:
                    Console.WriteLine("Enter first name");
                    string firstname = Console.ReadLine();
                    persongetDetail.EditAddressBook(firstname);
                    break;
                case 4:
                    Console.WriteLine("Enter first name");
                    firstname = Console.ReadLine();
                    persongetDetail.DeleteAddressBook(firstname);
                    break;
                case 5:
                    Console.WriteLine("Enter New Address Book Name");
                    string addresBookName = Console.ReadLine();
                    addressBookCollection.addressBookDictionary.Add(addresBookName, new PersonDetail());
                    Console.WriteLine("Address Book {0} selected.", addresBookName);
                    break;
                case 6:
                    Console.WriteLine("List of all Address Books");
                    foreach (var item in addressBookCollection.addressBookDictionary)
                    {
                        Console.WriteLine(item.Key);
                    }
                    break;
                case 7:
                    Console.WriteLine("Thank you");
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        } while (choice != 7);

    }
}



