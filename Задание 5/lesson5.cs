using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class lesson5
    {

            protected static void Print(string ms, int OrgX, int OrgY)//объявляем собственный методо Print и в него передаем текущие положение консоли и текст.
        {
            int x = OrgX / 2;//Перемещаем консоль на середину экрана
            int y = OrgY / 2;
            
            Console.SetWindowPosition(x, y);
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

            int origWidth, width;//Добавляем переменные для работы расположением консоли
            int origHeight, height;

            origWidth = Console.WindowWidth;//Узнаем текущие положение консоли
            origHeight = Console.WindowHeight;
            Console.WriteLine($"Текущие положение экрана: Высота - {origWidth}; Ширина - {origHeight}" );

            //перемещаем консоль в центр
            width = origWidth / 2;
            height = origHeight / 2;
            Console.SetWindowPosition(height,width);
            Console.WriteLine($"Текущие положение экрана: Высота - {width}; Ширина - {height}\nПеремещаем консоль в центр экрана.");
            Console.ReadKey();

            Console.WriteLine($"\nВыводим данне по анкете.\nСверим данные: Имя - {name}; Фамилия - {surname}; город проживания - {city};");
            Console.ReadKey();

            //Возвращаем консоль в исходное положение
            Console.WriteLine($"Перемещаем консоль в исходное положение. Текущие положение экрана: Высота - {origWidth}; Ширина - {origHeight}");
            Console.ReadKey();

            Console.WriteLine("\nЗадание 5.В. Выводим с помощью собственного метода Ваше 'Имя', 'Фамилию' и 'Горд проживания' по центру экрана.");
            Console.ReadKey();
            Console.WriteLine($"Текущие положение экрана: Высота - {width}; Ширина - {height}.\nПеремещаем консоль в центр экрана.");
            Console.ReadKey();

            //Помещаем текст в строковую переменную и передаем его в свой метод со значением координат
            string box = ($"Сверим данные: Имя - {name}; Фамилия - {surname}; город проживания - {city};");
            Print(box, origHeight, origWidth);
            Console.ReadKey();

        }
    }
}

/*задание 5
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) * Сделать задание, только вывод организовать в центре экрана.
 в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
  x, int y).*/
