namespace QLNH
{
    partial class frmBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchBan = new System.Windows.Forms.TextBox();
            this.btnSearchBan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvBan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnShowBan = new System.Windows.Forms.Button();
            this.btnDeleteBan = new System.Windows.Forms.Button();
            this.btnEditBan = new System.Windows.Forms.Button();
            this.btnAddBan = new System.Windows.Forms.Button();
            this.rdTrong = new System.Windows.Forms.RadioButton();
            this.rdCoNguoi = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(464, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 362);
            this.panel6.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdCoNguoi);
            this.panel1.Controls.Add(this.rdTrong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 76);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình Trạng";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTenBan);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 46);
            this.panel8.TabIndex = 2;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(134, 9);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(147, 20);
            this.txtTenBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Bàn";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMaban);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 46);
            this.panel7.TabIndex = 1;
            // 
            // txtMaban
            // 
            this.txtMaban.Enabled = false;
            this.txtMaban.Location = new System.Drawing.Point(134, 9);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.ReadOnly = true;
            this.txtMaban.Size = new System.Drawing.Size(147, 20);
            this.txtMaban.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bàn";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchBan);
            this.panel5.Controls.Add(this.btnSearchBan);
            this.panel5.Location = new System.Drawing.Point(464, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 63);
            this.panel5.TabIndex = 16;
            // 
            // txtSearchBan
            // 
            this.txtSearchBan.Location = new System.Drawing.Point(3, 22);
            this.txtSearchBan.Name = "txtSearchBan";
            this.txtSearchBan.Size = new System.Drawing.Size(208, 20);
            this.txtSearchBan.TabIndex = 5;
            // 
            // btnSearchBan
            // 
            this.btnSearchBan.Location = new System.Drawing.Point(236, 12);
            this.btnSearchBan.Name = "btnSearchBan";
            this.btnSearchBan.Size = new System.Drawing.Size(67, 39);
            this.btnSearchBan.TabIndex = 4;
            this.btnSearchBan.Text = "Tìm ";
            this.btnSearchBan.UseVisualStyleBackColor = true;
            this.btnSearchBan.Click += new System.EventHandler(this.btnSearchBan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvBan);
            this.panel4.Location = new System.Drawing.Point(30, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 362);
            this.panel4.TabIndex = 17;
            // 
            // dtgvBan
            // 
            this.dtgvBan.AllowUserToAddRows = false;
            this.dtgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvBan.Location = new System.Drawing.Point(6, 3);
            this.dtgvBan.Name = "dtgvBan";
            this.dtgvBan.Size = new System.Drawing.Size(401, 346);
            this.dtgvBan.TabIndex = 0;
            this.dtgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBan_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTaoMoi);
            this.panel3.Controls.Add(this.btnShowBan);
            this.panel3.Controls.Add(this.btnDeleteBan);
            this.panel3.Controls.Add(this.btnEditBan);
            this.panel3.Controls.Add(this.btnAddBan);
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
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnShowBan
            // 
            this.btnShowBan.Location = new System.Drawing.Point(346, 12);
            this.btnShowBan.Name = "btnShowBan";
            this.btnShowBan.Size = new System.Drawing.Size(67, 39);
            this.btnShowBan.TabIndex = 4;
            this.btnShowBan.Text = "Xem";
            this.btnShowBan.UseVisualStyleBackColor = true;
            this.btnShowBan.Click += new System.EventHandler(this.btnShowBan_Click);
            // 
            // btnDeleteBan
            // 
            this.btnDeleteBan.Location = new System.Drawing.Point(180, 12);
            this.btnDeleteBan.Name = "btnDeleteBan";
            this.btnDeleteBan.Size = new System.Drawing.Size(67, 39);
            this.btnDeleteBan.TabIndex = 2;
            this.btnDeleteBan.Text = "Xóa";
            this.btnDeleteBan.UseVisualStyleBackColor = true;
            this.btnDeleteBan.Click += new System.EventHandler(this.btnDeleteBan_Click);
            // 
            // btnEditBan
            // 
            this.btnEditBan.Location = new System.Drawing.Point(267, 12);
            this.btnEditBan.Name = "btnEditBan";
            this.btnEditBan.Size = new System.Drawing.Size(67, 39);
            this.btnEditBan.TabIndex = 1;
            this.btnEditBan.Text = "Sửa";
            this.btnEditBan.UseVisualStyleBackColor = true;
            this.btnEditBan.Click += new System.EventHandler(this.btnEditBan_Click);
            // 
            // btnAddBan
            // 
            this.btnAddBan.Location = new System.Drawing.Point(92, 12);
            this.btnAddBan.Name = "btnAddBan";
            this.btnAddBan.Size = new System.Drawing.Size(67, 39);
            this.btnAddBan.TabIndex = 0;
            this.btnAddBan.Text = "Thêm";
            this.btnAddBan.UseVisualStyleBackColor = true;
            this.btnAddBan.Click += new System.EventHandler(this.btnAddBan_Click);
            // 
            // rdTrong
            // 
            this.rdTrong.AutoSize = true;
            this.rdTrong.Checked = true;
            this.rdTrong.Location = new System.Drawing.Point(8, 46);
            this.rdTrong.Name = "rdTrong";
            this.rdTrong.Size = new System.Drawing.Size(53, 17);
            this.rdTrong.TabIndex = 1;
            this.rdTrong.TabStop = true;
            this.rdTrong.Text = "Trống";
            this.rdTrong.UseVisualStyleBackColor = true;
            // 
            // rdCoNguoi
            // 
            this.rdCoNguoi.AutoSize = true;
            this.rdCoNguoi.Location = new System.Drawing.Point(170, 46);
            this.rdCoNguoi.Name = "rdCoNguoi";
            this.rdCoNguoi.Size = new System.Drawing.Size(67, 17);
            this.rdCoNguoi.TabIndex = 2;
            this.rdCoNguoi.TabStop = true;
            this.rdCoNguoi.Text = "Có người";
            this.rdCoNguoi.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Bàn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Bàn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tình Trạng";
            this.Column3.Name = "Column3";
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdCoNguoi;
        private System.Windows.Forms.RadioButton rdTrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchBan;
        private System.Windows.Forms.Button btnSearchBan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnShowBan;
        private System.Windows.Forms.Button btnDeleteBan;
        private System.Windows.Forms.Button btnEditBan;
        private System.Windows.Forms.Button btnAddBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}