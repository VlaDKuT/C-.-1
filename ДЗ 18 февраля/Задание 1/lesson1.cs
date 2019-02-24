using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class lesson1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! \nЭто программа - 'Анкета'. Она сохраняет Ваши данные и выводит их на экран тремя способами.\nПожалуйста, ответьте на следующие вопросы. ");
            Console.Write("Как Вас звут? - ");
            string name = Console.ReadLine();

            Console.Write("Какая у Вас фамилия? - ");
            string surname = Console.ReadLine();

            Console.Write("Сколько Вам лет? - ");
            string age = Console.ReadLine();

            Console.Write("Какой у Вас рост? - ");
            string growth = Console.ReadLine();

            Console.Write("Какой у Вас вес? - ");
            string weight = Console.ReadLine();

            Console.WriteLine("\nЗадание 1.а. Выводим данные с помощью склеивания");
            Console.WriteLine("Сверим данные: " + "Имя - " + name + "; " + "Фамилия - " + surname + "; " + "Возраст - " + age + "; " + "Рост - " + growth + "; " + "Вес - " + weight + ".");

            Console.WriteLine("\nЗадание 1.б. Выводим данные используя форматированный вывод");
            Console.WriteLine(String.Format("Сверим данные: Имя - {0}; Фамилия - {1}; Возраст - {2}; Рост - {3}; Вес - {4}.", name, surname, age, growth, weight));

            Console.WriteLine("\nЗадание 1.в. Выводим данные используя интерполяцию '$'");
            Console.WriteLine($"Сверим данные: Имя - {name}; Фамилия - {surname}; Возраст - {age}; Рост - {growth}; Вес - {weight}.");

            Console.ReadKey();



        }
        
    }
}


/*1. написать программу «анкета». последовательно задаются вопросы(имя, фамилия, возраст,
рост, вес). в результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $ (Интрополяция).*/ 