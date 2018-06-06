using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class mSinhvien
    {
        public DataTable Load_on()
        {
            DataTable re;
            String lenh = "select s.MaSV, s.Ho, s.Ten, s.NgaySinh, s.GioiTinh, s.NoiSinh, s.KhoaHoc, s.MaKhoa, k.TenKhoa from SinhVien s, Khoa k where s.MaKhoa = k.MaKhoa";
            re = mXuly.TaoBang(lenh);
            return re;
        }

        public DataTable Load_on_Khoa(String a)
        {
            DataTable re;
            String lenh = "select k.MaKhoa from Khoa k, SinhVien s where s.MaSV = '" + a + "' and s.MaKhoa = k.MaKhoa";
            re = mXuly.TaoBang(lenh);
            return re;
        }

        public DataTable Load_on_tim()
        {
            DataTable re;
            String lenh = "select MaKhoa from Khoa";
            re = mXuly.TaoBang(lenh);
            return re;
        }

        public DataTable timkiem(String makhoa)
        {
            DataTable re;
            String lenh_2 = "select TenKhoa from Khoa where MaKhoa = '" + makhoa + "'";
            re = mXuly.TaoBang(lenh_2);
            return re;
        }

        public bool Add_SinhVien(String MaSV, String Ho, String Ten, String NgaySinh, String GioiTinh, String NoiSinh, String KhoaHoc, String MaKhoa)
        {
            String lenh1 = "insert SinhVien (MaSV, Ho, Ten, NgaySinh, GioiTinh, NoiSinh, KhoaHoc, MaKhoa) values ('" + MaSV + "', N'" + Ho + "', N'" + Ten + "', '" + NgaySinh + "', N'" + GioiTinh + "', N'" + NoiSinh + "', '" + KhoaHoc + "', '" + MaKhoa + "')";
            bool re = false;
            if (mXuly.ExecuteNonQuery(lenh1) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Delete_SinhVien(String MaSV)
        {
            String lenh4 = "delete from SinhVien where MaSV = '" + MaSV + "'";
            bool re = false;
            if (mXuly.ExecuteNonQuery(lenh4) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool ToFix_SinhVien(String MaSV, String Ho, String Ten, String NgaySinh, String GioiTinh, String NoiSinh, String KhoaHoc, String MaKhoa)
        {
            String lenh3 = "update SinhVien set Ho = N'" + Ho + "', Ten = N'" + Ten + "', NgaySinh = N'" + NgaySinh + "', GioiTinh = N'" + GioiTinh + "', NoiSinh = N'" + NoiSinh + "', KhoaHoc = '" + KhoaHoc + "', MaKhoa = '" + MaKhoa + "'";
            bool re = false;
            if (mXuly.ExecuteNonQuery(lenh3) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
