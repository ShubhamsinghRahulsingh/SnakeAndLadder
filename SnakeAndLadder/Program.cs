using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder Problem statement");
            GamePlay winner = new GamePlay();
            winner.TwoPlayer();
        }
    }
}