using System;
using System.Collections.Generic;
using System.Text;

namespace VezbiCSharpAdvanced.Entities
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 175)
                _age = value;

            }
        }
        public Animal(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        public abstract void Print();
    }
}
