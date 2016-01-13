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
            int sum = 0;
            int j = 1;
            int k = 1;
            int upperlimit = 4,000,000;
            int evenSum = 0;

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
