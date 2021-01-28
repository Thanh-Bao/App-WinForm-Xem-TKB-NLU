using NLUSchedule.FormTKB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NLUSchedule
{
    public partial class FormViewTKB : Form
    {
        private Form currentChildForm;
        public FormViewTKB()
        {
            InitializeComponent();
            OpenChildForm(new FormTableTKB());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();

            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTKB.Controls.Add(childForm);
            panelTKB.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnTKBListView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTableTKB());
        }

        private void btnTKBCalendarView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCalendarTKB());
        }
    }
}
