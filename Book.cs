using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public string name;
        public string author;
        public string category;
        public string language;
        public DateTime publicationDate;
        public string ISBN = "0000000000000";
        public bool borrowed = false;

    }
    class Person
    {
        public string name;
        public DateTime Date;
        public int borrowTime;
        public int bookCount = 0;
        public List<string> borrowedBooks = new List<string>();
    }
}
