namespace QL_KHACHSAN.View
{
    partial class FrmKhachHang
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
            this.btnHuyKH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.cmbGioiTinhKH = new System.Windows.Forms.ComboBox();
            this.dpNamSinhKH = new System.Windows.Forms.DateTimePicker();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSKH = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyKH
            // 
            this.btnHuyKH.Location = new System.Drawing.Point(674, 129);
            this.btnHuyKH.Name = "btnHuyKH";
            this.btnHuyKH.Size = new System.Drawing.Size(98, 59);
            this.btnHuyKH.TabIndex = 18;
            this.btnHuyKH.Text = "HỦY";
            this.btnHuyKH.UseVisualStyleBackColor = true;
            this.btnHuyKH.Click += new System.EventHandler(this.btnHuyKH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnHuyKH);
            this.groupBox1.Controls.Add(this.btnLuuKH);
            this.groupBox1.Controls.Add(this.btnSuaKH);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.cmbGioiTinhKH);
            this.groupBox1.Controls.Add(this.dpNamSinhKH);
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(632, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Location = new System.Drawing.Point(540, 129);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(98, 59);
            this.btnLuuKH.TabIndex = 17;
            this.btnLuuKH.Text = "LƯU";
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Enabled = false;
            this.btnSuaKH.Location = new System.Drawing.Point(397, 129);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(98, 59);
            this.btnSuaKH.TabIndex = 16;
            this.btnSuaKH.Text = "SỬA";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Enabled = false;
            this.btnXoaKH.Location = new System.Drawing.Point(257, 129);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(98, 59);
            this.btnXoaKH.TabIndex = 15;
            this.btnXoaKH.Text = "XÓA";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Enabled = false;
            this.btnThemKH.Location = new System.Drawing.Point(115, 129);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(98, 59);
            this.btnThemKH.TabIndex = 14;
            this.btnThemKH.Text = "THÊM";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbGioiTinhKH
            // 
            this.cmbGioiTinhKH.Enabled = false;
            this.cmbGioiTinhKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinhKH.FormattingEnabled = true;
            this.cmbGioiTinhKH.Location = new System.Drawing.Point(116, 67);
            this.cmbGioiTinhKH.Name = "cmbGioiTinhKH";
            this.cmbGioiTinhKH.Size = new System.Drawing.Size(121, 27);
            this.cmbGioiTinhKH.TabIndex = 13;
            // 
            // dpNamSinhKH
            // 
            this.dpNamSinhKH.Enabled = false;
            this.dpNamSinhKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNamSinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNamSinhKH.Location = new System.Drawing.Point(623, 29);
            this.dpNamSinhKH.Name = "dpNamSinhKH";
            this.dpNamSinhKH.Size = new System.Drawing.Size(200, 26);
            this.dpNamSinhKH.TabIndex = 12;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Enabled = false;
            this.txtSDTKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(342, 63);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(139, 26);
            this.txtSDTKH.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điện Thoại";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Enabled = false;
            this.txtDiaChiKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(623, 64);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(200, 26);
            this.txtDiaChiKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm Sinh";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(372, 31);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(166, 26);
            this.txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(139, 34);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDSKH);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dtgvDSKH
            // 
            this.dtgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSKH.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSKH.Name = "dtgvDSKH";
            this.dtgvDSKH.Size = new System.Drawing.Size(851, 126);
            this.dtgvDSKH.TabIndex = 0;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuyKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.ComboBox cmbGioiTinhKH;
        private System.Windows.Forms.DateTimePicker dpNamSinhKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSKH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
    }
}