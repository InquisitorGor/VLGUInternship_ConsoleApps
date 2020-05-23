using System;
using System.Linq;

namespace ConsoleApps
{
    class OneDimArray
    {
        private int[] IntArray;
        private int n;

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива ");
                int n = Convert.ToInt32(Console.ReadLine());
                OneDimArray array = new OneDimArray(n);
                array.fillArray();
                array.sortArray();
                array.displayArray();
                Console.WriteLine("Размер массива " + array.N);
                Console.Write("Введите скаляр ");
                int scal = Convert.ToInt32(Console.ReadLine());
                array.ScalArray = scal;
                array.displayArray();
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

            public OneDimArray(int n)
        {
            this.n = n;
            IntArray = new int[n];
        }

        public int N { get => n;}
        public void fillArray()
        {
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент ");
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void displayArray()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " элемент " + IntArray[i] + "\n");
            }
        }
        public void sortArray()
        {
            IntArray = IntArray.OrderBy(x => x).ToArray();
        }
        public int ScalArray
        {
            set
            {
                for (int i = 0; i < IntArray.Length; i++)
                    IntArray[i] = IntArray[i] * value;
            }
        }
    }
}
