using System;
namespace SnakeAndLadder
{
    public class GamePlay
    {
        int playerPosition = 0;
        Random random = new Random();
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        public void start()
        {
            Console.WriteLine("Lets Start the Game");
            Console.WriteLine("Player is at starting position "+ playerPosition);
        }
        public int DieRoll()
        {
            int dieRoll = random.Next(1, 7);
            return dieRoll;
        }
        public void CheckOption()
        {
            while(playerPosition <WINNING_POSITION)
            {
                int checkOption = random.Next(0, 3);
                switch (checkOption)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += DieRoll();
                        break;
                    case SNAKE:
                        this.playerPosition -= DieRoll();
                        if (playerPosition < 0)
                            playerPosition = 0;
                        break;
                }
            }
            Console.WriteLine("Game over ! Player is at winning position {0} ", playerPosition);
        }

    }
}
