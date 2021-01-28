using System.Drawing;

namespace NLUSchedule.FormTKB
{
    partial class FormCalendarTKB
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
            this.monthCalendarTKB = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendarTKB
            // 
            this.monthCalendarTKB.BackColor = System.Drawing.Color.White;
            this.monthCalendarTKB.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendarTKB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.monthCalendarTKB.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarTKB.Location = new System.Drawing.Point(66, 5);
            this.monthCalendarTKB.Name = "monthCalendarTKB";
            this.monthCalendarTKB.TabIndex = 0;
            this.monthCalendarTKB.TitleBackColor = System.Drawing.Color.MediumSpringGreen;
            this.monthCalendarTKB.TitleForeColor = System.Drawing.Color.Lime;
            this.monthCalendarTKB.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            
            // 
            // FormCalendarTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.monthCalendarTKB);
            this.Name = "FormCalendarTKB";
            this.Text = "FormCalendarTKB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarTKB;
    }
}