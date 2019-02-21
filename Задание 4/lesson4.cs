using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class lesson4
    {
        static void Main(string[] args)
        {
            int A = 23;
            int B = 12;
            Console.WriteLine("Привет.\nДанная программа меняет местами значения в переменной А и В двумя способами:\na) Через третью переменную Z;\nб) С помощью математических операторов сложения и вычитания.");
            Console.WriteLine($"Сейчас в переменная А = {A}, а переменная В = {B}.");
            Console.ReadLine();

            Console.WriteLine("А. Меняем местами переменные A и B через третью переменнйю Z.");
            int Z = A;
            Console.WriteLine("Z = A; Z = " + Z);

            A = B;
            Console.WriteLine("A = B; A = " + A);

            B = Z;
            Console.WriteLine("B = Z; B = " + B);

            Console.WriteLine($"\nТеперь переменная А = {A} , а переменная В = {B}");
            Console.ReadLine();

            Console.WriteLine("Б.Меняем местами переменные используя математический операторы сложения и вычитания.");
            Console.WriteLine($"А = А + В; А = {A = A + B}");
            Console.WriteLine($"B = A - В; B = {B = A - B}");
            Console.WriteLine($"A = A - B: A = {A = A - B}");
            Console.WriteLine($"\nТеперь переменная А = {A} , а переменная В = {B}");
            Console.ReadLine();

        }
    }
}

/*4. Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.
*/