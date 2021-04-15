using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CRM
{
    class ClsBllCustomerMaster
    {
        ClsDalCustomerMaster objdal = new ClsDalCustomerMaster();
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
        private Int32 _Nationality;
        public Int32 Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        
        }
        private Int32 _State;
        public Int32 State
        {
            get { return _State; }
            set { _State = value; }

        
        
        }
        private string _Locality;
        public string Locality
        {
            get { return _Locality; }
            set { _Locality = value; }
        }
        private string _TinNo;
        public string TinNo
        {
            get { return _TinNo; }
            set { _TinNo = value; }
        
        }
        private string _PhoneNo1;
        public string PhoneNo1
        {
            get { return _PhoneNo1; }
            set { _PhoneNo1 = value; }
        }
        private string _PhoneNo2;
        public string PhoneNo2
        {
            get { return _PhoneNo2; }
            set { _PhoneNo2 = value; }


        }
        private Int32 _CountryId;
        public Int32 CountryId
        {
            get{ return _CountryId; }
            set { _CountryId = value; }
        
        }
        private string _EmailID;
        public string EmailID
        {
            get { return _EmailID; }
            set { _EmailID = value; }
        
        }
        private byte[] _Photo;
        public byte[] Photo
        {
            get { return _Photo; }
            set { _Photo = value;}
        
        }
        private string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        
        
        }
        public void save(int flag)
        {

            objdal.save(this,flag);
        }
        public DataTable returndatatable(int flag)
        {
            return objdal.returndatatable(this,flag);

        }
        
        private int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        
        }
        public void delete()
        {
            objdal.delete(this);
        
        }
        //public int maxid(int flag)
        //{
        //    return objdal.maxid(this,flag);
        //}

    }
}
