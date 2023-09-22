using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class ValidAndInvaliMails
    {
        public static void CheckValidEmail()
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
