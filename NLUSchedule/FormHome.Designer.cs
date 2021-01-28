namespace NLUSchedule
{
    partial class FormHome
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
            this.btnHome_Load = new FontAwesome.Sharp.IconButton();
            this.txtHome_getMSSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHome_Load
            // 
            this.btnHome_Load.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome_Load.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome_Load.IconColor = System.Drawing.Color.Black;
            this.btnHome_Load.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome_Load.IconSize = 48;
            this.btnHome_Load.Location = new System.Drawing.Point(557, 293);
            this.btnHome_Load.Name = "btnHome_Load";
            this.btnHome_Load.Rotation = 0D;
            this.btnHome_Load.Size = new System.Drawing.Size(283, 63);
            this.btnHome_Load.TabIndex = 0;
            this.btnHome_Load.Text = "Tiếp tục";
            this.btnHome_Load.UseVisualStyleBackColor = true;
            this.btnHome_Load.Click += new System.EventHandler(this.btnHome_Load_Click);
            // 
            // txtHome_getMSSV
            // 
            this.txtHome_getMSSV.Location = new System.Drawing.Point(127, 311);
            this.txtHome_getMSSV.Name = "txtHome_getMSSV";
            this.txtHome_getMSSV.Size = new System.Drawing.Size(316, 29);
            this.txtHome_getMSSV.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 577);
            this.Controls.Add(this.txtHome_getMSSV);
            this.Controls.Add(this.btnHome_Load);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnHome_Load;
        private System.Windows.Forms.TextBox txtHome_getMSSV;
    }
}