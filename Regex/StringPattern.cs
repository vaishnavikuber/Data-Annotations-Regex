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
            Regex regex = new Regex(@"a*d");
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


        public static void PatternMatch3(string str)
        {
            Regex regex = new Regex(@"^My");
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

        public static void PatternMatch4(string str)
        {
            Regex regex = new Regex(@"work$");
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
