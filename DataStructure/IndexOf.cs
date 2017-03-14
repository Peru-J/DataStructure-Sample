using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class IndexOf
    {
        public static void IndexOfString()
        {
            
            Console.WriteLine(IndexOfStrings());
            Console.ReadLine();
        }
        private static int IndexOfStrings(string str= "abbbcdeab", string substr = "ab")
        {
            bool match;
            int index = -1;

            for (int i = 0; i < str.Length-substr.Length+1; ++i)
            {
                match = true;
                for (int j = 0; j < substr.Length; ++j)
                {
                    if (str[i + j] != substr[j])
                    {
                        match = false;
                    }
                    else
                    {
                        index = i;
                    }
                }
               // if (match) return i;
            }

            return index;
        }
    }
}
