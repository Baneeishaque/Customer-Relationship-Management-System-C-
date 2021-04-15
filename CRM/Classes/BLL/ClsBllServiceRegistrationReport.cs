using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CRM
{
    class ClsBllServiceRegistrationReport
    {
        ClsDalServiceRegistrationReport ObjDal = new ClsDalServiceRegistrationReport();
        #region Variables
        private Int32 custId;
        private Int32 servId;
        #endregion
        #region Properties

        public Int32 CustomerId
        {
            get { return custId; }
            set { custId = value; }
        }
    
        public Int32 ServiceId
        {
            get { return servId; }
            set { servId = value; }
        }
        #endregion
        #region methods
        public DataTable ReturnDataTable(int flag)
        {
            return ObjDal.returndatatable(this, flag);
        }
        #endregion
       
    }
}
