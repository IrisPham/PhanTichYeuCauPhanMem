﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace phantichyeucauphanmem.ConnectionSQL
{
     class SQL
    {
        //Phan xu li ket noi sql
        public static SqlCommand comnd;
        public static SqlConnection sql;
        public static void connect()
        {
            try
            {
                sql = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Thanh\Gifthup\PhanTichYeuCauPhanMem\phantichyeucauphanmem\phantichyeucauphanmem\TopicManagement.mdf;Integrated Security=True;User Instance=True");
                sql.Open();

            }
            catch (SqlException ex)
            {
               MessageBox.Show(ex.Message, "Kết nối thất bại");
            }
        }
        public static void disconnect()
        {
            sql.Close();
            sql.Dispose();
        }
    }
}
