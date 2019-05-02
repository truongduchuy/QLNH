namespace QLNH
{
    partial class frmChuyenBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBanMuonChuyen = new System.Windows.Forms.ComboBox();
            this.cmbBanChuyenDen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển Đến";
            // 
            // cmbBanMuonChuyen
            // 
            this.cmbBanMuonChuyen.FormattingEnabled = true;
            this.cmbBanMuonChuyen.Location = new System.Drawing.Point(21, 58);
            this.cmbBanMuonChuyen.Name = "cmbBanMuonChuyen";
            this.cmbBanMuonChuyen.Size = new System.Drawing.Size(121, 21);
            this.cmbBanMuonChuyen.TabIndex = 1;
            this.cmbBanMuonChuyen.SelectedIndexChanged += new System.EventHandler(this.cmbBanMuonChuyen_SelectedIndexChanged);
            // 
            // cmbBanChuyenDen
            // 
            this.cmbBanChuyenDen.FormattingEnabled = true;
            this.cmbBanChuyenDen.Location = new System.Drawing.Point(256, 58);
            this.cmbBanChuyenDen.Name = "cmbBanChuyenDen";
            this.cmbBanChuyenDen.Size = new System.Drawing.Size(121, 21);
            this.cmbBanChuyenDen.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 138);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBanChuyenDen);
            this.Controls.Add(this.cmbBanMuonChuyen);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenBan";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmChuyenBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBanMuonChuyen;
        private System.Windows.Forms.ComboBox cmbBanChuyenDen;
        private System.Windows.Forms.Button button1;
    }
}