using System;

namespace FlagAttributeExample
{
    enum Suits
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 4,
        Hearts = 8
    }

    [Flags]
    enum SuitsFlags
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 4,
        Hearts = 8
    }

    class Program
    {
        static void Main(string[] args)
        {
            var str1 = (Suits.Spades | Suits.Diamonds).ToString();
            Console.WriteLine(str1);    // "5"
            var str2 = (SuitsFlags.Spades | SuitsFlags.Diamonds).ToString();
            Console.WriteLine(str2);    // "Spades, Diamonds"
            Console.ReadKey();
        }
    }
}
