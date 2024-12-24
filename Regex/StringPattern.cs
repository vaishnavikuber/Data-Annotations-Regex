using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexpression
{
    internal class StringPattern
    {

        public static void PatternMatch(string str)
        {
            string pattern = @"^c*";

            if (Regex.IsMatch(str, pattern))
            {
                Console.WriteLine("Given string matches pattern");

            }
            else
            {
                Console.WriteLine("String does not match pattern");
            }
        }

        public static void PatternMatch2(string str)
        {
            //Regex regex = new Regex(@"a*d");
            //Regex regex = new Regex(@"^My");
            //Regex regex = new Regex(@"work$");
            //Regex regex = new Regex(@"^a?b");
            //Regex regex = new Regex(@"^a+b");
            //Regex regex = new Regex(@"(a|b)[a-z]");
            //Regex regex = new Regex(@"(as)+");
            Regex regex = new Regex(@"[^a-z]");


            Match m = regex.Match(str);
            if (m.Success)
            {
                Console.WriteLine($"Pattern matches : {m.Value}");

            }
            else
            {
                Console.WriteLine("Pattern does not match");
            }
        }


       

       

       

        

        





    }
}
