using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;

using System.Data;
using System.Data.SqlClient;


namespace CRM
{
    class ClsDalCustomerMaster
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand cmd;
        public void save(ClsBllCustomerMaster objbll,int flag)
        {
            if(con.State==ConnectionState.Closed)
            con.Open();
            cmd = new SqlCommand("SP_CustomerMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value =flag;
            if(flag==6)
            cmd.Parameters.Add("@CustomerId", SqlDbType.BigInt).Value = objbll.CustomerId;
            cmd.Parameters.Add("CustomerName", SqlDbType.VarChar).Value = objbll.Name;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = objbll.Address;
            cmd.Parameters.Add("@NationalityId", SqlDbType.BigInt).Value = objbll.Nationality;
            cmd.Parameters.Add("@StateId", SqlDbType.BigInt).Value = objbll.State;
            cmd.Parameters.Add("@Locality", SqlDbType.VarChar).Value = objbll.Locality;
            cmd.Parameters.Add("@TinNo", SqlDbType.VarChar).Value =objbll.TinNo;
            cmd.Parameters.Add("@Phone1", SqlDbType.VarChar).Value = objbll.PhoneNo1;
            cmd.Parameters.Add("@Phone2", SqlDbType.VarChar).Value = objbll.PhoneNo2;
            cmd.Parameters.Add("@EmailId", SqlDbType.VarChar).Value = objbll.EmailID;
            cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value=objbll.Fax;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = objbll.Photo;

            cmd.ExecuteNonQuery();
            con.Close();

        
        
        }
        public DataTable returndatatable(ClsBllCustomerMaster objbll,int flag)
        {
            if(con.State==ConnectionState.Open)
            {
            con.Close();
            }
            else
            {
             con.Open();
            }
            cmd = new SqlCommand("SP_CustomerMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value =flag;
            if (flag == 3)
                cmd.Parameters.Add("@CountryId", SqlDbType.BigInt).Value = objbll.CountryId;
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            return dt;
        
        }
        
        public void delete(ClsBllCustomerMaster objbll)
        {
            if (con.State == ConnectionState.Closed)
            
            con.Open();
            cmd=new SqlCommand("SP_CustomerMaster");
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Connection=con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = 5;
            cmd.Parameters.Add("@CustomerId", SqlDbType.BigInt).Value = objbll.CustomerId;
            cmd.ExecuteNonQuery();
            con.Close();

        
        }
        
        //public int maxid(ClsBllCustomerMaster objbll, int flag)
        //{
        //    if (con.State == ConnectionState.Open)
        //    {
        //        con.Close();
        //    }
        //    else
        //    {
        //        con.Open();
        //    }
        //    cmd=new SqlCommand("SP_CustomerMaster");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
        //    SqlParameter p = new SqlParameter();
        //    p = cmd.Parameters.Add("@Idout", SqlDbType.BigInt);
        //    p.Direction=ParameterDirection.Output;
        //    cmd.ExecuteNonQuery();
        //    return int.Parse (p.Value.ToString());
            







        //}
        


        
    }
   
}
