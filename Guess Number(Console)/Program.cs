using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int tryAnswer = 3;
            int playerNumber;
            
            Random random = new Random();
            number = random.Next(0, 11);

            Console.WriteLine("Угадайте число от 0 до 10");
            Console.WriteLine("У вас есть 3 попыток");
            
            
            while (tryAnswer-- > 0)
            {
                Console.Write("Ваше число: ");
                playerNumber = Convert.ToInt32(Console.ReadLine());
                if (playerNumber == number) 
                {
                    Console.WriteLine("Вы выйграли это было: " + number);
                    Console.ReadKey();
                    break;
                }
                else if (playerNumber != number)
                {
                    Console.WriteLine("Неверно");
                    Console.WriteLine($"У вас осталось {tryAnswer} попыток");
                }
            }
            if (tryAnswer < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("ВЫ ПРОИГРАЛИ ") ;
                Console.WriteLine($"Это было число {number}");
                Console.ReadKey();
            }
        }
    }
}
