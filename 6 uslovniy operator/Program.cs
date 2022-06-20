using System;

namespace _6_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            string userName = "Имя не установленно";
            string consoleColor;
            string userPassword = "0";
            string userInput;

            bool continueProgramExecution = true;

            while (continueProgramExecution == true)
            {           
                Console.WriteLine("1 - Установите имя");
                Console.WriteLine("2 - Изменить цвет консоли");
                Console.WriteLine("3 - установите пароль");
                Console.WriteLine("4 - Вывести имя");
                Console.WriteLine("0 - Выход");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        continueProgramExecution = false;
                        break;

                    case "1":
                        Console.WriteLine("Введите имя пользователя");
                        userName = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("1 - зеленый");
                        Console.WriteLine("2 - голубой");
                        Console.WriteLine("3 - красный");
                        Console.WriteLine("4 - Чурный");
                        consoleColor = Console.ReadLine();

                        switch (consoleColor)
                        {
                            case "1":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                break;

                            case "2":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                break;

                            case "3":
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;

                            case "4":
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;
                        }

                        break;

                    case "3":
                        Console.WriteLine("Введите пароль пользователя");
                        userPassword = Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("Введите пароль: ");
                        userInput = Console.ReadLine();
                        if (userInput == userPassword)
                        {
                            Console.WriteLine(userName);
                        }
                        else
                        {
                            Console.WriteLine("Пороль не верен");
                        }

                        break;
                        
                }
            }
        }
    }
}
