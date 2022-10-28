using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder Problem statement");
            GamePlay gamePlay = new GamePlay();
            gamePlay.start();
        }
    }
}