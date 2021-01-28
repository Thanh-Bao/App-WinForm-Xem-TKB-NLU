using System;
using System.Collections.Generic;
using System.Text;

namespace NLUSchedule
{
    public class MonHoc
    {


        public string maMH { get; set; }
        public string tenMH { get; set; }
        public int nhomMH { get; set; }
        public int soTinChi { get; set; }
        public string maLop { get; set; }
        public int caTH { get; set; }
        public int thu { get; set; }
        public int tietBD { get; set; }
        public int soTiet { get; set; }
        public string phong { get; set; }
        public string CBGV { get; set; }
        public DateTime timeBatDau { get; set; }
        public DateTime timeKetThuc { get; set; }
        public string DSSV { get; set; }


        public MonHoc(string maMH, string tenMH, int nhomMH, int soTinChi, string maLop, int caTH, int thu, int tietBD, int soTiet, string phong, string cBGV, DateTime timeBatDau, DateTime timeKetThuc, string dSSV)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.nhomMH = nhomMH;
            this.soTinChi = soTinChi;
            this.maLop = maLop;
            this.caTH = caTH;
            this.thu = thu;
            this.tietBD = tietBD;
            this.soTiet = soTiet;
            this.phong = phong;
            CBGV = cBGV;
            this.timeBatDau = timeBatDau;
            this.timeKetThuc = timeKetThuc;
            DSSV = dSSV;
        }


        public override string ToString()
        {
            return maMH + "___" + tenMH + "___" + nhomMH + "___" + soTinChi + "___" + maLop + "___" + caTH + "___" + thu + "___" + tietBD + "___" + soTiet + "___" + phong + "___" + CBGV + "___" + timeBatDau.ToString() + "___" + timeBatDau.ToString() + "___" + DSSV;
        }
    }
}
