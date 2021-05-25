using System;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parce(Console.ReadLine());

            if (years == 0)
                Console.WriteLine("Inexperienced");

            else if (years == 1)
                Console.WriteLine("Junior");

            else if (years == 3)
                Console.WriteLine("Mid-Level");

            else if (years == 5)
                Console.WriteLine("Senior");

            else (years >= 10);
            Console.WriteLine("Executive");
        }
    }
}