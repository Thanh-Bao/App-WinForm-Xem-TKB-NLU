
using appTKB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NLUSchedule.FormTKB
{
    public partial class FormTableTKB : Form
    {
        public FormTableTKB()
        {
            InitializeComponent();
        }

        private void FormTableTKB_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM TKBSV";
            dataGirdViewTKB.DataSource = ConnectDB.loadDataFromDatabase(query);

        }

        private void radSX_Thu_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radSX_CaTH_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radSX_SoTiet_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radSX_SoTinChi_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radSX_TietBatDau_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        

     
    }
}
