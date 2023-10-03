using System.Xml.Linq;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile_Formate.Check_Mobile_Formate();


            //Console.WriteLine("Regex Demo");
            //Console.WriteLine("Please select Options : \n" +
            //    "1.To Check For first Name  \n" +
            //    "1.To Check For first Name \n" +
            //    "3.To Check For Valid Email \n");
            //int option = Convert.ToInt32(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        PatternMatching.ValidFirstName();
            //        break;
            //    case 2:
            //        PatternMatching.ValidLastName();
            //        break;
            //    case 3:
            //        PatternMatching.ValidEmail();
            //        break;
            //    default:
            //        Console.WriteLine("Enter Valid Input");
            //        break;

            //}
            //ValidAndInvaliMails.CheckValidEmail();
            //ValidFirstName.ValidFName();
            LastName.ValidLastName();



        }
    }
}