using System;
using PhilsLendingLibrary.Classes;
using System.Collections.Generic;

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

        /// <summary>
        /// This is the Main Navigation Menu.  It is used to navigate through the basic functions of the Application.
        /// </summary>
        /// <returns>Returns a value to determine if the Application keeps running</returns>
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
            Console.WriteLine("6) Add a Book to the Library");
            Console.WriteLine("7) Remove a Book from the Library");
            Console.WriteLine("8) Exit");
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
                return true;
            }
            else if (navChoice == "7")
            {
                return true;
            }
            else if (navChoice == "8")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using Phil's Lending Library");
                Console.WriteLine("Please press any key to exit");
                Console.ReadKey();
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{navChoice} is not a valid Choice.  Please press any key to continue.");
                Console.ReadKey();
                return true;
            }


        }

        static void Book()
        {
            List<Book> book = new List<Book>
            {
                new Book{ TitleOfBook = "How to Impress Your TA with C#", AuthorOfBook = "Phil Werner", GenreOfBook = Classes.Book.Genre.Non_Fiction_Technology, CheckedOut = false },
                new Book{ TitleOfBook = "Space Balls", AuthorOfBook = "Wierd Al", GenreOfBook = Classes.Book.Genre.Sci_Fi, CheckedOut = false },
                new Book{ TitleOfBook = "Game of Thrones", AuthorOfBook = "George R. R. Martin", GenreOfBook = Classes.Book.Genre.Fantacy, CheckedOut = false },
                new Book{ TitleOfBook = "Educated", AuthorOfBook = "Phil Werner", GenreOfBook = Classes.Book.Genre.Non_Fiction_Generic, CheckedOut = false },
                new Book{ TitleOfBook = "The Art of War", AuthorOfBook = "Sun Tzu", GenreOfBook = Classes.Book.Genre.Non_Fiction_Generic, CheckedOut = false },
                new Book{ TitleOfBook = "C# and .NET Core Test-Driven Development", AuthorOfBook = "Ayobami Adewole", GenreOfBook = Classes.Book.Genre.Non_Fiction_Technology, CheckedOut = false },
                new Book{ TitleOfBook = "CSS the missing manual", AuthorOfBook = "David Sawyer McFarland", GenreOfBook = Classes.Book.Genre.Non_Fiction_Technology, CheckedOut = false },
                new Book{ TitleOfBook = "The Animal Book", AuthorOfBook = "Steve Jenkins", GenreOfBook = Classes.Book.Genre.Non_Fiction_Generic, CheckedOut = false },
                new Book{ TitleOfBook = "Master & Apprentice (Star Wars)", AuthorOfBook = "Claudia Gray", GenreOfBook = Classes.Book.Genre.Sci_Fi, CheckedOut = false },
                new Book{ TitleOfBook = "Wheel of Time", AuthorOfBook = "Robert Jordan", GenreOfBook = Classes.Book.Genre.Fantacy, CheckedOut = false }
            };
        }
    }
}
