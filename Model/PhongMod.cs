using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_KHACHSAN.Object;

namespace QL_KHACHSAN.Model
{
    class PhongMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_Phong";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            { 
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_Phong" + dieukien;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch(Exception ex )
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool AddData(PhongObj pObj)
        {
            cmd.CommandText = " Insert into tb_Phong values ('" + pObj.MaPhong + "', N'" + pObj.TenPhong + "'," + pObj.DonGia + ", 0 ) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                
            }
            return false;
        }
        public bool UpdData(PhongObj pObj)
        {
            cmd.CommandText = " Update tb_Phong set TenPhong =  N'" + pObj.TenPhong + "', SoLuong = " + pObj.SoLuong + ", DonGia = " + pObj.DonGia + " Where MaPhong = '" + pObj.MaPhong + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }
        public bool UpdSL(string mahh, int SL)
        {
            cmd.CommandText = "Update tb_Phong set  SoLuong = " + SL + " Where MaPhong = '" + mahh + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }
        public bool DelData(string ma)
        {
            cmd.CommandText = " delete tb_Phong where MaPhong = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }

    
    }
}