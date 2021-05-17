using System;
using System.Collections.Generic;
using System.Text;
using VezbiCSharpAdvanced.Entities;

namespace VezbiCSharpAdvanced.Generic
{
    public class GenericAnimalcs<T> where T : Animal
    {
        public static void PrintAnimals(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
