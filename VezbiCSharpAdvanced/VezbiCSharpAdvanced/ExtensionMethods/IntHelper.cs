using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.ExtensionMethods
{
    public static class IntHelper
    {
        public static bool IsEven(this int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
