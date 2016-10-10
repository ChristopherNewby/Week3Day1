using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = "The quick brown fox jumped over the lazy dog";
 
            int wvowels = myString.CountVowels();
            Console.WriteLine(wvowels);

            int number = 5.MultiplyByFive();
            Console.WriteLine(number);

            double newNumber = (1001.05).MultiplyByTwoPointFive();
            Console.WriteLine(newNumber);

            char aletter = 'a';
            Console.WriteLine(aletter.ACheck());

            bool check = true;
            Console.WriteLine(check.returnTwo());

            float anotherNumber = 10.5F;
            Console.WriteLine(anotherNumber.multiply());

            Console.ReadLine();
        }
    }
}
