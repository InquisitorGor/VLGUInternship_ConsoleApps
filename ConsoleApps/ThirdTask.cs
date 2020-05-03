using System;

namespace ConsoleApps
{
    class ThirdTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            Console.WriteLine("Введите координаты точек ");
            try
            {
                Console.Write("X1 ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y1 ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("X2 ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("X2 ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("X3 ");
                double x3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y3 ");
                double y3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("X4 ");
                double x4 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y4 ");
                double y4 = Convert.ToDouble(Console.ReadLine());
                Console.Write("X5 ");
                double x5 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y5 ");
                double y5 = Convert.ToDouble(Console.ReadLine());
                Console.Write("X6 ");
                double x6 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y6 ");
                double y6 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Длина первого отрезка " + f(x1, y1, x2, y2));
                Console.WriteLine("Длина второго отрезка " + f(x3, y3, x4, y4));
                Console.WriteLine("Длина третьего отрезка " + f(x5, y5, x6, y6));
                Console.WriteLine("Периметр треугольника " + d(f(x1, y1, x2, y2), f(x3, y3, x4, y4), f(x5, y5, x6, y6)));

                Console.WriteLine("Второе задание");
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h) Console.WriteLine("f({0:f2})={1:f4}", i, fX(i));

                Console.WriteLine("Третье задание");
                Console.Write("a=");
                a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                h = double.Parse(Console.ReadLine());
                double y;
                for (double i = a; i <= b; i += h)
                {
                    fX(i, out y);
                    Console.WriteLine("f({0:f2})={1:f4}", i, y);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
        }
        private static double d(double a, double b, double c)
        {
            return a + b + c;
        }
        private static double fX(double x)
        {
            if (x - 1 < 1) return 1;
            if (x - 1 == 1) return 0;
            if (x - 1 > 1) return -1;
            return 0;
        }
        private static void fX(double x, out double y)
        {
            y = 0.0;
            if (x - 1 < 1) y = 1;
            if (x - 1 == 1) y = 0;
            if (x - 1 > 1) y = -1;
        }
    }
}
