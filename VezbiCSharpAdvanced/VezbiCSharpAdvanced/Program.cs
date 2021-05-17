using System;
using System.Collections.Generic;
using System.Linq;
using VezbiCSharpAdvanced.Entities;

namespace VezbiCSharpAdvanced
{
    public class Program
    {
        public delegate bool StringDelegate(string wordOne, string wordTwo);
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Leon","black",4,"labrador"),
                new Dog("Sarko", "white", 3, "retriver"),
                new Dog("Roki","brown",5,"dzukela"),
            };
            List<Cat> cats = new List<Cat>()
            {
                new Cat("Lili","gray",2,true),
                new Cat("Boka","white",3,false),
                new Cat("Sily","brown",4,true),
            };
            List<Bird> birds = new List<Bird>()
            {
                new Bird("Dzivdziv","green",1,false),
                new Bird("Riki","yellow",2,true),
                new Bird("Sula","gray",1,true),
            };

            List<string> particularRace = dogs.Where(x => x.Race == "labrador").ToList();
            Cat lastLazyCat = cats.LastOrDefault(x => x.IsLazy == true);
            List<string> allWildBird = birds.All(x => x.IsWild == true).Where(x => x.Age > 3).OrderedBy(x => x.Name).ToList();
            //DELEGATE

            Func<string, string, bool> stringLength = (wordOne, wordTwo) => wordOne.Length > wordTwo.Length;
            Func<string, string, bool> startSameCharacter = (wordOne, wordTwo) => wordOne[0] == wordTwo[0];
            Func<string, string, bool> endSameCharacter = (wordOne, wordTwo) => wordOne[^1] == wordTwo[^1];

            StringDelegate delegateStringLength = new StringDelegate(stringLength);
            StringDelegate delegateStartSameCharacter = new StringDelegate(startSameCharacter);
            StringDelegate delegateEndSameCharacter = new StringDelegate(endSameCharacter);


            StringMagic("Sanja","Jane", delegateStringLength);
            StringMagic("Sanja", "Jane", delegateStartSameCharacter);
            StringMagic("Sanja", "Jane", delegateEndSameCharacter);

            Console.ReadLine();

        }
        public static bool StringMagic(string wordOne, string wordTwo, StringDelegate comparation)
        {
            Console.WriteLine($"{wordOne} {wordTwo}");
            Console.WriteLine(comparation(wordOne, wordTwo));
            return comparation(wordOne, wordTwo);
        }
    }
}
