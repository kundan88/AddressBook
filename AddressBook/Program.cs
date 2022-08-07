namespace AddressBook;
class Program
{
    public static void Main(string[] args)
    {
        PersonDetail perdeatil = new PersonDetail();
        perdeatil.SetPersonDetail();
        perdeatil.GetPersonDetail();
        Console.WriteLine("enter 'y' for Add New Contact");
        string ch = Console.ReadLine();
       if (ch == "y")
        {
            perdeatil.SetPersonDetail();

        }

    }
}

