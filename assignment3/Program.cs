namespace assignment3
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
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");

            // create game and play it

            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }

            // display who has won the game...
            if (war.player1.cards == null)
                Console.WriteLine($"{war.player2.name} has won!");
            else
                Console.WriteLine($"{war.player1.name} has won!");
        }
    }
}
