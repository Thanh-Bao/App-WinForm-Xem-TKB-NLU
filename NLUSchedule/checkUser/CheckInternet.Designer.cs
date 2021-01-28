using System.Drawing;

namespace NLUSchedule.checkUser
{
    partial class CheckInternet
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
            this.btnCheckInternetOK = new System.Windows.Forms.Button();
            this.noInternetIcon = new System.Windows.Forms.PictureBox();
            this.lblCheckInternet = new System.Windows.Forms.Label();
            this.lblCheckInternet2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noInternetIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckInternetOK
            // 
            this.btnCheckInternetOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckInternetOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckInternetOK.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckInternetOK.ForeColor = System.Drawing.Color.White;
            this.btnCheckInternetOK.Location = new System.Drawing.Point(255, 348);
            this.btnCheckInternetOK.Name = "btnCheckInternetOK";
            this.btnCheckInternetOK.Size = new System.Drawing.Size(286, 90);
            this.btnCheckInternetOK.TabIndex = 0;
            this.btnCheckInternetOK.Text = "Tiếp tục";
            this.btnCheckInternetOK.UseVisualStyleBackColor = false;
            this.btnCheckInternetOK.Click += new System.EventHandler(this.btnCheckInternetOK_Click);
            // 
            // noInternetIcon
            // 
           
            var bmpInternet = new Bitmap(NLUSchedule.Properties.Resources.noInternetIcon);
            this.noInternetIcon.Image = bmpInternet;
            this.noInternetIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noInternetIcon.Location = new System.Drawing.Point(201, 12);
            this.noInternetIcon.Name = "noInternetIcon";
            this.noInternetIcon.Size = new System.Drawing.Size(392, 212);
            this.noInternetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noInternetIcon.TabIndex = 1;
            this.noInternetIcon.TabStop = false;
            // 
            // lblCheckInternet
            // 
            this.lblCheckInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckInternet.AutoSize = true;
            this.lblCheckInternet.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckInternet.ForeColor = System.Drawing.Color.White;
            this.lblCheckInternet.Location = new System.Drawing.Point(299, 236);
            this.lblCheckInternet.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCheckInternet.Name = "lblCheckInternet";
            this.lblCheckInternet.Size = new System.Drawing.Size(213, 34);
            this.lblCheckInternet.TabIndex = 3;
            this.lblCheckInternet.Text = "Không có internet";
            this.lblCheckInternet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCheckInternet2
            // 
            this.lblCheckInternet2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckInternet2.AutoSize = true;
            this.lblCheckInternet2.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckInternet2.ForeColor = System.Drawing.Color.White;
            this.lblCheckInternet2.Location = new System.Drawing.Point(150, 289);
            this.lblCheckInternet2.Margin = new System.Windows.Forms.Padding(0);
            this.lblCheckInternet2.Name = "lblCheckInternet2";
            this.lblCheckInternet2.Size = new System.Drawing.Size(500, 34);
            this.lblCheckInternet2.TabIndex = 3;
            this.lblCheckInternet2.Text = "Ứng dụng cần kết nối internet để hoạt động";
            this.lblCheckInternet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCheckInternet2);
            this.Controls.Add(this.lblCheckInternet);
            this.Controls.Add(this.noInternetIcon);
            this.Controls.Add(this.btnCheckInternetOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckInternet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckInternet";
            ((System.ComponentModel.ISupportInitialize)(this.noInternetIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckInternetOK;
        private System.Windows.Forms.PictureBox noInternetIcon;
        private System.Windows.Forms.Label lblCheckInternet;
        private System.Windows.Forms.Label lblCheckInternet2;
        //var bmpInternet = new Bitmap(NLUSchedule.Properties.Resources.noInternetIcon);
        //this.noInternetIcon.Image = bmpInternet;
    }
}