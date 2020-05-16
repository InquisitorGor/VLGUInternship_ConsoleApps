using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApps
{
    class NinthTask
    {
        private const String PATH = "..\\..\\..\\text.txt";
        private const String PATH2 = "..\\..\\..\\text2.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            Console.WriteLine("Введите преложение");
            String sentence = Console.ReadLine();
            FileStream f = new FileStream(PATH, FileMode.Open);
            BinaryWriter fOut = new BinaryWriter(f);
            char[] chArray = sentence.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!Char.IsDigit(chArray[i])) fOut.Write(chArray[i]);
            }
            fOut.Close();
            Console.WriteLine("Второе задание");
            FileStream fileStream = new FileStream(PATH, FileMode.OpenOrCreate);
            StreamReader sR = new StreamReader(fileStream);
            String str1 = String.Empty;
            int count = 1;
            while ((str1 = sR.ReadLine()) != null && str1 != String.Empty)
            {
                File.AppendAllText(PATH2,str1 + " " + count++ + Environment.NewLine);
            }
            sR.Close();
            fileStream.Close();
        }
    }
}
