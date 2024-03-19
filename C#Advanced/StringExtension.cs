using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal static class StringExtension
    {
        
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ","");
        }

        public static string ReverceEx(this string value)
        {
            var chararray = value.ToCharArray();
            Array.Reverse(chararray);
            return new string (chararray);
        }
    }
}
