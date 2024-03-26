using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao dict
            Dictionary <int, string> dict = new Dictionary<int, string>();
            // khoi tao va gan gia tri
            Dictionary<int, string> dict2 = new Dictionary<int, string>() { { 1, "Linh" }, { 2, "Dieu" } };
            // them phan tu vao dict: dict.Add(key, value)
            dict2.Add(3, "Le");
            dict2.Add(4, "Nhung");

            // duyet va hien thi 1 dict
            foreach(KeyValuePair<int, string> kvp in dict2)
            {
                // ket qua la 1 cap key-value
                Console.WriteLine(kvp);
                // ket qua chi cho ra key hoac value
                Console.WriteLine("Key: " +kvp.Key + " || Value: " + kvp.Value);
            }
            // kiem tra key co ton tai trong dict k: dict.ContainsKey(x) -> True || False
            Console.WriteLine("Key = 3 co ton tai trong dict k: "+ dict2.ContainsKey(3));
            // kiem tra value co ton tai trong dict k: dict.ContainsValue(x) -> True || False

            // lay value tu key: dict[key]
            // xoa phan tu theo key. dict.Remove(key)
            Console.WriteLine("Hien thi phan tu co khoa = 1 la " + dict2[1]);
            dict2.Remove(3);
            Console.WriteLine("Dict sau khi xoa key 3 la: ");
            foreach (KeyValuePair <int, string> kvp in dict2)
            {
                Console.Write(kvp + " ");
            }
            Console.WriteLine();
            // Xoa toan bo phan tu: dict.Clear();
            // chuyen cac value cua dict thanh 1 list: dict.Values.ToList();
            // chuyen cac key cua dict thanh 1 list: dict.Keys.ToList();
            List<string> lsValue = new List<string>();
            List<int> lsKey = new List<int>();

            lsKey = dict2.Keys.ToList();
            lsValue = dict2.Values.ToList();
            Console.WriteLine("List cac key cua dict 2 la: ");
            foreach (int i in lsKey)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("List cac value cua dict 2 la ");
            foreach (string i in lsValue)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
