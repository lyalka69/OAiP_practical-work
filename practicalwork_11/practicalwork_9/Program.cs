using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Табулирование функции");
                Console.WriteLine("2 - Сумма членов бесконечного ряда");
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
            Console.WriteLine("\nЗадача 1: Табулирование функции.");
            Console.WriteLine("Функция: F(x) = 0.4 + arctg(x) - x");

            double A = 1.0;
            double B = 2.0;
            int M = 10;
            double H = (B - A) / M;

            Console.WriteLine("Результаты табулирования:");
            Console.WriteLine("x\tF(x)");

            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double fx = 0.4 + Math.Atan(x) - x;
                Console.WriteLine($"{x:F2}\t{fx:F4}");
            }
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Вычисление суммы членов бесконечного ряда с заданной точностью.");
            Console.WriteLine("Ряд: S = 1 + 2!/2^2 + 3!/3^3 + ...");

            double epsilon = 1e-2;
            double term = 1.0; // Первый член ряда
            double sum = term;
            int n = 1;

            Console.WriteLine("Итерации:\nn\tТекущий член\tСумма");

            while (term >= epsilon)
            {
                Console.WriteLine($"{n}\t{term:F6}\t{sum:F6}");

                n++;
                term = Factorial(n) / Math.Pow(n, n);
                sum += term;
            }

            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Сумма ряда с точностью {epsilon:F1e} равна {sum:F6}");
        }

        static double Factorial(int num)
        {
            double result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
