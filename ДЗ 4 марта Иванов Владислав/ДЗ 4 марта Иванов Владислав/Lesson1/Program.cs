using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lesson1
{
    
    //Создать программу, которая будет проверять корректность ввода логина.
    //    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.

    class Program
    {
        /// <summary>
        /// Метод проверки корректность логина по трем методам CheckLoginLength,CheckLoginChar,CheckLoginInitialChar
        /// </summary>
        /// <param name="arry">Масси с символами</param>
        private static void CheckLogin(char[] arry)
        {
            bool lengthPas = false;
            bool charPas = false;
            bool initialCharPas = false;
            do
            {
                lengthPas = CheckLoginLength(arry);
                charPas = CheckLoginChar(arry);
                initialCharPas = CheckLoginInitialChar(arry);
                if (lengthPas == false || charPas == false || initialCharPas == false)
                {
                    Console.Write("Логин не корректный.\nВведи логин еще раз: ");
                    arry = (Console.ReadLine()).ToCharArray();
                }

            } while (lengthPas == false || charPas == false || initialCharPas == false);
            Console.WriteLine("Логин корректный");
        }
        /// <summary>
        /// Метод возвращает true или false если логин длиной от 2 до 10 символов
        /// </summary>
        /// <param name="arry">Массив с символами</param>
        /// <returns></returns>
        private static bool CheckLoginLength(char[] arry)
        {
            bool flag = false;

            if (arry.Length >= 2 && arry.Length <= 9)
            {
                flag = true;
                return flag;

            }
            return flag;

        }
        /// <summary>
        /// Метод возвращает true или false по проверке логина на содержание латинских букв и цифр
        /// </summary>
        /// <param name="arry">Массив с символами</param>
        /// <returns></returns>
        private static bool CheckLoginChar(char[] arry)
        {
            bool flag = false;
            int i = 0;
            do
            {
                if (char.IsLetterOrDigit(arry[i]) && ((arry[i]>='a' && arry[i] <= 'z') || (arry[i] >= 'A' && arry[i] <= 'Z') || (arry[i] >= '0' && arry[i] <= '9')))//Проверяем наш символ, если он число или буква, которая входит в латинскай алфавит, то проверяем следующий символ
                {
                    i++;
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }

            } while (i < arry.Length);
            return flag;
            
        }
        /// <summary>
        /// Метод возвращает true или false если первое символ логина число.
        /// </summary>
        /// <param name="arry">Массив с символами</param>
        /// <returns></returns>
        private static bool CheckLoginInitialChar(char[] arry)
        {
            bool flag = false;
            if (char.IsNumber(arry[0]) == false)//Если первый символ не цифра, то выходим из цикла
            {
                flag = true;
                return flag;
            }
            return flag;

        }


        static void Main(string[] args)
        {
            Console.Write("Привет.\nДанная программа проверяет корректность введнного логина.\nКорректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.\nВведите логин: ");
            char[] mass = (Console.ReadLine()).ToCharArray();//Введнный логин преобразуем струку в массив символов
            CheckLogin(mass);
           

            Console.ReadKey();

       
        }

        
    }
}
