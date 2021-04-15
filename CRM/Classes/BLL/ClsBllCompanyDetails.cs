using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

namespace CRM
{
    class ClsBllCompanyDetails
    {
        ClsDalCompanyDetails objdal = new ClsDalCompanyDetails();
        private string _CompanyName;
        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        
        }
        private string _CompanyWebsite;
        public string CompanyWebsite
        {
            get { return _CompanyWebsite; }
            set { _CompanyWebsite = value; }
        
        }
        private string _CompanyAddress;
        public string CompanyAddress
        {
            get { return _CompanyAddress; }
            set { _CompanyAddress = value; }
        }
        private string _CompanyDescription;
        public string CompanyDescription
        {
            get { return _CompanyDescription;}
            set { _CompanyDescription = value; }
        
        }
        private string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; }
        
        }
        private string _StateName;
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }

        }
        private string _ZipCode;
        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }

        }
        private string _Phone1;
        public string Phone1
        {
         get{return _Phone1;}
            set{_Phone1=value;}

        
        }
        private string _Phone2;
        public string Phone2
        {
            get { return _Phone2; }
            set { _Phone2 = value; }

        }
        private string _EmailId1;
        public string EmailId1
        {
            get { return _EmailId1; }
            set { _EmailId1 = value; }

        }

        private string _EmailId2;
        public string EmailId2
        {
            get { return _EmailId2; }
            set { _EmailId2 = value; }

        }
        private string _FacebookURL;
        public string FacebookURL
        {
            get { return _FacebookURL; }
            set { _FacebookURL = value; }

        }
        private string _TwitterURL;
        public string TwitterURL
        {
            get { return _TwitterURL; }
            set { _TwitterURL = value; }
            

        }
        private byte[] _Photo;
        public byte[] Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        
        }

        private Int32 _CompanyId;
        public Int32 CompanyId
        {
            get { return _CompanyId; }
            set { _CompanyId = value; }
        
        }
        public void save(int flag)
        {

             objdal.save(this, flag);
        }
        public void delete(int flag)
        {
            objdal.delete(this, flag);
        
        }
        public DataTable returndatatable(int flag)
        {
            return objdal.returndatatable(this, flag);
        
        }





        internal void save()
        {
            throw new NotImplementedException();
        }
    }
}
