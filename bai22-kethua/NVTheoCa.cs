using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_kethua
{
    public class NVTheoCa: NhanVien
    {
        // ngoai cac thuoc tinh ke thua tu lop cha thi co the tu khai
        // bao them cac thuoc tinh cua lop con
        public string Ca {  get; set; }

        // ke thua method tu lop cha nhung co thay doi
        public new double TinhLuong()
        {
            return base.TinhLuong() * 1.2;
        }

    }
}
