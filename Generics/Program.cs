using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Program");
            Console.WriteLine("Maximum Number is :");
            int output = MaximumNumber.MaximumIntegerNumber(50, 60, 70);
            Console.WriteLine(output);
        }
    }
}
