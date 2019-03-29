using System;
using PhilsLendingLibrary.Classes;

namespace PhilsLendingLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool navMenu = true;
            while (navMenu)
            {
                navMenu = NavMenu();
            }
        }

        static bool NavMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Phil's Lending Library");
            Console.WriteLine("Please enter a number for one of the following choices.");
            Console.WriteLine("1) List all the Books by Title");
            Console.WriteLine("2) List all the Books by Author");
            Console.WriteLine("3) List Books Available to Borrow");
            Console.WriteLine("4) Borrow a Book by Title");
            Console.WriteLine("5) Return a Book by Title");
            Console.WriteLine("6) Exit");
            string navChoice = Console.ReadLine();

            if (navChoice == "1")
            {
                return true;
            }
            else if (navChoice == "2")
            {
                return true;
            }
            else if (navChoice == "3")
            {
                return true;
            }
            else if (navChoice == "4")
            {
                return true;
            }
            else if (navChoice == "5")
            {
                return true;
            }
            else if (navChoice == "6")
            {
                return false;
            }
            else
            {
                Console.WriteLine("That is not a valid Choice.  Please press any key to continue.");
                Console.ReadKey();
                return true;
            }


        }
    }
}
