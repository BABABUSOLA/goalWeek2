using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n =  "); 
          int n = int.Parse(Console.ReadLine());
          for (int row = 1; row <= n; row++)
          {
              for (int column = 1; column <= row; column++)
              {
                  Console.Write(column);
              }
              Console.WriteLine();
          }
        }
    }
}
