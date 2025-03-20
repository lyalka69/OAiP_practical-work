using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_13
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Максимум и минимум: номера строк с максимальной суммой");
                Console.WriteLine("2 - Таблица чемпионата: последовательность мест");
                Console.WriteLine("3 - Поменять столбцы местами");
                Console.WriteLine("4 - Одномерный массив из последних нечётных элементов");
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
                    case "4":
                        Task4();
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
            Console.WriteLine("\nЗадача 1: Найти номера двух соседних строк, сумма элементов в которых максимальна.");
            Random rand = new Random();
            int rows = 22;
            int cols = 2;
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

            int maxSum = int.MinValue;
            int row1 = -1, row2 = -1;

            for (int i = 0; i < rows - 1; i++)
            {
                int currentSum = matrix[i, 0] + matrix[i, 1] + matrix[i + 1, 0] + matrix[i + 1, 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    row1 = i;
                    row2 = i + 1;
                }
            }

            Console.WriteLine($"Номера строк с максимальной суммой: {row1 + 1} и {row2 + 1}");
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Последовательность мест в футбольном чемпионате.");
            Random rand = new Random();
            Console.WriteLine("Введите количество команд:");
            int n = int.Parse(Console.ReadLine());
            int[,] table = new int[n, n];
            int[] scores = new int[n];

            Console.WriteLine("Сгенерированная таблица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        table[i, j] = 0;
                    }
                    else
                    {
                        table[i, j] = rand.Next(0, 4);
                    }

                    scores[i] += table[i, j];
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

            var rankedTeams = scores
                .Select((score, index) => new { Team = index + 1, Score = score })
                .OrderByDescending(x => x.Score)
                .ToArray();

            Console.WriteLine("Последовательность мест:");
            foreach (var team in rankedTeams)
            {
                Console.WriteLine($"Команда {team.Team}: {team.Score} очков");
            }
        }

        static void Task3()
        {
            Console.WriteLine("\nЗадача 3: Поменять местами столбцы.");
            Random rand = new Random();
            int rows = 4;
            int cols = 6;
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

            for (int j = 0; j < cols; j += 2)
            {
                for (int i = 0; i < rows; i++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }

            Console.WriteLine("Матрица после перестановки столбцов:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Task4()
        {
            Console.WriteLine("\nЗадача 4: Формирование одномерного массива из последних нечётных элементов строк.");
            Random rand = new Random();
            int rows = 5;
            int cols = 7;
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

            int[] result = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                result[i] = 0;
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        result[i] = matrix[i, j];
                        break;
                    }
                }
            }
            Console.WriteLine("Результирующий массив:");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
