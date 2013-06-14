using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenlyDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int temp = 0;
            int sum = 0;

            //What is the smallest positive number that is
            //evenly divisible by all of the numbers from 1 to 20?
            //Console.WriteLine(smallestMultiple());

            //Largest Prime factor of 600851475143
            Console.WriteLine("What is the largest prime factor of the number 600851475143? : ");
            Console.WriteLine(largestPrime());

            //By considering the terms in the Fibonacci sequence whose 
            //values do not exceed four million, find the sum of the even-valued terms.
            while (temp < 4000000)
            {
                temp = fib(i);
                Console.WriteLine(temp + "\n");
                if (temp % 2 == 0 && temp < 4000000)
                {
                    sum += temp;
                }
                i++;
            }
            Console.WriteLine(sum);

            //Find the sum of all the multiples of 3 or 5 below 1000.
            i = 0;
            int mult3 = 0;
            int mult5 = 0;
            while (i < 1000)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " ");
                    mult3 += i;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " ");
                    mult5 += i;
                }
                i++;
            }
            Console.WriteLine("Sum of Multiples of 3: " + mult3 + "\n" + "Sum of multiples of 5: " + mult5 + "\n");
            Console.WriteLine("Sum of both sums: " + (mult3 + mult5) + "\n");
        }
        static int smallestMultiple()
        {
            int max = 0;
            int total = 0;
            for (int i = 0; i < 30000; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    if (i % j == 0)
                    {
                        total++;
                    }

                }
                if (total == 20)
                {
                    return i;
                }
                total = 0;
                max = i;
            }
            return max;
        }
        static long largestPrime()
        {
                long i = 0, sqi = 0;
                long value = 0, large = 600851475143;
                long max = 0;

                i   = 2;
                sqi = 4; //i*i
                for(value = large; sqi <= value ; sqi +=  2 * i++ + 1){
                while(value % i == 0){
                   value /= (max=i);
                }
                }

                if(value != 1 && value != large){
                     max = value;
                 }
                if(max == 0){
                     max = large;
                }

                return max;
        }
        public static int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (fib(n - 2) + fib(n - 1));
            }
        }
    }
}
