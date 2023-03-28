using System;
using UserRegistrationProblem_Regex;

namespace Regex_UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nchoose option to Perform \n1.First Name \n2.Last Name \n3.Email \n4.Mobile Number " +
                    "\n5.Password(Rule-1) \n6.Password(Rule-2) \n7.Password(Rule-3) \n8.Password(Rule-4) \n9.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                RegexProblems regular = new RegexProblems();
                switch (option)
                {
                    case 1:
                        regular.FirstName("Soma");
                        break; 
                        case 2:
                        regular.LastName("Shekar");
                        break;
                    case 3:
                        regular.Email("abc.xyz@bl.co.in");
                        break;
                        case 4:
                        regular.Mobile("919919819801");
                        break;
                        case 5:
                        regular.Password1("Somu9980");
                        break;
                        case 6:
                        regular.Password2("soMu99S0");
                        break;
                    case 7:
                        regular.Password3("S023Mae3");
                        break;
                    case 8:
                        regular.Password4("Sabcsd@5");
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}