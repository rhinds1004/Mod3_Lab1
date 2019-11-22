using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int result = Sum(20, 40);
           
            Console.WriteLine($"The sum of 20 and 40 is {result}" );

            int result2 = Sum(20, 40, 60);

            Console.WriteLine($"The sum of 20 and 40 is {result2}");
        }


        //Sum() method that takes three integer arguments and sums them
        //The method returns no value which is why we use void
        //We also need to use static in the method signature because Main is static
        //and you cannot call a non-static method from a static method

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;

            return sum;
        }


        //Sum() method that takes two integer arguments and sums them
        //The method returns no value which is why we use void
        //We also need to use static in the method signature because Main is static
        //and you cannot call a non-static method from a static method

        static int Sum(int first, int second)
        {
            int sum = first + second;

            return sum;
        }

        //Sum() method that takes two double arguments and sums them
        //The method returns no value which is why we use void
        //We also need to use static in the method signature because Main is static
        //and you cannot call a non-static method from a static method
        static double Sum(double first, double second)
        {
            return first + second;

           
        }
    }
}
