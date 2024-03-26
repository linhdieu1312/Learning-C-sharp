using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 5;
            int i3 = -3;
            float d1 = 2.0f;
            float d2 = 5.0f;
            float d3 = -0.5f;

            int r1 = i1 + (i2 * i3);
            int r2 = i1 * (i2 + i3);
            float r3 = (float)i1 / (i2 + i3);
            float r4 = (float)i1 / i2 + i3;

            float r5 = d1 / (d2 - d3);


            Console.WriteLine("{0} + ({1} * {2}) = {3}", i1, i2, i3, r1);
            Console.WriteLine("{0} * ({1} + {2}) = {3}", i1, i2, i3, r2);
            Console.WriteLine("{0} / ({1} + {2}) = {3}", i1, i2, i3, r3);
            Console.WriteLine("{0} / {1} + {2} = {3}", i1, i2, i3, r4);
            Console.WriteLine("{0} / ({1} - {2}) = {3}", d1, d2, d3, r5);

            Console.WriteLine(i1 +" / " + i2 + " + "  +i3 + " = "+ r4);

            Console.ReadKey();
        }
    }
}
