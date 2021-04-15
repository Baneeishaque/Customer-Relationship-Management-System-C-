using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CRM
{
    class ClsBllLoginMaster
    {
        ClsdalLoginMaster objdal = new ClsdalLoginMaster();


        public string UserName { get; set; }

        public String Password { get; set; }


        public DataTable Returndatatable(int flag)
        {
            return objdal.ReturnDataTable(flag,this);


        }
    }
}
