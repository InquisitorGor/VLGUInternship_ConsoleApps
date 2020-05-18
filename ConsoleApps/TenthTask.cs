using System;
using System.IO;

namespace ConsoleApps
{
    class TenthTask
    {
        static void Main(String[] args)
        {
            //1
            if (!Directory.Exists("C:\\temp"))
            {
                Directory.CreateDirectory("C:\\temp");
            }
            Directory.CreateDirectory("C:\\temp\\K1");
            Directory.CreateDirectory("C:\\temp\\K2");
            //2.a
            StreamWriter sw = new StreamWriter("C:\\temp\\K1\\t1.txt");
            sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            sw.Close();
            //2.b
            sw = new StreamWriter("C:\\temp\\K1\\t2.txt");
            sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            sw.Close();
            //3
            sw = new StreamWriter("C:\\temp\\K2\\t3.txt");
            StreamReader sr = new StreamReader("C:\\temp\\K1\\t1.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sr = new StreamReader("C:\\temp\\K1\\t2.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            //4
            DirectoryInfo [] directoryInf = { new DirectoryInfo("C:\\temp\\K1"), new DirectoryInfo("C:\\temp\\K2")};
            foreach (var item in directoryInf)
            {
                FileInfo[] fileInf = item.GetFiles();
                foreach (FileInfo fi in fileInf)
                {
                    Console.WriteLine("Full Path: " + fi.FullName.ToString() + " Attributes: " + fi.Attributes.ToString() + " File extension: " + fi.Extension.ToString());
                }
            }
            Console.WriteLine("--------------------");
            //5
            File.Move("C:\\temp\\K1\\t2.txt", "C:\\temp\\K2\\t2.txt");
            //6
            File.Copy("C:\\temp\\K1\\t1.txt", "C:\\temp\\K2\\t1.txt");
            //7
            Directory.Move("C:\\temp\\K2", "C:\\temp\\ALL");
            Directory.Delete("C:\\temp\\K1", true);
            //8
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\temp\\ALL");
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (FileInfo fi in fileInfo)
            {
                Console.WriteLine("Full Path: " + fi.FullName.ToString() + " Attributes: " + fi.Attributes.ToString() + " File extension: " + fi.Extension.ToString());
            }
        }
    }
}
