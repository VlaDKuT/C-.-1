using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class StaticClass
    {
        /// <summary>
        /// Глобальная переменная для работы в классе StaticClass
        /// </summary>
        public static  int[] Mass;

        /// <summary>
        /// Метод создающий новый массив
        /// </summary>
        /// <param name="LengthMass"></param>
        /// <returns></returns>
        public static int[] CreatArray(int LengthMass)
        {
            Mass = new int[LengthMass];
            Mass = RandMass(Mass);
            return Mass;
        }

        /// <summary>
        /// Методж заполняющий массив рандомными числами
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        public static int[] RandMass(int[] mass)
        {
            Random r = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(-10000, 10000);
            }
            return mass;
        }

        /// <summary>
        /// Метод, который выводит значение элемнтов массива на экран
        /// </summary>
        /// <param name="arry"></param>
        public static void TextWrite(int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write($"[{arry[i]}]");
            }

        }

        /// <summary>
        /// Метод ищущий количество пар в массиве, которые деляться на 3
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static int Task(int[] arry)
        {
            int pair = 0;
            for (var i = 0; i < arry.Length - 1; i++)
            {
                if (arry[i] % 3 == 0 && arry[i + 1] % 3 == 0)
                {
                    pair++;
                }
            }
            return pair;
        }

        /// <summary>
        /// Свойство показывает сумму значений элементов массива
        /// </summary>
        public static int SumMass
        {
            get
            {
                int sum = 0;
                for (var i = 0; i < Mass.Length; i++)
                {
                    sum = sum + Mass[i];
                }
                return sum;
            }

        }

        /// <summary>
        /// Метод меняющий значки значений элементов массива на противоположный
        /// </summary>
        /// <param name="Mass"></param>
        /// <returns></returns>
        internal static int[] Inverse(int[] Mass)
        {
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = Mass[i] * (-1);
            }
            return Mass;
        }

        /// <summary>
        /// Метод множающий каждый элемент массива на указанное число
        /// </summary>
        /// <param name="Mass"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        internal static int[] Multi(int[] Mass, int n)
        {
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = Mass[i] * (n);
            }
            return Mass;
        }

        /// <summary>
        /// Свойство которое возвращает максимальное количество элемнтов в массиве
        /// </summary>
        /// <param name="Mass"></param>
        /// <returns></returns>
        internal static int MaxCount
        {
            get
            {
                int Max = 0;
                for (int i = 0; i < Mass.Length; i++)
                {
                   if (Mass[i] > 0)
                   {
                        Max++;
                    }                        
                }
                
                return Max;

            }
            
        }
    }
}
