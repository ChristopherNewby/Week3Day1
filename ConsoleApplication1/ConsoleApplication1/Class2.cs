using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class WordCountClass
    {
        public static int CountVowels(this string originalString)
        {
            int count = 0;

            foreach (char c in originalString)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }
            count++;

            return count;
        }
    }

    public static class Multiply
    {
        public static int MultiplyByFive(this int number)
        {
            return number * 5;
        }
    }

    public static class TwoPointFiveTimes
    {
        public static double MultiplyByTwoPointFive(this double number)
        {
            return number * 2.5;
        }
    }


    public static class CheckForA
    {
        public static string ACheck(this char nextChar)
        {
            if (nextChar == 'a')
            {
                return "This is an a";
            }
            else
            {
                return "This is not an a";
            }
        }
    }

    public static class BoolExtension
    {
        public static int returnTwo(this bool var)
        {
            if (var == true)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }

    public static class FloatExtension
    {
        public static double multiply(this float number)
        {
            Console.WriteLine("Enter the number to be multiplied");
            string a = Console.ReadLine();

            return number * (Convert.ToDouble(a));
            
        }
    }
}










   