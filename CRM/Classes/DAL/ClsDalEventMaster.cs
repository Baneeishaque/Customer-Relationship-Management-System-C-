using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRM
{
    class ClsDalEventMaster
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con= new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);

        public void save(ClsBllEventMaster objbll, int flag)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand("Sp_EventMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            if (flag == 4)
            cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = objbll.EventId;  
            cmd.Parameters.Add("@EventName", SqlDbType.VarChar).Value = objbll.EventName;
            cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = objbll.Description;
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = objbll.StartDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = objbll.EndDate;
            cmd.Parameters.Add("@StartTime", SqlDbType.DateTime).Value = objbll.StartTime;
            cmd.Parameters.Add("@EndTime", SqlDbType.DateTime).Value = objbll.EndTime;
            cmd.Parameters.Add("@Location", SqlDbType.VarChar).Value = objbll.Location;
            cmd.Parameters.Add("@Priority", SqlDbType.VarChar).Value = objbll.Priority;
            cmd.Parameters.Add("@NotificationRequired", SqlDbType.VarChar).Value = objbll.NotificationRequired;
            cmd.Parameters.Add("@NotificationType", SqlDbType.VarChar).Value = objbll.NotificationType;
            cmd.Parameters.Add("@NotificationTime", SqlDbType.VarChar).Value = objbll.NotificationTime;
            cmd.Parameters.Add("@NotificationStartDate", SqlDbType.VarChar).Value = objbll.NotificationStartDate;
            cmd.Parameters.Add("@NotificationEndDate", SqlDbType.VarChar).Value = objbll.NotificationEndDate;
            cmd.Parameters.Add("@Sunday", SqlDbType.VarChar).Value = objbll.Sunday;
            cmd.Parameters.Add("@Monday", SqlDbType.VarChar).Value = objbll.Monday;
            cmd.Parameters.Add("@Tuesday", SqlDbType.VarChar).Value = objbll.Tuesday;
            cmd.Parameters.Add("@Wednesday", SqlDbType.VarChar).Value = objbll.Wednesday;
            cmd.Parameters.Add("@Thursday", SqlDbType.VarChar).Value = objbll.Thursday;
            cmd.Parameters.Add("@Friday", SqlDbType.VarChar).Value = objbll.Friday;
            cmd.Parameters.Add("@Saturday", SqlDbType.VarChar).Value = objbll.Saturday;
            cmd.ExecuteNonQuery();
            con.Close();
        
        }

        public DataTable ReturnDateTable(ClsBllEventMaster objbll, int flag)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            
            }
            cmd = new SqlCommand("Sp_EventMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            
        
        }
        public void delete(ClsBllEventMaster objbll, int flag)
        {
            if (con.State == ConnectionState.Closed)
            con.Open();
            cmd = new SqlCommand("Sp_EventMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
            cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = objbll.EventId;
            cmd.ExecuteNonQuery();
            con.Close();
        
        }
             









        internal DataTable ReturnDateTable()
        {
            throw new NotImplementedException();
        }

        internal void delete()
        {
            throw new NotImplementedException();
        }
    }
    
}
