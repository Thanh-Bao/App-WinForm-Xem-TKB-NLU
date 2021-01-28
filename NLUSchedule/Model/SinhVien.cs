using System;
using System.Collections.Generic;
using System.Text;

namespace appTKB
{
    public class SinhVien
    {


        public string maSV { get; set; }
        public string tenSV { get; set; }

        public string ngaySinh { get; set; }

        public string lop { get; set; }

        public string nganh { get; set; }

        public string khoa { get; set; }



        public SinhVien(string maSV, string tenSV, string ngaySinh, string lop, string nganh, string khoa)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.ngaySinh = ngaySinh;
            this.lop = lop;
            this.nganh = nganh;
            this.khoa = khoa;

        }

        public override string ToString()
        {
            return maSV + "_" + tenSV + "_" + ngaySinh + "_" + lop + "_" + nganh + "_" + khoa + "\n";
        }
    }
}
