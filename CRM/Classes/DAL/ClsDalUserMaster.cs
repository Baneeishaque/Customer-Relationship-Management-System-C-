using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CRM
{
    class ClsDalUserMaster
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand cmd;

        public void Save(ClsBllUserMaster objbll, int Flag)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            
            }

            cmd = new SqlCommand("Sp_UserMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = Flag;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = objbll.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = objbll.LastName;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = objbll.UserName;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = objbll.Password;
            cmd.Parameters.Add("@Company", SqlDbType.VarChar).Value = objbll.Company;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objbll.Country;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = objbll.State;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objbll.City;
            cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = objbll.PhoneNo;
            cmd.Parameters.Add("@EmailId", SqlDbType.VarChar).Value = objbll.EmailId;
            cmd.ExecuteNonQuery();



        
        
        }

        

    }
}
