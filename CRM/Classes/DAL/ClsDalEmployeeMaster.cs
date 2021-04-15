using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRM
{
    class ClsDalEmployeeMaster
    {
        //SqlConnection CON = new SqlConnection("server=SACLAP08-PC; uid=sa; pwd=sa; database=DB_CRM");
        SqlConnection CON = new SqlConnection(ConfigurationSettings.AppSettings["VARCON"]);
        SqlCommand ObjCmd = new SqlCommand();
        SqlDataAdapter Sda = new SqlDataAdapter();
        DataTable Dt = new DataTable();
            

        public void ConnectToDb()
        {
            if (CON.State == ConnectionState.Closed)
                CON.Open();
            SqlCommand ObjCmd = new SqlCommand("SP_EMPLOYEEMASTER");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;

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

        public void Save(ClsBllEmployeeMaster ObjBll, int flag)
        {
            //ConnectToDb();

            if (CON.State == ConnectionState.Closed)
                CON.Open();
            SqlCommand ObjCmd = new SqlCommand("SP_EMPLOYEEMASTER");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;

            ObjCmd.Parameters.Clear();

            
            ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            if (flag == 7)
            {
                ObjCmd.Parameters.Add("@EMPLOYEEID", SqlDbType.BigInt).Value = ObjBll.EmployeeId;
            }
            ObjCmd.Parameters.Add("@EMPLOYEENAME", SqlDbType.VarChar).Value = ObjBll.Name;
            ObjCmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = ObjBll.Address;
            ObjCmd.Parameters.Add("@DATEOFBIRTH", SqlDbType.DateTime).Value = ObjBll.DateOfBirth;
            ObjCmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = ObjBll.Gender;
            ObjCmd.Parameters.Add("@MARITALSTATUSID", SqlDbType.BigInt).Value = ObjBll.MaritalStatusId;
            ObjCmd.Parameters.Add("@REFERENCE", SqlDbType.VarChar).Value = ObjBll.Reference;
            ObjCmd.Parameters.Add("@BLOODGROUP", SqlDbType.BigInt).Value = ObjBll.BloodGroupId;
            ObjCmd.Parameters.Add("@NATIONALITYID", SqlDbType.BigInt).Value = ObjBll.NationalityId;
            ObjCmd.Parameters.Add("@STATEID", SqlDbType.BigInt).Value = ObjBll.StateId;
            ObjCmd.Parameters.Add("@LOCATION", SqlDbType.VarChar).Value = ObjBll.Location;
            ObjCmd.Parameters.Add("@PASSPORTNUMBER", SqlDbType.VarChar).Value = ObjBll.PassportNumber;
            ObjCmd.Parameters.Add("@DRIVINGLICENCENO", SqlDbType.VarChar).Value = ObjBll.PassportNumber;
            
            
            ObjCmd.Parameters.Add("@COMPANY", SqlDbType.VarChar).Value = ObjBll.Company;
            ObjCmd.Parameters.Add("@DEPARTMENT", SqlDbType.VarChar).Value = ObjBll.Department;
            ObjCmd.Parameters.Add("@DESIGNATIONID", SqlDbType.BigInt).Value = ObjBll.DesignationId;
            ObjCmd.Parameters.Add("@JOININGDATE", SqlDbType.DateTime).Value = ObjBll.JoiningDate;
            ObjCmd.Parameters.Add("@PROBATIONPERIOD", SqlDbType.VarChar).Value = ObjBll.ProbationPeriod;
            ObjCmd.Parameters.Add("@CONFIRMATIONDATE", SqlDbType.DateTime).Value = ObjBll.ConfirmationDate;
            ObjCmd.Parameters.Add("@PAN", SqlDbType.VarChar).Value = ObjBll.PAN;
            ObjCmd.Parameters.Add("@PHONE1", SqlDbType.VarChar).Value = ObjBll.Phone1;
            ObjCmd.Parameters.Add("@PHONE2", SqlDbType.VarChar).Value = ObjBll.Phone2;
            ObjCmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = ObjBll.Email;
            ObjCmd.Parameters.Add("@FAX", SqlDbType.VarChar).Value = ObjBll.Fax;
            
            ObjCmd.Parameters.Add("@EMPLOYEEGRADE", SqlDbType.VarChar).Value = ObjBll.EmployeeGrade;
            ObjCmd.Parameters.Add("@EMPLOYEETYPE", SqlDbType.VarChar).Value = ObjBll.EmployeeType;
            ObjCmd.Parameters.Add("@REPORTINGAUTHORITY", SqlDbType.VarChar).Value = ObjBll.ReportingAuthority;
            ObjCmd.Parameters.Add("@EXPERIENCEDORNOT", SqlDbType.VarChar).Value = ObjBll.ExperiencedOrNot;

            ObjCmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = ObjBll.Photo;
            
            
            ObjCmd.Parameters.Add("@QUALIFICATION", SqlDbType.BigInt).Value = ObjBll.QualificationId;
            ObjCmd.Parameters.Add("@BOARDORUNIVERSITY", SqlDbType.VarChar).Value = ObjBll.BoardOrUniversity;
            ObjCmd.Parameters.Add("@PASSOUTYEAR", SqlDbType.VarChar).Value = ObjBll.PassoutYear;
            ObjCmd.Parameters.Add("@CLASS", SqlDbType.VarChar).Value = ObjBll.Class;
            ObjCmd.Parameters.Add("@MARK", SqlDbType.VarChar).Value = ObjBll.Mark;
            ObjCmd.Parameters.Add("@EXPERIENCEXML", SqlDbType.Xml).Value = ConvertToXml(ObjBll.DtExperience);


            ObjCmd.ExecuteNonQuery();

            

        }


        //public void ExperienceSave(ClsBllEmployeeMaster ObjBll, int flag)
        //{
        //    ConnectToDb();
            
        //    ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
        //    if (flag == 11)
        //        ObjCmd.Parameters.Add("@EXPID", SqlDbType.BigInt).Value = ObjBll.ExpId;
        //    ObjCmd.Parameters.Add("@EMPLOYEEID", SqlDbType.BigInt).Value = ObjBll.EmployeeId;
        //    ObjCmd.Parameters.Add("@EXPERIENCECOMPANY", SqlDbType.VarChar).Value = ObjBll.ExperienceCompanny;
        //    ObjCmd.Parameters.Add("@EXPERIENCEFROMDATE", SqlDbType.DateTime).Value = ObjBll.ExperienceFromDate;
        //    ObjCmd.Parameters.Add("@EXPERIENCETODATE", SqlDbType.DateTime).Value = ObjBll.ExperienceToDate;
        //    ObjCmd.Parameters.Add("@EXPERIENCEROLE", SqlDbType.VarChar).Value = ObjBll.ExpereienceRole;

        //    ObjCmd.ExecuteNonQuery();


        //}

        public DataTable RetrunDataTable(ClsBllEmployeeMaster ObjBll,int flag)
        {
            //ConnectToDb();

            if (CON.State == ConnectionState.Closed)
                CON.Open();
            SqlCommand ObjCmd = new SqlCommand("SP_EMPLOYEEMASTER");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;

            ObjCmd.Parameters.Clear();
            

            ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = flag;
            if (flag == 10)
            {
                ObjCmd.Parameters.Add("@EMPLOYEEID", SqlDbType.BigInt).Value = ObjBll.EmployeeId;
            }
            if (flag == 3)
            {
                ObjCmd.Parameters.Add("@COUNTRYID", SqlDbType.BigInt).Value = ObjBll.CountryId;
            }
            SqlDataAdapter Sda = new SqlDataAdapter(ObjCmd);
            DataTable Dt = new DataTable();
            Sda.Fill(Dt);
            return Dt;
            
        }

        public void Delete(ClsBllEmployeeMaster ObjBll)
        {
//            ConnectToDb();
  
            if (CON.State == ConnectionState.Closed)
                CON.Open();
            SqlCommand ObjCmd = new SqlCommand("SP_EMPLOYEEMASTER");
            ObjCmd.CommandType = CommandType.StoredProcedure;
            ObjCmd.Connection = CON;

            ObjCmd.Parameters.Clear();


            ObjCmd.Parameters.Add("@FLAG", SqlDbType.BigInt).Value = 6;
            ObjCmd.Parameters.Add("@EMPLOYEEID", SqlDbType.BigInt).Value = ObjBll.EmployeeId;

            ObjCmd.ExecuteNonQuery();
 
        }

        
    }
}
