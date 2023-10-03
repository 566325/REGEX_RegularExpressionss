using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class ValidFirstName
    {
        public static void ValidFName()
        {
            Console.WriteLine("Enter the First name");
            string FName = Console.ReadLine();
            string namePattern = "[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexobj = new Regex(namePattern);
            if (regexobj.IsMatch(FName))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is valid");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid First name");
                Console.ReadLine();
            }
            Console.WriteLine(FName);
        }
    }
}
