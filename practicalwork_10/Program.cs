using System;

namespace ConsoleApp1
{
    class Program
    {
        static Random random = new Random(); // Создаем объект для генерации случайных чисел

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Задача 1: Квадраты четных чисел");
                Console.WriteLine("2 - Задача 2: Вычитание элементов");
                Console.WriteLine("3 - Задача 3: Команды чемпионата");
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

        // Задача 1: Пусть даны натуральные числа n, а1, ..., аn. Определите количество членов аk последовательности а1, ..., аn являющихся квадратами четных чисел.
        static void Task1()
        {
            Console.WriteLine("\nЗадача 1: Пусть даны натуральные числа n, а1, ..., аn. Определите количество членов аk последовательности а1, ..., аn являющихся квадратами четных чисел.");
            Console.WriteLine("Условие задачи: необходимо найти, сколько элементов последовательности являются квадратами четных чисел.");

            // Автоматически генерируем массив
            int n = random.Next(5, 21); // Длина последовательности от 5 до 20
            int[] sequence = GenerateRandomArray(n, 1, 100); // Генерация массива чисел от 1 до 100

            Console.WriteLine($"Сгенерированная последовательность: {string.Join(" ", sequence)}");

            int squareCount = 0;

            for (int i = 0; i < n; i++)
            {
                int number = sequence[i];

                // Проверяем, является ли число квадратом четного числа
                int root = (int)Math.Sqrt(number);
                if (root * root == number && root % 2 == 0)
                {
                    squareCount++;
                }
            }

            Console.WriteLine($"Количество квадратов четных чисел: {squareCount}");
        }

        // Задача 2: Дан одномерный массив из действительных чисел. Из всех положительных элементов вычесть элемент с номером k1, из остальных — элемент с номером k2.
        static void Task2()
        {
            Console.WriteLine("\nЗадача 2: Дан одномерный массив из действительных чисел. Из всех положительных элементов вычесть элемент с номером k1, из остальных — элемент с номером k2.");
            Console.WriteLine("Условие задачи: требуется модифицировать массив, вычтя определенные элементы из разных групп чисел.");

            // Автоматически генерируем массив действительных чисел
            double[] numbers = GenerateRandomArray(10, -20.0, 20.0); // Генерация массива из 10 чисел от -20 до 20
            Console.WriteLine($"Сгенерированный массив: \n{string.Join("\t", numbers)}");

            // Выбираем случайные индексы для k1 и k2
            int k1 = random.Next(0, numbers.Length);
            int k2 = random.Next(0, numbers.Length);

            Console.WriteLine($"k1 = {k1 + 1}, k2 = {k2 + 1}");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    // Вычитаем элемент с номером k1 из положительных элементов
                    if (i != k1)
                    {
                        numbers[i] -= numbers[k1];
                    }
                }
                else
                {
                    // Вычитаем элемент с номером k2 из остальных элементов
                    if (i != k2)
                    {
                        numbers[i] -= numbers[k2];
                    }
                }
            }

            Console.WriteLine("Измененный массив:");
            Console.WriteLine(string.Join("\t", numbers));
        }

        // Задача 3: В массиве записано количество очков, набранных 20 командами-участницами чемпионата по футболу. Определить команды, занявшие первое и второе место.
        static void Task3()
        {
            Console.WriteLine("\nЗадача 3: В массиве записано количество очков, набранных 20 командами-участницами чемпионата по футболу. Определить команды, занявшие первое и второе место.");
            Console.WriteLine("Условие задачи: необходимо найти две команды с наибольшим количеством очков.");

            // Автоматически генерируем массив из 20 элементов
            int[] points = GenerateRandomArray(20, 0, 100); // Генерация массива очков команд от 0 до 100
            Console.WriteLine($"Сгенерированные очки команд: {string.Join("\t", points)}");

            int firstPlaceIndex = 0;
            int secondPlaceIndex = -1;

            // Находим первое место
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i] > points[firstPlaceIndex])
                {
                    firstPlaceIndex = i;
                }
            }

            // Находим второе место
            for (int i = 0; i < points.Length; i++)
            {
                if (i != firstPlaceIndex &&
                    (secondPlaceIndex == -1 || points[i] > points[secondPlaceIndex]))
                {
                    secondPlaceIndex = i;
                }
            }

            Console.WriteLine($"Первое место: команда {firstPlaceIndex + 1} (очки: {points[firstPlaceIndex]})");
            Console.WriteLine($"Второе место: команда {secondPlaceIndex + 1} (очки: {points[secondPlaceIndex]})");
        }

        // Метод для генерации массива случайных целых чисел
        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        // Метод для генерации массива случайных действительных чисел
        static double[] GenerateRandomArray(int size, double minValue, double maxValue)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);
            }
            return array;
        }
    }
}