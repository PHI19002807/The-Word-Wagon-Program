using Sharprompt;


namespace Prototype
{
    internal static class CLI
    {
        public static Library library { get; set; }
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the { library.Name }!");
            Console.WriteLine("-----------------------------------");

            string manage = Prompt.Select("Select your option", new[] { "Manage Loans", "Manage Items" });


            switch (manage)
            {
                case "Manage Loans":
                    manageLoans();
                    break;
                case "Manage Items":
                    manageItems();
                    break;
                default:
                    break;
            }
        }


        private static void manageLoans()
        {
            Console.WriteLine($"Loan Manager");
            Console.WriteLine("---------------");
            string manage = Prompt.Select("Select your option", new[] { "Add New Loan", "View Loan", "Delete Loan" });

            switch (manage)
            {
                case "Add New Loan":
                    Console.Clear();
                    string type = Prompt.Input<string>("Enter type of media Dvd, Cd, Book");
                    bool dvd, book, cd = false;
                    Dvd selectedDvd = null;
                    Cd selectedCd = null;
                    Book selectedBook = null;

                    if (type == "dvd")
                    {
                        selectedDvd = Prompt.Select<Dvd>("Select a DVD", library.Dvds);
                        dvd = true;
                    }
                    else if (type == "Cd")
                    {
                        selectedCd = Prompt.Select<Cd>("Select a Cd", library.Cds);
                        cd = true;
                    }
                    else if (type == "Book")
                    {
                        selectedBook = Prompt.Select<Book>("Select a Book", library.Books);
                        book = true;
                    }
                    else
                    {
                        Console.WriteLine("Media not found");
                    }

                    if (dvd == true)
                    {

                    }

                    //Loan newLoan = new Loan((DateTime.Now, ,false, );

                    Console.ReadLine();
                    Console.WriteLine("Press any key to return to the main menu");
                    MainMenu();
                    break;
                
                case "View Loan":
                    Console.Clear();
                    foreach (var item in library.Loans)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("--------------");
                    }
                    Console.ReadLine();
                    Console.WriteLine("Press any key to return to the main menu");
                    MainMenu();
                    break;

                case "Delete Loan":
                    Console.Clear();
                    string Id = Prompt.Input<string>("Enter Loan ID");
                    Loan? current = library.GetLoan(Id);

                    if (current != null)
                    {
                        library.Loans.Remove(current);
                        Console.WriteLine("Loan removed");
                    }
                    else
                    {
                        Console.WriteLine("Loan not found");
                    }
                    Console.ReadLine();
                    Console.WriteLine("Press any key to return to the main menu");
                    MainMenu();
                    break;

                default:
                    break;
            }
        }


        private static void manageItems()
        {
            Console.WriteLine($"Items Manager");
            Console.WriteLine("---------------");
            string manage = Prompt.Select("Select your option", new[] { "Add New Loan", "View Loan", "Delete Loan" });
        }
    }
}
