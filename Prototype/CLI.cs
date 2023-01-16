using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks
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
            Console.WriteLine("\-----------------------------------/");

            string manage = Prompt.Select("Select your option", new[] { "Manage Loans", "Manage Items" });


            switch (manage)
            {
                case "Manage Loans":
                    manageLoans();
                    break;
                case "Manage Items":
                    managerItems();
                    break;
                default:
                    break;
            }
        }


        private static void manageLoans()
        {
            Console.WriteLine($"Loan Manager");
            Console.WriteLine("\---------------/");
            string manage = Prompt.Select("Select your option", new[] { "Add New Loan", "View Loan", "Delete Loan" });
        }


        private static void manageLoans()
        {
            Console.WriteLine($"Items Manager");
            Console.WriteLine("\---------------/");
            string manage = Prompt.Select("Select your option", new[] { "Add New Loan", "View Loan", "Delete Loan" });
        }
    }
}
