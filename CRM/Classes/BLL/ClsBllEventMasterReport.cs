using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CRM
{
    class ClsBllEventMasterReport
    {
        ClsDalEventMasterReport objdal = new ClsDalEventMasterReport();
        private Int32 _EventId;
        public Int32 EventId
        {
            get { return _EventId; }
            set { _EventId = value; }
        
        
        }

        private string _Priority;

        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }


        }
        public DataTable ReturnDataTable(int Flag)
        {
            return objdal.ReturnDataTable(this, Flag);
        
        
        }
        
    }
}
