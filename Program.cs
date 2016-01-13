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
            uint sum = 0;
            uint j = 1;
            uint k = 1;
            uint upperlimit =4000000000;
            uint evenSum = 0;

            while(j<=upperlimit)
            {
                if (j % 2 == 0)  {
                    Console.WriteLine(j + " " + "*");
                    evenSum += j;
                }  else {
                        Console.WriteLine(j);
                }
                sum = j + k;
                j = k;
                k = sum;
            }

            Console.WriteLine("Even sums = " + evenSum);
            Console.ReadKey();

        }
    }
}
