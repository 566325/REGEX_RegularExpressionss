using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class LastName
    {
        public static void ValidLastName()
        {
            Console.WriteLine("Enter the Last name");
            string LName = Console.ReadLine();
            string namePattern = "[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexobj = new Regex(namePattern);
            if (regexobj.IsMatch(LName))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Last Name is valid");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Last name");
                Console.ReadLine();
            }
            Console.WriteLine(LName);
        }
    }
}
