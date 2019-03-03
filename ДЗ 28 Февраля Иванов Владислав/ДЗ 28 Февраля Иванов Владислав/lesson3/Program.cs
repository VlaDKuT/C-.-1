using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    #region Текст задания 1 и 2
    //Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
    //Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
    //В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

    // 2) Реализуйте задачу 1 в виде статического класса StaticClass;
    // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    #endregion

    #region Задание 3
    //3)
    //а) Дописать класс для работы с одномерным массивом.
    //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    //Создать свойство Sum, которое возвращает сумму элементов массива, 
    //метод Inverse,возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
    //метод Multi, умножающий каждый элемент массива на определённое число, 
    //свойство MaxCount, возвращающее количество максимальных элементов.
    #endregion

    class Program
    {
        /// <summary>
        /// Метод переводящий введенные значения пользователя в число
        /// </summary>
        /// <returns></returns>
        public static int TextToInt ()
        {
            string textString = Console.ReadLine();//Вводим размер массива
            int number = Convert.ToInt32(textString);//переводим введенну. строк в число
            return number;
        }

        static void Main(string[] args)
        {
        
            #region Задание 1 - 2
            //int[] mass = new int[20];
            //mass = StaticClass.RandMass(mass);
            //StaticClass.TextWrite(mass);

            //Console.WriteLine("\nСортируем элементы массива");
            //Array.Sort(mass);
            //StaticClass.TextWrite(mass);

            //int pair = StaticClass.Task(mass);
            //Console.WriteLine("\nКоличество пар, которые деляться на 3  - " + pair);
            #endregion

            Console.Write("Привет! Данная программа демнстрирует работы класса для работы с массивом.\nДавай создадим новый массив NewMass и наполняем его значениями от - 10 000 до 10 000.\nСколько будет элементов в массиве: ");
            int NewLengthMass = TextToInt();

            int[] NewMass = StaticClass.CreatArray(NewLengthMass);
            Console.Write($"\nНовый массив содержит следующие значения - NewMass: ");
            StaticClass.TextWrite(NewMass);
            Console.ReadKey();

            int sum = StaticClass.SumMass;
            Console.Write($"\nС помощью свойства Sum определяем сумма элементов массива - {sum}");
            Console.ReadKey();

            int[] NewMass1 = StaticClass.Inverse(NewMass);
            Console.Write($"\nС помощью метода Inverse новый массив NewMass1 заполняем значениями массива NewMass, но меняем знаки значений массива на противоположный.\nNewMass1 - ");
            StaticClass.TextWrite(NewMass1);
            Console.ReadKey();

            Console.Write($"\nС помощью метода Multi умножаем каждый элемент массива NewMass1.\nНа какое число умножить элементы:");
            int mult = TextToInt();
            NewMass1 = StaticClass.Multi(NewMass1, mult);
            StaticClass.TextWrite(NewMass1);
            Console.ReadKey();

            Console.Write($"\nС помощью свойства MaxCount найдем количество элементов массива NewMass1, значения которых больше 0:");
            StaticClass.Mass = NewMass1;
            int coun = StaticClass.MaxCount;
            Console.Write($"\nВ массиве {coun} положительных(ый) элемент(а)");



            Console.ReadKey();
            
        }
    }
}
