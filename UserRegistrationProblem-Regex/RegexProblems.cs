using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem_Regex
{
    public class RegexProblems
    {
        public const string First_Name = "^[A-Z]{1}[a-z]{3}$";
        public const string Last_Name = "^[A-Z]{1}[a-z]{5}$";
        public const string EMAIL = "^[0-9a-zA-Z]+[.+_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3]([.][a-zA-Z]{2,3}){0,1}$";
        public const string MOBILE = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        public const string PASSWORD_1 = "^[a-zA-Z0-9]{8}";
        public void FirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, First_Name))
                Console.WriteLine("First Name Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void LastName(string lastname)
        {
            if (Regex.IsMatch(lastname, Last_Name))
                Console.WriteLine("Last Name Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Email(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
                Console.WriteLine("Email is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Mobile(string mobile)
        {
            if (Regex.IsMatch(mobile, MOBILE))
                Console.WriteLine("Mobile Number is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Passeord1(string password1)
        {
            if (Regex.IsMatch(password1, PASSWORD_1))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
    }
}
