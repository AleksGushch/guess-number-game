using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<Игра угадай-ка!>>>>>>>");
            Console.Write("Введите максимальный диапозон от 0 до: ");
            int maxNumber=int.Parse(Console.ReadLine());
            Random rand=new Random();
            int randNumber=rand.Next(0,maxNumber);
            while (true)
            {
                Console.Write("Угадайте число в вашем диапозоне: ");
                string _number=Console.ReadLine();
                int number;
                if (_number == " ")
                {
                    Console.WriteLine($"Загаданное число {randNumber}");
                    break;
                }
                else 
                {
                    number = Convert.ToInt32(_number);
                    if (number > randNumber)
                    {
                        Console.WriteLine("Загаданное число меньше введенного!!");
                    }
                    else
                    {
                        if (number < randNumber)
                        {
                            Console.WriteLine("Загаданное число больше введенного!!");
                        }
                        else
                        {
                            Console.WriteLine("Вы угадали загаданное число!!!");
                            break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
