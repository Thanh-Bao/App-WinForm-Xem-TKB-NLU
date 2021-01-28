using System;
using System.Collections.Generic;
using System.Text;

namespace NLUSchedule
{
    public class SinhVienDSSV_TKB
    {


        public string MSSV { get; set; }

        public string hoTen { get; set; }

        public string maLop { get; set; }

        public string tenLop { get; set; }

        public SinhVienDSSV_TKB(string mSSV, string hoTen, string maLop, string tenLop)
        {
            MSSV = mSSV;
            this.hoTen = hoTen;
           this. maLop = maLop;
            this.tenLop = tenLop;
        }

        public override string ToString()
        {
            return MSSV + "___" + hoTen + "___" + maLop + "___" + tenLop;
        }
    }
}
