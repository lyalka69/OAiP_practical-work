using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical13_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Задаём размер массива
                const int rows = 5;
                const int cols = 4;

                // Создаём двумерный массив и заполняем случайными числами
                int[,] matrix = GenerateRandomMatrix(rows, cols, 1, 100);

                // Выводим исходную матрицу
                Console.WriteLine("Исходная матрица:");
                PrintMatrix(matrix);

                // Находим строку с максимальным элементом для каждого столбца
                for (int j = 0; j < cols; j++) // Перебираем столбцы
                {
                    int maxValue = int.MinValue; // Инициализируем максимум минимально возможным значением
                    int maxRowIndex = -1;        // Переменная для хранения индекса строки с максимальным элементом

                    for (int i = 0; i < rows; i++) // Перебираем строки текущего столбца
                    {
                        if (matrix[i, j] >= maxValue) // Ищем максимум (если одинаковые значения, выбираем строку ниже)
                        {
                            maxValue = matrix[i, j];
                            maxRowIndex = i;
                        }
                    }

                    // Выводим результат для текущего столбца
                    Console.WriteLine($"Столбец {j + 1}: максимальный элемент = {maxValue}, находится в строке {maxRowIndex + 1}");
                }
            }

            // Метод для генерации случайного двумерного массива
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
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();



                
                }
            }
        }





    }

