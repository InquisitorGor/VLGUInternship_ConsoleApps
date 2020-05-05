using System;
namespace ConsoleApps
{
    class SixthTask
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
        static double f(double x)
        {
            try
            {
                
                if (2 * Math.Pow(x, 5) - 1 < 0) throw new Exception();
                else return Math.Log(Math.Abs(3 * x)) * Math.Sqrt(2 * Math.Pow(x, 5) - 1);
            }
            catch
            {
                throw;
            }
        }

    }

}
