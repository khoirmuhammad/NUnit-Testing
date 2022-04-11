using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class StringFunction : IStringFunction
    {
        public string ReverseString(string word)
        {
            char[] stringArray = word.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
    }
}
