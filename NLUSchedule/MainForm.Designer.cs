using System.Drawing;
using System.Windows.Forms;

namespace NLUSchedule
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btnMenu_About = new FontAwesome.Sharp.IconButton();
            this.btnMenu_Profile = new FontAwesome.Sharp.IconButton();
            this.btnMenu_HocPhi = new FontAwesome.Sharp.IconButton();
            this.btnMenu_LichThi = new FontAwesome.Sharp.IconButton();
            this.btnMenu_TKB = new FontAwesome.Sharp.IconButton();
            this.btnMenu_Home = new FontAwesome.Sharp.IconButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximine = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_titleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.toolTipforBtnExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFullScreen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNormalScreen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMinimize = new System.Windows.Forms.ToolTip(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.panel_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_Menu.Controls.Add(this.btnMenu_About);
            this.panel_Menu.Controls.Add(this.btnMenu_Profile);
            this.panel_Menu.Controls.Add(this.btnMenu_HocPhi);
            this.panel_Menu.Controls.Add(this.btnMenu_LichThi);
            this.panel_Menu.Controls.Add(this.btnMenu_TKB);
            this.panel_Menu.Controls.Add(this.btnMenu_Home);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(249, 699);
            this.panel_Menu.TabIndex = 0;
            // 
            // btnMenu_About
            // 
            this.btnMenu_About.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_About.FlatAppearance.BorderSize = 0;
            this.btnMenu_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_About.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu_About.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_About.ForeColor = System.Drawing.Color.White;
            this.btnMenu_About.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnMenu_About.IconColor = System.Drawing.Color.White;
            this.btnMenu_About.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu_About.IconSize = 48;
            this.btnMenu_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_About.Location = new System.Drawing.Point(0, 541);
            this.btnMenu_About.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu_About.Name = "btnMenu_About";
            this.btnMenu_About.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu_About.Rotation = 0D;
            this.btnMenu_About.Size = new System.Drawing.Size(249, 84);
            this.btnMenu_About.TabIndex = 1;
            this.btnMenu_About.Text = "About";
            this.btnMenu_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu_About.UseVisualStyleBackColor = true;
            this.btnMenu_About.Click += new System.EventHandler(this.btnMenu_About_Click);
            // 
            // btnMenu_Profile
            // 
            this.btnMenu_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_Profile.FlatAppearance.BorderSize = 0;
            this.btnMenu_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_Profile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu_Profile.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_Profile.ForeColor = System.Drawing.Color.White;
            this.btnMenu_Profile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnMenu_Profile.IconColor = System.Drawing.Color.White;
            this.btnMenu_Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu_Profile.IconSize = 48;
            this.btnMenu_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_Profile.Location = new System.Drawing.Point(0, 457);
            this.btnMenu_Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu_Profile.Name = "btnMenu_Profile";
            this.btnMenu_Profile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu_Profile.Rotation = 0D;
            this.btnMenu_Profile.Size = new System.Drawing.Size(249, 84);
            this.btnMenu_Profile.TabIndex = 1;
            this.btnMenu_Profile.Text = "Profile";
            this.btnMenu_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_Profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu_Profile.UseVisualStyleBackColor = true;
            this.btnMenu_Profile.Click += new System.EventHandler(this.btnMenu_Profile_Click);
            // 
            // btnMenu_HocPhi
            // 
            this.btnMenu_HocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_HocPhi.FlatAppearance.BorderSize = 0;
            this.btnMenu_HocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_HocPhi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu_HocPhi.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_HocPhi.ForeColor = System.Drawing.Color.White;
            this.btnMenu_HocPhi.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnMenu_HocPhi.IconColor = System.Drawing.Color.White;
            this.btnMenu_HocPhi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu_HocPhi.IconSize = 48;
            this.btnMenu_HocPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_HocPhi.Location = new System.Drawing.Point(0, 373);
            this.btnMenu_HocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu_HocPhi.Name = "btnMenu_HocPhi";
            this.btnMenu_HocPhi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu_HocPhi.Rotation = 0D;
            this.btnMenu_HocPhi.Size = new System.Drawing.Size(249, 84);
            this.btnMenu_HocPhi.TabIndex = 1;
            this.btnMenu_HocPhi.Text = "Học Phí";
            this.btnMenu_HocPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_HocPhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu_HocPhi.UseVisualStyleBackColor = true;
            this.btnMenu_HocPhi.Click += new System.EventHandler(this.btnMenu_HocPhi_Click);
            // 
            // btnMenu_LichThi
            // 
            this.btnMenu_LichThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_LichThi.FlatAppearance.BorderSize = 0;
            this.btnMenu_LichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_LichThi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu_LichThi.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_LichThi.ForeColor = System.Drawing.Color.White;
            this.btnMenu_LichThi.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnMenu_LichThi.IconColor = System.Drawing.Color.White;
            this.btnMenu_LichThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu_LichThi.IconSize = 48;
            this.btnMenu_LichThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_LichThi.Location = new System.Drawing.Point(0, 289);
            this.btnMenu_LichThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu_LichThi.Name = "btnMenu_LichThi";
            this.btnMenu_LichThi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu_LichThi.Rotation = 0D;
            this.btnMenu_LichThi.Size = new System.Drawing.Size(249, 84);
            this.btnMenu_LichThi.TabIndex = 1;
            this.btnMenu_LichThi.Text = "Lịch Thi";
            this.btnMenu_LichThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_LichThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu_LichThi.UseVisualStyleBackColor = true;
            this.btnMenu_LichThi.Click += new System.EventHandler(this.btnMenu_LichThi_Click);
            // 
            // btnMenu_TKB
            // 
            this.btnMenu_TKB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_TKB.FlatAppearance.BorderSize = 0;
            this.btnMenu_TKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_TKB.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu_TKB.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_TKB.ForeColor = System.Drawing.Color.White;
            this.btnMenu_TKB.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnMenu_TKB.IconColor = System.Drawing.Color.White;
            this.btnMenu_TKB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu_TKB.IconSize = 48;
            this.btnMenu_TKB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_TKB.Location = new System.Drawing.Point(0, 205);
            this.btnMenu_TKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu_TKB.Name = "btnMenu_TKB";
            this.btnMenu_TKB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu_TKB.Rotation = 0D;
            this.btnMenu_TKB.Size = new System.Drawing.Size(249, 84);
            this.btnMenu_TKB.TabIndex = 1;
            this.btnMenu_TKB.Text = "Xem TKB";
            this.btnMenu_TKB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_TKB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu_TKB.UseVisualStyleBackColor = true;
            this.btnMenu_TKB.Click += new System.EventHandler(this.btnMenu_TKB_Click);
            // 
            // btnMenu_Home
            // 
            this.btnMenu_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu_Home.FlatAppearance.BorderSize = 0;
            this.btnMenu_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu_Home.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu_Home.ForeColor = System.Drawing.Color.White;
            this.btnMenu_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnMenu_Home.IconColor = System.Drawing.Color.White;
            this.btnMenu_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu_Home.IconSize = 48;
            this.btnMenu_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_Home.Location = new System.Drawing.Point(0, 121);
            this.btnMenu_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu_Home.Name = "btnMenu_Home";
            this.btnMenu_Home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu_Home.Rotation = 0D;
            this.btnMenu_Home.Size = new System.Drawing.Size(249, 84);
            this.btnMenu_Home.TabIndex = 1;
            this.btnMenu_Home.Text = "Trang Chủ";
            this.btnMenu_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu_Home.UseVisualStyleBackColor = true;
            this.btnMenu_Home.Click += new System.EventHandler(this.btnMenu_Home_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.picBox_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(249, 121);
            this.panel_Logo.TabIndex = 0;
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.Location = new System.Drawing.Point(0, 12);
            this.picBox_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(249, 103);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 0;
            this.picBox_Logo.TabStop = false;
            this.picBox_Logo.Click += new System.EventHandler(this.picBox_Logo_Click);
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_TitleBar.Controls.Add(this.iconMinimize);
            this.panel_TitleBar.Controls.Add(this.iconMaximine);
            this.panel_TitleBar.Controls.Add(this.iconExit);
            this.panel_TitleBar.Controls.Add(this.lbl_titleChildForm);
            this.panel_TitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(249, 0);
            this.panel_TitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(972, 75);
            this.panel_TitleBar.TabIndex = 1;
            this.panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseDown);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconMinimize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 35;
            this.iconMinimize.Location = new System.Drawing.Point(869, 0);
            this.iconMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(35, 37);
            this.iconMinimize.TabIndex = 2;
            this.iconMinimize.TabStop = false;
            this.toolTipMinimize.SetToolTip(this.iconMinimize, " ");
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            this.iconMinimize.MouseLeave += new System.EventHandler(this.iconMinimize_MouseLeave);
            this.iconMinimize.MouseHover += new System.EventHandler(this.iconMinimize_MouseHover);
            // 
            // iconMaximine
            // 
            this.iconMaximine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMaximine.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconMaximine.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximine.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconMaximine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximine.IconSize = 35;
            this.iconMaximine.Location = new System.Drawing.Point(901, 0);
            this.iconMaximine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconMaximine.Name = "iconMaximine";
            this.iconMaximine.Size = new System.Drawing.Size(35, 37);
            this.iconMaximine.TabIndex = 2;
            this.iconMaximine.TabStop = false;
            this.toolTipFullScreen.SetToolTip(this.iconMaximine, " ");
            this.iconMaximine.Click += new System.EventHandler(this.iconMaximine_Click);
            this.iconMaximine.MouseLeave += new System.EventHandler(this.iconMaximine_MouseLeave);
            this.iconMaximine.MouseHover += new System.EventHandler(this.iconMaximine_MouseHover);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconExit.ForeColor = System.Drawing.Color.DarkRed;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconExit.IconColor = System.Drawing.Color.DarkRed;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 37;
            this.iconExit.Location = new System.Drawing.Point(932, 0);
            this.iconExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(40, 37);
            this.iconExit.TabIndex = 2;
            this.iconExit.TabStop = false;
            this.toolTipforBtnExit.SetToolTip(this.iconExit, " ");
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            this.iconExit.MouseLeave += new System.EventHandler(this.iconExit_MouseLeave);
            this.iconExit.MouseHover += new System.EventHandler(this.iconExit_MouseHover);
            // 
            // lbl_titleChildForm
            // 
            this.lbl_titleChildForm.AutoSize = true;
            this.lbl_titleChildForm.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_titleChildForm.Location = new System.Drawing.Point(37, 22);
            this.lbl_titleChildForm.Name = "lbl_titleChildForm";
            this.lbl_titleChildForm.Size = new System.Drawing.Size(103, 28);
            this.lbl_titleChildForm.TabIndex = 1;
            this.lbl_titleChildForm.Text = "Trang Chủ";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 33;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 22);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(39, 33);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // toolTipforBtnExit
            // 
            this.toolTipforBtnExit.AutomaticDelay = 0;
            this.toolTipforBtnExit.AutoPopDelay = 5000;
            this.toolTipforBtnExit.InitialDelay = 200;
            this.toolTipforBtnExit.ReshowDelay = 40;
            this.toolTipforBtnExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipforBtnExit.ToolTipTitle = "Đóng ứng dụng";
            // 
            // toolTipFullScreen
            // 
            this.toolTipFullScreen.AutomaticDelay = 0;
            this.toolTipFullScreen.AutoPopDelay = 5000;
            this.toolTipFullScreen.InitialDelay = 0;
            this.toolTipFullScreen.ReshowDelay = 0;
            this.toolTipFullScreen.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipFullScreen.ToolTipTitle = "Thay đổi kích thước cửa sổ";
            // 
            // toolTipNormalScreen
            // 
            this.toolTipNormalScreen.AutomaticDelay = 0;
            this.toolTipNormalScreen.AutoPopDelay = 5000;
            this.toolTipNormalScreen.InitialDelay = 0;
            this.toolTipNormalScreen.ReshowDelay = 0;
            this.toolTipNormalScreen.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipNormalScreen.ToolTipTitle = "Thu nhỏ cửa sổ";
            // 
            // toolTipMinimize
            // 
            this.toolTipMinimize.AutomaticDelay = 0;
            this.toolTipMinimize.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMinimize.ToolTipTitle = "Ẩn xuống thanh taskbar";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(249, 75);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(971, 624);
            this.panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 699);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NLUForm";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private FontAwesome.Sharp.IconButton btnMenu_About;
        private FontAwesome.Sharp.IconButton btnMenu_Profile;
        private FontAwesome.Sharp.IconButton btnMenu_HocPhi;
        private FontAwesome.Sharp.IconButton btnMenu_LichThi;
        private FontAwesome.Sharp.IconButton btnMenu_TKB;
        private FontAwesome.Sharp.IconButton btnMenu_Home;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label lbl_titleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconPictureBox iconMaximine;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private System.Windows.Forms.ToolTip toolTipforBtnExit;
        private System.Windows.Forms.ToolTip toolTipFullScreen;
        private System.Windows.Forms.ToolTip toolTipNormalScreen;
        private System.Windows.Forms.ToolTip toolTipMinimize;
        private Panel panelDesktop;
        //var bmp = new Bitmap(NLUSchedule.Properties.Resources.logoNLU);
        //this.picBox_Logo.Image = bmp;
    }
}

