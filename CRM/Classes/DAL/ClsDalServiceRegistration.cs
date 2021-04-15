using System;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
        class ClsDalServiceRegistration
        {
                SqlCommand ObjCmd = new SqlCommand();
                SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);

                public void ConnectToDb()
                {
                        if (con.State == ConnectionState.Closed)
                                con.Open();
                        SqlCommand ObjCmd = new SqlCommand("SP_SERVICEREGISTRATION");
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.Connection = con;
                        ObjCmd.Parameters.Clear();

                }

                public string ConvertToXml(DataTable dt)
                {
                        try
                        {
                                string result;
                                dt.TableName = "mytable";
                                using (StringWriter sw = new StringWriter())
                                {
                                        dt.WriteXml(sw);
                                        result = sw.ToString();
                                }
                                result = result.Replace("NewDataSet", "DocumentElement");
                                return result;
                        }
                        catch (Exception)
                        {

                                throw;
                        }
                }

                public void Save(ClsBllServiceRegistration ObjBll, int flag)
                {
                        //            ConnectToDb();

                        if (con.State == ConnectionState.Closed)
                                con.Open();
                        SqlCommand ObjCmd = new SqlCommand("SP_SERVICEREGISTRATION");
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.Connection = con;
                        ObjCmd.Parameters.Clear();



                        ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;

                        ObjCmd.Parameters.Add("@SERVICENO", SqlDbType.VarChar).Value = ObjBll.ServiceUID.ToString();

                        ObjCmd.Parameters.Add("@CUSTOMERID", SqlDbType.BigInt).Value = ObjBll.CustomerId;


                        ObjCmd.Parameters.Add("@ORDERDATE", SqlDbType.DateTime).Value = ObjBll.OrderDate;
                        ObjCmd.Parameters.Add("@SERVICEXML", SqlDbType.Xml).Value = ConvertToXml(ObjBll.DataTableToSave);

                        if (flag == 4)
                        {
                                ObjCmd.Parameters.Add("@REGISTRATIONID", SqlDbType.BigInt).Value = ObjBll.RegistrationId;

                        }


                        ObjCmd.ExecuteNonQuery();
                }

                public DataTable ReturnDT(ClsBllServiceRegistration ObjBll, int flag)
                {
                        if (con.State == ConnectionState.Closed)
                                con.Open();
                        ObjCmd = new SqlCommand("SP_SERVICEREGISTRATION");
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.Connection = con;
                        ObjCmd.Parameters.Clear();

                        ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
                        if (flag == 6)
                        {
                                ObjCmd.Parameters.Add("@PRODUCTID", SqlDbType.BigInt).Value = ObjBll.ProductId;

                        }
                        if (flag == 7)
                        {
                                ObjCmd.Parameters.Add("@SERVICEID", SqlDbType.BigInt).Value = ObjBll.ServiceId;
                        }
                        if (flag == 8)
                        {
                                ObjCmd.Parameters.Add("@REGISTRATIONID", SqlDbType.BigInt).Value = ObjBll.RegistrationId;
                        }
                        if (flag == 11)
                        {
                                ObjCmd.Parameters.Add("@CUSTOMERID", SqlDbType.BigInt).Value = ObjBll.CustomerId;
                        }

                        SqlDataAdapter SDA = new SqlDataAdapter(ObjCmd);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                        return DT;

                }

                public void Delete(ClsBllServiceRegistration ObjBll, int flag)
                {
                        //            ConnectToDb();
                        if (con.State == ConnectionState.Closed)
                                con.Open();
                        SqlCommand ObjCmd = new SqlCommand("SP_SERVICEREGISTRATION");
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.Connection = con;
                        ObjCmd.Parameters.Clear();



                        ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
                        ObjCmd.Parameters.Add("@REGISTRATIONID", SqlDbType.BigInt).Value = ObjBll.RegistrationId;

                        ObjCmd.ExecuteNonQuery();


                }


        }
}
