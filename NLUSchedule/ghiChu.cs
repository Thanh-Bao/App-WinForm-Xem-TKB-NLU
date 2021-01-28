using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NLUSchedule
{
    public partial class Form_ghiChu : Form
    {
        public string path;

        public Form_ghiChu(string path)
        {
            InitializeComponent();
            this.path = path;
            textGhiChu.Text = File.ReadAllText(path);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, "");
            File.WriteAllText(path, textGhiChu.Text);
            lblGhiChu.Text = "Dữ liệu đã được lưu thành công !";
        }
    }
}
