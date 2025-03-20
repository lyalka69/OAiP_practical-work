using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_17
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Конвертация числа в римские цифры");
                Console.WriteLine("2 - Решение квадратного уравнения из строки");
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
            Console.WriteLine("\nЗадача 1: Конвертация числа от 1 до 1999 в римские цифры.");
            Console.WriteLine("Введите число от 1 до 1999:");

            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 1999)
            {
                Console.WriteLine("Число должно быть от 1 до 1999.");
                return;
            }

            Console.WriteLine($"Римское представление: {ToRoman(number)}");
        }

        static string ToRoman(int number)
        {
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return thousands[number / 1000] +
                   hundreds[(number % 1000) / 100] +
                   tens[(number % 100) / 10] +
                   ones[number % 10];
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Решение квадратного уравнения из строки.");
            Console.WriteLine("Введите строку с квадратным уравнением, например: 2*x^2 + 3*x - 5 = 0");

            string input = Console.ReadLine();
            input = input.Replace("^2", "").Replace("= 0", "");

            string[] parts = input.Split(new[] { '*', 'x' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
            {
                Console.WriteLine("Ошибка в формате уравнения.");
                return;
            }

            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);
            double c = double.Parse(parts[2]);

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Корни уравнения: {root1} и {root2}");
            }
        }
    }
}
