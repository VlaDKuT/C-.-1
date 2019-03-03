using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    ///3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел. 
    class lesson3
    {
        /// <summary>
        /// Метод возврашающий сумму нечётных положительных чисел, которые ввел пользователь
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static string SumOddNumber(string x)
        {
            int sum = 0; //Сумма чисел
            int number = int.Parse(x);
            do
            {
                if ((number % 2 == 0) == false)//проверяем, что число нечетное
                {
                    if (number > 0)
                    {
                        sum = sum + number;//Суммиурем положительные числа
                    }
                }

                Console.Write("Введите число - ");
                string numberString = Console.ReadLine();
                number = int.Parse(numberString);

            } while (number != 0);
            return (Convert.ToString(sum));
        }
        

        static void Main(string[] args)
        {
            Console.Write("Привет!\nДанная программа считает сумму всех нечётных положительных чисел.\nВведите число - ");
            string msg = Console.ReadLine();
            string result = SumOddNumber(msg);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
