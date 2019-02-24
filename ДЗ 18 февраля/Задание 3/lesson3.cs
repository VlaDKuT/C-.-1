using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class lesson3
    {
        static double DistanceCalculation(double coordX1, double coordY1, double coordX2, double coordY2)//объявляем собственный метод DistanceCalculation. Он расчитывает расстояние между точками на основе переданных координат
        {
            double r;
            return r = Math.Round(Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2)), 2);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!\nДанная программа предназначена для расчета расстояние между точками с координатами (x1,y1) и (x2,y2)");
            Console.Write("Введите коррдинату Х1 - ");
            string X1String = Console.ReadLine();
            double X1 = double.Parse(X1String);

            Console.Write("Введите коррдинату У1 - ");
            string Y1String = Console.ReadLine();
            double Y1 = double.Parse(Y1String);

            Console.Write("Введите коррдинату Х2 - ");
            string X2String = Console.ReadLine();
            double X2 = double.Parse(X2String);

            Console.Write("Введите коррдинату У2 - ");
            string Y2String = Console.ReadLine();
            double Y2 = double.Parse(Y2String);

            double r = Math.Sqrt((X2 - X1) * (X2- X1) + (Y2 - Y1) * (Y2 - Y1));//Расчитываем растояние между введеными координатами и записываем в переменную r
            Console.WriteLine($"\nВходящие данные: \nКоордината первой точки ({X1String},{Y1String}); \nКоордината второй точки ({X2String},{Y2String});\nРасстояние между точками равно - {r:F2}");

            double res = DistanceCalculation(X1,Y1,X2,Y2);//Объявляем новую переменную и записываем в нее результат вычисления расстояния используя свой метод, передав координаты.
            Console.WriteLine($"\nВходящие данные: \nКоордината первой точки ({X1String},{Y1String}); \nКоордината второй точки ({X2String},{Y2String});\nРасстояние между точками равно - {res};\nРассчет произведен с помощью своего метода.");
            Console.ReadKey();

        }
    }
}
/*Задание. 3
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
    y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
    используя спецификатор формата .2f(с двумя знаками после запятой);
б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
метода.*/
