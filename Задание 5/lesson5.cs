using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class lesson5
    {

            protected static void Print(string ms, int x, int y)//объявляем собственный методо Print и в него передаем параметр строки и двух чисел
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(ms);
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Привет! \nЭто программа -'Анкета-2 '. Она сохраняет Ваши данные и выводит их на экран.\nПожалуйста, ответьте на следующие вопросы:");
            Console.Write("Как Вас звут? - ");
            string name = Console.ReadLine();

            Console.Write("Какая у Вас фамилия? - ");
            string surname = Console.ReadLine();

            Console.Write("В каком городе Вы проживаете? - ");
            string city = Console.ReadLine();
                       
            Console.WriteLine("\nЗадание 5.а. Выводим на экран Ваше 'Имя', 'Фамилию' и 'Горд проживания'.");
            Console.WriteLine($"Сверим данные: Имя - {name}; Фамилия - {surname}; город проживания - {city};");
            Console.ReadKey();

            Console.WriteLine("\nЗадание 5.б. Выводим по центру экрана Ваше 'Имя', 'Фамилию' и 'Горд проживания'.");
            Console.SetCursorPosition(15, 11);
            Console.WriteLine($"Сверим данные: Имя - {name}; Фамилия - {surname}; город проживания - {city};");
            Console.ReadKey();

            Console.WriteLine("\nЗадание 5.В. Выводим с помощью собственного метода Ваше 'Имя', 'Фамилию' и 'Горд проживания' по центру экрана.");
            string box = ($"Сверим данные: Имя - {name}; Фамилия - {surname}; город проживания - {city};");
            Print(box,15,14);
            Console.ReadKey();

        }
    }
}

/*задание 5
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) * Сделать задание, только вывод организовать в центре экрана.
 в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
  x, int y).*/
