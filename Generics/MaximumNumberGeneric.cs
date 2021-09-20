using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
 /// <summary>
 /// creating method to find maximum 
 /// </summary>
 /// <typeparam name="T"></typeparam>
    public class GenericMaximum<T> 

    {
        public T[] value;
        /// <summary>
        /// this method is created for initializing the construtor of instance variable
        /// </summary>
        /// <param name="value"></param>
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }

        /// <summary>
        /// this mmethod is created for sorting the values
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;

        }

        /// <summary>
        /// this method is created for finding max for given type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[sorted_values.Length - 1];
        }

        /// <summary>
        /// this method is created for calling maxvalue()
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        /// <summary>
        /// to print max value
        /// </summary>
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
