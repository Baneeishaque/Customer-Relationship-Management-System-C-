using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    class ClsBllProductMaster
    {

        ClsDalProductMaster ObjDal = new ClsDalProductMaster();

        private int _ProductId;
        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private string _Manufacturer;
        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; }
        }

        private string _ModelNo;
        public string ModelNo
        {
            get { return _ModelNo; }
            set { _ModelNo = value; }
        }

        private string _Supplier;
        public string Supplier
        {
            get { return _Supplier; }
            set { _Supplier = value; }
        }

        private string _ProductDimension;
        public string ProductDimension
        {
            get { return _ProductDimension; }
            set { _ProductDimension = value; }
        }

        private string _ProductDimensionUnit;
        public string ProductDimensionUnit
        {
            get { return _ProductDimensionUnit; }
            set { _ProductDimensionUnit = value; }
        }



        private string _ShippingWeight;
        public string ShippingWeight
        {
            get { return _ShippingWeight; }
            set { _ShippingWeight = value; }
        }
        
        private string _ShippingWeightUnit;
        public string ShippingWeightUnit
        {
            get { return _ShippingWeightUnit; }
            set { _ShippingWeightUnit = value; }
        }
        
        private string _ProductPrice;
        public string ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }


        public void Save(int flag)
        {
            ObjDal.Save(this, flag);

        }

        public DataTable ReturnDataTable(int flag)
        {
            return ObjDal.ReturnDataTable(this,flag);
        }

        public void Delete(int flag)
        {
            ObjDal.Delete(this, flag);
        }

    }
}
