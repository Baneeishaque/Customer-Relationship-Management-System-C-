using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class CRM : Form//Base.FormBase
    {
        public object FrmLogin;

        public CRM()
        {
            InitializeComponent();
        }

        public CRM(LoginMaster objLogin)
        {
            InitializeComponent();
            FrmLogin = objLogin;
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerMaster c = new CustomerMaster();
            c.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductMaster P = new ProductMaster();
            P.Show();
        }
        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeMaster EM = new EmployeeMaster();
            EM.Show();
        }
        private void seviceRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceRegistration sr = new ServiceRegistration();
            sr.Show();
        }
        private void serviceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceEntry s = new ServiceEntry();
            s.Show();
        }
        private void FrmMenuStrip_Load(object sender, EventArgs e)
        {
           
            //SetTitle(this);
            //SetContainerColor(this);
            //MaximizeBox = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {



            label1.Text = DateTime.Now.ToShortTimeString();

            //label1.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void addNewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventMaster em = new EventMaster();
            em.Show();
        }

        private void eventReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventMasterReport r = new frmEventMasterReport();
            r.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyDetails c = new CompanyDetails();
            c.Show();
        }

        private void createARemainderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemainderMaster f = new FrmRemainderMaster();
            f.Show();
        }

        private void serviceScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceSchedule s = new ServiceSchedule();
            s.Show();

        }

        private void serviceRegReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeviceRegistrationReport d = new FrmSeviceRegistrationReport();
            d.Show();
        }

        private void eventReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventMasterReport g = new frmEventMasterReport();
            g.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoginMaster m = new LoginMaster();
            //m.Show();

            Form objLogin = (Form)FrmLogin;
            objLogin.Show();

            this.Hide();


            
        }

    }
}
