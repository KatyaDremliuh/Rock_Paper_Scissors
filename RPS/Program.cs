using System;
using System.Globalization;

namespace RPS
{
    class Program
    {
        private static readonly CultureInfo CultureInfo = CultureInfo.InvariantCulture;

        static void Main(string[] args)
        {
            Greeting(out string name);
            GetAnswerIfPlayerIsReadyOrNot(name, out bool play);
            ChooseAnItem(play);
            Console.ReadKey();
        }

        private static void Greeting(out string name)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Input Ur name, please: ");
            string playersName = Console.ReadLine();
            Console.WriteLine("Hi, {0}!", playersName);
            Console.ResetColor(); // скидываем настройки цвета на стандартные

            name = playersName;
        }

        private static void GetAnswerIfPlayerIsReadyOrNot(string playersName, out bool play)
        {
            string readyToPlay = "YES";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Let's play a game \"Rock-Paper-Scissors\". \nIf U're ready, write {0}", readyToPlay);
            Console.ResetColor(); // скидываем настройки цвета на стандартные

            if (readyToPlay.Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Hurrah!");
                Console.Clear();
                //ChooseAnItem();
                play = true;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Okay, {playersName} we'll play another time. Goodbye!");
                play = false;
            }

        }

        private static void ChooseAnItem(bool play)
        {
            if (play)
            {
                int playersItem;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Pick a poin:\n1 - Rock\n2 - Paper\n3 - Scissors");
                    Console.ResetColor(); // скидываем настройки цвета на стандартные

                    string item = Console.ReadLine();

                    if (int.TryParse(item, NumberStyles.Any, CultureInfo, out playersItem) && !string.IsNullOrWhiteSpace(item) && ValidItemNumber(playersItem))
                    {
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ur input wasn't in the correct format. Enter a number between 1 and 3 including.");
                }
                while (true);

                Random random = new Random();
                int computerItem = random.Next(0, 3);

                var comp = CompareItems(computerItem);
                var user = CompareItems(playersItem);
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                //Console.WriteLine("Ur item is {0}, computers item is {1}", playersItem, computerItem);
                Console.WriteLine($"Ur item is {user}");
                Console.WriteLine($"Computers item is {comp}");

                // GAME

                bool userWin1 = user == Item.Rock && comp == Item.Rock;
                bool userWin2 = user == Item.Scissors && comp == Item.Paper;
                bool userWin3 = user == Item.Paper && comp == Item.Rock;

                if (userWin1 || userWin2 || userWin3)
                {
                    Console.WriteLine("UR a winner!");
                }
                else if (user == comp)
                {
                    Console.WriteLine("No one loses when the game's a draw.");
                }
                else
                {
                    Console.WriteLine("UR a loser :(");
                }
            }
            else
            {
                Console.WriteLine("Exit.");
            }
        }

        private static bool ValidItemNumber(int number)
        {
            return number is > 0 and <= 3;
        }

        private static Item CompareItems(int item)
        {
            return item switch
            {
                (int)Item.Rock => Item.Rock,
                (int)Item.Paper => Item.Paper,
                (int)Item.Scissors => Item.Scissors,
                _ => Item.Paper
            };
        }

        private static void Game()
        {


        }
    }
}
