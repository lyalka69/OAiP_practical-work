using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_16
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Найти слова, состоящие из цифр, и их сумму");
                Console.WriteLine("2 - Генерация строк с заданным шаблоном");
                Console.WriteLine("0 - Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        static void Task1()
        {
            Console.WriteLine("\nЗадача 1: Найти слова, состоящие из цифр, и их сумму.");

            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            int sum = 0;

            foreach (string word in words)
            {
                if (IsNumber(word))
                {
                    int number = int.Parse(word);
                    sum += number;
                    Console.WriteLine("Найдено слово-число: " + word);
                }
            }

            Console.WriteLine("Сумма чисел: " + sum);
        }

        static bool IsNumber(string word)
        {
            foreach (char c in word)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Генерация строк длины 10.");

            Random random = new Random();
            Console.WriteLine("Сгенерированные строки:");

            for (int i = 0; i < 5; i++)
            {
                string result = "";
                for (int j = 0; j < 10; j++)
                {
                    if (j < 4)
                    {
                        result += random.Next(0, 10).ToString();
                    }
                    else if (j < 6)
                    {
                        result += (char)random.Next('A', 'Z' + 1);
                    }
                    else
                    {
                        result += random.Next(0, 2).ToString();
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
