using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Ur name, please: ");
            string playersName = Console.ReadLine();
            Console.WriteLine("Hi, {0}!", playersName);

            GetAnswerIfPlayerIsReadyOrNot(playersName);

            Console.ReadKey();
        }

        private static void GetAnswerIfPlayerIsReadyOrNot( string playersName)
        {
            string readyToPlay = "YES";

            Console.WriteLine("Let's play a game \"Rock-Paper-Scissors\". \nIf U're ready, write {0}", readyToPlay);

            if (readyToPlay.Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Hurrah!"); 
            }
            else
            {
                Console.WriteLine($"Okay, {playersName} we'll play another time. Goodbye!");
            }
        }
    }
}
