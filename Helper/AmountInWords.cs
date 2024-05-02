using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePrintingApp.Helper
{
    internal class AmountInWords
    {
        public static string NumberToWords(double number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            // Handle the whole part of the number
            int intPart = (int)number;

            // Handle fractional part
            int decimalPart = (int)((number - intPart) * 100); // Assumes two decimal places
            if (decimalPart > 0 && decimalPart < 100)
            {
                words = NumberToWords(intPart) + " and " + NumberToWords(decimalPart) + " cents";
                return words;
            }

            if ((intPart / 1000000) > 0)
            {
                words += NumberToWords(intPart / 1000000) + " million ";
                intPart %= 1000000;
            }

            if ((intPart / 1000) > 0)
            {
                words += NumberToWords(intPart / 1000) + " thousand ";
                intPart %= 1000;
            }

            if ((intPart / 100) > 0)
            {
                words += NumberToWords(intPart / 100) + " hundred ";
                intPart %= 100;
            }

            if (intPart > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (intPart < 20)
                    words += unitsMap[intPart];
                else
                {
                    words += tensMap[intPart / 10];
                    if ((intPart % 10) > 0)
                        words += "-" + unitsMap[intPart % 10];
                }
            }

            return words;
        }

    }
}
