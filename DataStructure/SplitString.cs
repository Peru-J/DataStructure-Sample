using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SplitString
    {
        public string[] SplitStringWithDelimeter(string s, char c)
        {
            List<string> output = new List<string>();
            StringBuilder temp = new StringBuilder();
            if (s == null)
            {
                return new string[] {""};
            }
            for (int i = 0; i < s.Length; i++)
            {                
                if (s[i] == c)
                {
                    output.Add(temp.ToString());
                    temp.Clear();
                }
                if (s[i] != c)
                {
                    temp.Append(s[i]);
                }
            }
            output.Add(temp.ToString());
            return output.ToArray();
        }

        public static string[] split(string txt, char[] delim)
        {
            char[] text = txt.ToCharArray();
            string[] result = new string[txt.Length];
            int count = 0;
            int i = 0;
            StringBuilder buff = new StringBuilder();
            while (i < text.Length)
            {
                bool found = false;
                foreach (char del in delim)
                {
                    if (del == txt[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    count++;
                    result[count - 1] = buff.ToString();
                    buff = new StringBuilder();
                }
                else
                {
                    buff.Append(txt[i]);
                }

                i++;
            }

            if (buff.Length != 0)
            {
                count++;
                result[count - 1] = buff.ToString();
                Array.Resize(ref result, count);
            }
            Array.Resize(ref result, count);
            return (result);
        }
    }
}
