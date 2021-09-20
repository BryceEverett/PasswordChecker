using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordChecker { }
namespace tools_pswrd
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            int score = 0;
            Console.WriteLine("Test your Password!");
            Console.Write("Password: ");
            string password = Console.ReadLine();
            int len = password.Length;
            if (len >= minLength)
            {
                score++;
            }
            else
            {
                Console.WriteLine("Your Password Length is not good");
            }
            if (Tools.Contains("password", "lowercase"))
            {
                score++;
            }
            else
            {
                Console.WriteLine("You lack lowercase");
            }
            if (Tools.Contains("password", "uppercase"))
            {
                score++;
            }
            else
            {
                Console.WriteLine("You lack uppercase");
            }
            if (Tools.Contains("password", "digits"))
            {
                score++;
            }
            else
            {
                Console.WriteLine("You lack numbers");
            }
            if (Tools.Contains("password", "specialChars"))
            {
                score++;
            }
            else
            {
                Console.WriteLine("You lack special characters");
            }
            if (password == "1234" || password == "password" || password == "Password" || password == "PASSWORD")
            {
                Console.WriteLine("That is the ultimate taboo of passwords");
                score = 0;
            }
            switch (score)
            {
                case 5:
                    Console.WriteLine("Your password is a god amongst passwords");
                    break;
                case 4:
                    Console.WriteLine("Your password has to be using steroids or something");
                    break;
                case 3:
                    Console.WriteLine("Your password is quite beefed");
                    break;
                case 2:
                    Console.WriteLine("Your password is Average, how lame.");
                    break;
                case 1:
                    Console.WriteLine("Your password is weak beef it up man.");
                    break;
                default:
                    Console.WriteLine("Your password is absolute garbage.");
                    break;
            }
            Console.WriteLine("It has a score of " + score);
            Console.ReadKey();
        }
    }
}
