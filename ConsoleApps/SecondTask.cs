using System;

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
                Console.WriteLine("Категория - " + getAgeCategory(age));
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
            if (x == y && x * x + y * y < RADIUS * RADIUS || x * x + y * y == RADIUS * RADIUS && y < x)
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
        private static string getAgeCategory(int year)
        {
            int age = 2020 - year;
            if (age <= 1) return "младенец";
            else if (age > 1 && age <= 11) return "ребенок";
            else if (age > 11 && age <= 15) return "подросток";
            else if (age > 15 && age <= 25) return "юноша";
            else if (age > 25 && age <= 70) return "мужчина";
            else return "старик";
        }
        private static void ShowNegativeEvenNumbers(int A1, int B1)
        {
            int A = A1;
            int B = B1;
            while (A <= B && A < 0)
            {
                if (A % 2 != 0) A++;
                Console.Write(A);
                A += 2;
            }
            A = A1;
            B = B1;
            Console.WriteLine();
            do //do while не очень подходит для данной задачи
            {
                if (A > B && A > 0) break;
                if (A % 2 != 0) A++;
                Console.Write(A);
                A += 2;
            } while (A <= B && A < 0);
            A = A1;
            B = B1;
            Console.WriteLine();
            for (int i = A; i <= B; i+=2)
            {
                if (i >= 0) break;
                if (i % 2 != 0) i++;
                Console.Write(i);
                
            }
        }
        private static void ShowIDKWhatItIs()
        {
            int top = 8;
            for (int i = 1; i <= 4 ; i++)
            {               
                for (int j = 0; j < i; j++)
                {
                    Console.Write(top + " ");
                }
                top--;
                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {
                    Console.Write(top + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
