using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_KHACHSAN.Model;
using QL_KHACHSAN.Object;

namespace QL_KHACHSAN.Control
{
    class khachHangCtr
    {
        KhachhangMod nvMod = new KhachhangMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return nvMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return nvMod.UpdData(khObj);
        }
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
