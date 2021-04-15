using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class CompanyDetails : FormBase.FormBase
    {
        ClsBllCompanyDetails objbll = new ClsBllCompanyDetails();

        DataTable dt = new DataTable();
        public CompanyDetails()
        {
            InitializeComponent();
        }
        public void statefill()
        {
            objbll.StateName = cmbState.DisplayMember;
            DataTable dtstate = new DataTable();
            dtstate = objbll.returndatatable(2);
            cmbState.DisplayMember = "StateName"; 
            cmbState.ValueMember = "StateId";
            cmbState.DataSource = dtstate;
         
        
        }
        public void gridfill()
        {
            //DataTable dt = new DataTable();
            dt = objbll.returndatatable(3);
            dgvcompanyinfo.DataSource = dt;
         
        
        
        }
        public void clearfields()
        {
            txtCompanyName.Text = "";
            txtCompanywebsite.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyDescription.Text = "";
            txtCity.Text = "";
            statefill();
            txtZipCode.Text = "";
            txtphone1.Text = "";
            txtphone2.Text = "";
            txtEmail1.Text = "";
            txtEmail2.Text = "";
            txtFacebookURL.Text = "";
            txtTwittrerURL.Text = "";
            picfoto.BackgroundImage = null;

        
        
        }
        public void search(string FieldName)
        {
            DataView objdv = new DataView();
            string[] Field = FieldName.Split(' ');
            FieldName = "";
            for (int i = 0; i < Field.Length; i++)
            {
                FieldName = FieldName + Field[i].Trim();

            }
            string criteria = "", TextToSearch = "";
            TextToSearch = TxtSearch.Text;
            if (RdbStartsWith.Checked == true) criteria = FieldName + " Like '" + TextToSearch.ToUpper().Trim() + "%'";
            if (RdbEndsWithH.Checked == true) criteria = FieldName + " Like '%" + TextToSearch.ToUpper().Trim() + "'";
            if (RdbContains.Checked == true) criteria = FieldName + " Like '%" + TextToSearch.ToUpper().Trim() + "%'";
            if (RdbDoesNotContains.Checked == true) criteria = FieldName + " Not Like '%" + TextToSearch.ToUpper().Trim() + "%'";
            objdv = new DataView(dt, criteria, "", DataViewRowState.OriginalRows);
            dgvcompanyinfo.DataSource = objdv.ToTable();
        }


        public bool validation()
        {


            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("Company name can't be empty");
                txtCompanyName.Focus();
                return false;

            }
            if (txtCompanywebsite.Text == "")
            {

                MessageBox.Show("Company website can't be empty");
                txtCompanywebsite.Focus();
                return false;
            }
            if (txtCompanyAddress.Text == "")
            {
                MessageBox.Show("Company address can't be empty");
                txtCompanyAddress.Focus();
                return false;
            }
            if (txtCompanyDescription.Text == "")
            {
                MessageBox.Show("Company Description can't be empty");
                txtCompanyDescription.Focus();
                return false;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("city name can't be empty");
                txtCity.Focus();
                return false;
            }
            if (cmbState.Text == "")
            {
                MessageBox.Show("State name can't be empty");
                cmbState.Focus();
                return false;

            }
            if (txtZipCode.Text == "")
            {
                MessageBox.Show("Zip code can't be empty");
                txtZipCode.Focus();
                return false;
            }
            if (txtphone1.Text == "")
            {
                MessageBox.Show("phone1 can't be empty");
                txtphone1.Focus();
                return false;
            }
            if (txtphone2.Text == "")
            {
                MessageBox.Show("phone2 can't be empty");
                txtphone2.Focus();
                return false;
            }
            if (txtEmail1.Text == "")
            {
                MessageBox.Show("email id-1 can't be empty");
                txtEmail1.Focus();
                return false;
            }
            if (txtEmail2.Text == "")
            {
                MessageBox.Show("email id-2 can't be empty");
                txtEmail2.Focus();
                return false;
            }
            if (txtFacebookURL.Text == "")
            {
                MessageBox.Show("facebookURL can't be empty");
                txtFacebookURL.Focus();
                return false;
            }
            if (txtTwittrerURL.Text == "")
            {
                MessageBox.Show("twitterURL can't be empty");
                txtTwittrerURL.Focus();
                return false;
            }
            return true;

        }
        
        public byte[] imagetobytearray(System.Drawing.Image imagein)
        {
            System.IO.MemoryStream msio = new System.IO.MemoryStream();
            imagein.Save(msio, imagein.RawFormat);
            return msio.ToArray();


        }
        public Image bytearraytoimage(byte[] bytearrayin)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytearrayin);

            System.Drawing.Image returnimage = System.Drawing.Image.FromStream(ms);
            return returnimage;

        }




        private void CompanyDetails_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitle(this);
            //SetContainerColor(this);
            SetControlColor(btndelete, btnNew, btnEdit, btnclose);


            statefill();
            gridfill();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                txtCompanyName.Focus();
                pnlentry.Enabled = true;
                btnNew.Text = "Save";
                btnclose.Text = "Cancel";
                pnlentry.BringToFront();
                btndelete.Enabled = false;
                btnEdit.Enabled = false;
                clearfields();

            }
            else
            {
                if (validation() == true)
                  {
                    objbll.CompanyName = txtCompanyName.Text;
                    objbll.CompanyWebsite = txtCompanywebsite.Text;
                    objbll.CompanyAddress = txtCompanyAddress.Text;
                    objbll.CompanyDescription = txtCompanyDescription.Text;
                    objbll.City = txtCity.Text;
                    objbll.StateName = cmbState.Text;
                    objbll.ZipCode = txtZipCode.Text;
                    objbll.Phone1 = txtphone1.Text;
                    objbll.Phone2 = txtphone2.Text;
                    objbll.EmailId1 = txtEmail1.Text;
                    objbll.EmailId2 = txtEmail2.Text;
                    objbll.FacebookURL = txtFacebookURL.Text;
                    objbll.TwitterURL = txtTwittrerURL.Text;
                    objbll.Photo = imagetobytearray(picfoto.BackgroundImage);
                    objbll.save(1);
                    MessageBox.Show("Data Saved successfully");

                    btnNew.Text = "New";
                    pnlhistory.BringToFront();

                    btndelete.Enabled = true;
                    btnEdit.Enabled = true;
                    gridfill();
            
                }
                else
                {
                    MessageBox.Show("Error while saving");
                    
                }
            }
        }

       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text=="Update")
            {
                if (validation()==true )
                {
                    objbll.CompanyName = txtCompanyName.Text;
                    objbll.CompanyWebsite = txtCompanywebsite.Text;
                    objbll.CompanyAddress = txtCompanyAddress.Text;
                    objbll.CompanyDescription = txtCompanyDescription.Text;
                    objbll.City = txtCity.Text;
                    objbll.StateName = cmbState.Text;
                    objbll.ZipCode = txtZipCode.Text;
                    objbll.Phone1 = txtphone1.Text;
                    objbll.Phone2 = txtphone2.Text;
                    objbll.EmailId1 = txtEmail1.Text;
                    objbll.EmailId2 = txtEmail2.Text;
                    objbll.FacebookURL = txtFacebookURL.Text;
                    objbll.TwitterURL = txtTwittrerURL.Text;
                    objbll.Photo = imagetobytearray(picfoto.BackgroundImage);
                    objbll.CompanyId = Convert.ToInt32(dgvcompanyinfo.CurrentRow.Cells["CompanyId"].Value);
                    objbll.save(4);
                    MessageBox.Show("Data updated succussfully");
                    pnlhistory.BringToFront();
                    btnEdit.Text = "Edit";
                    btnNew.Text = "New";
                    btnNew.Enabled = true;
                    btndelete.Enabled = true;


                    gridfill();
                }
                else 
                {
                    MessageBox.Show("Error while updating");
                }
            





            }
            else
            {

                txtCompanyName.Text = dgvcompanyinfo.CurrentRow.Cells["CompanyName"].Value.ToString();
                txtCompanywebsite.Text = dgvcompanyinfo.CurrentRow.Cells["CompanyWebsite"].Value.ToString();
                txtCompanyAddress.Text = dgvcompanyinfo.CurrentRow.Cells["CompanyAddress"].Value.ToString();
                txtCompanyDescription.Text = dgvcompanyinfo.CurrentRow.Cells["Companydescription"].Value.ToString();
                txtCity.Text = dgvcompanyinfo.CurrentRow.Cells["City"].Value.ToString();
                cmbState.Text = dgvcompanyinfo.CurrentRow.Cells["StateName"].Value.ToString();
                txtZipCode.Text = dgvcompanyinfo.CurrentRow.Cells["ZipCode"].Value.ToString();
                txtphone1.Text = dgvcompanyinfo.CurrentRow.Cells["Phone1"].Value.ToString();
                txtphone2.Text = dgvcompanyinfo.CurrentRow.Cells["Phone2"].Value.ToString();
                txtEmail1.Text = dgvcompanyinfo.CurrentRow.Cells["EmailId1"].Value.ToString();
                txtEmail2.Text = dgvcompanyinfo.CurrentRow.Cells["EmailId2"].Value.ToString();
                txtFacebookURL.Text = dgvcompanyinfo.CurrentRow.Cells["FacebookURL"].Value.ToString();
                txtTwittrerURL.Text = dgvcompanyinfo.CurrentRow.Cells["TwitterURL"].Value.ToString();
                picfoto.BackgroundImage = bytearraytoimage((byte[])dgvcompanyinfo.CurrentRow.Cells["Photo"].Value);
                picfoto.BackgroundImageLayout = ImageLayout.Stretch;
                pnlentry.BringToFront();
                btnNew.Enabled = false;
                btndelete.Enabled = false;
                btnEdit.Text = "Update";
                btnclose.Text = "Cancel";
                
            }

                
        }

        private Image bytearraytoimage()
        {
            throw new NotImplementedException();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("delete this data ?", "confirmtion to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                
                objbll.CompanyId = Convert.ToInt32(dgvcompanyinfo.CurrentRow.Cells["CompanyId"].Value);
                objbll.delete(5);
                MessageBox.Show("Deleted data successfully");
                gridfill();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (btnclose.Text == "Close")
            {
                this.Close();
                btnclose.Text="Cancel";

            }
            else 
            {
                DialogResult dg = MessageBox.Show("Are sure want to cancel?", "confirm to cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    clearfields();
                    pnlhistory.BringToFront();
                    btnclose.Text = "Close";
                    btnNew.Text = "New";
                    btnEdit.Text = "Edit";
                    btnEdit.Enabled = true;
                    btndelete.Enabled = true;
                    btnNew.Enabled = true;
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog objfile = new OpenFileDialog();
            objfile.Filter = "image files (*.jpg,*jpeg,*.png,*.bmp,*.gif)|*.jpg;*jpeg;*.png;*.bmp;*.gif";
            objfile.ShowDialog(this);
            if (objfile.FileName != "")
            {
                picfoto.BackgroundImage = Image.FromFile(objfile.FileName);
                picfoto.BackgroundImageLayout = ImageLayout.Stretch;


            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            picfoto.BackgroundImage = null;
        }

        private void dgvcompanyinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void txtphone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;

            }
            if (char.IsDigit(e.KeyChar))
            
                return;
                
                e.Handled = true;
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;

            }
            if (char.IsDigit(e.KeyChar))

                return;
           
            e.Handled = true;
            
        }

        private void txtphone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;

            }
            if (char.IsDigit(e.KeyChar))
            
                return;

                e.Handled = true;
            
            
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void pnlhistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlentry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
           
            if(CmbSearchType.Text!="")
                search(CmbSearchType.Text.Trim());
            if(TxtSearch.Text=="")
            {
                gridfill();
            }
        
        
        }

       


          

       
       
       
    }
}
        