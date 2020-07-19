using System;

namespace Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Find the factors of a number
            string bottle = " bottles of beer on the wall";
            string take = "Take one down, pass it around";
            string end = " no more bottles of beer on the wall";

            for (int i = 100; i >= 1; i--)
            {
                if (i > 1)
                {
                    Console.WriteLine($"{i}{bottle}, {i}{bottle.Replace(" on the wall", "")}");
                    Console.WriteLine($"{take}, {i-1}{bottle}");
                }
                else
                {
                    Console.WriteLine($"{i}{bottle.Replace("es","e")}, {i} bottle of beer");
                    Console.WriteLine($"{take}{end}");
                }
                Console.WriteLine("__");
            }






        }
    }
}
