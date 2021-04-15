using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    class ClsBllEmployeeMaster
    {
        ClsDalEmployeeMaster ObjDal = new ClsDalEmployeeMaster();

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private Int32 _EmployeeId;
        public Int32 EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        


        private string _MaritalStatus;
        public string MaritalStatus
        {
            get { return _MaritalStatus; }
            set { _MaritalStatus= value; }
        }

        private int _MaritalStatusId;
        public int MaritalStatusId
        {
                get { return _MaritalStatusId; }
                set { _MaritalStatusId = value; }
        }


        private string _Reference;
        public string Reference
        {
            get { return _Reference; }
            set { _Reference= value; }
        }
        

        private int _BloodGroupId ;
        public int BloodGroupId 
        {
            get { return _BloodGroupId ; }
            set {_BloodGroupId  = value; }
        }

        private string _PassportNumber;
        public string PassportNumber
        {
            get { return _PassportNumber; }
            set {_PassportNumber = value; }
        }
        

        private string _DrivingLincenceNo;
        public string DrivingLincenceNo
        {
            get { return _DrivingLincenceNo; }
            set {_DrivingLincenceNo= value; }
        }
        

        private string _Company;
        public string Company
        {
            get { return _Company; }
            set {_Company = value; }
        }

        private Int32 _QualificationId;
        public Int32 QualificationId
        {
            get { return _QualificationId; }
            set { _QualificationId = value; }
        }
        private string _BoardOrUniversity;
        public string BoardOrUniversity
        {
            get { return _BoardOrUniversity; }
            set { _BoardOrUniversity = value; }
        }

        private string _PassoutYear;
        public string PassoutYear
        {
            get { return _PassoutYear; }
            set { _PassoutYear = value; }
        }

        private string _Class;
        public string Class
        {
            get { return _Class; }
            set { _Class = value; }
        }

        private string _Mark;
        public string Mark
        {
                get { return _Mark; }
                set { _Mark = value; }
        }

        private string _Department;
        public string Department
        {
            get { return _Department; }
            set {_Department = value; }
        }
        

        private string _ProbationPeriod;
        public string ProbationPeriod
        {
            get { return _ProbationPeriod; }
            set {_ProbationPeriod = value; }
        }
        
        private Int32 _NationalityId;
        public Int32 NationalityId 
        {
            get { return _NationalityId; }
            set {_NationalityId = value; }
        }

        private DateTime _ConfirmationDate;
        public DateTime ConfirmationDate
        {
            get { return _ConfirmationDate; }
            set { _ConfirmationDate = value; }
        }

        private string _PAN;
        public string PAN
        {
            get { return _PAN; }
            set { _PAN = value; }
        }

        private string _EmployeeGrade;
        public string EmployeeGrade
        {
            get { return _EmployeeGrade; }
            set { _EmployeeGrade = value; }
        }

        private string _EmployeeType;
        public string EmployeeType
        {
            get { return _EmployeeType; }
            set { _EmployeeType = value; }
        }




        private string _ReportingAuthority;
        public string ReportingAuthority
        {
            get { return _ReportingAuthority; }
            set { _ReportingAuthority = value; }
        }

        private string _ExperiencedOrNot;
        public string ExperiencedOrNot
        {
            get { return _ExperiencedOrNot; }
            set { _ExperiencedOrNot = value; }
        }

        private Int32 _CountryId;
        public Int32 CountryId
        {
            get { return _CountryId; }
            set { _CountryId = value; }
        }







        private Int32 _StateId ;
        public Int32 StateId 
        {
            get { return _StateId ; }
            set { _StateId = value; }
        }


        private string _Location;
        public string Location
        {
            get { return _Location; }
            set {_Location = value; }
        }


        private string _Phone1;
        public string Phone1
        {
            get { return _Phone1; }
            set { _Phone1= value; }
        }


        private string _Phone2;
        public string Phone2
        {
            get { return _Phone2; }
            set {_Phone2 = value; }
        }


        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email= value; }
        }


        private string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax= value; }
        }

        private byte[] _Photo;
        public byte[] Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        }

        

        private Int32 _DesignationId ;
        public Int32 DesignationId 
        {
            get { return _DesignationId ; }
            set {_DesignationId  = value; }
        }

        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        private DateTime _JoiningDate;
        public DateTime JoiningDate
        {
            get { return _JoiningDate; }
            set { _JoiningDate = value; }
        }

        private int _ExpId;
        public int ExpId
        {
            get { return _ExpId; }
            set { _ExpId = value; }
        }

        private string _ExperienceCompanny;
        public string ExperienceCompanny
        {
            get { return _ExperienceCompanny; }
            set { _ExperienceCompanny = value; }
        }

        private DateTime _ExperienceFromDate;
        public DateTime ExperienceFromDate
        {
            get { return _ExperienceFromDate; }
            set { _ExperienceFromDate = value; }
        }

        private DateTime _ExperienceToDate;
        public DateTime ExperienceToDate
        {
            get { return _ExperienceToDate; }
            set { _ExperienceToDate = value; }
        }

        private string _ExpereienceRole;
        public string ExpereienceRole
        {
            get { return _ExpereienceRole; }
            set { _ExpereienceRole = value; }
        }


        //public void SaveExperience(int flag)
        //{
        //    ObjDal.ExperienceSave(this,flag);
        //}

        public void Save(int flag)
        {
            ObjDal.Save(this, flag);
        }

        public DataTable ReturnTable(int flag)
        {
            return ObjDal.RetrunDataTable(this,flag);
        }



        public void Delete()
        {
            ObjDal.Delete(this);
        }

        private DataTable _DtExperience;
        public DataTable DtExperience
        {
            get{ return _DtExperience;}
            set{_DtExperience = value;}
        }





    }
}
