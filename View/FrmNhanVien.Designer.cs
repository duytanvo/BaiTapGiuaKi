namespace QL_KHACHSAN.View
{
    partial class FrmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuyNV = new System.Windows.Forms.Button();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.cmbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.dpNamSinhNV = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoaiNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSNV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHuyNV);
            this.groupBox1.Controls.Add(this.btnLuuNV);
            this.groupBox1.Controls.Add(this.btnSuaNV);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.cmbGioiTinhNV);
            this.groupBox1.Controls.Add(this.dpNamSinhNV);
            this.groupBox1.Controls.Add(this.txtDienThoaiNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChiNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // txtCa
            // 
            this.txtCa.Enabled = false;
            this.txtCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCa.Location = new System.Drawing.Point(139, 91);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(70, 26);
            this.txtCa.TabIndex = 20;
            this.txtCa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ca Làm Việc";
            // 
            // btnHuyNV
            // 
            this.btnHuyNV.Location = new System.Drawing.Point(674, 122);
            this.btnHuyNV.Name = "btnHuyNV";
            this.btnHuyNV.Size = new System.Drawing.Size(98, 59);
            this.btnHuyNV.TabIndex = 18;
            this.btnHuyNV.Text = "HỦY";
            this.btnHuyNV.UseVisualStyleBackColor = true;
            this.btnHuyNV.Click += new System.EventHandler(this.btnHuyNV_Click);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Location = new System.Drawing.Point(540, 122);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(98, 59);
            this.btnLuuNV.TabIndex = 17;
            this.btnLuuNV.Text = "LƯU";
            this.btnLuuNV.UseVisualStyleBackColor = true;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Enabled = false;
            this.btnSuaNV.Location = new System.Drawing.Point(397, 122);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(98, 59);
            this.btnSuaNV.TabIndex = 16;
            this.btnSuaNV.Text = "SỬA";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Enabled = false;
            this.btnXoaNV.Location = new System.Drawing.Point(257, 122);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(98, 59);
            this.btnXoaNV.TabIndex = 15;
            this.btnXoaNV.Text = "XÓA";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Enabled = false;
            this.btnThemNV.Location = new System.Drawing.Point(115, 122);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(98, 59);
            this.btnThemNV.TabIndex = 14;
            this.btnThemNV.Text = "THÊM";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // cmbGioiTinhNV
            // 
            this.cmbGioiTinhNV.Enabled = false;
            this.cmbGioiTinhNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinhNV.FormattingEnabled = true;
            this.cmbGioiTinhNV.Location = new System.Drawing.Point(140, 57);
            this.cmbGioiTinhNV.Name = "cmbGioiTinhNV";
            this.cmbGioiTinhNV.Size = new System.Drawing.Size(70, 27);
            this.cmbGioiTinhNV.TabIndex = 13;
            // 
            // dpNamSinhNV
            // 
            this.dpNamSinhNV.Enabled = false;
            this.dpNamSinhNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNamSinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNamSinhNV.Location = new System.Drawing.Point(641, 24);
            this.dpNamSinhNV.Name = "dpNamSinhNV";
            this.dpNamSinhNV.Size = new System.Drawing.Size(97, 26);
            this.dpNamSinhNV.TabIndex = 12;
            // 
            // txtDienThoaiNV
            // 
            this.txtDienThoaiNV.Enabled = false;
            this.txtDienThoaiNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoaiNV.Location = new System.Drawing.Point(644, 60);
            this.txtDienThoaiNV.Name = "txtDienThoaiNV";
            this.txtDienThoaiNV.Size = new System.Drawing.Size(94, 26);
            this.txtDienThoaiNV.TabIndex = 11;
            this.txtDienThoaiNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoaiNV_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điện Thoại";
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Enabled = false;
            this.txtDiaChiNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(319, 60);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(219, 26);
            this.txtDiaChiNV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm Sinh";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(372, 23);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(166, 26);
            this.txtTenNV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(139, 26);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(74, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDSNV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // dtgvDSNV
            // 
            this.dtgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSNV.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSNV.Name = "dtgvDSNV";
            this.dtgvDSNV.Size = new System.Drawing.Size(851, 126);
            this.dtgvDSNV.TabIndex = 0;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuyNV;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.ComboBox cmbGioiTinhNV;
        private System.Windows.Forms.DateTimePicker dpNamSinhNV;
        private System.Windows.Forms.TextBox txtDienThoaiNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.Label label6;
    }
}