using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CRM
{
    class ClsDalServiceRegistrationReport
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand cmd;
        public DataTable returndatatable(ClsBllServiceRegistrationReport objbll, int flag)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            cmd = new SqlCommand("SP_ServiceRegistrationReport");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            if (flag == 2 || flag==1)
                cmd.Parameters.Add("@CustomerId",SqlDbType.BigInt).Value=objbll.CustomerId;
            if (flag == 1)
            {
                cmd.Parameters.Add("@ServiceId", SqlDbType.BigInt).Value = objbll.ServiceId;
            
            
            }
               

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }
    }
}
