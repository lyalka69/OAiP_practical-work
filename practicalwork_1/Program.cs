﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalwork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sakara
            //25.запрашивает с клавиатуры три целых числа,
            //и выводит на экран результат умножения первого числа на PI(с точностью 4 знака после запятой),
            //второго на число Е(с точностью 3 знака после запятой)
            //и третьего числа на произведение числа PI на Е(с точностью 2 знака после запятой):

                //// Ввод данных с клавиатуры
                //Console.Write("a = ");
                //double a = double.Parse(Console.ReadLine());
                //Console.Write("b = ");
                //double b = double.Parse(Console.ReadLine());
                //Console.Write("c = ");
                //double c = double.Parse(Console.ReadLine());
                //// Вывод на экран результата умножения:
                //Console.WriteLine($"a * PI: {a} * {Math.PI:f4} = {a * Math.PI:f4}");
                //Console.WriteLine($"b * E: {b} * {Math.E:f3} = {b * Math.E:f3}");
                //Console.WriteLine($"c * PI * E: {c} * {Math.PI:f2} * {Math.E:f2} = {c * Math.PI * Math.E:f2}");
                //Console.ReadKey();
        
        //25.Дано пятизначное число. Найти число, образуемое при перестановке первой и четвертой, второй и пятой цифр.

        // Ввод пятизначного числа
        //Console.Write("Введите пятизначное число: ");
        //    int num = int.Parse(Console.ReadLine());
        //    // Получаем каждую цифру числа
        //    int one = num / 10000;
        //    int two = (num / 1000) % 10;
        //    int three = (num / 100) % 10;
        //    int four = (num / 10) % 10;
        //    int five = num % 10;
        //    // Перестановка первой и четвертой, второй и пятой цифр
        //    int newNum = (four * 10000) + (five * 1000) + (three * 100) + (one * 10) + two;
        //    // Вывод результата
        //    Console.WriteLine($"Новое число: {newNum}");
        //    Console.ReadKey();

            //25.сумму членов геометрической прогрессии, если известен ее первый член, знаменатель и число членов прогрессии.

            //Console.Write("Первый член прогрессии a: "); //8
            //double a1 = double.Parse(Console.ReadLine());
            //Console.Write("Знаменатель прогрессии q: "); //0,5
            //double q = double.Parse(Console.ReadLine());
            //Console.Write("Введите количество членов прогресси n: "); //5
            //double n = double.Parse(Console.ReadLine());
            //double Sn = a1 * (Math.Pow(q,n) - 1) / (q - 1); //15,5
            //Console.WriteLine($"Sn = a1*(q^n - 1)/(q - 1) = {Sn}"); 



            //работает "n" косилок, первая косилка работает "m" часов, остальные на 10 минут больше чем предыдущая. Узнать сумму часов.
            Console.Write("Введите количество косилок (n): "); //5
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество часов работы первой косилки (m): "); //3
            double m = double.Parse(Console.ReadLine());// a1 = m
            double d = 1.0 / 6.0; 
            double An = m + (d * (n - 1));
            double sum = (n * (m + An)) / 2;
            Console.WriteLine($"Sn = {sum} - сумма часов работы бригады"); //16,6666666666667
            //Sn = n * ((m + An) / 2) 
            Console.ReadKey();




        }
    }
}
