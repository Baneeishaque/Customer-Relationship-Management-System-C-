using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CRM
{
    class ClsDalProductMaster
    {
        
        SqlCommand ObjSqlCmd;
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        public DataTable Dt = new DataTable();


        public void Save(ClsBllProductMaster ObjBll, int flag)
        {
            
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand ObjSqlCmd = new SqlCommand("SP_PRODUCTMASTER");
            ObjSqlCmd.CommandType = CommandType.StoredProcedure;
            ObjSqlCmd.Connection = con;

            ObjSqlCmd.Parameters.Clear();
            ObjSqlCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            if (flag == 3)
                ObjSqlCmd.Parameters.Add("@PRODUCTID", SqlDbType.BigInt).Value = ObjBll.ProductId;
            ObjSqlCmd.Parameters.Add("@PRODUCTNAME", SqlDbType.VarChar).Value = ObjBll.ProductName;
            ObjSqlCmd.Parameters.Add("@MANUFACTURER", SqlDbType.VarChar).Value = ObjBll.Manufacturer;
            ObjSqlCmd.Parameters.Add("@MODELNO", SqlDbType.VarChar).Value = ObjBll.ModelNo;
            ObjSqlCmd.Parameters.Add("@SUPPLIER", SqlDbType.VarChar).Value = ObjBll.Supplier;
            ObjSqlCmd.Parameters.Add("@PRODUCTDIMENSION", SqlDbType.VarChar).Value = ObjBll.ProductDimension;
            ObjSqlCmd.Parameters.Add("@PRODUCTDIMENSIONUNIT", SqlDbType.VarChar).Value = ObjBll.ProductDimensionUnit;
            ObjSqlCmd.Parameters.Add("@SHIPPINGWEIGHT", SqlDbType.VarChar).Value = ObjBll.ShippingWeight;
            ObjSqlCmd.Parameters.Add("@SHIPPINGWEIGHTUNIT", SqlDbType.VarChar).Value = ObjBll.ShippingWeightUnit;
            ObjSqlCmd.Parameters.Add("@PRODUCTPRICE", SqlDbType.VarChar).Value = ObjBll.ProductPrice;

            ObjSqlCmd.ExecuteNonQuery();


        }

        public DataTable ReturnDataTable(ClsBllProductMaster ObjBll, int flag)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand ObjSqlCmd = new SqlCommand("SP_PRODUCTMASTER");
            ObjSqlCmd.CommandType = CommandType.StoredProcedure;
            ObjSqlCmd.Connection = con;

            ObjSqlCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            SqlDataAdapter sda = new SqlDataAdapter(ObjSqlCmd);
            DataTable Dt = new DataTable();
            sda.Fill(Dt);
            return Dt;
        }

        public void Delete(ClsBllProductMaster ObjBll, int flag)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            ObjSqlCmd = new SqlCommand("SP_PRODUCTMASTER");
            ObjSqlCmd.Connection = con;
            ObjSqlCmd.CommandType = CommandType.StoredProcedure;

            ObjSqlCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            ObjSqlCmd.Parameters.Add("@PRODUCTID", SqlDbType.BigInt).Value = ObjBll.ProductId;

            ObjSqlCmd.ExecuteNonQuery();

        }


    }
}
