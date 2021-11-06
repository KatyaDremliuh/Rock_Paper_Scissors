using System;
using System.Globalization;

namespace RPS
{
    class Program
    {
        private static readonly CultureInfo CultureInfo = CultureInfo.InvariantCulture;
        // Console.ForegroundColor = ConsoleColor.Green;
        // Console.ResetColor(); // скидываем настройки цвета на стандартные
        static void Main(string[] args)
        {
            // Знакомство
            Console.WriteLine("What's Ur name?");
            string namePlayer = Console.ReadLine();
            Console.WriteLine($"Hi, {namePlayer}!");

            // Предложение игры
            Console.WriteLine("Let's play the game \"Rock-Paper-Scissors\". \nIf U want to play input \"Yes\".");

            if ("Yes".Equals(Console.ReadLine()))
            {
                //Начало игры
                Console.Clear();

                //Выбор пользователя
                Console.WriteLine("Choose an item: Rock(1), Paper(2), Scissors(0). ");
                int userChoise = int.Parse(Console.ReadLine());

                //Выбор знака компьютером
                Random rnd = new Random();
                int compChoise = rnd.Next(0, 3);

                Console.Clear();
                Console.WriteLine($"Ur item        : {TranslateUsersChoice(userChoise)}");
                Console.WriteLine($"Computer's item: {TranslateUsersChoice(compChoise)}");

                if (userChoise == 0)
                {
                    if (compChoise == 0)
                    {
                        Console.WriteLine("No one loses when the game's a draw!!!"); // ничья
                    }
                    else if (compChoise == 1)
                    {
                        Console.WriteLine($"Paper wrapped a stone. {namePlayer} a winner!");
                    }
                    else
                    {
                        Console.WriteLine("Scissors cut paper. The computer's a winner!");
                    }
                }
                else if (userChoise == 1)
                {
                    if (compChoise == 0)
                    {
                        Console.WriteLine("Paper wrapped a stone. The computer's a winner!");
                    }
                    else if (compChoise == 1)
                    {
                        Console.WriteLine("No one loses when the game's a draw!!!");
                    }
                    else
                    {
                        Console.WriteLine($"A stone broke scissors. {namePlayer} a winner!");
                    }
                }
                else
                {
                    if (compChoise == 0)
                    {
                        Console.WriteLine($"Scissors cut paper. {namePlayer} a winner!");
                    }
                    else if (compChoise == 1)
                    {
                        Console.WriteLine("A stone broke scissors. The computer's a winner!");
                    }
                    else
                    {
                        Console.WriteLine("No one loses when the game's a draw!!!");
                    }
                }
            }
            else
            {
                // Прощание
                Console.WriteLine($"What a pity! Goodbye, {namePlayer}!");
            }

            Console.ReadKey();
        }

        public static string TranslateUsersChoice(int number)
        {
            switch (number)
            {
                case 0:
                    return "Paper";
                case 1:
                    return "Rock";
                case 2: 
                    return "Scissors";
                default:
                    return "Invalid number.";
            }
        }
    }
}
