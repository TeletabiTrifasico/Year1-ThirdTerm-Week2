using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace assignment1
{
    class BookStore
    {
        private List<BookStoreItem> bookStoreList;

        public BookStore()
        {
            bookStoreList = new List<BookStoreItem>();
        }

        public void AddBookOrMagazine(BookStoreItem b)
        {
            bookStoreList.Add(b);
        }

        public void PrintCompleteStock()
        {
            double totalPrice = 0;

            foreach (BookStoreItem b in bookStoreList)
            {
                b.PrintItem();
                totalPrice += b.price;
            }

            Console.WriteLine($"Total sales price: {totalPrice:0.00}");
        }
    }
}
