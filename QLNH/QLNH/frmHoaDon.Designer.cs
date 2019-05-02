namespace QLNH
{
    partial class frmHoaDon
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbTenDangNhap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdUnCheckOut = new System.Windows.Forms.RadioButton();
            this.rdCheckOut = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpkNgayHD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpkSearchHD = new System.Windows.Forms.DateTimePicker();
            this.btnSearchHD = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnShowHD = new System.Windows.Forms.Button();
            this.btnDeleteHD = new System.Windows.Forms.Button();
            this.btnEditHD = new System.Windows.Forms.Button();
            this.btnAddHD = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(464, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 362);
            this.panel6.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cmbTenDangNhap);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(3, 236);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(284, 53);
            this.panel10.TabIndex = 4;
            // 
            // cmbTenDangNhap
            // 
            this.cmbTenDangNhap.FormattingEnabled = true;
            this.cmbTenDangNhap.Location = new System.Drawing.Point(137, 11);
            this.cmbTenDangNhap.Name = "cmbTenDangNhap";
            this.cmbTenDangNhap.Size = new System.Drawing.Size(144, 21);
            this.cmbTenDangNhap.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbBan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 53);
            this.panel2.TabIndex = 4;
            // 
            // cmbBan
            // 
            this.cmbBan.FormattingEnabled = true;
            this.cmbBan.Location = new System.Drawing.Point(134, 11);
            this.cmbBan.Name = "cmbBan";
            this.cmbBan.Size = new System.Drawing.Size(144, 21);
            this.cmbBan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Bàn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdUnCheckOut);
            this.panel1.Controls.Add(this.rdCheckOut);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 53);
            this.panel1.TabIndex = 3;
            // 
            // rdUnCheckOut
            // 
            this.rdUnCheckOut.AutoSize = true;
            this.rdUnCheckOut.Checked = true;
            this.rdUnCheckOut.Location = new System.Drawing.Point(169, 33);
            this.rdUnCheckOut.Name = "rdUnCheckOut";
            this.rdUnCheckOut.Size = new System.Drawing.Size(104, 17);
            this.rdUnCheckOut.TabIndex = 2;
            this.rdUnCheckOut.TabStop = true;
            this.rdUnCheckOut.Text = "Chưa thanh toán";
            this.rdUnCheckOut.UseVisualStyleBackColor = true;
            // 
            // rdCheckOut
            // 
            this.rdCheckOut.AutoSize = true;
            this.rdCheckOut.Location = new System.Drawing.Point(9, 33);
            this.rdCheckOut.Name = "rdCheckOut";
            this.rdCheckOut.Size = new System.Drawing.Size(93, 17);
            this.rdCheckOut.TabIndex = 1;
            this.rdCheckOut.Text = "Đã thanh toán";
            this.rdCheckOut.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình Trạng";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtpkNgayHD);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 46);
            this.panel8.TabIndex = 2;
            // 
            // dtpkNgayHD
            // 
            this.dtpkNgayHD.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpkNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayHD.Location = new System.Drawing.Point(134, 10);
            this.dtpkNgayHD.Name = "dtpkNgayHD";
            this.dtpkNgayHD.Size = new System.Drawing.Size(147, 20);
            this.dtpkNgayHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Lập ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMaHD);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 46);
            this.panel7.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(134, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(144, 20);
            this.txtMaHD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpkSearchHD);
            this.panel5.Controls.Add(this.btnSearchHD);
            this.panel5.Location = new System.Drawing.Point(464, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 63);
            this.panel5.TabIndex = 16;
            // 
            // dtpkSearchHD
            // 
            this.dtpkSearchHD.CustomFormat = "MM/dd/yyyy";
            this.dtpkSearchHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkSearchHD.Location = new System.Drawing.Point(10, 19);
            this.dtpkSearchHD.Name = "dtpkSearchHD";
            this.dtpkSearchHD.Size = new System.Drawing.Size(200, 20);
            this.dtpkSearchHD.TabIndex = 5;
            // 
            // btnSearchHD
            // 
            this.btnSearchHD.Location = new System.Drawing.Point(220, 12);
            this.btnSearchHD.Name = "btnSearchHD";
            this.btnSearchHD.Size = new System.Drawing.Size(67, 39);
            this.btnSearchHD.TabIndex = 4;
            this.btnSearchHD.Text = "Tìm ";
            this.btnSearchHD.UseVisualStyleBackColor = true;
            this.btnSearchHD.Click += new System.EventHandler(this.btnSearchHH_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvHoaDon);
            this.panel4.Location = new System.Drawing.Point(30, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 362);
            this.panel4.TabIndex = 17;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToAddRows = false;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvHoaDon.Location = new System.Drawing.Point(6, 3);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.Size = new System.Drawing.Size(401, 346);
            this.dtgvHoaDon.TabIndex = 0;
            this.dtgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Bàn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tình Trạng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên Bàn";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Đăng Nhập";
            this.Column5.Name = "Column5";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTaoMoi);
            this.panel3.Controls.Add(this.btnShowHD);
            this.panel3.Controls.Add(this.btnDeleteHD);
            this.panel3.Controls.Add(this.btnEditHD);
            this.panel3.Controls.Add(this.btnAddHD);
            this.panel3.Location = new System.Drawing.Point(30, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 63);
            this.panel3.TabIndex = 14;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(6, 12);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(67, 39);
            this.btnTaoMoi.TabIndex = 5;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowHD
            // 
            this.btnShowHD.Location = new System.Drawing.Point(346, 12);
            this.btnShowHD.Name = "btnShowHD";
            this.btnShowHD.Size = new System.Drawing.Size(67, 39);
            this.btnShowHD.TabIndex = 4;
            this.btnShowHD.Text = "Xem";
            this.btnShowHD.UseVisualStyleBackColor = true;
            this.btnShowHD.Click += new System.EventHandler(this.btnShowHH_Click);
            // 
            // btnDeleteHD
            // 
            this.btnDeleteHD.Location = new System.Drawing.Point(180, 12);
            this.btnDeleteHD.Name = "btnDeleteHD";
            this.btnDeleteHD.Size = new System.Drawing.Size(67, 39);
            this.btnDeleteHD.TabIndex = 2;
            this.btnDeleteHD.Text = "Xóa";
            this.btnDeleteHD.UseVisualStyleBackColor = true;
            this.btnDeleteHD.Click += new System.EventHandler(this.btnDeleteHH_Click);
            // 
            // btnEditHD
            // 
            this.btnEditHD.Location = new System.Drawing.Point(267, 12);
            this.btnEditHD.Name = "btnEditHD";
            this.btnEditHD.Size = new System.Drawing.Size(67, 39);
            this.btnEditHD.TabIndex = 1;
            this.btnEditHD.Text = "Sửa";
            this.btnEditHD.UseVisualStyleBackColor = true;
            this.btnEditHD.Click += new System.EventHandler(this.btnEditHH_Click);
            // 
            // btnAddHD
            // 
            this.btnAddHD.Enabled = false;
            this.btnAddHD.Location = new System.Drawing.Point(92, 12);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(67, 39);
            this.btnAddHD.TabIndex = 0;
            this.btnAddHD.Text = "Thêm";
            this.btnAddHD.UseVisualStyleBackColor = true;
            this.btnAddHD.Click += new System.EventHandler(this.btnAddHH_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cmbTenDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchHD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnShowHD;
        private System.Windows.Forms.Button btnDeleteHD;
        private System.Windows.Forms.Button btnEditHD;
        private System.Windows.Forms.Button btnAddHD;
        private System.Windows.Forms.ComboBox cmbBan;
        private System.Windows.Forms.RadioButton rdUnCheckOut;
        private System.Windows.Forms.RadioButton rdCheckOut;
        private System.Windows.Forms.DateTimePicker dtpkNgayHD;
        private System.Windows.Forms.DateTimePicker dtpkSearchHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtMaHD;
    }
}