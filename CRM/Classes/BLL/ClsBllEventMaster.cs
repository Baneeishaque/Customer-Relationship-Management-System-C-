using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CRM
{
    class ClsBllEventMaster
    {
        ClsDalEventMaster objdal = new ClsDalEventMaster();
        private string _EventName;
        public string EventName
        {
            get { return _EventName; }
            set { _EventName = value; }

        }
        private String _Description;
        public string Description
        {
            get {return _Description;}
            set {_Description = value;}
        
        }
        private DateTime _StartDate;
        public DateTime StartDate
        {
            get { return _StartDate;}
            set { _StartDate = value; }
        
        }
        private DateTime _EndDate;
        public DateTime EndDate
        {
            get {return _EndDate;}
            set {_EndDate = value;}
        
        }
        private DateTime _StartTime;
        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }


        }
        private DateTime _EndTime;
        public DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        
        }
        private string _Location;
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }

        }
        private string _Priority;
        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value;}
        
        
        }
        private string _NotificationRequired;
        public string NotificationRequired
        {
            get { return _NotificationRequired; }
            set { _NotificationRequired = value; }
        
        }
        private string _NotificationType;
        public string NotificationType
        {
            get { return _NotificationType; }
            set { _NotificationType = value; }
        
        }
        private DateTime _NotificationTime;
        public DateTime NotificationTime
        {
            get { return _NotificationTime; }
            set { _NotificationTime = value; }
        
        }
        private DateTime _NotificationStartDate;
        public DateTime NotificationStartDate
        {
            get { return _NotificationStartDate; }
            set { _NotificationStartDate = value; }
        
        }
        private DateTime _NotificationEndDate;
        public DateTime NotificationEndDate
        {
            get { return _NotificationEndDate; }
            set { _NotificationEndDate = value; }
        
        }
        private Int32 _EventId;
        public Int32 EventId
        {
            get { return _EventId; }
            set { _EventId = value; }
        
        }
        private string _Sunday;
        public string Sunday
        {
            get { return _Sunday; }
            set { _Sunday = value; }
        
        }
        private string _Monday;
        public string Monday
        {
            get { return _Monday; }
            set { _Monday = value; }

        }
        private string _Tuesday;
        public string Tuesday
        {
            get { return _Tuesday;}
            set { _Tuesday = value; }
        
        }
        private string _Wednesday;
        public string Wednesday
        {
            get { return _Wednesday; }
            set { _Wednesday = value; }
        
        }
        private string _Thursday;
        public string Thursday
        {
            get { return _Thursday; }
            set { _Thursday = value; }
        
        
        }
        private string _Friday;
        public string Friday
        {
            get { return _Friday; }
            set { _Friday = value; }
        
        }
        private string _Saturday;
        public string Saturday
        {

            get { return _Saturday; }
            set { _Saturday = value; }
        
        }
        public void save(int flag)
        { 
         objdal.save(this,flag); 
        }
        public DataTable ReturnDateTable(int flag)
        {
            return objdal.ReturnDateTable(this, flag);
         
        }
        public void delete(int flag)
        {
            objdal.delete(this, flag);
        
        }




        internal void delete()
        {
            throw new NotImplementedException();
        }
    }
}
