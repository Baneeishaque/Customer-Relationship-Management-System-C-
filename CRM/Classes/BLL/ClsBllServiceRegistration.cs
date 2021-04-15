using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    class ClsBllServiceRegistration
    {
        ClsDalServiceRegistration ObjDal = new ClsDalServiceRegistration();

        private DateTime _OrderDate;
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }

        private int _RegistrationId;
        public int RegistrationId
        {
            get { return _RegistrationId; }
            set { _RegistrationId = value; }
        }

        private int _RegistrationDetailsId;
        public int RegistrationDetailsId
        {
            get { return _RegistrationDetailsId; }
            set { _RegistrationDetailsId = value; }
        }

        private int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        private string _ServiceUID;
        public string ServiceUID
        {
            get { return _ServiceUID; }
            set { _ServiceUID = value; }
        }

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

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

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

        private int _ServiceId;
        public int ServiceId
        {
            get { return _ServiceId; }
            set { _ServiceId = value; }
        }

        private string _ServiceName;
        public string ServiceName
        {
            get { return _ServiceName; }
            set { _ServiceName = value; }
        }

        private DateTime _DeliveryDate;
        public DateTime DeliveryDate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }

        private string _Cost;
        public string Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        private string _TotalCost;
        public string TotalCost
        {
            get { return _TotalCost; }
            set { _TotalCost = value; }
        }

        public void Save(int flag)
        {
            ObjDal.Save(this, flag);
        }

        public DataTable ReturnDT(int flag)
        {
            return ObjDal.ReturnDT(this, flag);

        }

        public void Delete(int flag)
        {
            ObjDal.Delete(this, flag);
        }

        private DataTable _DataTableToSave;
        public DataTable DataTableToSave
        {
            get { return _DataTableToSave; }
            set { _DataTableToSave = value; }
        }

        private string _DtString;
        public string DtString
        {
            get { return _DtString; }
            set { _DtString = value; }
        }


    }
}
