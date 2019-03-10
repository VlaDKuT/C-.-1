using System;
using System.Text;

namespace Lesson2
{
    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    //    Здесь требуется использовать класс Dictionary.

    public static class Messege
    {
        /// <summary>
        /// Метод считающий количество букв в массиве символов
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public static int CountLetter(string Str)
        {
            int Count = 0;
            char[] arry = Str.ToCharArray();
            for (var i = 0; i < arry.Length; i++)
            {
                if (char.IsLetter(arry[i]))
                {
                    Count++;
                }
            }
            return Count;
        }
        /// <summary>
        /// Метод который выводит слова, в котором больше или равно N букв
        /// </summary>
        /// <param name="arry"></param>
        /// <param name="n"></param>
        public static void PointA(string[] arry, int n)
        {
            for (var i = 0; i < arry.Length; i++)
            {

                if (CountLetter(arry[i]) >= n)
                {
                    Console.WriteLine(arry[i]);
                }

            }
        }
        /// <summary>
        /// Метод, который который ищет в массиве указанный символ. если он в конце строки, то удаляет эту строку.
        /// </summary>
        /// <param name="arry"></param>
        /// <param name="Chr"></param>
        public static void PointB(ref string[] arry, char Chr)
        {
            for (var i = 0; i < arry.Length; i++)
            {
                if (arry[i].LastIndexOf($"{Chr}") == arry[i].Length - 1)
                {
                    arry[i] = arry[i].Remove(0, arry[i].Length);
                }
            }



        }
        /// <summary>
       /// Метод ищет самое длиное слово в массиве
       /// </summary>
       /// <param name="arry"></param>
        public static void PointC(string[] arry)
        {
            int z = arry.Length-1;
            do
            {
                Console.WriteLine($"{arry[z]}");
                z--;

            } while (arry[z].Length == arry[arry.Length - 1].Length);

        }
        /// <summary>
        /// Метод сортировки элементов массива по длине от меньшего к большему
        /// </summary>
        /// <param name="arry"></param>
        public static void SortArry(ref string[] arry)
        {
            string Words;
            int count = 0;
            int z = arry.Length - 1;
            do
            {
                for (var i = 0 ; i < arry.Length; i++)
                {
                    
                    if (arry[i].Length > arry[z].Length && i < z)
                    {
                        Words = arry[z];
                        arry[z] = arry[i];
                        arry[i] = Words;
                    }
                }
                count++;
                z--;

            } while (count < arry.Length);
            
            
        }

        public static void PointG(string[] arry)
        {
            int z = arry.Length - 1;
            StringBuilder a = new StringBuilder();
            do
            {
              
                a.Append(arry[z]);
                z--;

            } while (arry[z].Length == arry[arry.Length - 1].Length);
            Console.WriteLine($"{a}");
        }

        
    }
}
