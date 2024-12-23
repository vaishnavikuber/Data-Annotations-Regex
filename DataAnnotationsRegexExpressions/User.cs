using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAnnotationsRegexExpressions
{
    internal class User
    {
        [Required(ErrorMessage ="Field name is Required")]
        [StringLength( 35 , MinimumLength =3, ErrorMessage =" The string length should be between 2 and 35")]
        public string Name { get; set; }

        [Range(18,85,ErrorMessage ="Age should be between 18 and 85")]
        public int Age {  get; set; }

        [EmailAddress(ErrorMessage ="Email is not valid")]
        public string Email {  get; set; }

        [RegularExpression("^[0-9]{10}",ErrorMessage ="Phone number pattern does not match")]
        public long Phone {  get; set; }

        [RegularExpression("^[0-9]{5,6}",ErrorMessage ="ZipCode should have 5 to 6 numbers")]
        public int ZipCode {  get; set; }

        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [Compare("Password",ErrorMessage ="Password and ConfirmPassword does not match")]
        public string ConfirmPassword {  get; set; }

        public static User UserInput()
        {
            Console.WriteLine("Enter your details");
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            long phone = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter ZipCode: ");
            int zipcode =int.Parse( Console.ReadLine());

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Confirm Password: ");
            string confirmPassword = Console.ReadLine();

            User user = new User
            {
                Name = name,
                Age = age,
                Email = email,
                Phone = phone,
                ZipCode = zipcode,
                Password = password,
                ConfirmPassword = confirmPassword
                
            };
            return user;

        }
        public static void ValidateDetails()
        {
            User user = UserInput();

            var Context= new ValidationContext(user);
            var ErrorResults = new List<ValidationResult>();
            bool IsValid=Validator.TryValidateObject(user, Context,ErrorResults,true);

            if (IsValid) 
            {
                Console.WriteLine("User details are valid");
                Console.WriteLine($"Name: {user.Name}\n  Email: {user.Email}\n Age: {user.Age}\n Phone: {user.Phone}\n ZipCode: {user.ZipCode}");
            }
            else
            {
                Console.WriteLine("Details are invalid");
                foreach(ValidationResult error in ErrorResults)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

        }
        

    }
}
