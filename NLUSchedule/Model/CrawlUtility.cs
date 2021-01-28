using appTKB;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Windows;

namespace NLUSchedule
{
    public class CrawlUtility
    {

        private const string URL_TKB_NLU = @"https://dkmh.hcmuaf.edu.vn/Default.aspx?page=thoikhoabieu&sta=1&id=";

        public static List<MonHoc> CrawlTKB_DKMH(string MSSV)
        {

            List<MonHoc> listMonHoc = new List<MonHoc>();

            string maMH = "";
            string tenMH = "";
            string nhomMH = "";
            string soTC = "";
            string maLop = "";
            string caTH = "";
            string thu = "";
            string tietBD = "";
            string soTiet = "";
            string phong = "";
            string CBGV = "";
            string tuanHoc = "";
            string DSSV = "";

            string URL = URL_TKB_NLU + MSSV;


            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(URL);

            var TKB = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ContentPlaceHolder1_ctl00_pnlHeader\"]/table//tr[2]/td/div[2]");

            HtmlNodeCollection ListMonHoc = TKB.SelectNodes("table/tr");


            foreach (var MonHoc in ListMonHoc)
            {
                HtmlNodeCollection Col_MonHocs = MonHoc.SelectNodes("td");
                if (Col_MonHocs[13].SelectNodes("table") != null)
                {
                    // cột thứ 13  // const (chọn ngẫu nhiên một cột để đếm số hàng con trong cột đó)
                    HtmlNodeCollection cot_thu13 = Col_MonHocs[13].SelectNodes("table");

                    if (cot_thu13.Count == 1)
                    {
                        maMH = Col_MonHocs[0].InnerText;
                        tenMH = Col_MonHocs[1].InnerText;
                        nhomMH = Col_MonHocs[2].InnerText;
                        soTC = Col_MonHocs[3].InnerText;
                        maLop = Col_MonHocs[4].InnerText;
                        caTH = Col_MonHocs[9].SelectSingleNode("table").InnerText;
                        thu = Col_MonHocs[10].SelectSingleNode("table").InnerText;
                        tietBD = Col_MonHocs[11].SelectSingleNode("table").InnerText;
                        soTiet = Col_MonHocs[12].SelectSingleNode("table").InnerText;
                        phong = Col_MonHocs[13].SelectSingleNode("table").InnerText;
                        CBGV = Col_MonHocs[14].SelectSingleNode("table").InnerText;
                        tuanHoc = Col_MonHocs[15].SelectSingleNode("table//tr/td").Attributes["onmouseover"].Value.ToString();
                        if (MSSV.Length > 3)
                        {
                            DSSV = Col_MonHocs[16].SelectSingleNode("a").Attributes["href"].Value.ToString();
                        }
                        else
                        {
                            DSSV = Col_MonHocs[16].SelectSingleNode("table/tr/td/a").Attributes["href"].Value.ToString();

                        }

                        listMonHoc.Add(new MonHoc(
                            maMH,
                            tenMH,
                            Int32.Parse(nhomMH),
                            Int32.Parse(soTC),
                            maLop,
                            (caTH == "" ? 0 : Int32.Parse(caTH)),
                            thuVN_to_int(thu),
                            Int32.Parse(tietBD),
                            Int32.Parse(soTC),
                            phong,
                            CBGV,
                            convertDateBatDauMH(tuanHoc),
                            convertDateKetThucMH(tuanHoc),
                            DSSV));

                    }
                    else
                    {
                        maMH = Col_MonHocs[0].InnerText;
                        tenMH = Col_MonHocs[1].InnerText;
                        nhomMH = Col_MonHocs[2].InnerText;
                        soTC = Col_MonHocs[3].InnerText;
                        maLop = Col_MonHocs[4].InnerText;
                        caTH = Col_MonHocs[9].SelectSingleNode("table").InnerText;
                        thu = Col_MonHocs[10].SelectSingleNode("table").InnerText;
                        tietBD = Col_MonHocs[11].SelectSingleNode("table").InnerText;
                        soTiet = Col_MonHocs[12].SelectSingleNode("table").InnerText;
                        phong = Col_MonHocs[13].SelectSingleNode("table").InnerText;
                        CBGV = Col_MonHocs[14].SelectSingleNode("table").InnerText;
                        tuanHoc = Col_MonHocs[15].SelectSingleNode("table//tr/td").Attributes["onmouseover"].Value.ToString();
                        if (MSSV.Length>3)
                        {
                            DSSV = Col_MonHocs[16].SelectSingleNode("a").Attributes["href"].Value.ToString();
                        }
                        else
                        {
                            DSSV = Col_MonHocs[16].SelectSingleNode("table/tr/td/a").Attributes["href"].Value.ToString();

                        }


                        listMonHoc.Add(new MonHoc(
                            maMH,
                            tenMH,
                            Int32.Parse(nhomMH),
                            Int32.Parse(soTC),
                            maLop,
                            (caTH == "" ? 0 : Int32.Parse(caTH)),
                            thuVN_to_int(thu),
                            Int32.Parse(tietBD),
                            Int32.Parse(soTC),
                            phong,
                            CBGV,
                            convertDateBatDauMH(tuanHoc),
                            convertDateKetThucMH(tuanHoc),
                            DSSV));

                        maMH = Col_MonHocs[0].InnerText;
                        tenMH = Col_MonHocs[1].InnerText;
                        nhomMH = Col_MonHocs[2].InnerText;
                        soTC = Col_MonHocs[3].InnerText;
                        maLop = Col_MonHocs[4].InnerText;
                        caTH = Col_MonHocs[9].SelectSingleNode("table[2]").InnerText;
                        thu = Col_MonHocs[10].SelectSingleNode("table[2]").InnerText;
                        tietBD = Col_MonHocs[11].SelectSingleNode("table[2]").InnerText;
                        soTiet = Col_MonHocs[12].SelectSingleNode("table[2]").InnerText;
                        phong = Col_MonHocs[13].SelectSingleNode("table[2]").InnerText;
                        CBGV = Col_MonHocs[14].SelectSingleNode("table[2]").InnerText;
                        tuanHoc = Col_MonHocs[15].SelectSingleNode("table[2]//tr/td").Attributes["onmouseover"].Value.ToString();

                        if (MSSV.Length >3)
                        {
                            DSSV = Col_MonHocs[16].SelectSingleNode("a").Attributes["href"].Value.ToString();
                        }
                        else
                        {
                            DSSV = Col_MonHocs[16].SelectSingleNode("table[2]/tr/td/a").Attributes["href"].Value.ToString();

                        }
                        listMonHoc.Add(new MonHoc(
                           maMH,
                           tenMH,
                           Int32.Parse(nhomMH),
                           Int32.Parse(soTC),
                           maLop,
                           (caTH == "" ? 0 : Int32.Parse(caTH)),
                           thuVN_to_int(thu),
                           Int32.Parse(tietBD),
                           Int32.Parse(soTC),
                           phong,
                           CBGV,
                           convertDateBatDauMH(tuanHoc),
                           convertDateKetThucMH(tuanHoc),
                           DSSV));


                    }
                }
                else
                {
                    maMH = Col_MonHocs[0].InnerText.Trim();
                    tenMH = Col_MonHocs[1].InnerText.Trim();
                    nhomMH = Col_MonHocs[2].InnerText.Trim();
                    soTC = Col_MonHocs[3].InnerText.Trim();
                    maLop = Col_MonHocs[4].InnerText.Trim();
                    caTH = Col_MonHocs[9].InnerText.Trim();
                    thu = Col_MonHocs[10].InnerText.Trim();
                    tietBD = Col_MonHocs[11].InnerText.Trim();
                    soTiet = Col_MonHocs[12].InnerText.Trim();
                    phong = Col_MonHocs[13].InnerText.Trim();
                    CBGV = Col_MonHocs[14].InnerText.Trim();
                    DSSV = Col_MonHocs[16].SelectSingleNode("a").Attributes["href"].Value.ToString();
                    tuanHoc = Col_MonHocs[15].SelectSingleNode("div").Attributes["onmouseover"].Value.ToString();

                    listMonHoc.Add(new MonHoc(
                       maMH,
                       tenMH,
                       Int32.Parse(nhomMH),
                       Int32.Parse(soTC),
                       maLop,
                       (caTH == "" ? 0 : Int32.Parse(caTH)),
                       thuVN_to_int(thu),
                       Int32.Parse(tietBD),
                       Int32.Parse(soTC),
                       phong,
                       "",
                       convertDateBatDauMH(tuanHoc),
                       convertDateKetThucMH(tuanHoc),
                       DSSV));

                }
            }
            return listMonHoc;
        }


        private static int thuVN_to_int(string thuVN)
        {

            switch (thuVN)
            {
                case "Hai":
                    return 2;
                case "Ba":
                    return 3;
                case "Tư":
                    return 4;
                case "Năm":
                    return 5;
                case "Sáu":
                    return 6;
                case "Bảy":
                    return 7;
                case "CN":
                    return 8;
                default:
                    throw new Exception("Lỗi lấy tên thứ trong tuần của TKB");

            }
        }

        private static DateTime convertDateBatDauMH(string date)
        {
            int dayStart = Int32.Parse(date.Substring(15, 2));
            int monthStart = Int32.Parse(date.Substring(18, 2));
            int yearStart = Int32.Parse(date.Substring(21, 4));
            return new DateTime(yearStart, monthStart, dayStart);
        }

        private static DateTime convertDateKetThucMH(string date)
        {
            int dayEnd = Int32.Parse(date.Substring(27, 2));
            int monthEnd = Int32.Parse(date.Substring(30, 2));
            int yearEnd = Int32.Parse(date.Substring(33, 4));
            return new DateTime(yearEnd, monthEnd, dayEnd);
        }

        public static string printTKBtoPlaintext(List<MonHoc> tkb)
        {
            string str = "";
            foreach (MonHoc mh in tkb)
            {
                str += mh + "\n";
            }

            return str;
        }


        public static SinhVien crawlProfileSV(string MSSV)
        {
            string URL = URL_TKB_NLU + MSSV;

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(URL);
            string ten = "";
            string ngaySinh = "";
            string lop = "";
            string nganh = "";
            string khoa = "";


            string ten_NgaySinh = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ContentPlaceHolder1_ctl00_lblContentTenSV\"]").InnerText;
            string lop_Nganh_Khoa = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ContentPlaceHolder1_ctl00_lblContentLopSV\"]").InnerText;

            // tách tên, Ngày sinh 
            string[] arrTen_NgaySinh = ten_NgaySinh.Split('-');
            ten = arrTen_NgaySinh[0].Trim();
            ngaySinh = arrTen_NgaySinh[1].Trim().Substring(10, 10);
            // bóc tách lop, nganh, khoa. 
            string[] arrLop_Nganh_Khoa = lop_Nganh_Khoa.Split('-');
            lop = arrLop_Nganh_Khoa[0].Trim();
            nganh = arrLop_Nganh_Khoa[1].Trim().Substring(7);
            khoa = arrLop_Nganh_Khoa[2].Trim().Substring(6);

            return new SinhVien(MSSV, ten, ngaySinh, lop, nganh, khoa);


        }


        public static List<SinhVienDSSV_TKB> CrawlDSSV_TKB(string URL)
        {


            List<SinhVienDSSV_TKB> list = new List<SinhVienDSSV_TKB>();

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(URL);

            HtmlNode DSSV = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ContentPlaceHolder1_ctl00_gvDSSinhVien\"]");

            HtmlNodeCollection listSinhVien = DSSV.SelectNodes("tr");
            listSinhVien.Remove(0);

            foreach (var sinhVien in listSinhVien)
            {
                HtmlNodeCollection colSV = sinhVien.SelectNodes("td");
                list.Add(new SinhVienDSSV_TKB(colSV[1].InnerText.Trim(),
                    colSV[2].InnerText.Trim() + " " + colSV[3].InnerText.Trim(),
                    colSV[4].InnerText.Trim(),
                    colSV[5].InnerText.Trim()));
            }

            return list;
        }

        public static string crawlTenCBGV(string MS)
        {
            string ten = "";
            string URL = URL_TKB_NLU + MS;
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(URL);
            ten = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ContentPlaceHolder1_ctl00_lblContentTenSV\"]").InnerText.Trim();
            return ten.Trim();

        }



        public static string printListSV(List<SinhVienDSSV_TKB> list)
        {
            string output = "";
            foreach (SinhVienDSSV_TKB sv in list)
            {
                output += sv + "\n";
            }

            return output;
        }



    }
}
