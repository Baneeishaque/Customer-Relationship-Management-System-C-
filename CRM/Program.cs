using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CRM;

namespace CRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new CRM.CustomerMaster());
          //Application.Run(new CRM.CompanyDetails());
           //Application.Run(new CRM.EventMaster());
            // Application.Run(new CRM.ServiceSchedule());
           //Application.Run(new CRM.ServiceCustomerMaster());
         //  Application.Run(new CRM.EmployeeMaster());    
           //Application.Run(new FrmSeviceRegistrationReport());
           // Application.Run(new frmEventMasterReport());
         //Application.Run(new CRM ());
           // Application.Run(new ServiceEntry());
            //Application.Run(new ProductMaster());
           // Application.Run(new ServiceRegistration());
           //Application.Run(new UserMaster());
      Application.Run(new LoginMaster());
            //Application.Run(new CurrencyMaster());
            //Application.Run(new Form ());
            //Application.Run(new FrmRemainderMaster());
       
        }   
    }
}
