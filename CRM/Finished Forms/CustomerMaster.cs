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
    public partial class CustomerMaster : FormBase.FormBase
    {
        public CustomerMaster()
        {
            InitializeComponent();
        }

        ClsBllCustomerMaster objbll = new ClsBllCustomerMaster();

        DataTable dt1 = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtid.Text = objbll.maxid(7).ToString();




        }
        public void fillcountry()
        {
            DataTable dtcountry = new DataTable();
            dtcountry = objbll.returndatatable(2);
            cmbnationality.DisplayMember = "CountryName";
            cmbnationality.ValueMember = "CountryId";
            cmbnationality.DataSource = dtcountry;


        }
        public void fillstate()
        {
            objbll.CountryId = Convert.ToInt32(cmbnationality.SelectedValue);
            DataTable dtstate = new DataTable();
            dtstate = objbll.returndatatable(3);
            cmbstate.DisplayMember = "StateName";
            cmbstate.ValueMember = "StateId";
            cmbstate.DataSource = dtstate;



        }
        public void gridfill()
        {
            
            dt1 = objbll.returndatatable(4);
            dgvEmployeeMaster.DataSource = dt1;


        }
        public void Clearfields()
        {
            txtname.Text = "";
            txtaddress.Text = "";
            fillcountry();
            txtlocation.Text = "";
            txttinno.Text = "";
            txtphone1.Text = "";
            txtphone2.Text = "";
            txtemailid.Text = "";
            txtfax.Text = "";
            fillstate();

        }
        public bool validation()
        {
            erperror.Dispose();
            if (txtname.Text == "")
            {
                MessageBox.Show("Customer Name Can't Be Empty");
                txtname.Focus();
                return false;

            }
            if (txtaddress.Text == "")
            {
                MessageBox.Show("Customer Address Can't Be Empty");
                return false;
            }
            if (cmbnationality.DisplayMember == "")
            {
                MessageBox.Show("Country Name Can't Be Empty");
                return false;

            }
            if (cmbstate.DisplayMember == "")
            {
                MessageBox.Show("State Name Can't Be Empty");
                return false;

            }
            if (txtlocation.Text == "")
            {
                MessageBox.Show("Location Name Can't Be Empty");
                return false;

            }
            if (txttinno.Text == "")
            {
                MessageBox.Show("Tin No Can't Be Empty");
                return false;

            }
            if (txtphone1.Text == "")
            {
                MessageBox.Show("Phone No 1 Can't Be Empty");
                return false;
            }
            if (txtphone2.Text == "")
            {
                MessageBox.Show("Phone No 1 Can't Be Empty");
                return false;
            }
            if (txtfax.Text == "")
            {
                MessageBox.Show("Fax Can't Be Empty");
                return false;

            }
            if (txtemailid.Text == "")
            {
                erperror.SetError(txtemailid, "Fax Can't Be Empty");
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
            objdv = new DataView(dt1, criteria, "", DataViewRowState.OriginalRows);
            dgvEmployeeMaster.DataSource = objdv.ToTable();
        }

        


        private void btnNew_Click(object sender, EventArgs e)
        {


            if (btnNew.Text == "New")
            {
                btnedit.Enabled = false;
                btndelete.Enabled = false;

                pnlentry.Enabled = true;
                btnNew.Text = "Save";
                btnclose.Text = "Cancel";
                pnlentry.BringToFront();
                txtname.Focus();

            }
            else
            {
                if (validation() == true)
                {
                    objbll.Name = txtname.Text;
                    objbll.Address = txtaddress.Text;
                    objbll.Nationality = Convert.ToInt32(cmbnationality.SelectedValue);
                    objbll.State = Convert.ToInt32(cmbstate.SelectedValue);
                    objbll.Locality = txtlocation.Text;
                    objbll.TinNo = txttinno.Text;
                    objbll.PhoneNo1 = txtphone1.Text;
                    objbll.PhoneNo2 = txtphone2.Text;
                    objbll.EmailID = txtemailid.Text;
                    objbll.Fax = txtfax.Text;
                    objbll.Photo = imagetobytearray(picphoto.BackgroundImage);
                    objbll.save(1);
                    MessageBox.Show("Data Saved Successfully");
                    pnlhistory.BringToFront();
                    Clearfields();
                    btnedit.Enabled = true;
                    btndelete.Enabled = true;



                    gridfill();
                }
                else
                {
                    MessageBox.Show("Error While Saving");
                }




            }
        }
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtaddress.Focus();
        }


        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbnationality.Focus();
        }

        private void cmbnationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbstate.Focus();
        }

        private void cmbstate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtlocation.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {


            objbll.CustomerId = Convert.ToInt32(dgvEmployeeMaster.CurrentRow.Cells["CustomerId"].Value);
            DialogResult dg = MessageBox.Show("Are you sure to delete this data?", "confirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                objbll.delete();


                gridfill();
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {


            if (btnedit.Text == "Update")
            {

                DialogResult dg = MessageBox.Show("Are you sure to update?", "confirm to cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    if (validation() == true)
                    {
                        objbll.Name = txtname.Text;
                        objbll.Address = txtaddress.Text;
                        objbll.Nationality = Convert.ToInt32(cmbnationality.SelectedValue);
                        objbll.State = Convert.ToInt32(cmbstate.SelectedValue);
                        objbll.Locality = txtlocation.Text;
                        objbll.TinNo = txttinno.Text;
                        objbll.PhoneNo1 = txtphone1.Text;
                        objbll.PhoneNo2 = txtphone2.Text;
                        objbll.EmailID = txtemailid.Text;
                        objbll.Fax = txtfax.Text;
                        objbll.Photo = imagetobytearray(picphoto.BackgroundImage);
                        objbll.CustomerId = Convert.ToInt32(dgvEmployeeMaster.CurrentRow.Cells["CustomerId"].Value);

                        objbll.save(6);
                        pnlhistory.BringToFront();
                        btnedit.Text = "Edit";
                        btndelete.Enabled = true;
                        btnNew.Enabled = true;
                        Clearfields();

                        gridfill();
                    }
                    else
                    {
                        MessageBox.Show("Error While Updating");
                    }
                
                }

            }
            else
            {
                txtname.Focus();

                txtname.Text = dgvEmployeeMaster.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtaddress.Text = dgvEmployeeMaster.CurrentRow.Cells["Address"].Value.ToString();
                txtlocation.Text = dgvEmployeeMaster.CurrentRow.Cells["Locality"].Value.ToString();
                txttinno.Text = dgvEmployeeMaster.CurrentRow.Cells["TinNo"].Value.ToString();
                txtphone1.Text = dgvEmployeeMaster.CurrentRow.Cells["Phone1"].Value.ToString();
                txtphone2.Text = dgvEmployeeMaster.CurrentRow.Cells["Phone2"].Value.ToString();
                txtemailid.Text = dgvEmployeeMaster.CurrentRow.Cells["EmailId"].Value.ToString();
                txtfax.Text = dgvEmployeeMaster.CurrentRow.Cells["Fax"].Value.ToString();
                cmbnationality.SelectedValue = Convert.ToInt32(dgvEmployeeMaster.CurrentRow.Cells["NationalityId"].Value);
                cmbstate.SelectedValue = Convert.ToInt32(dgvEmployeeMaster.CurrentRow.Cells["StateId"].Value);
                picphoto.BackgroundImage = bytearraytoimage((byte[])dgvEmployeeMaster.CurrentRow.Cells["Photo"].Value);
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;






                pnlentry.BringToFront();
                btndelete.Enabled = false;
                btnNew.Enabled = false;

                pnlentry.Enabled = true;

                btnedit.Text = "Update";
                btnclose.Text = "Cancel";

                //Clearfields();

            }

        }

        private void dgvEmployeeMaster_DoubleClick(object sender, EventArgs e)
        {
            txtname.Focus();
            txtname.Text = dgvEmployeeMaster.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtaddress.Text = dgvEmployeeMaster.CurrentRow.Cells["Address"].Value.ToString();
            txtlocation.Text = dgvEmployeeMaster.CurrentRow.Cells["Locality"].Value.ToString();
            txttinno.Text = dgvEmployeeMaster.CurrentRow.Cells["TinNo"].Value.ToString();
            txtphone1.Text = dgvEmployeeMaster.CurrentRow.Cells["Phone1"].Value.ToString();
            txtphone2.Text = dgvEmployeeMaster.CurrentRow.Cells["Phone2"].Value.ToString();
            txtemailid.Text = dgvEmployeeMaster.CurrentRow.Cells["EmailId"].Value.ToString();
            txtfax.Text = dgvEmployeeMaster.CurrentRow.Cells["Fax"].Value.ToString();
            cmbnationality.SelectedValue = Convert.ToInt32(dgvEmployeeMaster.CurrentRow.Cells["NationalityId"].Value);
            cmbstate.SelectedValue = Convert.ToInt32(dgvEmployeeMaster.CurrentRow.Cells["StateId"].Value);
            picphoto.BackgroundImage = bytearraytoimage((byte[])dgvEmployeeMaster.CurrentRow.Cells["Photo"].Value);


            picphoto.BackgroundImageLayout = ImageLayout.Stretch;
            pnlentry.BringToFront();

            pnlentry.Enabled = true;
            btndelete.Enabled = false;
            btnNew.Enabled = false;

            btnedit.Text = "Update";
            btnclose.Text = "Cancel";

        }

        private void txttinno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;

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



        private void txtlocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttinno.Focus();

            }
        }

        private void txttinno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtphone1.Focus();
            }
        }

        private void txtphone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtphone2.Focus();
            }
        }

        private void txtphone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtfax.Focus();
        }

        private void txtfax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtemailid.Focus();
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }

        //private void form1_Load_1(object sender, EventArgs e)
        //{
        //    fillcountry();
           
        //}



        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog objfile = new OpenFileDialog();
            objfile.Filter = "image files (*.jpg,*jpeg,*.png,*.bmp,*.gif)|*.jpg;*jpeg;*.png;*.bmp;*.gif";
            objfile.ShowDialog(this);
            if (objfile.FileName != "")
            {
                picphoto.BackgroundImage = Image.FromFile(objfile.FileName);
                picphoto.BackgroundImageLayout = ImageLayout.Stretch;


            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picphoto.BackgroundImage = null;
        }

        private void CustomerMaster_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitle(this);
            SetContainerColor(this);
            SetControlColor(btnNew, btndelete, btnclose, btnedit);
            fillcountry();
            gridfill();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
           if (btnclose.Text == "Close")
            {
                
              DialogResult dj=MessageBox.Show("Are you sure to close?","confirm to exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
              if (dj == DialogResult.Yes)
              {

                  this.Close();

                  btnclose.Text = "Cancel";
              }
                
            }
            
            else
            {
                DialogResult dg = MessageBox.Show("Are you sure wanna cancel?", "Confirm to cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Clearfields();




                    pnlhistory.BringToFront();
                    btnclose.Text = "Close";
                    btnNew.Text = "New";
                    btnedit.Enabled = true;
                    btndelete.Enabled = true;
                    btnedit.Text = "Edit";
                    btnNew.Enabled = true;
                }
                
            }

        }

        private void cmbnationality_SelectedValueChanged(object sender, EventArgs e)
        {
            fillstate();
        }

        private void dgvEmployeeMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnedit.PerformClick();
        }

        private void PnlSearch_Load(object sender, EventArgs e)
        {

        }

        private void picphoto_Click(object sender, EventArgs e)
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

        private void tmrPanelSize_Tick(object sender, EventArgs e)
        {

        }

        


        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // CustomerMaster
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 262);
        //    this.Name = "CustomerMaster";
        //    this.Load += new System.EventHandler(this.CustomerMaster_Load);
        //    this.ResumeLayout(false);

        //}

        

    }
}
