using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorsInInnerMostLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /*Console.Write("Please enter the positive integer, n = ");
            string numberAsString = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            // calculate n! = 1*2*....*n
            int factorial = n;
           do
            {
                factorial *= n;
                n--;
            }
            while( n > 0) ;
            Console.WriteLine("n! = " + factorial);
             */
            //A simple loop to calculate n!
            
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            for (int i = 1; i <= n; i++)
			{
			 factorial *= i;
			}
            Console.WriteLine("factorial = {0}", factorial);
        }
    }
}
