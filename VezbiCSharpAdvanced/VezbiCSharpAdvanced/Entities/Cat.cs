using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.Entities
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }
        public Cat(string name, string color, int age, bool isLazy) : base(name, color, age)
        {
            IsLazy = isLazy;
        }
        public void Meow()
        {
            Console.WriteLine($"MEOW");
        }
        public override void Print()
        {
            Console.WriteLine($"The cat {Name} has {Color} color and is {Age} years old.");
        }
    }
}
