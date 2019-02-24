using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    ////4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
    //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    //С помощью цикла do while ограничить ввод пароля тремя попытками. 
    class lesson4
    {
        /// <summary>
        /// Метод проверки логина и пароля
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool CheckUser (string name, string password)
        {
            int flag = 3;//Количество попыток
            do
            {
                if (name == "root")
                {
                    if (password == "GeekBrains")
                    {
                        return (true);
                    }
                }
                
                
                flag--;
                Console.WriteLine($"Логин/пароль не верный.\nУ Вас осталось {flag} попытки(а).");

                if (flag != 0) //Дополнительно проверям, надо ли спросить логин или пароль
                {
                    Console.Write("Введите логин и пароль.\nЛогин - ");
                    name = Console.ReadLine();

                    Console.Write("Пароль - ");
                    password = Console.ReadLine();

                }
               
            } while (flag != 0);
            return (false);
        }

        static void Main(string[] args)
        {
            Console.Write("Добрый день!\nЧтобы войти в систему введите логин и пароль.\nЛогин - ");
            string nameUser = Console.ReadLine();

            Console.Write("Пароль - ");
            string passowrdUser = Console.ReadLine();
            
            bool access = CheckUser(nameUser, passowrdUser);
            if (access == true)
            {
                Console.WriteLine("Доступ разрешен!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Доступ запрещен!");
                Console.ReadKey();
            }
        }
    }
}
