using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Program");
            /*Console.WriteLine("Maximum Number is :");
              int output = MaximumNumber.MaximumInteger(50, 60, 70);
              Console.WriteLine(output);

              double doubleoutput = MaximumNumber.MaximumFloat(30.7, 28.47, 98.56);
              Console.WriteLine(doubleoutput);

              string stringoutput = MaximumNumber.MaximumString("80","26","69");
              Console.WriteLine(stringoutput);
            */

            int[] intArray = { 112, 344, 432, 634, 488 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 120.2, 34.8, 46.3, 568.5, 686.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "orange", "banana", "grapes" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
