using System;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parse(Console.ReadLine());

            if (years == 0)
                Console.WriteLine("Inexperienced");

            else if (years == 1)
                Console.WriteLine("Junior");

            else if (years == 2)
                Console.WriteLine("Mid Level");

            else if (years == 3)
                Console.WriteLine("Advanced");

            else if (years >= 4)
                Console.WriteLine("Senior");

        }
    }
}