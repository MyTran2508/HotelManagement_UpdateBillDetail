﻿namespace HotelManagement.Forms
{
    partial class KindOfRoomForm
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
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.GridViewKORooms = new System.Windows.Forms.DataGridView();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbMax = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKORooms)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReload
            // 
            this.BtnReload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnReload.Location = new System.Drawing.Point(171, 423);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(132, 36);
            this.BtnReload.TabIndex = 69;
            this.BtnReload.Text = "Tải Lại";
            this.BtnReload.UseVisualStyleBackColor = false;
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(24, 318);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(279, 31);
            this.TBPrice.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Đơn Giá";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Location = new System.Drawing.Point(24, 488);
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
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRemove.Location = new System.Drawing.Point(24, 423);
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
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEdit.Location = new System.Drawing.Point(171, 369);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(132, 36);
            this.BtnEdit.TabIndex = 62;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnInsert.Location = new System.Drawing.Point(24, 369);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(132, 36);
            this.BtnInsert.TabIndex = 61;
            this.BtnInsert.Text = "Thêm";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // GridViewKORooms
            // 
            this.GridViewKORooms.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewKORooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewKORooms.Location = new System.Drawing.Point(334, 136);
            this.GridViewKORooms.Name = "GridViewKORooms";
            this.GridViewKORooms.RowHeadersWidth = 51;
            this.GridViewKORooms.RowTemplate.Height = 24;
            this.GridViewKORooms.Size = new System.Drawing.Size(763, 388);
            this.GridViewKORooms.TabIndex = 60;
            this.GridViewKORooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewKORooms_CellClick);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(24, 194);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(279, 31);
            this.TBName.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên LP";
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(24, 136);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(279, 31);
            this.TBId.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã LP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Quản Lý Loại Phòng";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 58;
            this.label4.Text = "Số Người";
            // 
            // TbMax
            // 
            this.TbMax.Location = new System.Drawing.Point(24, 262);
            this.TbMax.Name = "TbMax";
            this.TbMax.Size = new System.Drawing.Size(279, 31);
            this.TbMax.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 97);
            this.panel1.TabIndex = 71;
            // 
            // KindOfRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1128, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TbMax);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.GridViewKORooms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KindOfRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Loại Phòng";
            this.Load += new System.EventHandler(this.KindOfRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKORooms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.DataGridView GridViewKORooms;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbMax;
        private System.Windows.Forms.Panel panel1;
    }
}