using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class SecondTask
    {
        private const int RADIUS = 12;
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            try
            {
                Console.WriteLine("Введите x: ");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                float y = float.Parse(Console.ReadLine());
                CheckCoordinates(x, y);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Второе задание");
            Console.WriteLine("Введите возраст");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0) throw new Exception("Отрицательное число");
                Console.WriteLine("Категория - " + checkAgeCategory(age));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Третье задание");
            Console.WriteLine("Задайте диапазон от А до В (А<=В)");
            try
            {
                Console.Write("A:");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("B:");
                int B = Convert.ToInt32(Console.ReadLine());
                ShowNegativeEvenNumbers(A, B);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Четвертое задание");
            ShowIDKWhatItIs();


        }
        private static void CheckCoordinates(float x, float y)
        {
            if (x == y && x * x + y * y < RADIUS * RADIUS)
            {
                Console.WriteLine("На границе");

            }
            else if (y < x && x * x + y * y < RADIUS * RADIUS)
            {
                Console.WriteLine("Да");

            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
        private static string checkAgeCategory(int year)
        {
            int age = 2020 - year;
            if (age <= 1) return "младенец";
            else if (age > 1 && age < 11) return "ребенок";
            else if (age > 12 && age < 15) return "подросток";
            else if (age > 16 && age < 25) return "юноша";
            else if (age > 26 && age < 70) return "мужчина";
            else return "старик";
        }
        private static void ShowNegativeEvenNumbers(int A, int B)
        {
            while (A <= B && A < 0)
            {
                if (A % 2 != 0) A++;
                Console.WriteLine(A);
                A += 2;
            }
        }
        private static void ShowIDKWhatItIs()
        {
            int top = 8;
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine(top);
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(top--);
                }
            }
        }
    }
}
