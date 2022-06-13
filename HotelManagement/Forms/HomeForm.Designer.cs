namespace HotelManagement.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRooms = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnReservations = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnAccounts = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnServices = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnBills = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(181, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCustomers.Location = new System.Drawing.Point(93, 111);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(230, 44);
            this.BtnCustomers.TabIndex = 2;
            this.BtnCustomers.Text = "Quản Lý Khách hàng";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmployees.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEmployees.Location = new System.Drawing.Point(93, 167);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Size = new System.Drawing.Size(230, 44);
            this.BtnEmployees.TabIndex = 4;
            this.BtnEmployees.Text = "Quản Lý Nhân Viên";
            this.BtnEmployees.UseVisualStyleBackColor = false;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRooms
            // 
            this.BtnRooms.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRooms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRooms.Location = new System.Drawing.Point(93, 223);
            this.BtnRooms.Name = "BtnRooms";
            this.BtnRooms.Size = new System.Drawing.Size(230, 44);
            this.BtnRooms.TabIndex = 6;
            this.BtnRooms.Text = "Quản Lý Phòng";
            this.BtnRooms.UseVisualStyleBackColor = false;
            this.BtnRooms.Click += new System.EventHandler(this.BtnRooms_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // BtnReservations
            // 
            this.BtnReservations.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservations.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnReservations.Location = new System.Drawing.Point(93, 279);
            this.BtnReservations.Name = "BtnReservations";
            this.BtnReservations.Size = new System.Drawing.Size(230, 44);
            this.BtnReservations.TabIndex = 8;
            this.BtnReservations.Text = "Quản Lý Đặt Phòng";
            this.BtnReservations.UseVisualStyleBackColor = false;
            this.BtnReservations.Click += new System.EventHandler(this.BtnReservations_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLogout.Location = new System.Drawing.Point(281, 338);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(230, 44);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Đăng Xuất";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnAccounts
            // 
            this.BtnAccounts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccounts.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAccounts.Location = new System.Drawing.Point(412, 111);
            this.BtnAccounts.Name = "BtnAccounts";
            this.BtnAccounts.Size = new System.Drawing.Size(230, 44);
            this.BtnAccounts.TabIndex = 11;
            this.BtnAccounts.Text = "Quản Lý Tài Khoản";
            this.BtnAccounts.UseVisualStyleBackColor = false;
            this.BtnAccounts.Click += new System.EventHandler(this.BtnAccounts_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(349, 110);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // BtnServices
            // 
            this.BtnServices.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServices.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnServices.Location = new System.Drawing.Point(412, 167);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(230, 44);
            this.BtnServices.TabIndex = 13;
            this.BtnServices.Text = "Quản Lý Dich Vụ";
            this.BtnServices.UseVisualStyleBackColor = false;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(349, 166);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // BtnBills
            // 
            this.BtnBills.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBills.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBills.Location = new System.Drawing.Point(412, 222);
            this.BtnBills.Name = "BtnBills";
            this.BtnBills.Size = new System.Drawing.Size(230, 44);
            this.BtnBills.TabIndex = 15;
            this.BtnBills.Text = "Quản Lý Hóa Đơn";
            this.BtnBills.UseVisualStyleBackColor = false;
            this.BtnBills.Click += new System.EventHandler(this.BtnBills_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(349, 221);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(57, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(231, 343);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(44, 34);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 95);
            this.panel1.TabIndex = 17;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(681, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.BtnBills);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.BtnServices);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.BtnAccounts);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnReservations);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnRooms);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnEmployees);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnEmployees;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRooms;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnReservations;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnAccounts;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BtnServices;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BtnBills;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel1;
    }
}