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
    public partial class FrmKhachHang : Form
    {
        khachHangCtr khCtr = new khachHangCtr();
        private int flagLuu = 0;
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        private void bingding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dtgvDSKH.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dtgvDSKH.DataSource, "TenKH");
            cmbGioiTinhKH.DataBindings.Clear();
            cmbGioiTinhKH.DataBindings.Add("Text", dtgvDSKH.DataSource, "GioiTinh");
            txtDiaChiKH.DataBindings.Clear();
            txtDiaChiKH.DataBindings.Add("Text", dtgvDSKH.DataSource, "DiaChi");
            txtSDTKH.DataBindings.Clear();
            txtSDTKH.DataBindings.Add("Text", dtgvDSKH.DataSource, "SDT");
            dpNamSinhKH.DataBindings.Clear();
            dpNamSinhKH.DataBindings.Add("Text", dtgvDSKH.DataSource, "NamSinh");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvDSKH.DataSource, "Email");
        }
        private void LoadCMB()
        {
            cmbGioiTinhKH.Items.Clear();
            cmbGioiTinhKH.Items.Add("Nam");
            cmbGioiTinhKH.Items.Add("Nữ");
            cmbGioiTinhKH.SelectedItem = 0;

        }
        private void ClearData()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSDTKH.Text = "";
            dpNamSinhKH.Value = DateTime.Now.Date;
            LoadCMB();
            txtEmail.Text = "";
        }
        private void DisEnl(bool e)
        {
            btnThemKH.Enabled = !e;
            btnXoaKH.Enabled = !e;
            btnSuaKH.Enabled = !e;
            btnLuuKH.Enabled = e;
            btnHuyKH.Enabled = e;
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtDiaChiKH.Enabled = e;
            txtSDTKH.Enabled = e;
            cmbGioiTinhKH.Enabled = e;
            dpNamSinhKH.Enabled = e;
            txtEmail.Enabled = e;
        }
        private void addData(KhachHangObj kh)
        {
            kh.MaKhachHang = txtMaKH.Text.Trim();
            if (cmbGioiTinhKH.SelectedIndex == 0)
            {
                kh.GioiTinh = "Nam";
            }
            else
                kh.GioiTinh = "Nữ";
            kh.DiaChi = txtDiaChiKH.Text.Trim();
            kh.DienThoai = txtSDTKH.Text.Trim();
            kh.TenKhachHang = txtTenKH.Text.Trim();
            kh.NamSinh = dpNamSinhKH.Text;
            kh.Email = txtEmail.Text.Trim();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            ClearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtr.DelData(txtMaKH.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmKhachHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            LoadCMB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangObj khObj = new KhachHangObj();
            addData(khObj);
            if (flagLuu == 0)
            {
                if (khCtr.AddData(khObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khCtr.UpdData(khObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmKhachHang_Load(sender, e);
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = khCtr.GetData();
            dtgvDSKH.DataSource = dtDS;
            bingding();
            DisEnl(false);
        }

        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                FrmKhachHang_Load(sender, e);
            else
                return;
        }

        
    }
}
