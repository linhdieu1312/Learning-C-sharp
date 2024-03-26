using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    // tao class sinhVien
    public class SinhVien
    {
        // kbao bien lop: voi bien nay chi sd pham vi truy xuat protected hoac private
        private int maSV;
        private string nameSV;
        private float diemSV;

        // khai bao Constructor mac dinh cho doi tuong
        public SinhVien()
        {
            // khi nguoi dung ko nhap gi vao thi day la gia tri mac dinh cua 2 bien nay
            this.maSV = 0;
            this.nameSV = "";
            this.diemSV = 0;
        }
        // kb constructor, khoi tao gia tri cho doi tuong do nguoi dung truyen vao
        public SinhVien(int maSV, string nameSV, float diemSV)
        {
            // this: thay cho cac doi tuong minh tao ra
            this.maSV = maSV;
            this.nameSV = nameSV;
            this.diemSV = diemSV;
        }

        // Su dung properties de thay doi duoc gia tri
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string NameSV
        {
            get { return nameSV; }
            set { nameSV = value; }
        }
        public float DiemSV
        {
            get { return diemSV; }
            set { diemSV = value; }
        }

        //method
        public override string ToString()
        {
            return "Ma SV: " + this.maSV + "\t Ten SV: " + this.nameSV;
        }

        private bool CheckDiem(float diemSV)
        {
            if (diemSV >= 7) return true;
            else return false;
        }

        public void Display()
        {
            if (CheckDiem(this.diemSV))
            {
                Console.WriteLine("Ho so sv chuan");
            }
            else
            {
                Console.WriteLine("Kiem tra lai ho so sinh vien nay");
            }
        }

        //VD ve overloading method: phuong thuc nap chong
        // constructor la TH dac biet cua overloading method
        // Overloading method la cac phuong thuc cung ten nhung khac ve
        // //signature(so luong doi so | kieu du lieu | thu tu doi so)

        public int Total (int x, int y)
        {
            return x + y;
        }

        public double Total (double x, double y)
        {
            return x + y;
        }

        public int Total (int x, int y, int z)
        {
            return x + y + z;
        }

        // Parameters List method
        public double DiemTB (params double[] arr)
        {
            double diemTong = 0;
            foreach (double i in arr)
            {
                diemTong += i;
            }
            return diemTong/arr.Count();
        }
    }
}
