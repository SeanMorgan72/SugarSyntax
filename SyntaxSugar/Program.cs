using System;

namespace SyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            var answer = int.Parse(Console.ReadLine());
            var response = (answer < 9) ? $"{answer} is less than nine." : $"{answer} greater than or equal to nine.";

            Console.WriteLine(response);
        }
    }
}
