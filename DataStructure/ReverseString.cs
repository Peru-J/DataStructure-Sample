using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class ReverseString
    {
        public string ReverseaString(string input)
        {
            string output= string.Empty;
            int j = 0;
            for (int i= input.Length-1; i>= 0; i--){
                output += input[i];
               // j++;
            }
            return output;
        }
    }
}
