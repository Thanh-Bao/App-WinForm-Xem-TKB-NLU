namespace NLUSchedule
{
    partial class FormViewTKB
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
            this.panelTKB = new System.Windows.Forms.Panel();
            this.btnTKBListView = new FontAwesome.Sharp.IconButton();
            this.btnTKBCalendarView = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelTKB
            // 
            this.panelTKB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTKB.Location = new System.Drawing.Point(0, 50);
            this.panelTKB.Margin = new System.Windows.Forms.Padding(0);
            this.panelTKB.Name = "panelTKB";
            this.panelTKB.Size = new System.Drawing.Size(953, 527);
            this.panelTKB.TabIndex = 1;
            // 
            // btnTKBListView
            // 
            this.btnTKBListView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTKBListView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTKBListView.IconColor = System.Drawing.Color.Black;
            this.btnTKBListView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKBListView.IconSize = 48;
            this.btnTKBListView.Location = new System.Drawing.Point(260, 21);
            this.btnTKBListView.Name = "btnTKBListView";
            this.btnTKBListView.Rotation = 0D;
            this.btnTKBListView.Size = new System.Drawing.Size(182, 38);
            this.btnTKBListView.TabIndex = 2;
            this.btnTKBListView.Text = "Xem dạng danh sách";
            this.btnTKBListView.UseVisualStyleBackColor = true;
            this.btnTKBListView.Click += new System.EventHandler(this.btnTKBListView_Click);
            // 
            // btnTKBCalendarView
            // 
            this.btnTKBCalendarView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTKBCalendarView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTKBCalendarView.IconColor = System.Drawing.Color.Black;
            this.btnTKBCalendarView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKBCalendarView.IconSize = 48;
            this.btnTKBCalendarView.Location = new System.Drawing.Point(511, 21);
            this.btnTKBCalendarView.Name = "btnTKBCalendarView";
            this.btnTKBCalendarView.Rotation = 0D;
            this.btnTKBCalendarView.Size = new System.Drawing.Size(182, 38);
            this.btnTKBCalendarView.TabIndex = 2;
            this.btnTKBCalendarView.Text = "Xem dạng lịch";
            this.btnTKBCalendarView.UseVisualStyleBackColor = true;
            this.btnTKBCalendarView.Click += new System.EventHandler(this.btnTKBCalendarView_Click);
            // 
            // FormViewTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 577);
            this.Controls.Add(this.btnTKBCalendarView);
            this.Controls.Add(this.btnTKBListView);
            this.Controls.Add(this.panelTKB);
            this.Name = "FormViewTKB";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTKB;
        private FontAwesome.Sharp.IconButton btnTKBListView;
        private FontAwesome.Sharp.IconButton btnTKBCalendarView;
    }
}