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

    }
}
