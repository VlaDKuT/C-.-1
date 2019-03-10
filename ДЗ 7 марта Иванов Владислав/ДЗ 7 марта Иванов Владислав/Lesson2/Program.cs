using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Lesson2
{

    //    Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 
    public delegate double MyFunc(double x);

    class Program
    {
        /// <summary>
        /// Функция x * x - 50 * x + 10 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Point1(double x)
        {
            return x * x - 50 * x + 10;
        }

        /// <summary>
        /// Функция x - 50 * x + 10
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Point2(double x)
        {
            return x - 50 * x + 10;
        }

        /// <summary>
        /// Функция x * x  + 10
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Point3(double x)
        {
            return x * x  + 10;
        }

        /// <summary>
        /// Функция создает и записывает в файл значения
        /// </summary>
        /// <param name="F"></param>
        /// <param name="fileName"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="h"></param>
        public static void SaveFunc(MyFunc F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Фукнция считывает значения из файла и записывает их в массив
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[] arry = new double [fs.Length];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                arry[i] = d;            
                    
               if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arry;
                        
        }

        /// <summary>
        /// Метод который выводит содержимое массива
        /// </summary>
        /// <param name="arry"></param>
        public static void ReadArry(double[] arry)
        {
            for (var i = 0; i < arry.Length; i++)
                Console.Write("{0} ", arry[i]);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Првиет!\nТебе даны следующие фукнции: \nPoint1 - x * x - 50 * x + 10\nPoint2 - x - 50 * x + 10\nPoint3 -  x * x  + 10\n");
            Console.WriteLine("Ввдени имя функции и число меньше 100: ");
            string Point = Console.ReadLine();//Переменная выбора функции
            int MinNumber = int.Parse(Console.ReadLine());//Минимальное значение для отрезка

            

            #region Задание 2 пункт А
            switch (Point)
            {
                case "Point1":
                    SaveFunc(Point1, "data.bin", MinNumber, 100, 0.5);
                    break;
                case "Point2":
                    SaveFunc(Point2, "data.bin", MinNumber, 100, 0.5);
                    break;
                case "Point3":
                    SaveFunc(Point3, "data.bin", MinNumber, 100, 0.5);
                    break;
            }
            #endregion

            #region Задание 2 Пункт Б
            double min; //Параметр, который будет содержать мигнимальное значение
            double[] mass;//Массив в который будет записан массив со начениями, который прочли в файле
            mass = Load("data.bin", out min);
            Console.WriteLine($"Min - {min}\n");
            Array.Sort(mass);
            #endregion

            Console.ReadKey();

        }


        
    }
}

