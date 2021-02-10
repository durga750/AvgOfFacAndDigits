using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            int sum = 0;
            int count = 0;
            int avg = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i );
                    count++;
                    sum = sum + i;
                    avg = sum / count;
                  
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine(avg);
        }
    }
}
