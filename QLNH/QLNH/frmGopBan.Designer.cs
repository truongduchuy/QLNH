namespace QLNH
{
    partial class frmGopBan
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBanGop = new System.Windows.Forms.ComboBox();
            this.cmbBanMuonGop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBanGop
            // 
            this.cmbBanGop.FormattingEnabled = true;
            this.cmbBanGop.Location = new System.Drawing.Point(273, 67);
            this.cmbBanGop.Name = "cmbBanGop";
            this.cmbBanGop.Size = new System.Drawing.Size(121, 21);
            this.cmbBanGop.TabIndex = 6;
            // 
            // cmbBanMuonGop
            // 
            this.cmbBanMuonGop.FormattingEnabled = true;
            this.cmbBanMuonGop.Location = new System.Drawing.Point(38, 67);
            this.cmbBanMuonGop.Name = "cmbBanMuonGop";
            this.cmbBanMuonGop.Size = new System.Drawing.Size(121, 21);
            this.cmbBanMuonGop.TabIndex = 5;
            this.cmbBanMuonGop.SelectedIndexChanged += new System.EventHandler(this.cmbBanMuonGop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gộp vào";
            // 
            // frmGopBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 164);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBanGop);
            this.Controls.Add(this.cmbBanMuonGop);
            this.Controls.Add(this.label1);
            this.Name = "frmGopBan";
            this.Text = "frmGopBan";
            this.Load += new System.EventHandler(this.frmGopBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBanGop;
        private System.Windows.Forms.ComboBox cmbBanMuonGop;
        private System.Windows.Forms.Label label1;
    }
}