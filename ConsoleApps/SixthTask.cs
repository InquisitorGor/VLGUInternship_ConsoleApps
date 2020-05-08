using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApps
{
    class SixthTask
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Первое задание: одномерный массив");
                Console.Write("Введите размер: ");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Задайте диапазон от А до В [А,В]");
                Console.Write("А: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                int[] arr = getOneDimensionalFilledArray(size);
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > B || arr[i] < A) Console.Write(arr[i] + " ");
                }
                Console.WriteLine("Первое задание: двумерный массив");
                Console.Write("Введите количество строк: ");
                int lines = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int columns = Convert.ToInt32(Console.ReadLine());
                int[,] arr1 = getTwoDimensionalFilledArray(lines, columns);
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (arr1[i, j] > B || arr1[i, j] < A) Console.Write(arr1[i, j] + " ");
                    }
                }
                Console.WriteLine("Второе задание");
                Console.Write("Введите размер: ");
                int size1 = Convert.ToInt32(Console.ReadLine());
                int[] arr2 = getOneDimensionalFilledArray(size1);
                Console.Write("Максимальный модуль - : " + arr2.Select(Math.Abs).Max());
                Console.WriteLine("Третье задание");
                Console.Write("Введите количество строк: ");
                int lines1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int columns1 = Convert.ToInt32(Console.ReadLine());
                int[,] arr3 = getStrangeByOrdedArray(lines1, columns1);
                displayTwoDimensionalArray(arr3);
                Console.WriteLine("Четвертое задание");
                Console.WriteLine("Введите размер");
                int size2 = Convert.ToInt32(Console.ReadLine());
                int[][] arr4 = getTwoDimensionalFilledArray(size2);
                int[] arr5 = new int[arr4.Length];
                for (int i = 0; i < arr4.Length; i++)
                {
                    arr5[i] = getLineSum(arr4[i], A, B);
                }
                for (int i = 0; i < arr5.Length; i++)
                {
                    Console.WriteLine(arr5[i] + " ");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        private static int [] getOneDimensionalFilledArray(int size)
        {
            int[] temp = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите " + (i + 1) + " число ");
                temp[i] = Convert.ToInt32(Console.ReadLine());
            }
            return temp;
        }
        private static int[,] getTwoDimensionalFilledArray(int lines, int columns)
        {
            int[,] temp = new int[lines,columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Введите число: " + (i + 1) +" строка " + (j + 1) +" столбец - ");
                    temp[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return temp;
        }
        private static int[,] getStrangeByOrdedArray(int lines, int columns)
        {
            int[,] temp = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp[i, j] = 0;
                }
            }
            int value = 1;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    temp[j, i] = value++;
                }
                if (i + 1 == columns) break;
                temp[lines - 1, ++i] = value++;
                if (i + 1 == columns) break;
                ++i;
                for (int j = lines - 1; j >= 0; j--)
                {
                    temp[j, i] = value++;
                }
                if (i + 1 == columns) break;
                temp[0, ++i] = value++;
                if (i + 1 == columns) break;
                
            }
            return temp;
        }
        private static void displayTwoDimensionalArray(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static int[][] getTwoDimensionalFilledArray(int size)
        {
            int[][] temp = new int[size][];
            for (int i = 0; i < size; i++)
            {
                temp[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Введите число: " + (i + 1) + " строка " + (j + 1) + " столбец - ");
                    temp[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return temp;
        }
        private static int getLineSum(int[]arr,int A, int B)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < A || arr[i] > B) sum += arr[i];
            }
            return sum;
        }
    }
}
