using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_12
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Минимальный элемент верхней треугольной матрицы");
                Console.WriteLine("2 - Минимум среди сумм диагоналей, параллельных главной");
                Console.WriteLine("3 - Общее число очков футбольной команды");
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
                    case "3":
                        Task3();
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
            Console.WriteLine("\nЗадача 1: Определить минимальный элемент верхней треугольной матрицы для A(8x10).");
            Random rand = new Random();
            int rows = 8;
            int cols = 10;
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int min = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент верхней треугольной матрицы: {min}");
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Найти минимум среди сумм элементов диагоналей, параллельных главной диагонали матрицы.");
            Random rand = new Random();
            int rows = 5;
            int cols = 6;
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-50, 51);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int minSum = int.MaxValue;

            for (int start = 0; start < rows; start++)
            {
                int sum = 0;
                for (int i = start, j = 0; i < rows && j < cols; i++, j++)
                {
                    sum += matrix[i, j];
                }
                minSum = Math.Min(minSum, sum);
            }

            for (int start = 1; start < cols; start++)
            {
                int sum = 0;
                for (int i = 0, j = start; i < rows && j < cols; i++, j++)
                {
                    sum += matrix[i, j];
                }
                minSum = Math.Min(minSum, sum);
            }

            Console.WriteLine($"Минимальная сумма среди диагоналей: {minSum}");
        }

        static void Task3()
        {
            Console.WriteLine("\nЗадача 3: Определить общее число очков, набранных футбольной командой.");
            Random rand = new Random();
            int games = 22;
            int[,] scores = new int[2, games];

            Console.WriteLine("Результаты игр (забито / пропущено):");
            for (int i = 0; i < games; i++)
            {
                scores[0, i] = rand.Next(0, 6);
                scores[1, i] = rand.Next(0, 6);
                Console.WriteLine($"Игра {i + 1}: {scores[0, i]} - {scores[1, i]}");
            }

            int totalPoints = 0;
            for (int i = 0; i < games; i++)
            {
                if (scores[0, i] > scores[1, i])
                {
                    totalPoints += 3;
                }
                else if (scores[0, i] == scores[1, i])
                {
                    totalPoints += 1;
                }
            }

            Console.WriteLine($"Общее число очков команды: {totalPoints}");
        }
    }
}
