using System.Drawing;

namespace NLUSchedule.FormTKB
{
    partial class FormTableTKB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radSX_Thu = new System.Windows.Forms.RadioButton();
            this.radSX_CaTH = new System.Windows.Forms.RadioButton();
            this.radSX_SoTiet = new System.Windows.Forms.RadioButton();
            this.radSX_SoTinChi = new System.Windows.Forms.RadioButton();
            this.radSX_TietBatDau = new System.Windows.Forms.RadioButton();
            this.lblCachSapXep = new System.Windows.Forms.Label();
            this.dataGirdViewTKB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdViewTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // radSX_Thu
            // 
            this.radSX_Thu.AutoSize = true;
            this.radSX_Thu.Checked = true;
            this.radSX_Thu.Location = new System.Drawing.Point(230, 22);
            this.radSX_Thu.Name = "radSX_Thu";
            this.radSX_Thu.Size = new System.Drawing.Size(57, 25);
            this.radSX_Thu.TabIndex = 0;
            this.radSX_Thu.TabStop = true;
            this.radSX_Thu.Text = "Thứ";
            this.radSX_Thu.UseVisualStyleBackColor = true;
            this.radSX_Thu.CheckedChanged += new System.EventHandler(this.radSX_Thu_CheckedChanged);
            // 
            // radSX_CaTH
            // 
            this.radSX_CaTH.AutoSize = true;
            this.radSX_CaTH.Location = new System.Drawing.Point(347, 22);
            this.radSX_CaTH.Name = "radSX_CaTH";
            this.radSX_CaTH.Size = new System.Drawing.Size(122, 25);
            this.radSX_CaTH.TabIndex = 1;
            this.radSX_CaTH.Text = "Ca thực hành";
            this.radSX_CaTH.UseVisualStyleBackColor = true;
            this.radSX_CaTH.CheckedChanged += new System.EventHandler(this.radSX_CaTH_CheckedChanged);
            // 
            // radSX_SoTiet
            // 
            this.radSX_SoTiet.AutoSize = true;
            this.radSX_SoTiet.Location = new System.Drawing.Point(516, 22);
            this.radSX_SoTiet.Name = "radSX_SoTiet";
            this.radSX_SoTiet.Size = new System.Drawing.Size(75, 25);
            this.radSX_SoTiet.TabIndex = 1;
            this.radSX_SoTiet.Text = "Số tiết";
            this.radSX_SoTiet.UseVisualStyleBackColor = true;
            this.radSX_SoTiet.CheckedChanged += new System.EventHandler(this.radSX_SoTiet_CheckedChanged);
            // 
            // radSX_SoTinChi
            // 
            this.radSX_SoTinChi.AutoSize = true;
            this.radSX_SoTinChi.Location = new System.Drawing.Point(645, 22);
            this.radSX_SoTinChi.Name = "radSX_SoTinChi";
            this.radSX_SoTinChi.Size = new System.Drawing.Size(95, 25);
            this.radSX_SoTinChi.TabIndex = 1;
            this.radSX_SoTinChi.Text = "Số tín chỉ";
            this.radSX_SoTinChi.UseVisualStyleBackColor = true;
            this.radSX_SoTinChi.CheckedChanged += new System.EventHandler(this.radSX_SoTinChi_CheckedChanged);
            // 
            // radSX_TietBatDau
            // 
            this.radSX_TietBatDau.AutoSize = true;
            this.radSX_TietBatDau.Location = new System.Drawing.Point(786, 22);
            this.radSX_TietBatDau.Name = "radSX_TietBatDau";
            this.radSX_TietBatDau.Size = new System.Drawing.Size(112, 25);
            this.radSX_TietBatDau.TabIndex = 1;
            this.radSX_TietBatDau.Text = "Tiết bắt đầu";
            this.radSX_TietBatDau.UseVisualStyleBackColor = true;
            this.radSX_TietBatDau.CheckedChanged += new System.EventHandler(this.radSX_TietBatDau_CheckedChanged);
            // 
            // lblCachSapXep
            // 
            this.lblCachSapXep.AutoSize = true;
            this.lblCachSapXep.Location = new System.Drawing.Point(52, 26);
            this.lblCachSapXep.Name = "lblCachSapXep";
            this.lblCachSapXep.Size = new System.Drawing.Size(141, 21);
            this.lblCachSapXep.TabIndex = 2;
            this.lblCachSapXep.Text = "Sắp Xếp TKB Theo :";
            // 
            // dataGirdViewTKB
            // 
            this.dataGirdViewTKB.AllowUserToAddRows = false;
            this.dataGirdViewTKB.AllowUserToDeleteRows = false;
            this.dataGirdViewTKB.BackgroundColor = System.Drawing.Color.White;
            this.dataGirdViewTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirdViewTKB.Location = new System.Drawing.Point(43, 88);
            this.dataGirdViewTKB.Name = "dataGirdViewTKB";
            this.dataGirdViewTKB.ReadOnly = true;
            this.dataGirdViewTKB.RowHeadersWidth = 51;
            this.dataGirdViewTKB.Size = new System.Drawing.Size(880, 403);
            this.dataGirdViewTKB.TabIndex = 3;
            this.dataGirdViewTKB.Text = "dataGridView1";
            this.dataGirdViewTKB.RowHeadersVisible = false;
            // 
            // FormTableTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.dataGirdViewTKB);
            this.Controls.Add(this.lblCachSapXep);
            this.Controls.Add(this.radSX_TietBatDau);
            this.Controls.Add(this.radSX_SoTinChi);
            this.Controls.Add(this.radSX_SoTiet);
            this.Controls.Add(this.radSX_CaTH);
            this.Controls.Add(this.radSX_Thu);
            this.Name = "FormTableTKB";
            this.Text = "Thứ";
            this.Load += new System.EventHandler(this.FormTableTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdViewTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSX_Thu;
        private System.Windows.Forms.RadioButton radSX_CaTH;
        private System.Windows.Forms.RadioButton radSX_SoTiet;
        private System.Windows.Forms.RadioButton radSX_TietBatDau;
        private System.Windows.Forms.RadioButton radSX_SoTinChi;
        private System.Windows.Forms.Label lblCachSapXep;
        private System.Windows.Forms.DataGridView dataGirdViewTKB;
    }
}