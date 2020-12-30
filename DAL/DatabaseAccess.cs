﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        public DatabaseAccess() { }
        // không cần đổi chuỗi kếết nối nữa, dùng chung cho mọi máy
        public string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch
            {
                
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        
    }
}
