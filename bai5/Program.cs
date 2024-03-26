using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = x++ - ++y + 1;

            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
