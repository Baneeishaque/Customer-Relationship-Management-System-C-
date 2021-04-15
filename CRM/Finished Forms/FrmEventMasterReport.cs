using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM.Reports;
//using System.

namespace CRM
{
    public partial class frmEventMasterReport : Form
    {
        ClsBllEventMasterReport objbll = new ClsBllEventMasterReport();
        DataTable DtEventName;
        DataTable DtEventReport;
        DataTable DtPriority;
        
        public frmEventMasterReport()
        {
            InitializeComponent();
        }
        public void FillEventName()

        {

            objbll.EventId = Convert.ToInt32(cmbEventName.SelectedValue);
            DtEventName = new DataTable();
            DtEventName = objbll.ReturnDataTable(2);
            cmbEventName.ValueMember = "EventId";
            cmbEventName.DisplayMember = "EventName";
            cmbEventName.DataSource = DtEventName;
           
        }
        public void FillPriority()
        {
            objbll.EventId = Convert.ToInt32(cmbPriority.SelectedValue);

            DtPriority = new DataTable();

            DtPriority = objbll.ReturnDataTable(3);
            cmbPriority.ValueMember = "EventId";
            cmbPriority.DisplayMember = "Priority";
            cmbPriority.DataSource = DtPriority;

        }
        
        private void frmEventMasterReport_Load(object sender, EventArgs e)
        {
            FillEventName();
            cmbEventName.SelectedIndex = -1;
            FillPriority();
            cmbPriority.SelectedIndex = -1;
        

        }

        private void cmbEventName_SelectedValueChanged(object sender, EventArgs e)
        {
            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbEventName.Text != "")
                objbll.EventId = Convert.ToInt32(cmbEventName.SelectedValue);
            else
            {
                objbll.EventId = 0;

                if (cmbPriority.Text != "")
                {
                    
                    objbll.Priority = Convert.ToString(cmbPriority.Text);
                    
                }
                else
                    objbll.Priority = "";
            }

                       //objbll.EventId = Convert.ToInt32(cmbPriority.SelectedValue);
                       DtEventReport = new DataTable();
                       DtEventReport = objbll.ReturnDataTable(1);
                       CrpEventReport objEventReport = new CrpEventReport();
                       objEventReport.SetDataSource(DtEventReport);
                       FrmEventReportViewer EventViewer = new FrmEventReportViewer();
                       EventViewer.CrvEventReport.ReportSource = objEventReport;
                       EventViewer.Show();

                   
        }

       

        
    }
}
