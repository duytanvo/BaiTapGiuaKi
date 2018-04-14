namespace QL_KHACHSAN.View
{
    partial class FrmHoaDon
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnCham = new System.Windows.Forms.Button();
            this.cmbkhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhanVienLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHD = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDSP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoaHD);
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.btnCham);
            this.groupBox1.Controls.Add(this.cmbkhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNhanVienLap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(380, 118);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 61);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(258, 118);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 61);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu Hóa Đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(139, 118);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(88, 61);
            this.btnXoaHD.TabIndex = 10;
            this.btnXoaHD.Text = "Xóa Hóa Đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(22, 118);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(88, 61);
            this.btnTaoMoi.TabIndex = 9;
            this.btnTaoMoi.Text = "Tạo Mới Hóa Đơn";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnCham
            // 
            this.btnCham.Location = new System.Drawing.Point(213, 62);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(45, 24);
            this.btnCham.TabIndex = 8;
            this.btnCham.Text = "...";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.btnCham_Click_1);
            // 
            // cmbkhachHang
            // 
            this.cmbkhachHang.FormattingEnabled = true;
            this.cmbkhachHang.Location = new System.Drawing.Point(367, 60);
            this.cmbkhachHang.Name = "cmbkhachHang";
            this.cmbkhachHang.Size = new System.Drawing.Size(121, 27);
            this.cmbkhachHang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách Hàng";
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.Location = new System.Drawing.Point(371, 24);
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.Size = new System.Drawing.Size(119, 26);
            this.txtNhanVienLap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân Viên Lập";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(106, 60);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(100, 26);
            this.txtNgayLap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Lập";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(106, 24);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 26);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDSHD);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // dtgvDSHD
            // 
            this.dtgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHD.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSHD.Name = "dtgvDSHD";
            this.dtgvDSHD.Size = new System.Drawing.Size(491, 181);
            this.dtgvDSHD.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblThanhTien);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnBot);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbPhong);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(511, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Hóa Đơn";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThanhTien.Location = new System.Drawing.Point(101, 103);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(27, 19);
            this.lblThanhTien.TabIndex = 17;
            this.lblThanhTien.Text = "(0)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Thành Tiền";
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(199, 139);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(88, 61);
            this.btnBot.TabIndex = 15;
            this.btnBot.Text = "Bớt";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(66, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 61);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(282, 63);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 26);
            this.txtSL.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(93, 63);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 26);
            this.txtDonGia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn Giá";
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(95, 24);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(121, 27);
            this.cmbPhong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvDSP);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(511, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 206);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Phòng";
            // 
            // dtgvDSP
            // 
            this.dtgvDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSP.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSP.Name = "dtgvDSP";
            this.dtgvDSP.Size = new System.Drawing.Size(381, 181);
            this.dtgvDSP.TabIndex = 0;
            this.dtgvDSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSP_CellClick);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 428);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhanVienLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbkhachHang;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDSP;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label8;
    }
}