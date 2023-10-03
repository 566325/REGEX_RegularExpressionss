using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class Mobile_Formate
    {
       public  static void Check_Mobile_Formate()
        {
            Console.WriteLine("Enter Valid Mobile Number");
            string Mobile = Console.ReadLine();
            string namePattern = "^[0-9]{1,4}\\s[0-9]{10,12}$";
            Regex regexobj = new Regex(namePattern);
            if (regexobj.IsMatch(Mobile))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mobile Number is valid");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Mobile Number");
                Console.ReadLine();
            }
            Console.WriteLine(Mobile);
        }
    }
}
