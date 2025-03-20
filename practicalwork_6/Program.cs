using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("номер №: ");
            int N = int.Parse(Console.ReadLine());
            switch (N)
            {
                case 1:
                    /*5.В поликлинике кабинеты распределены так:
                     * 1, 2, 3, 17 - окулисты, 4, 18, 19, 20 - хирурги, 5-8 стоматологи,9-16 - педиатры.
                     * Задать целое число от 1 до 20 (номер кабинета) и определить специальность врача.*/
                    Console.Write("Введите номер кабинета: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n >= 1 & n <= 3 || n == 17) 
                        Console.WriteLine("окулисты");

                    else if (n == 4 || n >= 18 & n <= 20) 
                        Console.WriteLine("хирурги");

                    else if (n >= 5 & n <= 8) 
                        Console.WriteLine("стоматологи");

                    else if (n >= 9 & n <= 16) 
                        Console.WriteLine("педиатры");

                    else
                        Console.WriteLine("Некорректный номер кабинета.");

                    break;

                case 2:
                    /*5.В трехзначном числе х зачеркнули его вторую цифру.
                     * Когда к образованному при этом двузначному числу слева приписали вторую цифру числа х,
                     * то получилось число546. Найти число х.*/
                    for (int x = 100; x < 1000; x++)  // Перебираем все трехзначные числа
                    {
                        int firstDigit = x / 100;      // Первая цифра
                        int secondDigit = (x / 10) % 10;  // Вторая цифра
                        int thirdDigit = x % 10;       // Третья цифра

                        int newNum = secondDigit * 100 + firstDigit * 10 + thirdDigit;

                        if (newNum == 546)
                        {
                            Console.WriteLine($"Число x: {x}");
                            break;
                        }
                    }   
                     break;

                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            
            Console.ReadKey();



        }
    }
}
