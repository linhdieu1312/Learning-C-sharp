
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "TA = 78 KH = 83 Math = 68 Lsu = 65 Van = 100";
            // tinh tong cac so trong chuoi tren
            int total = 0;
            int dem = 0;

            string[] ls = s1.Split(' ');
            foreach (string i in ls) {
                /*foreach (char c in i)
                {
                    if (char.IsDigit(c)) {
                        total += int.Parse(i);
                        break;
                    }
                }*/
                if (char.IsDigit(i[0]))
                {
                    total += int.Parse(i);
                    dem++;
                }
            }
            Console.WriteLine("Tong diem la " + total);
            // tinh diem trung binh cong
            float avg = (float)total / dem;
            Console.WriteLine("Diem trung binh la " + avg);
            Console.ReadKey();
        }
    }
}
