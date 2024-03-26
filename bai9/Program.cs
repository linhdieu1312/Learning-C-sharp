using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Nhap x: ");
            x = int.Parse(Console.ReadLine());

            while (x < 0 || x >= 100)
            { 
                Console.WriteLine("Nhap lai 0 < x < 100");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
