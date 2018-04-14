using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHACHSAN.Object
{
    class PhongObj
    {
        string ma, ten;
        int dongia, soluong;
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string MaPhong
        {
            get { return ma; }
            set { ma = value; }
        }
        public string TenPhong
        {
            get { return ten; }
            set { ten = value; }
        }
        public PhongObj() { }
        public PhongObj(string ma, string ten, int dongia, int soluong)
        {
            this.ma = ma; 
            this.ten = ten;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }

}
