using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //  Console.WriteLine(i);
            //}

            int[] ls = { 1, 3, 5, 7, 8, 10, 12 };
            if (n == 2)
            {
                Console.WriteLine("Feb has 28 or 29 days");
            }
            else {
                foreach (int i in ls)
                {
                    if (n == i)
                    {
                        Console.WriteLine("Month {0} has 31 days", n);
                        break;
;                    }
                    else
                    {
                        Console.WriteLine("Month {0} has 30 days", n);
                        break;
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
