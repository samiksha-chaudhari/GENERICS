using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Program");
            Console.WriteLine("Maximum Number is :");
            int output = MaximumNumber.MaximumInteger(50, 60, 70);
            Console.WriteLine(output);

            double doubleoutput = MaximumNumber.MaximumFloat(30.7, 28.47, 98.56);
            Console.WriteLine(doubleoutput);
            
            string stringoutput = MaximumNumber.MaximumString("80","26","69");
            Console.WriteLine(stringoutput);
        }
    }
}
