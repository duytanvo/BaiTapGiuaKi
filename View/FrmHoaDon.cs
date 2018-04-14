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
    public partial class FrmHoaDon : Form
    {
        HoaDonCtr hdCtr = new HoaDonCtr();
        ChiTietCtr ctCtr = new ChiTietCtr();
        PhongCtr hhCtr = new PhongCtr();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;

        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            bingding();
            txtNgayLap.Enabled = false;
        }

        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource, "MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            txtNhanVienLap.DataBindings.Clear();
            txtNhanVienLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            cmbkhachHang.DataBindings.Clear();
            cmbkhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
        }

        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            txtNhanVienLap.Enabled = e;
            cmbkhachHang.Enabled = e;
            btnTaoMoi.Enabled = !e;
            btnXoaHD.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnCham.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbPhong.Enabled = e;
            txtSL.Enabled = e;
            txtDonGia.Enabled = e;
        }

        private void LoadcmbKhachHang()
        {
            khachHangCtr khctr = new khachHangCtr();
            cmbkhachHang.DataSource = khctr.GetData();
            cmbkhachHang.DisplayMember = "TenKH";
            cmbkhachHang.ValueMember = "MaKH";
            cmbkhachHang.SelectedIndex = 0;
        }

        private void LoadcmbHangHoa()
        {
            PhongCtr hhctr = new PhongCtr();
            cmbPhong.DataSource = hhctr.GetData();
            cmbPhong.DisplayMember = "TenPhong";
            cmbPhong.ValueMember = "MaPhong";
        }

        private void clearData()
        {
            txtMa.Text = "";
            txtNhanVienLap.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadcmbKhachHang();
        }

        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.Nguoilap = txtNhanVienLap.Text.Trim();
            hdObj.KhacHang = cmbkhachHang.SelectedValue.ToString();
        }

        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }

        private void capnhatSL(string mahh, int sol)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString()) + sol;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }

        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhCtr.GetData("Where MaPhong = '" + cmbPhong.SelectedValue.ToString() + "' and SoLuong>= " + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSP.DataSource = dt;

            }
            catch
            {
                dtgvDSP.DataSource = null;
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcmbHangHoa();
            LoadcmbKhachHang();

            dtDSCT.Rows.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("Phong");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmHoaDon_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoaDonObj hdObj = new HoaDonObj();
            addData(hdObj);
            if (hdCtr.AddData(hdObj))
            {
                if (ctCtr.AddData(dtDSCT))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FrmHoaDon_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                FrmHoaDon_Load(sender, e);
            else
                return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMa.Text))
            {
                if(kiemtraSL(cmbPhong.SelectedValue.ToString(), int.Parse(txtSL.Text.Trim())))
                {
                    if (!checktrung(cmbPhong.SelectedValue.ToString()))
                    {
                        DataRow dr = dtDSCT.NewRow();
                        dr[0] = txtMa.Text.Trim();
                        dr[1] = cmbPhong.SelectedValue.ToString();
                        dr[2] = txtDonGia.Text;
                        dr[3] = txtSL.Text;
                        dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
                        dtDSCT.Rows.Add(dr);
                    }
                    else
                    {
                        capnhatSL(cmbPhong.SelectedValue.ToString(), int.Parse(txtSL.Text));
                    }
                dtgvDSP.DataSource = dtDSCT;
                }
                else
                {
                    MessageBox.Show("Số lượng không dủ", "Lỗi");
                    txtSL.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMa.Focus();
            }
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhCtr.GetData("Where MaHang = '" + cmbPhong.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][2].ToString());

                txtDonGia.Text = (gia * 1.1).ToString();

                lblThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgvDSP.DataSource = dtDSCT;
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            lblThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
        }

        private void dtgvDSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitriclick = e.RowIndex;
        }

        private void btnCham_Click_1(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
