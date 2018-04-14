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
    public partial class FrmPhong : Form
    {
        PhongCtr PCtr = new PhongCtr();
        private int flagLuu = 0;
        public FrmPhong()
        {
            InitializeComponent();
        }

        private void bingding()
        {
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", dtgvDSPHONG.DataSource, "MaPhong");
            txtTenPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Add("Text", dtgvDSPHONG.DataSource, "TenPhong");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dtgvDSPHONG.DataSource, "DonGia");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dtgvDSPHONG.DataSource, "SoLuong");
            
        }
        private void ClearData()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            
        }
        private void AddData(PhongObj hh)
        {
            hh.MaPhong = txtMaPhong.Text.Trim();
            hh.TenPhong = txtTenPhong.Text.Trim();
            hh.DonGia = int.Parse(txtDonGia.Text.Trim());
            hh.SoLuong = int.Parse(txtSoLuong.Text.Trim());
        }
        private void DisEnl(bool e)
        {
            btnNhapPhong.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaPhong.Enabled = e;
            txtTenPhong.Enabled = e;
            txtDonGia.Enabled = e;
            txtSoLuong.Enabled = e;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            ClearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa phòng này?", "xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (PCtr.DelData(txtMaPhong.Text.Trim()))
                    MessageBox.Show("xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmPhong_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhongObj hhObj = new PhongObj();
            AddData(hhObj);
            if(flagLuu ==0)
            {
                if (PCtr.AddData(hhObj))
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flagLuu == 1)
            {
                if (PCtr.UpdData(hhObj))
                    MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PCtr.UpdData(hhObj))
                    MessageBox.Show("Nhập phòng thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nhập phòng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmPhong_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa phòng này?", "xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
                FrmPhong_Load(sender, e);
            else
                return;
        }

        private void btnNhapPhong_Click(object sender, EventArgs e)
        {
            flagLuu = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnNhapPhong.Enabled = false;
            txtSoLuong.Enabled = true;
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = PCtr.GetData();
            dtgvDSPHONG.DataSource = dtDS;
            bingding();
            DisEnl(false);
        }

    }
}
