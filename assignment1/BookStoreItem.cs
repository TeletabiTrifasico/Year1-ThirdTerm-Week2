using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public abstract class BookStoreItem
    {
        public string title;
        public double price;

        public BookStoreItem(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public abstract void PrintItem();
    }
}
