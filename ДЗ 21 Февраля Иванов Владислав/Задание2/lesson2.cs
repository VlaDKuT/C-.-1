using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    //2.	Написать метод подсчета количества цифр числа. 

    class lesson2
    {
        static void Main(string[] args)
        {
            Console.Write("Привет!\nДанная программа считает количество цифр.\nВведите число - ");
            string msg = Console.ReadLine();
            int countNumber = 0;//кеолиячество чисел

            foreach (char c in msg)//Перебираем символы в переменной
                if (Char.IsDigit(c) == true)//Проверям что символ число
                {
                    countNumber++;
                }
                        
            Console.WriteLine($"Кол-во чисел - {countNumber}");
            Console.ReadKey();

        }
    }
    
}
