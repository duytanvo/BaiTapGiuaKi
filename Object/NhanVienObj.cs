using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHACHSAN.Object
{
    class NhanVienObj
    {
        string ma, ten, gt, dc, sdt, mk, ca, ns;
        
        public string MaNhanVien
        {
            get { return ma; }
            set { ma = value; }
        }
        public string TenNhanVien
        {
            get { return ten; }
            set { ten = value; }
        }
        public string GioiTinh
        {
            get { return gt; }
            set { gt = value; }
        }
        public string DiaChi
        {
            get { return dc; }
            set { dc = value; }
        }
        public string MatKhau
        {
            get { return mk; }
            set { mk= value; }
        }
        public string CaLamViec
        {
            get { return ca; }
            set { ca = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string NamSinh
        {
            get { return ns; }
            set { ns = value; }
        }
        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gt, string dc, string sdt, string ca, string mk, string ns) 
        {
            this.ma = ma;
            this.ten = ten;
            this.gt = gt;
            this.dc = dc;
            this.sdt = sdt;
            this.mk = mk;
            this.ca = ca;
            this.ns = ns;
            
        }
    }
}
