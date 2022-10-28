using System;
namespace SnakeAndLadder
{
    public class GamePlay
    {
        int playerPosition = 0;
        Random random = new Random();
        const int NO_PLAY=0, LADDER = 1, SNAKE = 2;
        public void start()
        {
            Console.WriteLine("Lets Start the Game");
            Console.WriteLine("Player is at starting position "+ playerPosition);
        }
        public int DieRoll()
        {
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The player gets the number {0} on dice",dieRoll);
            return dieRoll;
        }
        public void CheckOption()
        {
            int checkOption=random.Next(0,3);
            switch(checkOption)
            {
                case NO_PLAY:
                    playerPosition = 0;
                    break;
                case LADDER:
                    this.playerPosition += DieRoll();
                    break;
                case SNAKE:
                    this.playerPosition -= DieRoll();
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
            Console.WriteLine("Player is at {0} position",playerPosition);
        }

    }
}
