using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите номер задания:");
        Console.WriteLine("1. Задание 25.1 - Определить сколько раз в числе встречается первая цифра.");
        Console.WriteLine("2. Задание 25.2 - Проверка порядка этапов гонщика.");
        Console.WriteLine("3. Задание 25.3 - Подсчёт студентов, получивших двойку.");
        Console.Write("Введите номер задания: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("25.1 Дано натуральное число. Определить, сколько раз в нем встречается первая цифра.");

                Console.Write("Введите натуральное число: ");
                int number = int.Parse(Console.ReadLine());

                int firstDigit = number;
                while (firstDigit >= 10)
                {
                    firstDigit /= 10;
                }

                int count = 0;
                int tempNumber = number;
                while (tempNumber > 0)
                {
                    if (tempNumber % 10 == firstDigit)
                    {
                        count++;
                    }
                    tempNumber /= 10;
                }

                Console.WriteLine($"Первая цифра числа: {firstDigit}");
                Console.WriteLine($"Количество вхождений первой цифры в числе: {count}");
                break;

            case 2:
                Console.WriteLine("25.2 Известны результаты (время в минутах), показанные автогонщиком.");
                Console.WriteLine("Проверить, был ли этап, который он выиграл, раньше этапа, на котором он занял последнее место.");

                Console.Write("Введите количество этапов: ");
                int stagesCount = int.Parse(Console.ReadLine());

                int[] results = new int[stagesCount];
                Console.WriteLine("Введите результаты (время в минутах) для каждого этапа:");
                for (int i = 0; i < stagesCount; i++)
                {
                    Console.Write($"Этап {i + 1}: ");
                    results[i] = int.Parse(Console.ReadLine());
                }

                int minIndex = 0, maxIndex = 0;
                for (int i = 1; i < stagesCount; i++)
                {
                    if (results[i] < results[minIndex])
                        minIndex = i;
                    if (results[i] > results[maxIndex])
                        maxIndex = i;
                }

                bool isWinnerBeforeLast = minIndex < maxIndex;

                Console.WriteLine($"\nЭтап, на котором гонщик занял первое место: {minIndex + 1}");
                Console.WriteLine($"Этап, на котором гонщик занял последнее место: {maxIndex + 1}");
                Console.WriteLine($"Верно ли, что этап с первым местом был раньше этапа с последним местом? {isWinnerBeforeLast}");
                break;

            case 3:
                Console.WriteLine("25.3 Определить количество студентов группы, получивших двойку на экзамене.");

                Console.Write("Введите количество студентов в группе: ");
                int studentsCount = int.Parse(Console.ReadLine());

                int[,] grades = new int[studentsCount, 2];

                Console.WriteLine("Введите оценки студентов по двум предметам (через пробел):");
                for (int i = 0; i < studentsCount; i++)
                {
                    Console.Write($"Студент {i + 1}: ");
                    string[] input = Console.ReadLine().Split();
                    grades[i, 0] = int.Parse(input[0]);
                    grades[i, 1] = int.Parse(input[1]);
                }

                int failCount = 0;
                for (int i = 0; i < studentsCount; i++)
                {
                    if (grades[i, 0] == 2 || grades[i, 1] == 2)
                        failCount++;
                }

                Console.WriteLine($"\nКоличество студентов, получивших двойку: {failCount}");
                break;

            default:
                Console.WriteLine("Некорректный номер задания.");
                break;
        }
        Console.ReadKey();
    }
}
