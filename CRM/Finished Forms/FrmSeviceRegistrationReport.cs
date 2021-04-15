using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM.Reports;

namespace CRM
{
    public partial class FrmSeviceRegistrationReport : FormBase.FormBase
    {
        
        ClsBllServiceRegistrationReport ObjBll = new ClsBllServiceRegistrationReport();
        DataTable DtReport;
        DataTable Dtservice;
        DataTable DtCustomer;
        public FrmSeviceRegistrationReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillService()
        {
            Dtservice = new DataTable();
            Dtservice = ObjBll.ReturnDataTable(2);
            cmbService.ValueMember = "RegistrationId";
            cmbService.DisplayMember = "ServiceNo";
            cmbService.DataSource = Dtservice;
        }
        public void FillCustomer()
        {
            DtCustomer = new DataTable();
            DtCustomer = ObjBll.ReturnDataTable(3);
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.DataSource = DtCustomer;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ObjBll.ServiceId = Convert.ToInt32(cmbService.SelectedValue);
            ObjBll.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            DtReport = new DataTable();
            DtReport = ObjBll.ReturnDataTable(1);
            CrpRegisteredServiceReport ObjReport = new CrpRegisteredServiceReport();
            ObjReport.SetDataSource(DtReport);
            FrmReportViewer Obj1 = new FrmReportViewer();
            Obj1.crv.ReportSource = ObjReport;
            Obj1.Show();
            

        }
        
        private void FrmSeviceRegistrationReport_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitle(this);
            SetContainerColor(this);
            SetControlColor(btnClose, btnPrint);

            FillCustomer();
            FillService();
            cmbCustomer.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjBll.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            FillService();
            cmbService.SelectedIndex = -1;
        }
    }
}
