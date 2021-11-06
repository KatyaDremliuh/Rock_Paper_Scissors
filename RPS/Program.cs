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
            GetAnswerIfPlayerIsReadyOrNot(name);

            Console.ReadKey();
        }

        private static void Greeting(out string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Input Ur name, please: ");
            string playersName = Console.ReadLine();
            Console.WriteLine("Hi, {0}!", playersName);
            Console.ResetColor(); // скидываем настройки цвета на стандартные

            name = playersName;
        }

        private static void GetAnswerIfPlayerIsReadyOrNot(string playersName)
        {
            string readyToPlay = "YES";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Let's play a game \"Rock-Paper-Scissors\". \nIf U're ready, write {0}", readyToPlay);
            Console.ResetColor(); // скидываем настройки цвета на стандартные

            if (readyToPlay.Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Hurrah!");
                Console.Clear();
                ChooseAnItem();
            }
            else
            {
                Console.WriteLine($"Okay, {playersName} we'll play another time. Goodbye!");
            }
        }

        private static void ChooseAnItem()
        {
            int playersItem = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pick a poin:\n1 - Rock\n2 - Paper\n3 - Scissors");
                Console.ResetColor(); // скидываем настройки цвета на стандартные

                string item = Console.ReadLine();

                if (int.TryParse(item, NumberStyles.Any, CultureInfo, out playersItem) && !string.IsNullOrWhiteSpace(item) && ValidItemNumber(playersItem))
                {
                    break;
                }

                Console.WriteLine($"Ur input wasn't in the correct format. Enter a number between 1 and 3 including.");
            }
            while (true);

            Random random = new Random();
            int computerItem = random.Next(0, 3);

            Console.WriteLine("Ur item is {0}, computers item is {1}", playersItem, computerItem);
        }

        private static bool ValidItemNumber(int number)
        {
            return number is > 0 and <= 3;
        }
    }
}
