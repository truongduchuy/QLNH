﻿namespace QLNH
{
    partial class frmHuyBan
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
            this.cmbBanCoNguoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBanCoNguoi
            // 
            this.cmbBanCoNguoi.FormattingEnabled = true;
            this.cmbBanCoNguoi.Location = new System.Drawing.Point(55, 52);
            this.cmbBanCoNguoi.Name = "cmbBanCoNguoi";
            this.cmbBanCoNguoi.Size = new System.Drawing.Size(121, 21);
            this.cmbBanCoNguoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Bàn Muốn Hủy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHuyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBanCoNguoi);
            this.Name = "frmHuyBan";
            this.Text = "frmHuyBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHuyBan_FormClosing);
            this.Load += new System.EventHandler(this.frmHuyBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBanCoNguoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}