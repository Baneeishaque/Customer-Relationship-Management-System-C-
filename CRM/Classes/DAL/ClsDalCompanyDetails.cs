using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CRM
{
    class ClsDalCompanyDetails
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand cmd;
        public void save(ClsBllCompanyDetails objbll, int flag)
        {
            if(con.State==ConnectionState.Closed)
            con.Open();
            cmd = new SqlCommand("sp_CompanyInfo");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            if (flag == 4)
                cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = objbll.CompanyId;
            cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = objbll.CompanyName;
            cmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar).Value = objbll.CompanyWebsite;
            cmd.Parameters.Add("@CompanyAddress", SqlDbType.VarChar).Value = objbll.CompanyAddress;
            cmd.Parameters.Add("@CompanyDescription", SqlDbType.VarChar).Value = objbll.CompanyDescription;
            cmd.Parameters.Add("@City",SqlDbType.VarChar).Value=objbll.City;
            cmd.Parameters.Add("@StateName",SqlDbType.VarChar).Value=objbll.StateName;
            cmd.Parameters.Add("@ZipCode",SqlDbType.VarChar).Value=objbll.ZipCode;
            cmd.Parameters.Add("@Phone1",SqlDbType.VarChar).Value=objbll.Phone1;
            cmd.Parameters.Add("@Phone2",SqlDbType.VarChar).Value=objbll.Phone2;
            cmd.Parameters.Add("@EmailId1",SqlDbType.VarChar).Value=objbll.EmailId1;
            cmd.Parameters.Add("@EmailId2",SqlDbType.VarChar).Value=objbll.EmailId2;
            cmd.Parameters.Add("@FacebookURL",SqlDbType.VarChar).Value=objbll.FacebookURL;
            cmd.Parameters.Add("@TwitterURL",SqlDbType.VarChar).Value=objbll.TwitterURL;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = objbll.Photo;
            cmd.ExecuteNonQuery();
            con.Close();
        
        }
        public DataTable returndatatable(ClsBllCompanyDetails objbll, int flag)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            cmd = new SqlCommand("sp_CompanyInfo");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }
        public void delete(ClsBllCompanyDetails objbll, int flag)
        {
            if(con.State==ConnectionState.Closed)
            con.Open();
            cmd = new SqlCommand("sp_CompanyInfo");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = objbll.CompanyId;
            cmd.ExecuteNonQuery();
            con.Close();
            
        }


        
    }
   
}
