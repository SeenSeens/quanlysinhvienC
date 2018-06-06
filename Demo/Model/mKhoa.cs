		using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class mKhoa
    {
        public DataTable Load_on()
        {
            DataTable re;
            String lenh = "select * from Khoa";
            re = mXuly.TaoBang(lenh);
            return re;
        }

        public bool Add_Khoa(String makhoa, String tenkhoa, String diadiem, String dienthoai, String email, String truongkhoa)
        {
            String lenh_1 = "insert Khoa(MaKhoa, TenKhoa, DiaDiem, DienThoai, Email, TruongKhoa) values ('" + makhoa + "', N'" + tenkhoa + "', N'" + diadiem + "', '" + dienthoai + "', '" + email + "', N'" + truongkhoa + "')";
            bool re = false;
            if (mXuly.ExecuteNonQuery(lenh_1) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Delete_Khoa(String makhoa)
        {
            String lenh_4 = "delete from Khoa where MaKhoa = '" + makhoa + "'";
            bool re = false;
            if (mXuly.ExecuteNonQuery(lenh_4) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool ToFix(String makhoa, String tenkhoa, String diadiem, String dienthoai, String email, String truongkhoa)
        {
            String lenh_3 = "update Khoa set TenKhoa = N'" + tenkhoa + "', DiaDiem = N'" + diadiem + "', DienThoai = '" + dienthoai + "', Email = '" + email + "', TruongKhoa = N'" + truongkhoa + "' where MaKhoa = '" + makhoa + "'";
            bool re = false;
            if (mXuly.ExecuteNonQuery(lenh_3) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
