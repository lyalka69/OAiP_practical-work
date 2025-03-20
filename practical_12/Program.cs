using System;

namespace Practical12
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу для демонстрации:");
                Console.WriteLine("1 - Записать на место отрицательных элементов матрицы нули, а на место положительных – единицы. Вывести на печать нижнюю треугольную матрицу.");
                Console.WriteLine("2 - Найти количество столбцов, содержащих хотя бы один нулевой элемент.");
                Console.WriteLine("3 - В поезде 18 вагонов, в каждом из которых 36 мест, определить количество свободных мест в каждом вагоне.");
                Console.WriteLine("0 - Выход.");

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
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        // Метод для автоматического заполнения матрицы случайными числами
        static int[,] GenerateRandomMatrix(int rows, int cols, int minValue, int maxValue)
        {
            int[,] matrix = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }

        // Метод для вывода матрицы
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Задача 1: Преобразовать матрицу и вывести нижнюю треугольную часть
        static void Task1()
        {
            int rows = 5, cols = 5; //Задаём количество строк и столбцов для матрицы
            int[,] matrix = GenerateRandomMatrix(rows, cols, -10, 10); //Генерируем матрицу случайных чисел в диапазоне от -10 до 10

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);//вывод матрицы

            //Преобразование матрицы: заменяем отрицательные числа на 0, а положительные - на 1
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = matrix[i, j] < 0 ? 0 : 1;// проверка, если меньше 0 - 0, иначе 1
                }
            }

            Console.WriteLine("Преобразованная матрица:");
            PrintMatrix(matrix);

            Console.WriteLine("Нижняя треугольная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)//если строка = 3, спускаемся ниже и выводим 3 элемениа 
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Задача 2: Найти количество столбцов с хотя бы одним нулевым элементом
        static void Task2()
        {
            int rows = 5, cols = 5;//объявление переменных столбцов и строк
            int[,] matrix = GenerateRandomMatrix(rows, cols, 0, 5);// Инициализируем двумерный массив Random размера.

            Console.WriteLine("Сгенерированная матрица:");
            PrintMatrix(matrix);//вывод

            int zeroColumnCount = 0;//переменная для подсчёта столбцов с хотя бы одним нулевым элементом

            for (int j = 0; j < cols; j++)// Цикл по столбцам
            {
                for (int i = 0; i < rows; i++)// Цикл по строкам
                {
                    if (matrix[i, j] == 0)//проверка элементов массива на ноль
                    {
                        zeroColumnCount++;// Увеличиваем счётчик столбцов с нулями
                        break;
                    }
                }
            }

            Console.WriteLine($"Количество столбцов с хотя бы одним нулевым элементом: {zeroColumnCount}");
        }

        // Задача 3: Определить количество свободных мест в каждом вагоне.
        static void Task3()
        {
            //объявление констант
            const int wagons = 18;
            const int seats = 36;

            int[,] train = new int[wagons, seats]; //Создаём двумерный массив, представляющий места в поезде: строки - вагоны, столбцы - места.
            Random random = new Random();

            for (int i = 0; i < wagons; i++)
            {
                for (int j = 0; j < seats; j++)
                {
                    train[i, j] = random.Next(0, 2); // 0 - свободно, 1 - занято
                }
            }

            Console.WriteLine("Сгенерированная матрица мест в поезде (0 - свободно, 1 - занято):");
            PrintMatrix(train);

            for (int i = 0; i < wagons; i++)
            {
                int freeSeats = 0;//переменная для подсчёта свободных мест в текущем вагоне.
                for (int j = 0; j < seats; j++)
                {
                    if (train[i, j] == 0) freeSeats++;// Если место свободно (0), увеличиваем счётчик свободных мест.
                }
                Console.WriteLine($"Свободных мест в вагоне {i + 1}: {freeSeats}");
            }
        }
    }
}
