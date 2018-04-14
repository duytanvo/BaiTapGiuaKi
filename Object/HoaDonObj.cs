using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHACHSAN.Object
{
    class HoaDonObj
    {
        string ma, ngaylap, nguoilap, khachhang;

        public string MaHoaDon
        {
            get { return ma; }
            set { ma = value; }
        }

        public string NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string Nguoilap
        {
            get { return nguoilap; }
            set { nguoilap = value; }
        }

        public string KhacHang
        {
            get { return khachhang; }
            set { khachhang = value; }
        }

        public HoaDonObj(){}
        public HoaDonObj( string ma, string ngaylap, string nguoilap, string khachhang)
        {
            this.ma = ma;
            this.ngaylap = ngaylap;
            this.nguoilap = nguoilap;
            this.khachhang = khachhang;
        }
    }
}
