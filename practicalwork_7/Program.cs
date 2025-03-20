using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("z= ");
            int z = int.Parse(Console.ReadLine());  
            switch (z)
            {
                case 1:
            //7.1	кубы всех целых чисел из диапазона от А до В (A <= B) в обратном порядке;
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());

            if (a <= b)
            {
                for (int i = b; i >= a; i--)  // Идем от B к A
                {
                    int cube = i * i * i;    // Вычисляем куб числа
                    Console.WriteLine($"Куб числа {i}: {cube}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Число A должно быть меньше или равно B.");
            }
                    break;
                    case 2:
                //7.2   Вывести на экран числа следующим образом: 1; 22; 333; 4444; 55555.
        
                int n = 5;  // Количество строк

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                    break; 

                case 3:
            //7.3	Найти сумму квадратов всех целых чисел от а до B (значения а и B вводятся с клавиатуры; B >=A );

            Console.Write("Введите значение A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("Ошибка: значение A должно быть меньше или равно B.");
                Console.ReadKey();
                return;
            }
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i * i;  // Вычисляем квадрат числа i и добавляем к сумме
            }

            Console.WriteLine($"Сумма квадратов всех чисел от {A} до {B}: {sum}");
                    break;
            }
            Console.ReadKey();
                
            

        }
    }
}
