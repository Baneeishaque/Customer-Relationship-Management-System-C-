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
    public partial class UserMaster : Form
    {
        public UserMaster()
        {
            InitializeComponent();
        }
        ClsBllUserMaster objbll = new ClsBllUserMaster();

        private void UserMaster_Load(object sender, EventArgs e)
        {
            //notifyIcon1.Text = "A new Messsage";
            

        }


        public bool Validation()
        {
            if (txtFirstName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtFirstName, "First name can't be empty");
                txtFirstName.Focus();
                return false;

            }
            if (txtLastName.Text.Trim() == "")
            {

                errorProvider1.SetError(txtLastName, "Last name can't be empty");
                txtLastName.Focus();
                return false;
            }
            if (txtUserName1.Text.Trim() == "")
            {
                errorProvider1.SetError(txtUserName1, "User name can't be empty");
                txtUserName1.Focus();
                return false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPassword, "Enter the Password");
                txtPassword.Focus();
                return false;
            
            }
            if (txtCompany.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCompany, "Company name can't be empty");
                txtCompany.Focus();
                return false;
            }
            if (txtCountry.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCountry, "Company name can't be empty");
                txtCountry.Focus();
                return false;

            }
            if (txtState.Text.Trim() == "")
            {
                errorProvider1.SetError(txtState, "State name can't be empty");
                txtState.Focus();
                return false;

            }
            if (txtCity.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCity, "City name can't be empty");
                txtCity.Focus();
                return false;

            }
            if (txtPhoneNo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPhoneNo, "PhoneNo name can't be empty");
                txtPhoneNo.Focus();
                return false;

            }
            if (txtEmail.Text.Trim() == "")
            {
                errorProvider1.SetError(txtEmail, "Email Id can't be empty");
                txtEmail.Focus();
                return false;

            }
            
            
            return true;
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                objbll.FirstName = txtFirstName.Text;
                objbll.LastName = txtLastName.Text;
                objbll.UserName = txtUserName1.Text;
                objbll.Password = txtPassword.Text;
                objbll.Company = txtCompany.Text;
                objbll.Country = txtCountry.Text;
                objbll.State = txtState.Text;
                objbll.City = txtCity.Text;
                objbll.PhoneNo = txtPhoneNo.Text;
                objbll.EmailId = txtEmail.Text;
                objbll.save(1);
                //this.Close();
                
            }
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            
            }


        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
