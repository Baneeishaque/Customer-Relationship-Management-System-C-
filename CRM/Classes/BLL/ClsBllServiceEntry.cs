using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    class ClsBllServiceEntry
    {
        ClsDalServiceEntry ObjDal = new ClsDalServiceEntry();

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
        
        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private int _ProductId;
        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }


        private string _TimeRequiredDays;
        public string TimeRequiredDays
        {
            get { return _TimeRequiredDays; }
            set { _TimeRequiredDays = value; }
        }

        private string _TimeRequiredHours;
        public string TimeRequiredHours
        {
            get { return _TimeRequiredHours; }
            set { _TimeRequiredHours = value; }
        }

        private string _TimeRequiredMinutes;
        public string TimeRequiredMinutes
        {
            get { return _TimeRequiredMinutes; }
            set { _TimeRequiredMinutes = value; }
        }

        private string _ServiceCost;
        public string ServiceCost
        {
            get { return _ServiceCost; }
            set { _ServiceCost = value; }
        }

        public DataTable ReturnData(int flag)
        {
            return ObjDal.ReturnDataTable(this, flag);
        }

        public void Save(int flag)
        {
            ObjDal.Save(this, flag);
        }

        public void Delete(int flag)
        {
            ObjDal.Delete(this, flag);
        }
    }
}
