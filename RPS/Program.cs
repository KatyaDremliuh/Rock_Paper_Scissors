using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Ur name, please: ");
            string playersName = Console.ReadLine();
            Console.WriteLine("Hi! {0}", playersName);
            Console.ReadKey();
        }
    }
}
