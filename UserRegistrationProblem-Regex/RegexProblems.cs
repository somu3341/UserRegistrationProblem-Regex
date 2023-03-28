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
        public const string EMAIL = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})(\.[a-zA-Z]{2,5})?$";
        public const string MOBILE = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        public const string PASSWORD_1 = "^[a-zA-Z0-9]{8}$";
        public const string PASSWORD_2 = "^[a-zA-Z0-9]{8}$";
        public const string PASSWORD_3 = "^[a-zA-Z0-9]{8}$";
        public const string PASSWORD_4 = "^[A-Z]{1,}[a-z]{5,}[!+@+#+%+&+*+~+$]{1}[0-9]{1,}$";
        string[] allmails = { "abc@yahoo.com", "abc-100@yahoo.com", 
            "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", 
            " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", 
            "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com",
            "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com", 
            "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
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
        public void Password1(string password1)
        {
            if (Regex.IsMatch(password1, PASSWORD_1))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Password2(string password2)
        {
            if (Regex.IsMatch(password2, PASSWORD_2))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Password3(string password3)
        {
            if (Regex.IsMatch(password3, PASSWORD_3))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Password4(string password4)
        {
            if (Regex.IsMatch(password4, PASSWORD_4))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void AllEmails()
        {
            for (int i = 0; i < allmails.Length; i++)
            {
                if (Regex.IsMatch(allmails[i], EMAIL))
                    Console.WriteLine(allmails[i] +" ----> Valid");
                else
                    Console.WriteLine(allmails[i] + " -----> Invalid");
            }
        }
    }
}
