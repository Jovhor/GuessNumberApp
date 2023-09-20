using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Guess a number\n");

            Console.WriteLine("Приложение для нахождения заданного программой числа.");
            Console.WriteLine("Я загадаю тебе любое число от нуля до того, что ты мне скажешь.\n");
            Console.WriteLine("Скажи, по какое число мне загадать? Впиши его.\n");
            int lastNumber= int.Parse(Console.ReadLine());
            int iiNumber = rand.Next(0, lastNumber + 1);
            int count = 0;
            int userNumber;

            for (; ; )
            {
                Console.WriteLine("\nВведите число:");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    Console.WriteLine("\nУ меня больше.");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("\nУ меня меньше.");
                }
                else
                {
                    Console.WriteLine($"\nУгадал! Число затраченных попыток: {count}.");;
                    Console.ReadKey();
                }
            }
        }
    }
}
