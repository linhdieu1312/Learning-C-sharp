using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //Console.WriteLine("Nhap vao a: ");
            //a = int.Parse(Console.ReadLine());

            //string x = (a % 2 == 0)?"Even":"Odd";
            float diem;
            Console.WriteLine("Nhap vao diem so");
            diem = float.Parse(Console.ReadLine());
            string x = (diem > 8.5f) ? "Gioi" : ((diem < 8f && diem >= 6.5f)? "Kha":((diem < 6.5f && diem >= 5f )?"Trung Binh":"Yeu"));
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
