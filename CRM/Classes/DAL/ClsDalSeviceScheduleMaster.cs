using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;




namespace CRM
{
        class ClsDalSeviceScheduleMaster
        {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
                public DataTable returndatatable(ClsBllSeviceScheduleMaster objbll, int flag)
                {
                        if (con.State == ConnectionState.Closed)
                                 con.Open();
                        cmd = new SqlCommand("dbo.Sp_ServiceSchedule");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
                        if (flag == 2 || flag == 3)
                                cmd.Parameters.Add("@RegistrationId", SqlDbType.BigInt).Value = objbll.RegistrationId;
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;

                }

                public void Delete(ClsBllSeviceScheduleMaster ObjBll, int flag)
                {
                        if (con.State == ConnectionState.Closed) con.Open();
                        cmd = new SqlCommand("Sp_ServiceSchedule");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;
                        cmd.Parameters.Add("@ScheduleId", SqlDbType.BigInt).Value = ObjBll.ScheduleId;
                        cmd.Parameters.Add("@ScheduleDetailsId", SqlDbType.BigInt).Value = ObjBll.ScheduleDetailsId;

                        cmd.ExecuteNonQuery();

                }

                public void SaveServiceSchedule(ClsBllSeviceScheduleMaster objbll, int flag)
                {
                        if (con.State == ConnectionState.Closed)
                                con.Open();
                        cmd = new SqlCommand("dbo.Sp_ServiceSchedule");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.Clear();

                        cmd.Parameters.Add("@Flag", SqlDbType.BigInt).Value = flag;

                        if (flag == 9)
                        {
                                cmd.Parameters.Add("@ScheduleId", SqlDbType.BigInt).Value = objbll.ScheduleId;
                        }


                        cmd.Parameters.Add("@ScheduleNo", SqlDbType.VarChar).Value = objbll.ScheduleNo;
                        cmd.Parameters.Add("@RegistrationId", SqlDbType.BigInt).Value = objbll.RegistrationId;
                        cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = objbll.Date;
                        cmd.Parameters.Add("@MyTable", SqlDbType.Xml).Value = ConvertToXml(objbll.MyTable);


                        cmd.ExecuteNonQuery();

                }


                public string ConvertToXml(DataTable dt)
                {
                        try
                        {
                                string Result;
                                dt.TableName = "MyTable";
                                using (StringWriter sw = new StringWriter())
                                {
                                        dt.WriteXml(sw);
                                        Result = sw.ToString();
                                }
                                Result = Result.Replace("NewDataSet", "DocumentElement");
                                return Result;

                        }
                        catch (Exception)
                        {
                                throw;


                        }
                }
                public int nextnumber(ClsBllSeviceScheduleMaster objbll)
                {
                        con.Open();
                        cmd = new SqlCommand("dbo.Sp_ServiceSchedule");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@flag", SqlDbType.BigInt).Value = 6;
                        SqlParameter p = new SqlParameter();
                        p = cmd.Parameters.Add("@Idout", SqlDbType.BigInt);
                        p.Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        return int.Parse(p.Value.ToString());


                }








        }

}
