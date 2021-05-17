using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.Generic
{
    public static class Generics
    {
        public static void PrintList<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
