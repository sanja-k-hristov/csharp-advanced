using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.Entities
{
    public class Dog : Animal
    {
        public string Race { get; set; }
        public Dog(string name, string color, int age,string race) : base(name, color, age)
        {
            Race = race;
        }
        public void Bark()
        {
            Console.WriteLine($"BARK BARK");
        }
        public override void Print()
        {
            Console.WriteLine($"The dog {Name} has {Color} color and is {Age} years old.");
        }
    }
}
