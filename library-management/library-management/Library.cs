using library_management;
using System;
using System.Collections.Generic;

using System.ComponentModel.Design;
using System.Text;

namespace library_management
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public Boolean IsAvailable { get; set; }
        public Book(string title, string author, int isbn)
        {

            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;


        }
    }
    class Library
    {
        List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            book.IsAvailable = true;

            books.Add(book);

        }


        public void BorrowBook(string title)
        {
            bool found = false;

            foreach (Book book in books)
            {

                if (book.Title == title)
                {
                    found = true;
                    if (book.IsAvailable == true)
                    {

                        book.IsAvailable = false;
                        Console.WriteLine("Book borrowed successfully.");
                        break;
                    }

                    else

                        Console.WriteLine("Book is already borrowed.");
                }

            }
            if (found == false)
            {
                Console.WriteLine(" Book not found");
            }
        }

        public void ReturnBook(string title)
        {
            bool found = false;

            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    found = true;
                    if (book.IsAvailable == false)
                    {


                        book.IsAvailable = true;
                        Console.WriteLine("Book returned successfully.");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Book is already in the library.");
                        break;
                    }

                }

            }
            if (found == false)
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}



class Program
{

    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book("c#", "steve", 18547);
        Book book2 = new Book("java", "daniel", 85758);
        Book book3 = new Book("c++", "sommi", 985752);
        Book book4 = new Book("c", "john", 187453);
        Book book5 = new Book("asp.net", "emi", 97584);
        Book book6 = new Book("html", "smith", 87654);


        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        library.AddBook(book5);
        library.AddBook(book6);
        int input = 0;
        while (input != 4)
        {

            Console.WriteLine("Enter 1 to add a book.");
            Console.WriteLine("Enter 2 to borrow a book.");
            Console.WriteLine("Enter 3 to return a book. ");
            Console.WriteLine("Enter 4 to exit.");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {

                case 1:
                    {
                        Console.Write("Enter your Title of Book");
                        string title = Console.ReadLine()!;
                        Console.Write("Enter your Author of Book");
                        string author = Console.ReadLine()!;
                        Console.Write("Enter your ISBN of Book");
                        int isbn = Convert.ToInt32(Console.ReadLine());
                        Book book = new Book(title, author, isbn);
                        library.AddBook(book);
                        Console.WriteLine("Book added successfully.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter your Title of Book");
                        string title = Console.ReadLine()!;
                        library.BorrowBook(title);

                        break;
                    }

                case 3:
                    {
                        Console.Write("Enter your Title of Book");
                        string title = Console.ReadLine()!;
                        library.ReturnBook(title);
                        break;
                    }
                case 4:
                    break;

                default:
                    {
                        Console.WriteLine("invalid number");
                        break;
                    }

            }
           

        }

        }
    }