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
        public void FirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, First_Name))
                Console.WriteLine("First Name Valid");
            else
                Console.WriteLine("Not Valid");
        }
    }
}
