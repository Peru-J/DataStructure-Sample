using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StringOperation
    {
        public static string ReverseWord(string s="ab cd ef gh")
        {
            StringBuilder output = new StringBuilder();
            for (int i = s.Length-1; i >= 0; i--)
            {
                output.Append(s[i]);

            }
            return output.ToString();
        }


        public static string ReverseWordWithoutReversingIndividual(string s = "ab cd ef gh")
        {
            string[] output = new string[s.Length];
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if(s[i] ==' ')
                {
                    count++;
                    output[count - 1] = sb.ToString();
                    sb.Clear();
                }
                sb.Append(s[i]);               

            }
            count++;
            output[count - 1] = sb.ToString();

            Array.Resize(ref output, count);

            for (int j = output.Length-1; j>=0;j--)
            {
                string a = output[j];
                continue;
            }
            return output.ToString();
        }
    }
}
