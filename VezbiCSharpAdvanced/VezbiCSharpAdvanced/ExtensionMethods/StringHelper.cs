using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.ExtensionMethods
{
    public static class StringHelper
    {
        public static string GetFirstLetter(this string str)
        {
            string first = str.Substring(0, 1);
            return first;
        }
        public static string LastLetter(this string str)
        {
            string last = str.Substring(str.Length -1);
            return last;
        }
    }
}
