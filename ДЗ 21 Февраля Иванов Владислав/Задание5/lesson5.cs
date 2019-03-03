using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    //5.	а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. 
           //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    class lesson5
    {
        /// <summary>
        /// Метод рассчитывает ИМТ
        /// </summary>
        /// <param name="growtString"></param>
        /// <param name="weightString"></param>
        /// <returns></returns>
        static double IMT(double growt, double weight)
        {
            double result = Math.Round(weight / Math.Pow(growt, 2), 2);//Расчитываем массу тела, округляем до двух знаком
            return (result);
        }

        /// <summary>
        /// Метод наоснове результата ИМТ сообщает о необходимости работы с весом
        /// </summary>
        /// <param name="mass"></param>
        static void ExplainResult(double mass, double growt, double weight)
        {
            double weightNorm = weight;//переменная для расчет разницы между текущим весом и нормой
            if (mass > 24.99)
            {
                do
                {
                    weightNorm = weightNorm - 0.1;//Из текущего веса вычитаем 100 грамм для поиска нужного весса
                    mass = IMT(growt, weightNorm);

                } while (mass > 24.99);

                weight = Math.Round((weight - weightNorm),2);//Ищем разницу между нормой и текущем весом
                Console.WriteLine($"До нормы Вам нужно сбросить {weight} кг.");
                
            }
            else if (mass < 18.5)
            {
                do
                {
                    weightNorm = weightNorm + 0.1;//К текущему весу вычитаем 100 грамм для поиска нужного весса
                    mass = IMT(growt, weightNorm);

                } while (mass < 18.5);
                weight = Math.Round((weightNorm - weight),2);//Ищем разницу между нормой и текущим весом
                Console.WriteLine($"До нормы Вам нужно набрать {weight} кг.");
                
            }
            else
            {
                Console.WriteLine($"Вы в норме!");
            }


        }

        static void Main(string[] args)
        {
            Console.Write("Привет!\nДанная программа расчитывает индекс массы тела.\nВведите Ваш рост - ");
            double growthUser = double.Parse ( Console.ReadLine());

            Console.Write("Укажите Ваш вес - ");
            double weightUser = double.Parse(Console.ReadLine());

            double result = IMT(growthUser, weightUser);
            
            Console.WriteLine($"ИМТ = {result}");
            ExplainResult(result, growthUser, weightUser);
            Console.ReadKey();
        }
    }
}
