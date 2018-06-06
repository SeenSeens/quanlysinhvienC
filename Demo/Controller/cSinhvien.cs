using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Controller
{
    class cSinhvien
    {
        mSinhvien sv = new mSinhvien();

        public bool Add_SinhVien(String MaSV, String Ho, String Ten, String NgaySinh, String GioiTinh, String NoiSinh, String KhoaHoc, String MaKhoa)
        {
            return sv.Add_SinhVien(MaSV, Ho, Ten, NgaySinh, GioiTinh, NoiSinh, KhoaHoc, MaKhoa);
        }

        public bool ToFix_SinhVien(String MaSV, String Ho, String Ten, String NgaySinh, String GioiTinh, String NoiSinh, String KhoaHoc, String MaKhoa)
        {
            return sv.ToFix_SinhVien(MaSV, Ho, Ten, NgaySinh, GioiTinh, NoiSinh, KhoaHoc, MaKhoa);
        }

        public bool Delete_SinhVien(String MaSV)
        {
            return sv.Delete_SinhVien(MaSV);
        }
    }
}
