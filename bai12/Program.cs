using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(1,100); // lay so tu 0 -> 99; giong vs python
            Console.WriteLine("So random may sinh ra la " + n);
            double m = rnd.NextDouble(); // lay cac so thuc trong khoang 0-1
            Console.WriteLine("So random double " + m);
            Console.ReadKey();
        }
    }
}
