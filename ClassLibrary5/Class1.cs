using System;
using System.Collections.Generic;
using System.Linq;

namespace LabLibrary5
{
    public class Class1
    {
        // Подзадание 1: Определить, есть ли в записи квадрата данного числа цифра n
        public static void SubTask1()
        {
            Console.WriteLine("--- Подзадание 1: Проверка наличия цифры в квадрате числа ---");
            Console.Write("Введите целое число x: ");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                Console.Write("Введите цифру n (символ от '0' до '9'): ");
                char nChar = Console.ReadKey().KeyChar;
                Console.WriteLine();

                long square = (long)x * x;
                string squareStr = square.ToString();

                if (squareStr.Contains(nChar))
                {
                    Console.WriteLine($"Квадрат числа ({x} * {x} = {square}) СОДЕРЖИТ цифру '{nChar}'.");
                }
                else
                {
                    Console.WriteLine($"Квадрат числа ({x} * {x} = {square}) НЕ СОДЕРЖИТ цифру '{nChar}'.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода числа.");
            }
        }

        // Подзадание 2: Напечатать все слова, которые встречаются в последовательности по одному разу
        public static void SubTask2()
        {
            Console.WriteLine("--- Подзадание 2: Слова, встречающиеся по одному разу ---");
            Console.WriteLine("Введите последовательность слов через запятую, оканчивающуюся точкой (например: cat,dog,cat,bird.):");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                // Удаляем точку в конце строки, если она есть
                input = input.TrimEnd('.');

                // Разделяем строку на слова по запятой
                string[] words = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Очищаем пробелы и приводим к нижнему регистру для корректного сравнения
                List<string> cleanWords = new List<string>();
                foreach (var w in words)
                {
                    cleanWords.Add(w.Trim().ToLower());
                }

                // Подсчитываем частоту каждого слова с помощью словаря (Dictionary)
                Dictionary<string, int> counts = new Dictionary<string, int>();
                foreach (var word in cleanWords)
                {
                    if (counts.ContainsKey(word))
                        counts[word]++;
                    else
                        counts[word] = 1;
                }

                Console.WriteLine("Слова, встречающиеся ровно по одному разу:");
                bool found = false;
                foreach (var pair in counts)
                {
                    if (pair.Value == 1)
                    {
                        Console.Write(pair.Key + " ");
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Нет слов, встречающихся ровно один раз.");
                }
                Console.WriteLine();
            }
        }

        // Подзадание 3: Удвоить все гласные буквы
        public static void SubTask3()
        {
            Console.WriteLine("--- Подзадание 3: Удвоение всех гласных букв ---");
            Console.WriteLine("Введите строку (слово или предложение):");
            string input = Console.ReadLine();

            if (input != null)
            {
                // Список гласных букв (латинские и русские)
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
                                  'A', 'E', 'I', 'O', 'U', 'Y', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };

                string result = "";
                foreach (char c in input)
                {


                    result += c;
                    bool isVowel = false;
                    foreach (char v in vowels)
                    {
                        if (c == v)
                        {
                            isVowel = true;
                            break;
                        }
                    }
                    if (isVowel)
                    {
                        result += c; // Удваиваем гласную букву
                    }
                }

                Console.WriteLine("Результат после удвоения гласных:");
                Console.WriteLine(result);
            }
        }
    }
}