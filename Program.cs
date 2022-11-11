using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class MaximumNumber
    {

        public static string MaximumStringNum(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)

            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }


    }
}


namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter First Value");
            string firstValue = Console.ReadLine();

            Console.WriteLine("Please Enter Second Value");
            string secondValue = Console.ReadLine();

            Console.WriteLine("Please Enter Third Value");
            string thirdValue = Console.ReadLine();

            string output = MaximumNumber.MaximumStringNum(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maxmimum string value is:");
            Console.WriteLine(output);

        }

    }
}