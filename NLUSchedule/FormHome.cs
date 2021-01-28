using appTKB;

using NLUSchedule.Model;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace NLUSchedule
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnHome_Load_Click(object sender, EventArgs e)
        {



            string mssv = txtHome_getMSSV.Text;
            if (Utility.studentIDValidation(mssv))
            {
                // kiểm tra TKB SV có tồn tại trong DB hay chưa
                if (!ConnectDB.checkExist(mssv, "MSSV", "TKBSV"))
                {
                    try
                    {
                        List<MonHoc> tkb = CrawlUtility.CrawlTKB_DKMH(mssv);
                        // Đổ dữ liệu vào Bảng TKB
                        foreach (MonHoc mh in tkb)
                        {
                            // add vào Bang MonHoc
                            if (!ConnectDB.checkExist(mh.maMH, "MaMH", "MonHoc"))
                            {
                                string insertMH = "INSERT INTO MonHoc VALUES(" + mh.maMH + ", N'" + mh.tenMH.Trim() + "', " + mh.nhomMH + ", " + mh.soTinChi + ")";
                                ConnectDB.insertDataFromDatabase(insertMH);
                            }
                            // add vào Bang Giang Vien
                            if (!ConnectDB.checkExist(mh.CBGV, "MaGV", "GiaoVien"))
                            {
                                // dùng N cho Unicode
                                string insertGV = "INSERT INTO GiaoVien VALUES('" + mh.CBGV + "', N'" + CrawlUtility.crawlTenCBGV(mh.CBGV) + "')";
                                ConnectDB.insertDataFromDatabase(insertGV);
                            }

                            if (!ConnectDB.checkExistForDSSVTable(mh.maMH, mh.thu, mh.tietBD, mh.caTH))
                            {
                                List<SinhVienDSSV_TKB> list = CrawlUtility.CrawlDSSV_TKB("https://dkmh.hcmuaf.edu.vn/" + mh.DSSV);
                                foreach (SinhVienDSSV_TKB sv in list)
                                {
                                    string insertDSSV = "INSERT INTO DSSV VALUES(" + mh.maMH + ", " + mh.thu + ", " + mh.tietBD + ", " + mh.caTH + ", '" + sv.maLop + "', N'" + sv.tenLop + "', N'" + sv.hoTen + "');";
                                    ConnectDB.insertDataFromDatabase(insertDSSV);
                                }
                            }

                            // add vào Bảng TKB
                            string insertTKB = "INSERT INTO TKBSV VALUES(" + mssv + ", " + mh.maMH + ", " + mh.caTH + ", " + mh.thu + ", " + mh.tietBD + ", " + mh.soTiet + ", '" + mh.phong + "', '" + mh.CBGV + "', '" + string.Format("{0:yyyy/M/d}", mh.timeBatDau) + "', '" + string.Format("{0:yyyy/M/d}", mh.timeKetThuc) + "', '" + mh.maLop.Trim() + "', '')";
                            ConnectDB.insertDataFromDatabase(insertTKB);

                        }

                    }

                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Lỗi cơ sở dữ liệu");
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Không tồn tại MSSV trên hệ thống");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã số không hợp lệ");
            }

        }
    }
}

