using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApps
{
    class EightTask {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите строку");
            String st = Console.ReadLine();
            String pattern = @"((https?|ftp)\:\/\/)?([a-z0-9]{1})((\.[a-z0-9-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)";
            Regex newReg = new Regex(pattern);
            MatchCollection matches = newReg.Matches(st);
            foreach (Match mat in matches)
            {
                Console.WriteLine("Значение найденного объекта {0}", mat.Value);
            }
            Console.WriteLine("Число найденных совпадений {0}", matches.Count);

            Console.ReadLine();
        }
    }
}

