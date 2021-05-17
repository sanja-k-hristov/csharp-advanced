using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.Entities
{
    public class Bird : Animal
    {
        public bool IsWild { get; set; }
        public Bird(string name, string color, int age, bool isWild) : base(name, color, age)
        {
            IsWild = isWild;
        }
        public void FlySouth()
        {
            if (IsWild)
            {
                Console.WriteLine($"The bird is flying south.");
            }
            else
            {
                Console.WriteLine($"The bird is a domesticated bird.");
            }
            
        }
        public override void Print()
        {
            Console.WriteLine($"The bird {Name} has {Color} color and is {Age} years old.");
        }
    }
}
