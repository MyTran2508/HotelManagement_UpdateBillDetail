namespace HotelManagement.Forms
{
    partial class BillDetailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TBCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBBillId = new System.Windows.Forms.ComboBox();
            this.GridViewBillDetail = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.CBServiceId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 89);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(285, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Dịch Vụ";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Location = new System.Drawing.Point(19, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(268, 33);
            this.BtnBack.TabIndex = 34;
            this.BtnBack.Text = "Về Trang Chủ";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TBCustomerName
            // 
            this.TBCustomerName.Location = new System.Drawing.Point(105, 144);
            this.TBCustomerName.Name = "TBCustomerName";
            this.TBCustomerName.Size = new System.Drawing.Size(182, 35);
            this.TBCustomerName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên KH";
            // 
            // TBCustomerId
            // 
            this.TBCustomerId.Location = new System.Drawing.Point(105, 107);
            this.TBCustomerId.Name = "TBCustomerId";
            this.TBCustomerId.Size = new System.Drawing.Size(182, 35);
            this.TBCustomerId.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã KH";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBill.Location = new System.Drawing.Point(582, 378);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(256, 37);
            this.btnBill.TabIndex = 24;
            this.btnBill.Text = "Quay Lại Thanh Toán";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hóa Đơn";
            // 
            // CBBillId
            // 
            this.CBBillId.FormattingEnabled = true;
            this.CBBillId.Location = new System.Drawing.Point(19, 242);
            this.CBBillId.Name = "CBBillId";
            this.CBBillId.Size = new System.Drawing.Size(268, 37);
            this.CBBillId.TabIndex = 22;
            this.CBBillId.SelectedIndexChanged += new System.EventHandler(this.CBBillId_SelectedIndexChanged);
            // 
            // GridViewBillDetail
            // 
            this.GridViewBillDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridViewBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBillDetail.Location = new System.Drawing.Point(311, 107);
            this.GridViewBillDetail.Name = "GridViewBillDetail";
            this.GridViewBillDetail.RowHeadersWidth = 51;
            this.GridViewBillDetail.RowTemplate.Height = 24;
            this.GridViewBillDetail.Size = new System.Drawing.Size(527, 259);
            this.GridViewBillDetail.TabIndex = 21;
            this.GridViewBillDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBillDetail_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAdd.Location = new System.Drawing.Point(19, 283);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(119, 33);
            this.BtnAdd.TabIndex = 35;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEdit.Location = new System.Drawing.Point(168, 283);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(119, 33);
            this.BtnEdit.TabIndex = 36;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRemove.Location = new System.Drawing.Point(19, 322);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(119, 33);
            this.BtnRemove.TabIndex = 37;
            this.BtnRemove.Text = "Xóa";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRefresh.Location = new System.Drawing.Point(168, 322);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(119, 33);
            this.BtnRefresh.TabIndex = 38;
            this.BtnRefresh.Text = "Tải Lại";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            // 
            // CBServiceId
            // 
            this.CBServiceId.FormattingEnabled = true;
            this.CBServiceId.Location = new System.Drawing.Point(105, 182);
            this.CBServiceId.Name = "CBServiceId";
            this.CBServiceId.Size = new System.Drawing.Size(182, 37);
            this.CBServiceId.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Dịch Vụ";
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 442);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBServiceId);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TBCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBBillId);
            this.Controls.Add(this.GridViewBillDetail);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillDetail";
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBillDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TBCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBBillId;
        private System.Windows.Forms.DataGridView GridViewBillDetail;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ComboBox CBServiceId;
        private System.Windows.Forms.Label label5;
    }
}