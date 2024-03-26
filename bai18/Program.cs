using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>() {1, 3, 5, 7, 9, 2, 3, 4, 6};

            // them phan tu moi vao ls: ls.Add(phan tu)
            ls.Add(100);
            // xoa phan tu x dau tien tim thay trong list: ls.Remove(x)
            // dem so phan tu trong list: ls.Count()
            // xoa tat ca phan tu trong 1 list, khi do con lai 1 list rong. ls.Clear()
            // l1.AddRange(l2): them toan bo l2 vao cuoi cua l1
            // kiem tra phan tu x co trong list ko: ls.Contains(x)
            // ls.GetRange(a, b): lay 1 list con co index tu a den b
            // ls.IndexOf(x): tra ve index cua x neu tim thay, con ko tim thay tra ve -1
            // ls.Insert(index, x): chen x vao vi tri index
            // l1.InsertRange(index i, l2): chen l2 vao bat dau tu index i
            // ls.RemoveAt(x): xoa phan tu co index la x
            // ls.RemoveRange(index i, n phan tu): xoa n phan tu bat dau tu vi tri index i
            // ls.Reverse(): dao nguoc list nay
            // ls.Sort(): sap xep tang dan
            // ls.BinarySearch(x): tim x trong list, dieu kien list phai xep theo thu tu Sort
            // ls.Max(), ls.Min(): tim min max trong list
            foreach (int i in ls)
            {
                Console.Write(i + " | ");
            }
            Console.ReadKey();

        }
    }
}
