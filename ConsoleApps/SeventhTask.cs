using System;
using System.Text;

namespace ConsoleApps
{
    class SeventhTask
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Первое задание: ");
                Console.WriteLine("Введите строку: ");
                StringBuilder str = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Исходная строка: " + str);
                Console.WriteLine("Измененная строка: " + getChangedString(str));
                Console.WriteLine("Второе задание: ");
                Console.WriteLine("Введите строку: ");
                str = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Исходная строка: " + str);
                Console.WriteLine("Измененная строка: " + checkSentenceCorrection(str));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static StringBuilder getChangedString(StringBuilder str)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==':') return temp;
                temp.Append(str[i]);
            }
            return temp;
        }
        private static StringBuilder checkSentenceCorrection(StringBuilder str)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 1; i < str.Length; i++)
            {
                char previousChar = str[i - 1];
                char followingChar = str[i];
                if (char.IsPunctuation(previousChar) && char.IsLetterOrDigit(followingChar))
                    temp.Append(previousChar + " ");
                else
                    temp.Append(previousChar);
            }
            temp.Append(str[str.Length - 1]);
            return temp;
        }
    }
}
