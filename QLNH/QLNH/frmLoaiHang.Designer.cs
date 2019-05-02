namespace QLNH
{
    partial class frmLoaiHang
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchLH = new System.Windows.Forms.TextBox();
            this.btnSearchLH = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteLH = new System.Windows.Forms.Button();
            this.btnEditLH = new System.Windows.Forms.Button();
            this.btnAddLH = new System.Windows.Forms.Button();
            this.btnShowLH = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(455, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 362);
            this.panel6.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTenLH);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 46);
            this.panel8.TabIndex = 2;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(134, 9);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(147, 20);
            this.txtTenLH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Hàng";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMaLH);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 46);
            this.panel7.TabIndex = 1;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Enabled = false;
            this.txtMaLH.Location = new System.Drawing.Point(134, 9);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.ReadOnly = true;
            this.txtMaLH.Size = new System.Drawing.Size(147, 20);
            this.txtMaLH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Hàng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchLH);
            this.panel5.Controls.Add(this.btnSearchLH);
            this.panel5.Location = new System.Drawing.Point(455, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 63);
            this.panel5.TabIndex = 12;
            // 
            // txtSearchLH
            // 
            this.txtSearchLH.Location = new System.Drawing.Point(3, 22);
            this.txtSearchLH.Name = "txtSearchLH";
            this.txtSearchLH.Size = new System.Drawing.Size(208, 20);
            this.txtSearchLH.TabIndex = 5;
            // 
            // btnSearchLH
            // 
            this.btnSearchLH.Location = new System.Drawing.Point(229, 3);
            this.btnSearchLH.Name = "btnSearchLH";
            this.btnSearchLH.Size = new System.Drawing.Size(74, 57);
            this.btnSearchLH.TabIndex = 4;
            this.btnSearchLH.Text = "Tìm ";
            this.btnSearchLH.UseVisualStyleBackColor = true;
            this.btnSearchLH.Click += new System.EventHandler(this.btnSearchLH_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvLoaiHang);
            this.panel4.Location = new System.Drawing.Point(39, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 362);
            this.panel4.TabIndex = 13;
            // 
            // dtgvLoaiHang
            // 
            this.dtgvLoaiHang.AllowUserToAddRows = false;
            this.dtgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dtgvLoaiHang.Location = new System.Drawing.Point(6, 3);
            this.dtgvLoaiHang.Name = "dtgvLoaiHang";
            this.dtgvLoaiHang.Size = new System.Drawing.Size(401, 346);
            this.dtgvLoaiHang.TabIndex = 0;
            this.dtgvLoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiHang_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Loại Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Loại Hàng";
            this.Column1.Name = "Column1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowLH);
            this.panel3.Controls.Add(this.btnDeleteLH);
            this.panel3.Controls.Add(this.btnEditLH);
            this.panel3.Controls.Add(this.btnAddLH);
            this.panel3.Location = new System.Drawing.Point(39, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 63);
            this.panel3.TabIndex = 10;
            // 
            // btnDeleteLH
            // 
            this.btnDeleteLH.Location = new System.Drawing.Point(101, 3);
            this.btnDeleteLH.Name = "btnDeleteLH";
            this.btnDeleteLH.Size = new System.Drawing.Size(74, 57);
            this.btnDeleteLH.TabIndex = 2;
            this.btnDeleteLH.Text = "Xóa";
            this.btnDeleteLH.UseVisualStyleBackColor = true;
            this.btnDeleteLH.Click += new System.EventHandler(this.btnDeleteLH_Click);
            // 
            // btnEditLH
            // 
            this.btnEditLH.Location = new System.Drawing.Point(194, 3);
            this.btnEditLH.Name = "btnEditLH";
            this.btnEditLH.Size = new System.Drawing.Size(74, 57);
            this.btnEditLH.TabIndex = 1;
            this.btnEditLH.Text = "Sửa";
            this.btnEditLH.UseVisualStyleBackColor = true;
            this.btnEditLH.Click += new System.EventHandler(this.btnEditLH_Click);
            // 
            // btnAddLH
            // 
            this.btnAddLH.Location = new System.Drawing.Point(6, 3);
            this.btnAddLH.Name = "btnAddLH";
            this.btnAddLH.Size = new System.Drawing.Size(74, 57);
            this.btnAddLH.TabIndex = 0;
            this.btnAddLH.Text = "Thêm";
            this.btnAddLH.UseVisualStyleBackColor = true;
            this.btnAddLH.Click += new System.EventHandler(this.btnAddLH_Click);
            // 
            // btnShowLH
            // 
            this.btnShowLH.Location = new System.Drawing.Point(292, 3);
            this.btnShowLH.Name = "btnShowLH";
            this.btnShowLH.Size = new System.Drawing.Size(74, 57);
            this.btnShowLH.TabIndex = 3;
            this.btnShowLH.Text = "Xem";
            this.btnShowLH.UseVisualStyleBackColor = true;
            this.btnShowLH.Click += new System.EventHandler(this.btnShowLH_Click);
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmLoaiHang";
            this.Text = "frmLoaiHang";
            this.Load += new System.EventHandler(this.frmLoaiHang_Load);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchLH;
        private System.Windows.Forms.Button btnSearchLH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvLoaiHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteLH;
        private System.Windows.Forms.Button btnEditLH;
        private System.Windows.Forms.Button btnAddLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnShowLH;
    }
}