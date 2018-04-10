using System;

namespace Template_Method
{
    public abstract class Game
    {
        // This is a template method `Run()`
        // The implementation of these methods are on the inherited classes like `Chess` class in this example.
        // Template method describes the algorithm. In this case the game playing alghoritm at a high level,
        // but letting the inheritors provide the implementation details for the different constituent parts.

        public void Run()
        {
            Start();
            while (!HaveWinner)
                TakeTurn();

            Console.WriteLine($"Player {WinningPlayer} wins.");
        }

        protected int currentPlayer;
        protected readonly int numberOfPlayers;

        protected Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }

        protected abstract void Start();
        protected abstract void TakeTurn();
        protected abstract bool HaveWinner { get; }
        protected abstract int WinningPlayer { get; }
    }
}
