using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApps
{
    class FourthTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.Write("Введите m ");
            try
            {
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (m < n) throw new Exception("n не может быть больше m");
                Console.Write("Результат сочетания :" + C(m, n));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            getWierdPicture('A', 80, "down",0);
        }
            private static int C(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            else
                return C(n - 1, k - 1) + C(n - 1, k);
        }
        private static void getWierdPicture(Char character, int count, String direction, int spaceCount)
        {
            for (int i = 0; i < spaceCount; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
            if (direction == "down" && count != 30) getWierdPicture(++character, count -= 2, "down",++spaceCount);
            else {
                if (count == 80) return;
                getWierdPicture(--character, count += 2, "up",--spaceCount); 
            }
        }
    }
}
