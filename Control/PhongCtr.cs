using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_KHACHSAN.Object;
using QL_KHACHSAN.Model;
using QL_KHACHSAN.Control;
namespace QL_KHACHSAN.Control
{
    class PhongCtr
    {
        PhongMod hhMod = new PhongMod();
        public DataTable GetData()
        {
            return hhMod.GetData();
        }
        public DataTable GetData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
        public bool AddData(PhongObj hhObj)
        {
            return hhMod.AddData(hhObj);
        }
        public bool UpdData(PhongObj hhObj)
        {
            return hhMod.UpdData(hhObj);
        }
        public bool UpdSL(PhongObj hhObj)
        {
            DataTable dthh = new DataTable();
            dthh = hhMod.GetData();
            for (int i = 0; i < dthh.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dthh.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][3].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][3].ToString()) - int.Parse(dthh.Rows[i][3].ToString());
                        if (!hhMod.UpdSL(dthh.Rows[j][0].ToString(), SLmoi))
                            return false;
                        break;
                    }
                }

            }
            return true;
        }
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}
