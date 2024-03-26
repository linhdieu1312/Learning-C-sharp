using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string s = @"Le:\ Dieu:\ Linh";
            Console.WriteLine(s);
            string s1 = "Le \' Dieu \" Linh \\";
            Console.WriteLine(s1);*/

            /*//chuyen doi 1 gia tri sang kieu du lieu string
            int i = 1234;
            string s1 = i.ToString();
            string s2 = i + "";
            string s3 = Convert.ToString(i);

            Console.WriteLine(s2.GetType().ToString());
            Console.WriteLine(s3.GetType().ToString());
            Console.WriteLine(s1.GetType().ToString());

            //tach chuoi sang ky tu le va cho vao 1 list/mang
            string s4 = "Le Dieu Linh";
            char[] ls = s4.ToCharArray();
            Console.WriteLine(ls.Length);
            Console.WriteLine(ls[0]);
            Console.WriteLine(ls.GetType().ToString());*/

            /*// HAM CopyTo
            string s1 = "12345";
            //khai bao 1 list moi gom 6 phan tu
            char[] ls = new char[6];
            ls[0] = 'a';
            ls[1] = 'b';
            Console.WriteLine(ls);

            s1.CopyTo(0, ls, 0, 3); // s1.CopyTo(a, ls, b, c): copy tu c ky tu tu s1 bat dau tu index s1[a] vao vi tri ls[b]
            Console.WriteLine(ls);
            string s2 = "Le Dieu Linh";
            string chuoi = s1.Insert(3, s2);
            Console.WriteLine(chuoi);*/

            //Split
            string s = "abc1bcd1a b123c145 61bcd";
            string[] ls = s.Split('1');
            Console.WriteLine(ls[0]);
            Console.WriteLine(ls[1]);
            Console.WriteLine(ls[2]);
            foreach (string i in ls) {
                Console.WriteLine(i);
            }

            // Join
            string s1 = string.Join("***", ls);
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}
