using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StringToNumber
    {
        public static int convertToInt(string s="-23")
        {   
            int output = 0;
            bool isNegative = false;
            if (s[0] == '-')
                isNegative = true;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] >'0' || s[i] < '9')
                output = output  * 10 + (s[i] - '0'); 
            }
            if (isNegative)
                output =  output * -1;
            return output;
        }

        public static float convertToFloat(string s = "-23.2")
        {
            int digitsAfterdecimal = 0;
            float output;           
            if(s.Contains('.'))
            {
                digitsAfterdecimal = s.Split('.')[1].Length;
            }
            s = s.Replace(".", "");

            output = convertToInt(s) / (float)Math.Pow(10, digitsAfterdecimal);
            return output;

        }

        public static String ConvertToUpperCase(String input)
        {            
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                //To Lower case
                //if (input[i] >= 'A' && input[i] <= 'Z')
                //{
                //    output += (char)(input[i] - 'A' + 'a');
                //}

                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }

                else
                    output += input[i];
            }
            return output;
        }

        public string IntToString(int a)
        {
            var chars = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var str = string.Empty;
            if (a == 0)
            {
                str = chars[0];
            }
            else if (a == int.MinValue)
            {
                str = "-2147483648";
            }
            else
            {
                bool isNegative = (a < 0);
                if (isNegative)
                {
                    a = -a;
                }

                while (a > 0)
                {
                    str = chars[a % 10] + str;
                    a /= 10;
                }

                if (isNegative)
                {
                    str = "-" + str;
                }
            }

            return str;
        }
    }
}
