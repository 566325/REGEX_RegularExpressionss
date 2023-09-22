using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class PatternMatching
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter the First name");
            string FName = Console.ReadLine();
            string namePattern = "[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexobj =new Regex (namePattern);
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
        public static void ValidEmail()
        {
            Console.WriteLine("Enter the Last name");
            string Email = Console.ReadLine();
            string namePattern = "[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            Regex regexobj = new Regex(namePattern);
            if (regexobj.IsMatch(Email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email is valid");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Email");
                Console.ReadLine();
            }
            Console.WriteLine(Email);
        }
    }
}
