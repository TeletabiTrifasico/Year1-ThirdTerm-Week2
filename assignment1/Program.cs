using System.Globalization;

namespace assignment1
{
    class Program{
        static void Main()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            BookStore bookStore = new BookStore();
            bookStore.AddBookOrMagazine(new Book("Dracula", "Bram Stoker", 15.00));
            bookStore.AddBookOrMagazine(new Book("Joe speedboot", "Tommy Wieringa", 12.50));
            bookStore.AddBookOrMagazine(new Magazine("Time", "Friday", 3.90));
            bookStore.AddBookOrMagazine(new Magazine("Donald Duck", "Thursday", 2.50));
            bookStore.AddBookOrMagazine(new Book("The hobbit", "J.R.R. Tolkien", 12.50));

            bookStore.PrintCompleteStock();
        }
    }
}
