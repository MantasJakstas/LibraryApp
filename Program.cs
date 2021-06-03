﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static Person person = new Person();
        static List<Book> bookList = new List<Book>();
        static Book book = new Book();
        static List<Person> personList = new List<Person>();

        static void Main(string[] args)
        {

            bool close = true;
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
                "1)Add book\n" +
                "2)Take book\n" +
                "3)Book List\n"+
                "4)Close\n\n");
                Console.Write("Choose your option from menu : ");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AddBook();
                }
                else if(option == 2)
                {
                    TakeBook();
                }
                else if(option == 3)
                {
                    DisplayBooks();
                }
                else if(option == 4)
                {
                    Console.WriteLine("Thank you");
                    close = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }
            }
        }
        public static void AddBook()
        {
            Book book = new Book();
            Console.Write("Book Name:");
            book.name = Console.ReadLine();
           Console.Write("Book Language:");
            book.language = Console.ReadLine();
           Console.Write("Book Author:");
            book.author = Console.ReadLine();
            Console.Write("Book Category:");
            book.category = Console.ReadLine();
           /* Console.Write("Book publication date: M/dd/yyyy: ");
            string pattern = "M/dd/yyyy";
            book.publicationDate = DateTime.ParseExact(Console.ReadLine(), pattern, null);
            book.ISBN += 1;*/
            bookList.Add(book);
        }
        public static void TakeBook()
        {
            //Book book = new Book();
            //Person person = new Person();
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            personList.Add(person);
            Console.WriteLine("Your book count {0}:", person.bookCount);
            Console.WriteLine("\n");
            Console.WriteLine("Theese are the books that are available:");
            for (var i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].borrowed == false)
                {
                    Console.WriteLine("Book name: {0}", bookList[i].name);
                } else
                {
                    Console.WriteLine("There are no available books :( ");
                    return;
                }
            }
            Console.WriteLine("What book do you want to borrow?");
            string bookToBorrow = Console.ReadLine();
                if (bookList.Exists(s => s.name == bookToBorrow))
                {
                int index = bookList.FindIndex(r => r.name == bookToBorrow);
                //Console.WriteLine("Inedx is {0}: " , index);
                if (bookList[index].borrowed == true)
                    {
                        Console.WriteLine("The book is already borrowed");
                    return;
                    
                    }
                    Console.WriteLine("For how many days would you like to borrow it?");
                    person.borrowTime = int.Parse(Console.ReadLine());
                    if(person.borrowTime >= 60)
                    {
                        Console.WriteLine("You can't borrow it for longer than 60 days");
                    return;
                    }
                if (person.bookCount == 3)
                {
                    Console.WriteLine("You can't borrow more than 3 books");
                    return;
                }
                    Console.WriteLine($"The book is yours {person.name}");
                    bookList[index].borrowed = true;
                    person.bookCount++;
                    person.Date = DateTime.Now;
                }
        }
        public static void DisplayBooks()
        {
            Console.WriteLine("Theese are the books that are available:");
            Console.WriteLine("\n");
            for (var i = 0; i < bookList.Count; i++)
            {
                if(bookList.Count == 0)
                {

                    Console.WriteLine("There are no available books :( ");
                    return;
                }
                if (bookList[i].borrowed == false)
                {
                    Console.WriteLine("Book name: {0}, Book Author: {1}, Book Language: {2}, Book " +
                        "Category: {3}", bookList[i].name, bookList[i].author, bookList[i].language, bookList[i].author);
                }
            }
        }
    }
}
