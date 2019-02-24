using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Здание_2
{
    class lesson2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Првиет! \nЭто программа расчет 'ИМТ' - индекс массы тела. \nДля того чтобы расчитать индекс, пожалуйста, ответьте на следующие воросы:");
            Console.Write("Какая у Вас масса тела? (Введите значение в килограммах) - ");
            string WeightString = Console.ReadLine();//Записывае значение массы в строковую переменную
            double Weight= double.Parse (WeightString);//Переводим тип данных из строки в числовой с плавающей точкой


            Console.Write("Какой у Вас рос? (Введите значение в метрах) - ");
            string GrowthString = Console.ReadLine();//Записывае значение роста в строковую переменную
            double Growth = double.Parse(GrowthString);//Переводим тип данных из строки в числовой с плавающей точкой

            double i = Weight / (Growth * Growth);//Рассчитываем инедекс
            Console.WriteLine($"При массе тела - {WeightString} кг.;\nПри росте - {GrowthString} м.;\nИМТ равен - {i:N2} кг/м");//Спомощью интерполяции выводим дынные и указываем количество знаков после запятой
            Console.ReadKey();

        }
    }
}

/*2.	Ввести вес и рост человека.
 * Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах. */