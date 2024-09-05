namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();
            Console.WriteLine();
            deck.Shuffle();
            deck.Print();
        }
    }
}
