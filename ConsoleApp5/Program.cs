using System;
using LabLibrary5;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== ЛАБОРАТОРНАЯ РАБОТА  5, ЗАДАНИЕ 1 (ВАРИАНТ 3) ===");
                Console.WriteLine("1. Определить, есть ли в записи квадрата данного числа цифра n.");
                Console.WriteLine("2. Напечатать все слова, которые встречаются в последовательности по одному разу.");
                Console.WriteLine("3. Удвоить все гласные буквы.");
                Console.WriteLine("0. Выход.");
                Console.Write("Выберите номер подзадания [0-3]: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Class1.SubTask1();
                            break;
                        case 2:
                            Class1.SubTask2();
                            break;
                        case 3:
                            Class1.SubTask3();
                            break;
                        case 0:
                            Console.WriteLine("Выход из программы.");
                            break;
                        default:
                            Console.WriteLine("Неверный номер подзадания. Попробуйте снова.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите число от 0 до 3.");
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                   
                }

            } while (choice != 0);
        }
    }
}