using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularRomanCalculator.Models
{
    public class RomanCalHelper
    {
        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
        public  String addRoman(String num1,String num2)
        {
            string ans = "";
            try
            {
                ans = intToRoman(romanToInt(num1) + romanToInt(num2));
            }
            catch
            {
                ans = "Error:Range Exceeded, Final Result should be <= MMMCMXCIX(3999)";
            }
            return ans;
        }
        public  String intToRoman(int num)
        {
            String ans = "";
            // storing roman values of digits from 0-9
            // when placed at different places
            String[] m = { "", "M", "MM", "MMM" };
            String[] c = { "",  "C",  "CC",  "CCC",  "CD",
                       "D", "DC", "DCC", "DCCC", "CM" };
            String[] x = { "",  "X",  "XX",  "XXX",  "XL",
                       "L", "LX", "LXX", "LXXX", "XC" };
            String[] i = { "",  "I",  "II",  "III",  "IV",
                       "V", "VI", "VII", "VIII", "IX" };
            try
            {
                // Converting to roman
                String thousands = m[num / 1000];
                String hundereds = c[(num % 1000) / 100];
                String tens = x[(num % 100) / 10];
                String ones = i[num % 10];
           
             ans = thousands + hundereds + tens + ones;
            }
            catch(System.IndexOutOfRangeException e)
            {
               
                throw;
            }
          
            return ans;
        }
        public  int romanToInt(String roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                    number -= RomanMap[roman[i]];
                }
                else
                {
                    number += RomanMap[roman[i]];
                }
            }
            return number;

        }
    }
}
