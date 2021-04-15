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
    public partial class LoginMaster : Form
    {
        public LoginMaster()
        {
            InitializeComponent();
        }
        ClsBllLoginMaster objBll=new ClsBllLoginMaster();
        private void LoginMaster_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            label6.Text = DateTime.Now.ToShortTimeString();
            checkUser();

        }
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        public  void checkUser()
        {
          dt=objBll.Returndatatable(1);
          dt.AcceptChanges();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            
                objBll.UserName = txtUserName.Text;
                objBll.Password = TxtPassword.Text;
                objBll.Returndatatable(2);
                dt = objBll.Returndatatable(1);

                dt.AcceptChanges();
                //txtUserName.ResetText();
                //TxtPassword.ResetText();

            if (dt.Rows.Count > 0)
            {
                
                
                string Criteria="UserName ='"+txtUserName.Text.Trim()+"'and Password='"+TxtPassword.Text.Trim()+"'";
                dv = new DataView(dt, Criteria, "", DataViewRowState.OriginalRows);

            }
            //this.Close();
            if (dv.ToTable().Rows.Count > 0)
            {
                CRM ff = new CRM(this);
                ff.Show();
                txtUserName.Focus();
                this.Hide();

                PrchaseForm t = new PrchaseForm();
                t.Show();

                t.label1.Text = txtUserName.Text;
                TxtPassword.ResetText();
                txtUserName.ResetText();
                
            }
            
            else
            {

                MessageBox.Show("Invalid UserName and Password");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserMaster u = new UserMaster();
            u.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToShortTimeString();
        }

       
    }
}
