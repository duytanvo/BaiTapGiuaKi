using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHACHSAN.Object
{
    class ChiTietObj
    {
        string mahh, mahd;
        int dongia, sl;

        public string MaHoaDon
        {
            get { return mahd; }
            set { mahd = value; }
        }

        public string MaHangHoa
        {
            get { return mahh; }
            set { mahh = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public int SoLuong
        {
            get { return sl; }
            set { sl = value; }
        }

        public ChiTietObj() { }
        public ChiTietObj(string mahh, string mahd, int dongia, int sl)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.dongia = dongia;
            this.sl = sl;

        }
    }
}
