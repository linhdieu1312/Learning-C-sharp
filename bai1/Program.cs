using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello");
            Console.WriteLine("Xin chào");
            //Console.ReadLine();
            float diem = 9.5f;
            string chuoi = "Linh";
            Console.WriteLine("Hi {0} {1}", chuoi, diem);
            Console.WriteLine("Hi {0}", chuoi);
            Console.ReadKey();
        }
    }
}
