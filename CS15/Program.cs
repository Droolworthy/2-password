//Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению. 
//Пользователь вводит пароль, далее происходит проверка пароля на правильность, и если пароль неверный, то попросите его ввести пароль ещё раз. 
//Если пароль подошёл, выведите секретное сообщение.
//Если пользователь неверно ввел пароль 3 раза, программа завершается.
using System;

namespace CS15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "Изподвыподверта";
            int tryCount = 3;
            string userInput;
            
            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.Write("Секретное сообщение");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль. У вас осталось " + (tryCount - 1 - i) + " попытки");
                }  
            }
        }
    }
}
