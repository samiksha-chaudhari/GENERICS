using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)// main method
        {
            Console.WriteLine("Welcome To Generics Program");
            /*Console.WriteLine("Maximum Number is :");
              int output = MaximumNumber.MaximumInteger(50, 60, 70); // calling maximumInterger()
              Console.WriteLine(output);

              double doubleoutput = MaximumNumber.MaximumFloat(30.7, 28.47, 98.56);// calling maximumFloat()
              Console.WriteLine(doubleoutput);

              string stringoutput = MaximumNumber.MaximumString("80","26","69");// calling maximumString()
              Console.WriteLine(stringoutput);
            */

            int[] intArray = { 112, 344, 432, 634, 488 }; //creating int array
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 120.2, 34.8, 46.3, 568.5, 686.78 }; //creating double array
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "orange", "banana", "grapes" }; //creating string array
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
