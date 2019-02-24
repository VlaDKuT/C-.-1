using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    //1.	Написать метод, возвращающий минимальное из трёх чисел. 
    class lesson1
    {   

        /// <summary>
        /// Метод возврашает максимальное число
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        static double MaxNumber(double x, double y, double z)
        {
            if(x < y && x < z)
            {
                return (x);
            }
            else
            {
                if (y < z)
                {
                    return (y);
                }
                else
                {
                    return (z);
                }
                    
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Привет!\nДанная программа выводит минимальное число из Ваших 3-х чисел.");
            Console.Write("Введиде первое число - ");
            double number1 = double.Parse(Console.ReadLine());
          
            Console.Write("Введиде второе число - ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Введиде третье число число - ");
            double number3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное число - {MaxNumber(number1,number2,number3)}");//Отправляем введенные данные в свой метод
            Console.ReadKey();
        }
    }
}
