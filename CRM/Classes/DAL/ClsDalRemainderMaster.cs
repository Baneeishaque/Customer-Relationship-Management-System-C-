using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace CRM
{
        class ClsDalRemainderMaster
        {
                SqlCommand Cmd;
                SqlConnection CON;


                
                public void ConnectToDb()
                {
                        CON = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
                        if (CON.State == ConnectionState.Closed)
                        {
                                CON.Open();
                        }
                        Cmd = new SqlCommand("SP_RemainderMaster");
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Connection = CON;


                }


                public DataTable ReturnDT(ClsBllRemainderMaster ObjBll, int flag)
                {
                        ConnectToDb();

                        Cmd.Parameters.Clear();

                        Cmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;

                        Cmd.ExecuteNonQuery();

                        SqlDataAdapter sda = new SqlDataAdapter(Cmd);
                        DataTable DT = new DataTable();
                        sda.Fill(DT);
                        return DT;
                }

                public void Save(ClsBllRemainderMaster ObjBll, int flag)
                {
                        ConnectToDb();

                        Cmd.Parameters.Clear();
                        Cmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
                        if (flag == 4)
                        {
                                Cmd.Parameters.Add("@REMAINDERID", SqlDbType.BigInt).Value = ObjBll.RemainderId;
                        }

                        Cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = ObjBll.Name;
                        Cmd.Parameters.Add("@MESSAGE", SqlDbType.VarChar).Value = ObjBll.Message;
                        Cmd.Parameters.Add("@STARTTIME", SqlDbType.DateTime).Value = ObjBll.StartTime;
                        Cmd.Parameters.Add("@STOPTIME", SqlDbType.DateTime).Value = ObjBll.StopTime;
                        Cmd.Parameters.Add("@PRIORITYID", SqlDbType.BigInt).Value = ObjBll.PriorityId;
                        Cmd.Parameters.Add("@INTERVALSID", SqlDbType.BigInt).Value = ObjBll.Intervals;
                        Cmd.Parameters.Add("@DAYS", SqlDbType.VarChar).Value = ObjBll.Days;
                        Cmd.Parameters.Add("@APPLICABLEUSERSIDS", SqlDbType.VarChar).Value = ObjBll.ApplicableUsers;

                        Cmd.ExecuteNonQuery();

                }

                public void Delete(ClsBllRemainderMaster ObjBll, int flag)
                {
                        ConnectToDb();

                        Cmd.Parameters.Clear();
                        Cmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
                        Cmd.Parameters.Add("@REMAINDERID", SqlDbType.BigInt).Value = ObjBll.RemainderId;

                        Cmd.ExecuteNonQuery();
                }


        }
}
