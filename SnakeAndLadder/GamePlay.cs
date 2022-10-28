using System;
namespace SnakeAndLadder
{
    public class GamePlay
    {
        int playerPosition = 0;
        Random random = new Random();
        public void start()
        {
            Console.WriteLine("Lets Start the Game");
            Console.WriteLine("Player is at starting position "+ playerPosition);
        }
        public void DieRoll()
        {
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The player gets the number {0} on dice",dieRoll);
        }

    }
}
