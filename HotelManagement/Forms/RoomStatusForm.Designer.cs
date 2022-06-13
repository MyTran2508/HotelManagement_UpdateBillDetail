﻿namespace HotelManagement
{
    partial class RoomStatusForm
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
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.GridViewRoomStatus = new System.Windows.Forms.DataGridView();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRoomStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReload
            // 
            this.BtnReload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnReload.Location = new System.Drawing.Point(183, 310);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(132, 36);
            this.BtnReload.TabIndex = 69;
            this.BtnReload.Text = "Tải Lại";
            this.BtnReload.UseVisualStyleBackColor = false;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.Location = new System.Drawing.Point(36, 375);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(274, 36);
            this.BtnBack.TabIndex = 64;
            this.BtnBack.Text = "Trở lại";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRemove.Location = new System.Drawing.Point(36, 310);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(132, 36);
            this.BtnRemove.TabIndex = 63;
            this.BtnRemove.Text = "Xóa";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEdit.Location = new System.Drawing.Point(183, 256);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(132, 36);
            this.BtnEdit.TabIndex = 62;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // GridViewRoomStatus
            // 
            this.GridViewRoomStatus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewRoomStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRoomStatus.Location = new System.Drawing.Point(346, 173);
            this.GridViewRoomStatus.Name = "GridViewRoomStatus";
            this.GridViewRoomStatus.RowHeadersWidth = 51;
            this.GridViewRoomStatus.RowTemplate.Height = 24;
            this.GridViewRoomStatus.Size = new System.Drawing.Size(480, 238);
            this.GridViewRoomStatus.TabIndex = 60;
            this.GridViewRoomStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRoomStatus_CellClick);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(36, 197);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(279, 31);
            this.TBName.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên Trạng Thái";
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(36, 139);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(279, 31);
            this.TBId.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Quản Lý Trạng Thái Phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 31);
            this.textBox1.TabIndex = 70;
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnInsert.Location = new System.Drawing.Point(36, 256);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(132, 36);
            this.BtnInsert.TabIndex = 61;
            this.BtnInsert.Text = "Thêm";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(663, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 71;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 99);
            this.panel1.TabIndex = 72;
            // 
            // RoomStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(861, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.GridViewRoomStatus);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomStatusForm";
            this.Load += new System.EventHandler(this.RoomStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRoomStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridView GridViewRoomStatus;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}