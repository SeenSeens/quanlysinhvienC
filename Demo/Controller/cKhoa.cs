using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Controller;
using Demo.View;

namespace Demo.Controller
{
    class cKhoa
    {
        mKhoa khoa = new mKhoa();

        public bool Add_Khoa(String makhoa, String tenkhoa, String diadiem, String dienthoai, String email, String truongkhoa)
        {
            return khoa.Add_Khoa(makhoa, tenkhoa, diadiem, dienthoai, email, truongkhoa);
        }

        public bool ToFix(String makhoa, String tenkhoa, String diadiem, String dienthoai, String email, String truongkhoa)
        {
            return khoa.ToFix(makhoa, tenkhoa, diadiem, dienthoai, email, truongkhoa);
        }

        public bool Delete_Khoa(String makhoa)
        {
            return khoa.Delete_Khoa(makhoa);
        }
    }
}
