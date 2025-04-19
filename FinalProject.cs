using System;
using System.Linq;
using System.Collections.Generic;

namespace FinalProject;

public static class Program
{
    public static string book1 = "";
    public static bool borrowed1 = false;
    public static string book2 = "";
    public static bool borrowed2 = false;
    public static string book3 = "";
    public static bool borrowed3 = false;
    public static string book4 = "";
    public static bool borrowed4 = false;
    public static string book5 = "";
    public static bool borrowed5 = false;

    public static int totalBorrowedBooks = 0;

    public static void Main()
    {
        Console.WriteLine("This is a small Library Management App. \nYou can do the mext actions: \n1-Add a Book Title \n2-Remove a Book Title \n3-Display All Book Titles \n4-Search Book by Title \n5-Borrow Book \n6-Check-In a Borrowed Book \n0-Exit");
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Type the action you wish to perform:");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddBook();
                    break;

                case "2":
                    RemoveBook();
                    break;

                case "3":
                    ListAllBooks();
                    break;

                case "4":
                    SearchBook();
                    break;

                case "5":
                    BorrowBook();
                    break;

                case "6":
                    CheckInBook();
                    break;

                case "0":
                    Console.WriteLine("GoodBye");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Unknown Option");
                    break;
            }
        }
    }

    public static void AddBook()
    {
        if (string.IsNullOrEmpty(book1) || string.IsNullOrEmpty(book2) || string.IsNullOrEmpty(book3) || string.IsNullOrEmpty(book4) || string.IsNullOrEmpty(book5))
        {
            Console.WriteLine("Type the Title of the Book you wish to Add:");
            string title = Console.ReadLine();
            if (string.IsNullOrEmpty(book1))
            {
                book1 = title;
            }
            else if (string.IsNullOrEmpty(book2))
            {
                book2 = title;
            }
            else if (string.IsNullOrEmpty(book3))
            {
                book3 = title;
            }
            else if (string.IsNullOrEmpty(book4))
            {
                book4 = title;
            }
            else if (string.IsNullOrEmpty(book5))
            {
                book5 = title;
            }

            Console.WriteLine("Title Saved");

        }
        else
        {
            Console.WriteLine("Imposible to Add more Books");
        }
    }

    public static void RemoveBook()
    {
        if (!string.IsNullOrEmpty(book1) || !string.IsNullOrEmpty(book2) || !string.IsNullOrEmpty(book3) || !string.IsNullOrEmpty(book4) || !string.IsNullOrEmpty(book5))
        {
            Console.WriteLine("Type the Title of the Book you wish to Remove:");
            string title = Console.ReadLine();
            if (book1 == title)
            {
                book1 = "";
                //If the book was borrowed
                if (borrowed1)
                {
                    totalBorrowedBooks -= 1;
                }
                borrowed1 = false;
            }
            else if (book2 == title)
            {
                book2 = "";
                //If the book was borrowed
                if (borrowed2)
                {
                    totalBorrowedBooks -= 1;
                }
                borrowed2 = false;
            }
            else if (book3 == title)
            {
                book3 = title;
                //If the book was borrowed
                if (borrowed3)
                {
                    totalBorrowedBooks -= 1;
                }
                borrowed3 = false;
            }
            else if (book4 == title)
            {
                book4 = "";
                //If the book was borrowed
                if (borrowed4)
                {
                    totalBorrowedBooks -= 1;
                }
                borrowed4 = false;
            }
            else if (book5 == title)
            {
                book5 = "";
                //If the book was borrowed
                if (borrowed5)
                {
                    totalBorrowedBooks -= 1;
                }
                borrowed5 = false;
            }
            else
            {
                Console.WriteLine("Title Not Found");
                return;
            }

            Console.WriteLine("Title Removed");

        }
        else
        {
            Console.WriteLine("Imposible to Remove Books, non available");
        }
    }

    public static void ListAllBooks()
    {
        if (!string.IsNullOrEmpty(book1) || !string.IsNullOrEmpty(book2) || !string.IsNullOrEmpty(book3) || !string.IsNullOrEmpty(book4) || !string.IsNullOrEmpty(book5))
        {
            Console.WriteLine("Listing All Books: ");

            if (!string.IsNullOrEmpty(book1))
            {
                Console.WriteLine("Title: " + book1);
            }

            if (!string.IsNullOrEmpty(book2))
            {
                Console.WriteLine("Title: " + book2);
            }

            if (!string.IsNullOrEmpty(book3))
            {
                Console.WriteLine("Title: " + book3);
            }

            if (!string.IsNullOrEmpty(book4))
            {
                Console.WriteLine("Title: " + book4);
            }

            if (!string.IsNullOrEmpty(book5))
            {
                Console.WriteLine("Title: " + book5);
            }

            Console.WriteLine("All Books Listed");

        }
        else
        {
            Console.WriteLine("No Books to List");
        }
    }

    public static void SearchBook()
    {
        if (!string.IsNullOrEmpty(book1) || !string.IsNullOrEmpty(book2) || !string.IsNullOrEmpty(book3) || !string.IsNullOrEmpty(book4) || !string.IsNullOrEmpty(book5))
        {
            Console.WriteLine("Type the Title of the Book you wish to Search:");
            string title = Console.ReadLine();
            if (book1 == title || book2 == title || book3 == title || book4 == title || book5 == title)
            {
                Console.WriteLine("Book Found!");
            }
            else
            {
                Console.WriteLine("Title Not Found");
                return;
            }
        }
        else
        {
            Console.WriteLine("Imposible to Search Book, non available");
        }
    }

    public static void BorrowBook()
    {
        if (!string.IsNullOrEmpty(book1) || !string.IsNullOrEmpty(book2) || !string.IsNullOrEmpty(book3) || !string.IsNullOrEmpty(book4) || !string.IsNullOrEmpty(book5))
        {
            if (totalBorrowedBooks == 3)
            {
                Console.WriteLine("Impossible to Borrow Mmore Books, Maximum Reached (3)");
                return;
            }

            Console.WriteLine("Type the Title of the Book you wish to Borrow:");
            string title = Console.ReadLine();
            if (book1 == title)
            {
                borrowed1 = true;
                totalBorrowedBooks += 1;
            }
            else if (book2 == title)
            {
                borrowed2 = true;
                totalBorrowedBooks += 1;
            }
            else if (book3 == title)
            {
                borrowed3 = true;
                totalBorrowedBooks += 1;
            }
            else if (book4 == title)
            {
                borrowed4 = true;
                totalBorrowedBooks += 1;
            }
            else if (book5 == title)
            {
                borrowed5 = true;
                totalBorrowedBooks += 1;
            }
            else
            {
                Console.WriteLine("Title Not Found");
                return;
            }

            Console.WriteLine("Title Borrowed");

        }
        else
        {
            Console.WriteLine("Imposible to Borrow Books, non available");
        }
    }

    public static void CheckInBook()
    {
        if (!string.IsNullOrEmpty(book1) || !string.IsNullOrEmpty(book2) || !string.IsNullOrEmpty(book3) || !string.IsNullOrEmpty(book4) || !string.IsNullOrEmpty(book5))
        {
            Console.WriteLine("Type the Title of the Book you wish to Check-In:");
            string title = Console.ReadLine();
            if (book1 == title)
            {
                borrowed1 = false;
                totalBorrowedBooks -= 1;
            }
            else if (book2 == title)
            {
                borrowed2 = false;
                totalBorrowedBooks -= 1;
            }
            else if (book3 == title)
            {
                borrowed3 = false;
                totalBorrowedBooks -= 1;
            }
            else if (book4 == title)
            {
                borrowed4 = false;
                totalBorrowedBooks -= 1;
            }
            else if (book5 == title)
            {
                borrowed5 = false;
                totalBorrowedBooks -= 1;
            }
            else
            {
                Console.WriteLine("Title Not Found");
                return;
            }

            Console.WriteLine("Title Checked In");

        }
        else
        {
            Console.WriteLine("Imposible to Check-In Books, non available");
        }
    }
}
