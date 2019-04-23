using System;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Text");
            Acronym acronym = new Acronym();
            acronym.TextToAcr();
            Console.ReadLine();
        }
    }
}
