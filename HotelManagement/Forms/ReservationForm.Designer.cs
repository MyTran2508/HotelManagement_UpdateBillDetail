namespace HotelManagement.Forms
{
    partial class ReservationForm
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
            this.CBRoomId = new System.Windows.Forms.ComboBox();
            this.CBEmployeeId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTOut = new System.Windows.Forms.DateTimePicker();
            this.DTIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCustomerId = new System.Windows.Forms.ComboBox();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridViewReservation = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnBill = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // CBRoomId
            // 
            this.CBRoomId.FormattingEnabled = true;
            this.CBRoomId.Location = new System.Drawing.Point(580, 134);
            this.CBRoomId.Name = "CBRoomId";
            this.CBRoomId.Size = new System.Drawing.Size(263, 37);
            this.CBRoomId.TabIndex = 72;
            // 
            // CBEmployeeId
            // 
            this.CBEmployeeId.FormattingEnabled = true;
            this.CBEmployeeId.Location = new System.Drawing.Point(297, 134);
            this.CBEmployeeId.Name = "CBEmployeeId";
            this.CBEmployeeId.Size = new System.Drawing.Size(263, 37);
            this.CBEmployeeId.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(580, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 31);
            this.label6.TabIndex = 69;
            this.label6.Text = "Ngày Trả";
            // 
            // DTOut
            // 
            this.DTOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTOut.Location = new System.Drawing.Point(585, 198);
            this.DTOut.Name = "DTOut";
            this.DTOut.Size = new System.Drawing.Size(258, 35);
            this.DTOut.TabIndex = 70;
            // 
            // DTIn
            // 
            this.DTIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTIn.Location = new System.Drawing.Point(297, 198);
            this.DTIn.Name = "DTIn";
            this.DTIn.Size = new System.Drawing.Size(263, 35);
            this.DTIn.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(457, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 46);
            this.label1.TabIndex = 52;
            this.label1.Text = "Quản Lý Đặt Phòng";
            // 
            // CBCustomerId
            // 
            this.CBCustomerId.FormattingEnabled = true;
            this.CBCustomerId.Location = new System.Drawing.Point(12, 198);
            this.CBCustomerId.Name = "CBCustomerId";
            this.CBCustomerId.Size = new System.Drawing.Size(263, 37);
            this.CBCustomerId.TabIndex = 67;
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(12, 134);
            this.TBId.Multiline = true;
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(263, 35);
            this.TBId.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(292, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(580, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "Số Phòng";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 27);
            this.label5.TabIndex = 58;
            this.label5.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã Đăng Ký";
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnInsert.Location = new System.Drawing.Point(849, 132);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(132, 36);
            this.BtnInsert.TabIndex = 60;
            this.BtnInsert.Text = "Thêm";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEdit.Location = new System.Drawing.Point(984, 132);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(132, 36);
            this.BtnEdit.TabIndex = 61;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(849, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 36);
            this.button3.TabIndex = 62;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 36);
            this.button4.TabIndex = 63;
            this.button4.Text = "Trở lại";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(292, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 31);
            this.label7.TabIndex = 64;
            this.label7.Text = "Ngày Thuê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 95);
            this.panel1.TabIndex = 73;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GridViewReservation
            // 
            this.GridViewReservation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewReservation.Location = new System.Drawing.Point(12, 255);
            this.GridViewReservation.Name = "GridViewReservation";
            this.GridViewReservation.RowHeadersWidth = 51;
            this.GridViewReservation.RowTemplate.Height = 24;
            this.GridViewReservation.Size = new System.Drawing.Size(1104, 311);
            this.GridViewReservation.TabIndex = 74;
            this.GridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewReservation_CellClick);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Location = new System.Drawing.Point(12, 572);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(132, 36);
            this.BtnBack.TabIndex = 75;
            this.BtnBack.Text = "Trở Lại";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnBill
            // 
            this.BtnBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBill.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBill.Location = new System.Drawing.Point(889, 572);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(227, 36);
            this.BtnBill.TabIndex = 76;
            this.BtnBill.Text = "Đi Tới Thanh Toán";
            this.BtnBill.UseVisualStyleBackColor = false;
            this.BtnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(984, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 36);
            this.button5.TabIndex = 77;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1128, 637);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnBill);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GridViewReservation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBRoomId);
            this.Controls.Add(this.CBEmployeeId);
            this.Controls.Add(this.DTOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTIn);
            this.Controls.Add(this.CBCustomerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đặt Phòng";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBRoomId;
        private System.Windows.Forms.ComboBox CBEmployeeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTOut;
        private System.Windows.Forms.DateTimePicker DTIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBCustomerId;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridViewReservation;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnBill;
        private System.Windows.Forms.Button button5;
    }
}