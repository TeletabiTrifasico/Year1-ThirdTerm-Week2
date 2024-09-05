using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Book : BookStoreItem
    {
        private string author;

        public Book(string title, string author, double price) : base(title, price)
        {
            this.author = author;
        }


        public override void PrintItem()
        {
            Console.WriteLine($"[Book] '{title}' by {author}, {price:0.00}");
        }
    }
}
