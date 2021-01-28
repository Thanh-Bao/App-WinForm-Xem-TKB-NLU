using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NLUSchedule.checkUser
{
    public partial class CheckInternet : Form
    {
        public CheckInternet()
        {
            InitializeComponent();
        }

        private void btnCheckInternetOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
