using System;
using System.Linq;

namespace ConsoleApps
{
    class OneDimArray
    {
        private int[] intArray;
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

                Console.WriteLine("Получение значение по индексу 0 " + array[0]);

                Console.WriteLine("Увеличение всех элементов на 1");
                array++;
                array.displayArray();

                Console.WriteLine("Уменьшение всех элементов на 1:");
                array--;
                array.displayArray(); ;

                if (!array) Console.WriteLine("Массив не упорядочен по возростанию.");
                else
                    Console.WriteLine("Массив упорядочен по возростанию.");

                Console.WriteLine("Домножение всех элементов на скаляр ");
                array = array * scal;
                array.displayArray(); ;

                Console.WriteLine("Домножение всех элементов на скаляр с перестановкой множителей");
                array = scal * array;
                array.displayArray(); ;
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
            intArray = new int[n];
        }

        public int N { get => n;}
        public void fillArray()
        {
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void displayArray()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " элемент " + intArray[i] + "\n");
            }
        }
        public void sortArray()
        {
            intArray = intArray.OrderBy(x => x).ToArray();
        }
        public int ScalArray
        {
            set
            {
                for (int i = 0; i < intArray.Length; i++)
                    intArray[i] = intArray[i] * value;
            }
        }
        public int this[int index]
        {
            get { return intArray[index]; }
        }

        public static OneDimArray operator ++(OneDimArray array)
        {
            OneDimArray obj = new OneDimArray(array.intArray.Length);
            for (int i = 0; i < array.intArray.Length; i++)
            {
                obj.intArray[i] = array.intArray[i] + 1;
            }
            return obj;
        }

        public static OneDimArray operator --(OneDimArray array)
        {
            OneDimArray obj = new OneDimArray(array.intArray.Length);
            for (int i = 0; i < array.intArray.Length; i++)
            {
                obj.intArray[i] = array.intArray[i] - 1;
            }
            return obj;
        }

        public static bool operator !(OneDimArray array)
        {
            bool a = false;
            for (int i = 0; i < array.intArray.Length - 1; i++)
                if (array.intArray[i] > array.intArray[i + 1])
                    a = true;
            return a;
        }

        public static OneDimArray operator *(OneDimArray array, int scal)
        {
            for (int i = 0; i < array.intArray.Length; i++)
            {
                array.intArray[i] *= scal;
            }
            return array;
        }

        public static OneDimArray operator *(int scal, OneDimArray array)
        {
            for (int i = 0; i < array.intArray.Length; i++)
            {
                array.intArray[i] *= scal;
            }
            return array;
        }

        public static explicit operator OneDimArray(int[] array)
        {
            OneDimArray obj = new OneDimArray(array.Length);
            array.CopyTo(obj.intArray, 0);
            return obj;
        }

        public static explicit operator int[](OneDimArray obj)
        {
            return obj.intArray;
        }
    }
}
