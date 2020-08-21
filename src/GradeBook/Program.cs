using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 12.5;

            double result = x + y;

            Console.WriteLine(result);

            if (args.Length > 0) 
            {
                Console.WriteLine("Hello " + args[0] + "!"); // concatenation
                Console.WriteLine($"Hello {args[0]}!"); // interpolation
            }
            else 
            {
                Console.WriteLine("No Argument Passed!");
            }            
        }
    }
}
