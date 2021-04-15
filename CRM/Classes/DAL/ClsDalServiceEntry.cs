using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace CRM
{
    class ClsDalServiceEntry
    {
        SqlConnection CON = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand ObjCmd = new SqlCommand();

        public void Save(ClsBllServiceEntry ObjBll, int flag)
        {
            if (CON.State == ConnectionState.Closed)
                CON.Open();

            SqlCommand ObjCmd = new SqlCommand("SP_SERVICEENTRY");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;
            ObjCmd.Parameters.Clear();

            ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            if (flag == 3)
                ObjCmd.Parameters.Add("@SERVICEID", SqlDbType.BigInt).Value = ObjBll.ServiceId;
            ObjCmd.Parameters.Add("@PRODUCTID", SqlDbType.BigInt).Value = ObjBll.ProductId;
            ObjCmd.Parameters.Add("@SERVICENAME", SqlDbType.VarChar).Value = ObjBll.ServiceName;
            ObjCmd.Parameters.Add("@TIMEREQUIREDDAYS", SqlDbType.VarChar).Value = ObjBll.TimeRequiredDays;
            ObjCmd.Parameters.Add("@TIMEREQUIREDHOURS", SqlDbType.VarChar).Value = ObjBll.TimeRequiredHours;
            ObjCmd.Parameters.Add("@TIMEREQUIREDMINUTES", SqlDbType.VarChar).Value = ObjBll.TimeRequiredMinutes;
            ObjCmd.Parameters.Add("@SERVICECOST", SqlDbType.VarChar).Value = ObjBll.ServiceCost;


            ObjCmd.ExecuteNonQuery();

        }

        public DataTable ReturnDataTable(ClsBllServiceEntry ObjBll, int flag)
        {
            if (CON.State == ConnectionState.Closed)
                CON.Open();

            SqlCommand ObjCmd = new SqlCommand("SP_SERVICEENTRY");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;
            ObjCmd.Parameters.Clear();

            ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            //ObjCmd.Parameters.Add("@SERVICEID", SqlDbType.VarChar).Value = ObjBll.ServiceId;

            SqlDataAdapter sda = new SqlDataAdapter(ObjCmd);
            DataTable Dt = new DataTable();
            sda.Fill(Dt);
            return Dt;



        }

        public void Delete(ClsBllServiceEntry ObjBll, int flag)
        {
            if (CON.State == ConnectionState.Closed)
                CON.Open();

            SqlCommand ObjCmd = new SqlCommand("SP_SERVICEENTRY");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;
            ObjCmd.Parameters.Clear();

            ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            ObjCmd.Parameters.Add("@SERVICEID", SqlDbType.BigInt).Value = ObjBll.ServiceId;

            ObjCmd.ExecuteNonQuery();

        }

    }
}
