namespace HotelManagement.Forms
{
    partial class RoomForm
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
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.GridViewRooms = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBKindOfRom = new System.Windows.Forms.ComboBox();
            this.CBRoomStatus = new System.Windows.Forms.ComboBox();
            this.BtnReload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnRoomTypes = new System.Windows.Forms.Button();
            this.BtnRoomStatuses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRooms)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(34, 340);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(412, 47);
            this.TbDescription.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(29, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ghi Chú";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.Location = new System.Drawing.Point(167, 452);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(274, 36);
            this.BtnBack.TabIndex = 47;
            this.BtnBack.Text = "Trở lại";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRemove.Location = new System.Drawing.Point(307, 399);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(134, 36);
            this.BtnRemove.TabIndex = 46;
            this.BtnRemove.Text = "Xóa";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEdit.Location = new System.Drawing.Point(168, 399);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(127, 36);
            this.BtnEdit.TabIndex = 45;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnInsert.Location = new System.Drawing.Point(29, 399);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(127, 36);
            this.BtnInsert.TabIndex = 44;
            this.BtnInsert.Text = "Thêm";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // GridViewRooms
            // 
            this.GridViewRooms.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRooms.Location = new System.Drawing.Point(465, 208);
            this.GridViewRooms.Name = "GridViewRooms";
            this.GridViewRooms.RowHeadersWidth = 51;
            this.GridViewRooms.RowTemplate.Height = 24;
            this.GridViewRooms.Size = new System.Drawing.Size(642, 292);
            this.GridViewRooms.TabIndex = 43;
            this.GridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRooms_CellClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(248, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tình Trạng";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "Loại Phòng";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(253, 200);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(193, 31);
            this.TBName.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên Phòng";
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(29, 200);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(193, 31);
            this.TBId.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã Phòng";
            // 
            // CBKindOfRom
            // 
            this.CBKindOfRom.FormattingEnabled = true;
            this.CBKindOfRom.Location = new System.Drawing.Point(29, 268);
            this.CBKindOfRom.Name = "CBKindOfRom";
            this.CBKindOfRom.Size = new System.Drawing.Size(193, 35);
            this.CBKindOfRom.TabIndex = 50;
            // 
            // CBRoomStatus
            // 
            this.CBRoomStatus.FormattingEnabled = true;
            this.CBRoomStatus.Location = new System.Drawing.Point(253, 268);
            this.CBRoomStatus.Name = "CBRoomStatus";
            this.CBRoomStatus.Size = new System.Drawing.Size(193, 35);
            this.CBRoomStatus.TabIndex = 51;
            // 
            // BtnReload
            // 
            this.BtnReload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnReload.Location = new System.Drawing.Point(29, 452);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(132, 36);
            this.BtnReload.TabIndex = 52;
            this.BtnReload.Text = "Tải Lại";
            this.BtnReload.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 92);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(485, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 44);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quản Lý Phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 36);
            this.textBox1.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(975, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 56;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnRoomTypes
            // 
            this.BtnRoomTypes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRoomTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRoomTypes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRoomTypes.Location = new System.Drawing.Point(465, 124);
            this.BtnRoomTypes.Name = "BtnRoomTypes";
            this.BtnRoomTypes.Size = new System.Drawing.Size(318, 36);
            this.BtnRoomTypes.TabIndex = 60;
            this.BtnRoomTypes.Text = "Quản Lý Loại Phòng";
            this.BtnRoomTypes.UseVisualStyleBackColor = false;
            this.BtnRoomTypes.Click += new System.EventHandler(this.BtnRoomTypes_Click);
            // 
            // BtnRoomStatuses
            // 
            this.BtnRoomStatuses.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRoomStatuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRoomStatuses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRoomStatuses.Location = new System.Drawing.Point(789, 124);
            this.BtnRoomStatuses.Name = "BtnRoomStatuses";
            this.BtnRoomStatuses.Size = new System.Drawing.Size(318, 36);
            this.BtnRoomStatuses.TabIndex = 59;
            this.BtnRoomStatuses.Text = "Quản Lý Trạng Thái Phòng";
            this.BtnRoomStatuses.UseVisualStyleBackColor = false;
            this.BtnRoomStatuses.Click += new System.EventHandler(this.BtnRoomStatuses_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1128, 529);
            this.Controls.Add(this.BtnRoomTypes);
            this.Controls.Add(this.BtnRoomStatuses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.CBRoomStatus);
            this.Controls.Add(this.CBKindOfRom);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.GridViewRooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRooms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.DataGridView GridViewRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBKindOfRom;
        private System.Windows.Forms.ComboBox CBRoomStatus;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRoomTypes;
        private System.Windows.Forms.Button BtnRoomStatuses;
    }
}