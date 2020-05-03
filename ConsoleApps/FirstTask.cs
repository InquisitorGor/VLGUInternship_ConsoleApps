using System;

namespace ConsoleApps
{
    class FirstTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            try
            {
                double outerRadius, innerRadius;
                Console.WriteLine("Введите внешний радуйс:");
                outerRadius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите внутренний радуйс:");
                innerRadius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь кольца равна:" + CountRingSquare(outerRadius, innerRadius));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Второе задание");
            Console.WriteLine("Введите трехзначное число:");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (AreSame(number))
                {
                    Console.WriteLine("Все цифры равны");
                }
                else
                {
                    Console.WriteLine("Цифры не равны");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }       
        }
        private static bool AreSame(int number) 
        {
            if (number % 111 == 0) return true;
            else return false;
        }
        private static double CountRingSquare(double outerRadius, double innerRadius)
        {
            return Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
        }
    }

}
