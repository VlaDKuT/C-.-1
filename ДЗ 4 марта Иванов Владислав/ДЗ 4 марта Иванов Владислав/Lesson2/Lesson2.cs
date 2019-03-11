using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson2
{

    class Lesson2
    {
        /// <summary>
        /// Метод который выводит значения элемнтов массива
        /// </summary>
        /// <param name="arry"></param>
        static void MassWrit(string[] arry)
        {
            for (var i = 0; i < arry.Length; i++)
            {
                Console.WriteLine($"{i+1} слово - {arry[i]};");
            }
          
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Привет!\nДанна программа работает с классом Message. Введите сообщение");
            string Line = Console.ReadLine();
            char[] div = { ' ' };//заполняем массив разделителями. Они будут делить наше сообщение на строки.
            string[] mass = Line.Split(div);//Заполняем массив разбив наш текст на строки.

            Messege.SortArry(ref mass);


            #region Задание 2 пункт А
            //Console.Write("Введите число букв, которое должно сожержать Ваше слово для вывода наэкран: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Messege.PointA(mass, n);
            #endregion

            #region задание 2 пунтк Б
            //Console.WriteLine("Введите символ. Если этот символ будет в конце слова, то оно будет удалено.");
            //char Chr = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Messege.PointB(ref mass, Chr);
            //Console.WriteLine("Результат работы: ");
            //MassWrit(mass);

            #endregion

            #region Задание 2 пункт В
            //Console.WriteLine("Ввыведем самые длинные слова: ");
            //Messege.PointC(mass);
            #endregion

            #region Задание 2 пункт Г
            Messege.PointG(mass);
            #endregion


            Console.ReadKey();

        }
    }
}
