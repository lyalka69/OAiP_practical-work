using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_11
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Найти самую длинную диагональ выпуклого многоугольника");
                Console.WriteLine("2 - Частное суммы положительных и отрицательных элементов массива");
                Console.WriteLine("3 - Упорядочить массив результатов соревнований");
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
            Console.WriteLine("\nЗадача 1: Найти самую длинную диагональ выпуклого многоугольника.");
            Console.WriteLine("Введите количество вершин многоугольника:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Генерируем случайные координаты вершин...");
            Random rand = new Random();
            double[,] vertices = new double[n, 2];
            for (int i = 0; i < n; i++)
            {
                vertices[i, 0] = rand.Next(-100, 101);
                vertices[i, 1] = rand.Next(-100, 101);
                Console.WriteLine($"Вершина {i + 1}: ({vertices[i, 0]}, {vertices[i, 1]})");
            }

            double maxDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double dx = vertices[j, 0] - vertices[i, 0];
                    double dy = vertices[j, 1] - vertices[i, 1];
                    double distance = Math.Sqrt(dx * dx + dy * dy);
                    if (distance > maxDiagonal)
                    {
                        maxDiagonal = distance;
                    }
                }
            }

            Console.WriteLine($"Самая длинная диагональ имеет длину: {maxDiagonal:F2}");
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Найти частное от деления суммы положительных элементов массива на модуль суммы отрицательных элементов.");

            Console.WriteLine("Генерируем массив случайных чисел...");
            Random rand = new Random();
            double[] array = new double[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 51) + rand.NextDouble();
                Console.Write($"{array[i]:F2} ");
            }
            Console.WriteLine();

            double positiveSum = 0;
            double negativeSum = 0;

            foreach (var num in array)
            {
                if (num > 0)
                    positiveSum += num;
                else if (num < 0)
                    negativeSum += num;
            }

            if (negativeSum == 0)
            {
                Console.WriteLine("Модуль суммы отрицательных элементов равен нулю. Деление невозможно.");
            }
            else
            {
                double result = positiveSum / Math.Abs(negativeSum);
                Console.WriteLine($"Результат: {result:F2}");
            }
        }

        static void Task3()
        {
            Console.WriteLine("\nЗадача 3: Упорядочить массив результатов соревнований.");
            Console.WriteLine("Генерируем массив случайных результатов...");
            Random rand = new Random();
            int[] results = new int[25];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = rand.Next(1, 101);
                Console.Write($"{results[i]} ");
            }
            Console.WriteLine();

            // Упорядочивание массива
            Array.Sort(results);
            Array.Reverse(results);

            Console.WriteLine("Упорядоченный массив:");
            Console.WriteLine(string.Join(" ", results));
        }
    }
}