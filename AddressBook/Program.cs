namespace AddressBook;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System");
        AddressBook addbook = new AddressBook();
        Console.WriteLine("Enter First name");
        addbook.FirstName = Console.ReadLine();
        Console.WriteLine("Enter your Last name");
        addbook.LastName = Console.ReadLine();
        Console.WriteLine("Enter your Address");
        addbook.Address = Console.ReadLine();
        Console.WriteLine("Enter City");
        addbook.City = Console.ReadLine();
        Console.WriteLine("enter State");
        addbook.State = Console.ReadLine();
        Console.WriteLine("Enter your Zipcode");
        addbook.zipcode = Console.ReadLine();
        Console.WriteLine("Enter your Phone number");
        addbook.PhoneNumber = Console.ReadLine();
        Console.WriteLine("enter your email id");
        addbook.EmailId = Console.ReadLine();
    }
}

