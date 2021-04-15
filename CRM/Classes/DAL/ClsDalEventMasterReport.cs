using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRM
{
    class ClsDalEventMasterReport
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand cmd;
        public DataTable ReturnDataTable(ClsBllEventMasterReport objbll, int Flag)
        {


            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand("SP_EventReport");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();

            if (objbll.Priority == "High")
            {
                Flag = 6;
                objbll.Priority = "";
            }
            if (objbll.Priority == "Medium")

            {
                objbll.Priority = "";
                Flag = 7;
            }
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = Flag;

            //if (Flag == 3)
            //    cmd.Parameters.Add("EventId", SqlDbType.BigInt).Value = objbll.EventId;
            if (Flag == 1)
            {
                    cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = objbll.EventId;
                   
               
            }
            //if(Flag==4)
            //    cmd.Parameters.Add("EventId", SqlDbType.BigInt).Value = objbll.EventId;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;

       }


        
        
    
    }
}
