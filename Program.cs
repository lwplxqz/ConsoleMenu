using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput, temporaryInput;
            string message = null;
            string privateMessage = null;
            string password = null;

            Console.WriteLine("Нет информации. \nUse 'help' to show available commands. ");
            userInput = Console.ReadLine();
            Console.Clear();
            while (userInput != "exit")
            {
                if (privateMessage != null && message != null && userInput == null)
                {
                    Console.WriteLine($"Есть сообщение: {message}\nЕсть приватное сообщение.\nUse 'help' to show available commands.");
                    userInput = Console.ReadLine();
                }
                else if (message != null && userInput == null)
                {
                    Console.WriteLine($"Есть сообщение: {message}\nUse 'help' to show available commands.");
                    userInput = Console.ReadLine();
                }
                else if (privateMessage != null && userInput == null)
                {
                    Console.WriteLine($"Есть приватное сообщение.\nUse 'help' to show available commands.");
                    userInput = Console.ReadLine();
                }
                else if (privateMessage != null && message != null && userInput == null)
                {
                    Console.WriteLine($"Есть сообщение: {message}\nЕсть приватное сообщение.\nUse 'help' to show available commands.");
                    userInput = Console.ReadLine();
                }
                else if (userInput == null)
                {
                    Console.WriteLine("Нет информации. \nUse 'help' to show available commands. ");
                    userInput = Console.ReadLine();
                }
                else
                {
                    switch (userInput)
                    {
                        case "help":
                            Console.WriteLine("set_message - оставить сообщение.");
                            Console.WriteLine("set_private_message - оставить приватное сообщение (Доступ получит только пользователь, знающий пароль).");
                            Console.WriteLine("get_private_message - получить приватное сообщение.");
                            Console.WriteLine("wipe_data - очистить имеющиеся сообщения.");
                            Console.WriteLine("exit - выход.");
                            userInput = Console.ReadLine();
                            break;
                        case "set_message":
                            Console.Write("Введите сообщение: ");
                            message = Console.ReadLine();
                            userInput = null;
                            Console.Clear();
                            break;
                        case "set_private_message":
                            Console.Write("Введите сообщение: ");
                            privateMessage = Console.ReadLine();
                            Console.Write("Задайте пароль: ");
                            password = Console.ReadLine();
                            userInput = null;
                            Console.Clear();
                            break;
                        case "get_private_message":
                            if (privateMessage == null)
                            {
                                Console.WriteLine("Нет приватных сообщений. Нажмите любую кнопку для продолжения.");
                                Console.ReadKey();
                                userInput = null;
                                Console.Clear();
                            }
                            else
                            {
                                Console.Write("Введите пароль: ");
                                temporaryInput = Console.ReadLine();
                                if (temporaryInput == password)
                                {
                                    Console.WriteLine($"Приватное сообщение:\n{privateMessage}\nНажмите любую кнопку для продолжения.");
                                    Console.ReadKey();
                                    userInput = null;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Пароль введен не верно. Сообщение будет удалено.\nНажмите любую кнопку для продолжения.");
                                    Console.ReadKey();
                                    userInput = null;
                                    Console.Clear();
                                }
                            }
                            break;
                        case "wipe_data":
                            message = null;
                            privateMessage = null;
                            userInput = null;
                            Console.Clear();
                            break;
                        case "exit":
                            break;
                        default:
                            Console.WriteLine("Не знаю такой команды.\nНажмите любую кнопку для продолжения.");
                            Console.ReadKey();
                            Console.Clear();
                            userInput = null;
                            break;
                    }
                }
            }
        }
    }
}
