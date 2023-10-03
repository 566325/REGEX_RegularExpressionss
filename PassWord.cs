using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class PassWord
    {
        public static void CheckPassWord()
        {
            Console.WriteLine("Enter the PassWord");
            string PassWord = Console.ReadLine();
            string namePattern = "^(?=.*[A-Z])(?=.*[a-z]{8,}).*$";
            Regex regexobj = new Regex(namePattern);
            if (regexobj.IsMatch(PassWord))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PassWord is valid");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid password");
                Console.ReadLine();
            }
            Console.WriteLine(PassWord);
        }
    }
}
