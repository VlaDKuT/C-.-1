using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    
    public delegate double Fun(double x);
    public delegate double Fun1(double x, double a);

    class Program
    {

        /// <summary>
        /// Метод, котрый находит X^3, прибавлая 1 и выводит результат на экран, то тех пор пока х не будет равен b..
        /// </summary>
        /// <param name="F"></param>
        /// <param name="x"></param>
        /// <param name="b"></param>
        public static void Table(Fun F, double x, double b )
        {
            Console.WriteLine("----- X ----- Y ----- ");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.00} | {1,8:0.00} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        /// <summary>
        /// Метод нахождения x^3
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Метод, который демнстрирует работу на функции с функцией a* x^2
        /// </summary>
        /// <param name="F1"></param>
        /// <param name="x"></param>
        /// <param name="b"></param>
        public static void Table(Fun1 F1, double x, double b)
        {
            Console.WriteLine("----- X ----- Y ----- ");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.00} | {1,8:0.00} | ", x, F1(x,b));
                x += 1;
            }
            Console.WriteLine("------------------------");
        }

        /// <summary>
        /// Метод подсчитывает функцию a* x^2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double MyFunc1(double x, double a)
        {
            return a * Math.Pow(x,2);
        }

        /// <summary>
        /// Метод, котрый подсчитывает фукцию a* sin(x)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double MyFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");

            Console.WriteLine("Демонстрация работы на функции с функцией x * x * x");
          
            Table(MyFunc, -2, 2);

            Console.WriteLine("Демонстрация работы на функции с функцией a* x^2");
        
            Table( MyFunc1, -2, 2);

            Console.WriteLine("Демонстрация работы на функции с функцией a* sin(x)");

            Table(MyFunc2, -2, 2);



            Console.ReadKey();
        }

    }
}
