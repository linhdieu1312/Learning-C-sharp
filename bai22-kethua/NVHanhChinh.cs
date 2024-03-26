using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_kethua
{
    // pvi_truy_cap class ten_lop_con: Ten_lop_cha {}
    public class NVHanhChinh: NhanVien
    {
        // ghi de override vs phuong thuc ThuongCong o lop NhanVien
        public override double ThuongCong(int NgayCong)
        {
            return 0;
        }
    }
}
