using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_KHACHSAN.Control;
using QL_KHACHSAN.Object;

namespace QL_KHACHSAN.View
{
    public partial class FrmNhanVien : Form
    {
        NhanVienCtr nvctr = new NhanVienCtr();
        
        int flag = 0;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvctr.GetData();
            dtgvDSNV.DataSource = dtNhanVien;
            bingding();
            Dis_En(false);

        }

        void bingding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dtgvDSNV.DataSource, "MaNV");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dtgvDSNV.DataSource, "TenNV");
            cmbGioiTinhNV.DataBindings.Clear();
            cmbGioiTinhNV.DataBindings.Add("Text", dtgvDSNV.DataSource, "GioiTinh");
            txtDiaChiNV.DataBindings.Clear();
            txtDiaChiNV.DataBindings.Add("Text", dtgvDSNV.DataSource, "DiaChi");
            txtDienThoaiNV.DataBindings.Clear();
            txtDienThoaiNV.DataBindings.Add("Text", dtgvDSNV.DataSource, "SDT");
            dpNamSinhNV.DataBindings.Clear();
            dpNamSinhNV.DataBindings.Add("Text", dtgvDSNV.DataSource, "NamSinh");
            txtCa.DataBindings.Clear();
            txtCa.DataBindings.Add("Text", dtgvDSNV.DataSource, "CaLamViec");
        }

        void Dis_En(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtDiaChiNV.Enabled = e;
            txtDienThoaiNV.Enabled = e;
            cmbGioiTinhNV.Enabled = e;
            dpNamSinhNV.Enabled = e;
            txtCa.Enabled = e;
            btnThemNV.Enabled = !e;
            btnXoaNV.Enabled = !e;
            btnSuaNV.Enabled = !e;
            btnLuuNV.Enabled = e;
            btnHuyNV.Enabled = e;
        }

        void GanDuLieu(NhanVienObj nvObj)
        {
            nvObj.MaNhanVien = txtMaNV.Text.Trim();
            nvObj.TenNhanVien = txtTenNV.Text.Trim();
            nvObj.GioiTinh = cmbGioiTinhNV.Text.Trim();
            nvObj.SDT = txtDienThoaiNV.Text.Trim();
            nvObj.DiaChi = txtDiaChiNV.Text.Trim();
            nvObj.CaLamViec = txtCa.Text.Trim();
            nvObj.NamSinh = dpNamSinhNV.Text.Trim();
            nvObj.MatKhau = "";
        }

        void Loadcontrol()
        {
            cmbGioiTinhNV.Items.Clear();
            cmbGioiTinhNV.Items.Add("Nam");
            cmbGioiTinhNV.Items.Add("Nữ");
            cmbGioiTinhNV.SelectedItem = 0; 
        }
        void ClearData()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChiNV.Text = "";
            txtDienThoaiNV.Text = "";
            cmbGioiTinhNV.Text = "";
            dpNamSinhNV.Value = DateTime.Now.Date;
            txtCa.Text = "";
            Loadcontrol();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            flag = 0;
            ClearData();
            Dis_En(true);
            
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_En(true);
            Loadcontrol();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn Xóa?", "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvctr.DelData(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            FrmNhanVien_Load(sender, e);
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            NhanVienObj nvobj = new NhanVienObj();
            GanDuLieu(nvobj);
            if (flag == 0)
            {
                if (nvctr.AddData(nvobj))
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvctr.UpdData(nvobj))
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmNhanVien_Load(sender, e);
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien_Load(sender, e);
            Dis_En(false);
        }

        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
