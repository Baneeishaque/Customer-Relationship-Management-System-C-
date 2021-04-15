using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CRM
{
    class ClsdalLoginMaster
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand cmd;



        public DataTable ReturnDataTable(int flag,ClsBllLoginMaster objbll)
        {
            cmd = new SqlCommand("Sp_LoginForm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = objbll.UserName;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = objbll.Password;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;





        }
    }
}
