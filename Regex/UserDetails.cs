using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexpression
{
    internal class UserDetails
    {

        public string Name { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }

        public static bool IsNameValid(string name)
        {
            string pattern = @"^[A-Z][a-z]{2,35}$";

            return Regex.IsMatch(name, pattern);
        }

        public static bool IsAgeValid(string age)
        {
            string pattern = @"^[1-9]{2}$";
            
            int validAge= int.Parse(age);
            if(validAge >=18 && validAge <= 60)
            {
                return Regex.IsMatch(age, pattern);
            } 
            
            return false;

           
        }

        public static bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-z0-9._#$%&]+@[a-zA-z0-9.-]+\.[a-z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        public static bool IsPhoneValid(string phone)
        {
            string pattern = @"^\d{10}$";

            return Regex.IsMatch(phone, pattern);

        }

        public static bool IsZipCodeValid(string zip)
        {
            string pattern = @"^\d{5,6}";

            return Regex.IsMatch(zip, pattern);
        }

        public static void UserInput()
        {
            Console.WriteLine("Enter your details");
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter ZipCode: ");
            string zipcode = Console.ReadLine();
            UserDetails user = new UserDetails
            {
                Name = name,
                Age = age,
                Email = email,
                Phone = phone,
                ZipCode = zipcode
            };

            bool IsValidName=IsNameValid(name);
            bool IsValidAge=IsAgeValid(age);
            bool IsValidEmail=IsEmailValid(email);
            bool IsValidPhone=IsPhoneValid(phone);
            bool IsValidZip= IsZipCodeValid(zipcode);

            if (IsValidName && IsValidAge && IsValidEmail && IsValidPhone && IsValidZip)
            {
                Console.WriteLine("Entered User Data is valid");
            } 
            else
            {
                if (!IsValidName)
                {
                    Console.WriteLine("First letter of name should be Capital");
                }
                if (!IsValidAge)
                {
                    Console.WriteLine("Age should be between 18 and 60");
                }
                if (!IsValidEmail)
                {
                    Console.WriteLine("Email pattern does not match");

                }
                if (!IsValidPhone)
                {
                    Console.WriteLine("Phone number should have 10 numbers");
                }
                if (IsValidZip) 
                {
                    Console.WriteLine("Zip Code should have 5 or 6 numbers");
                }
            }
        }
    }
}
