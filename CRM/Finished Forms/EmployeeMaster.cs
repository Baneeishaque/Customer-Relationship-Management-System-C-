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
        public partial class EmployeeMaster : FormBase.FormBase
        {
                ClsBllEmployeeMaster ObjBll = new ClsBllEmployeeMaster();
                public DataTable DtExperience = new DataTable();

                public EmployeeMaster()
                {
                        InitializeComponent();
                }

                private void EmployeeMaster_Load(object sender, EventArgs e)
                {
                    SetTitle(this);
                    SetContainerColor(this);
                    SetControlColor(btnClose,btnEdit,btnNew,btnDelete);
                  
                    btnPlus.Tag = 0;
                    fillGridHistory();
                    grpExperience.Enabled = false;
                    dtpExperienceFromDate.Value = DateTime.Now;
                    dtpExperienceToDate.Value = DateTime.Now;
                }

                public void DeleteRowFromGridExperiences()
                {
                        if (dgvExperiences.Rows.Count > 0)
                        {
                                dgvExperiences.Rows.RemoveAt(dgvExperiences.CurrentRow.Index);
                                MessageBox.Show("Row Deleted");
                        }
                        else
                        {
                                MessageBox.Show("No row to delete", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                }

                public void fillGridHistory()
                {
                        DataTable DtGrid = new DataTable();
                        DtGrid = ObjBll.ReturnTable(5);
                        dgvHistory.DataSource = DtGrid;

                }

                public void fillGridExperienceFromDatabase()
                {
                        ObjBll.EmployeeId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["EmployeeId"].Value);
                        DtExperience = ObjBll.ReturnTable(10);
                        dgvExperiences.DataSource = DtExperience;
                }

                public void fillCmbCountry()
                {
                        DataTable DtCountry = new DataTable();
                        DtCountry = ObjBll.ReturnTable(2);
                        cmbNationality.DisplayMember = "CountryName";
                        cmbNationality.ValueMember = "CountryId";
                        cmbNationality.DataSource = DtCountry;
                }

                public void fillCmbState()
                {

                        DataTable DtState = new DataTable();
                        ObjBll.CountryId = Convert.ToInt32(cmbNationality.SelectedValue);
                        if (ObjBll.CountryId > 0)
                        {
                                DtState = ObjBll.ReturnTable(3);
                                cmbState.DisplayMember = "StateName";
                                cmbState.ValueMember = "StateId";
                                cmbState.DataSource = DtState;
                        }
                }

                public void fillCmbDesignation()
                {
                        DataTable DtDesignation = new DataTable();
                        DtDesignation = ObjBll.ReturnTable(4);
                        cmbDesignation.DisplayMember = "Designation";
                        cmbDesignation.ValueMember = "DesignationId";

                        cmbDesignation.DataSource = DtDesignation;
                }

                public void AddValuesToGridExperience()
                {

                        if (DtExperience.Columns.Count < 1)
                        {
                                DtExperience.Columns.Add("ExpId");
                                //DtExperience.Columns.Add("EmployeeId");
                                DtExperience.Columns.Add("Company");
                                DtExperience.Columns.Add("FromDate");
                                DtExperience.Columns.Add("ToDate");
                                DtExperience.Columns.Add("ExpRole");
                        }

                        if (Convert.ToInt32(btnPlus.Tag) == 0)
                        {
                                DataRow DtExpRow = DtExperience.NewRow();
                                DtExpRow["ExpId"] = 0;

                                //DtExperence_r1["EmployeeId"] = Convert.ToInt32(dgvHistory.CurrentRow.Cells["EmployeeId"].Value.ToString());
                                string fromDate = dtpExperienceFromDate.Text;
                                DtExpRow["Company"] = txtExperienceCompany.Text;
                                DtExpRow["FromDate"] = fromDate;
                                string toDate = dtpExperienceToDate.Text;
                                DtExpRow["ToDate"] = toDate ;
                                DtExpRow["ExpRole"] = txtExperienceRole.Text;
                                DtExperience.Rows.Add(DtExpRow);

                        }
                        else if (Convert.ToInt32(btnPlus.Tag) > 0)
                        {
                                DtExperience.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["Company"] = txtExperienceCompany.Text;
                                DtExperience.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["FromDate"] = dtpExperienceFromDate.Value.ToString();
                                DtExperience.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ToDate"] = dtpExperienceFromDate.Value.ToString();
                                DtExperience.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ExpRole"] = txtExperienceRole.Text;
                                MessageBox.Show("The Row updated");
                                btnPlus.Tag = 0;

                        }
                        else
                        {
                                MessageBox.Show("Some error");
                        
                        }


                        dgvExperiences.DataSource = DtExperience;
                        ClearExperienceColums();
                }

                public void ComboBox_InitialSet()
                {

                        cmbMaritialStatus.SelectedIndex = 0;
                        cmbBloodGroup.SelectedIndex = 0;
                        cmbEmployeeGrade.SelectedIndex = 0;
                        cmbEmployeeType.SelectedIndex = 0;

                }

                public void ClearExperienceColums()
                {
                        txtExperienceCompany.Text = "";
                        dtpExperienceFromDate.Value = DateTime.Now;
                        txtExperienceRole.Text = "";
                        dtpExperienceToDate.Value = DateTime.Now;

                }

                //public void SaveExperience()
                //{
                //    for (int i = 0; i < dgvExperiences.Rows.Count; i++)
                //    {


                //        ObjBll.ExperienceCompanny = Convert.ToString(dgvExperiences.Rows[i].Cells["Company"].Value);
                //        ObjBll.ExperienceFromDate = Convert.ToDateTime(dgvExperiences.Rows[i].Cells["FromDate"].Value);
                //        ObjBll.ExperienceToDate = Convert.ToDateTime(dgvExperiences.Rows[i].Cells["ToDate"].Value);
                //        ObjBll.ExpereienceRole = Convert.ToString(dgvExperiences.Rows[i].Cells["ExpRole"].Value);

                //        if (btnEdit.Text == "Update")
                //        {
                //            ObjBll.SaveExperience(11);
                //        }
                //        if (btnNew.Text == "Save")
                //        {

                //            ObjBll.SaveExperience(8);
                //        }
                //    }
                //}

                public void ClearDtExperience()
                {
                        int i = DtExperience.Rows.Count;
                        int j = i - 1;

                        while (j > -1 && j < i)
                        {
                                DtExperience.Rows.RemoveAt(j);
                                j--;
                        }

                        dgvExperiences.DataSource = DtExperience;
                }

                public void ClearFields()
                {
                        txtName.ResetText();
                        txtAddress.ResetText();
                        dtpDateOfBirth.Value = DateTime.Now;
                        rdbMale.Checked = false;
                        rdbFemale.Checked = false;
                        cmbMaritialStatus.ResetText();
                        txtReference.Text = "";
                        cmbBloodGroup.ResetText();
                        fillCmbCountry();
                        fillCmbDesignation();
                        txtLocation.ResetText();
                        txtPassportNumber.ResetText();
                        txtDrivingLicenceNumber.ResetText();
                        txtCompany.ResetText();
                        txtDepartment.ResetText();
                        cmbDesignation.ResetText();
                        dtpJoiningDate.Value = DateTime.Now;
                        txtProbationPeriod.ResetText();
                        dtpConfirmationDate.Value = DateTime.Now;
                        txtPAN.ResetText();
                        txtPhone1.Text = "";
                        txtPhone2.Text = "";
                        txtEmail.Text = "";
                        txtFax.Text = "";
                        cmbEmployeeGrade.ResetText();
                        cmbEmployeeType.ResetText();
                        txtReportingAuthority.ResetText();
                        rdbExperiencedNo.Checked = false;
                        rdbExperiencedYes.Checked = false;
                        cmbQualification.ResetText();
                        txtBordOrInstitute.ResetText();
                        txtPassoutYear.ResetText();
                        txtClass.ResetText();
                        ClearDtExperience();
                        picPhoto.BackgroundImage = null;

                }

                public bool ValidationOfFields()
                {
                        if (txtName.Text == "")
                                return false;
                        if (txtAddress.Text == "")
                                return false;

                        if ((rdbMale.Checked || rdbFemale.Checked) == false)
                                return false;
                        if (cmbMaritialStatus.Items.ToString() == "")
                                return false;
                        if (txtReference.Text == "")
                                return false;
                        if (cmbBloodGroup.Items.ToString() == "")
                                return false;

                        if (txtLocation.Text == "")
                                return false;
                        if (txtPassportNumber.Text == "")
                                return false;
                        if (txtDrivingLicenceNumber.Text == "")
                                return false;
                        if (txtCompany.Text == "")
                                return false;
                        if (txtDepartment.Text == "")
                                return false;
                        if (txtProbationPeriod.Text == "")
                                return false;
                        if (txtPAN.Text == "")
                                return false;
                        if (txtPhone1.Text == "")
                                return false;
                        if (txtPhone2.Text == "")
                                return false;
                        if (txtEmail.Text == "")
                                return false;
                        if (txtFax.Text == "")
                                return false;
                        if (cmbEmployeeGrade.Items.ToString() == "")
                                return false;
                        if (cmbEmployeeType.Items.ToString() == "")
                                return false;
                        if ((rdbExperiencedNo.Checked || rdbExperiencedYes.Checked) == false)
                                return false;
                        if (txtReportingAuthority.Text == "")
                                return false;
                        if ((rdbExperiencedYes.Checked || rdbExperiencedNo.Checked) == false)
                                return false;
                        if (cmbQualification.Items.ToString() == "")
                                return false;
                        if (txtBordOrInstitute.Text == "")
                                return false;
                        if (txtPassoutYear.Text == "")
                                return false;
                        if (txtClass.Text == "")
                                return false;
                        if (rdbExperiencedYes.Checked == true)
                        {
                                if (dgvExperiences.Rows.Count == 0)
                                {
                                        DialogResult Dg = MessageBox.Show("Do you want to add experience?","Experience ...", MessageBoxButtons.YesNo);
                                        if (Dg == DialogResult.No)
                                        {
                                                rdbExperiencedNo.Checked = true;
                                                return true;
                                        }
                                        else 
                                        {
                                                return false;
                                        }

                                 }
                        }
                        if (rdbExperiencedNo.Checked == true)
                        {
                                if (dgvExperiences.Rows.Count > 0)
                                {
                                        DialogResult Dg = MessageBox.Show("No experience. Discard the Datas?", "Experience...", MessageBoxButtons.YesNo);
                                        if (Dg == DialogResult.Yes)
                                        {
                                                return true;
                                        }
                                        else
                                        {
                                                rdbExperiencedYes.Checked = true;
                                                return false;
                                        }
                                }
                        }

                        return true;
                }

                public byte[] ImageToByteArray(System.Drawing.Image ImageIn)
                {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        ImageIn.Save(ms, ImageIn.RawFormat);
                        return ms.ToArray();
                }

                public Image ByteArrayToImage(byte[] ByteArrayIn)
                {
                        MemoryStream ms = new MemoryStream(ByteArrayIn);
                        Image ReturnImage = Image.FromStream(ms);
                        return ReturnImage;

                }


                public void SaveFields()
                {
                        ObjBll.Name = txtName.Text;
                        ObjBll.Address = txtAddress.Text;
                        ObjBll.DateOfBirth = dtpDateOfBirth.Value;

                        if (rdbMale.Checked == true)
                        {
                                ObjBll.Gender = "Male";
                        }
                        if (rdbFemale.Checked == true)
                        {
                                ObjBll.Gender = "Female";
                        }

                        ObjBll.MaritalStatusId = Convert.ToInt32( cmbMaritialStatus.SelectedValue.ToString());
                        ObjBll.Reference = txtReference.Text;
                        ObjBll.BloodGroupId = Convert.ToInt32(cmbBloodGroup.SelectedValue);
                        ObjBll.NationalityId = Convert.ToInt32(cmbNationality.SelectedValue);
                        ObjBll.StateId = Convert.ToInt32(cmbState.SelectedValue);
                        ObjBll.Location = txtLocation.Text;
                        ObjBll.PassportNumber = txtPassportNumber.Text;
                        ObjBll.DrivingLincenceNo = txtDrivingLicenceNumber.Text;
                        ObjBll.Company = txtCompany.Text;
                        ObjBll.Department = txtDepartment.Text;
                        ObjBll.DesignationId = Convert.ToInt32(cmbDesignation.SelectedValue);
                        ObjBll.JoiningDate = dtpJoiningDate.Value;
                        ObjBll.ProbationPeriod = txtProbationPeriod.Text;
                        ObjBll.ConfirmationDate = dtpConfirmationDate.Value;
                        ObjBll.PAN = txtPAN.Text;
                        ObjBll.Phone1 = txtPhone1.Text;
                        ObjBll.Phone2 = txtPhone2.Text;
                        ObjBll.Email = txtEmail.Text;
                        ObjBll.Fax = txtFax.Text;
                        ObjBll.EmployeeGrade = cmbEmployeeGrade.SelectedItem.ToString();
                        ObjBll.EmployeeType = cmbEmployeeType.SelectedItem.ToString();
                        ObjBll.ReportingAuthority = txtReportingAuthority.Text;

                        if (rdbExperiencedYes.Checked == true)
                        {
                                ObjBll.ExperiencedOrNot = "Yes";
                        }
                        if (rdbExperiencedNo.Checked == true)
                        {
                                ObjBll.ExperiencedOrNot = "No";
                        }

                        if (picPhoto.BackgroundImage != null)
                        {

                                ObjBll.Photo = ImageToByteArray(picPhoto.BackgroundImage);
                                picPhoto.Image = null;

                        }
                        if (picPhoto.Image != null)
                        {
                                picPhoto.BackgroundImage = null;
                                ObjBll.Photo = ImageToByteArray(picPhoto.Image);
                        }


                        ObjBll.QualificationId =Convert.ToInt32( cmbQualification.SelectedValue);
                        ObjBll.BoardOrUniversity = txtBordOrInstitute.Text;
                        ObjBll.PassoutYear = txtPassoutYear.Text;
                        ObjBll.Class = txtClass.Text;
                        ObjBll.Mark = txtMark.Text;
                        if (rdbExperiencedYes.Checked == true)
                        {
                                ObjBll.DtExperience = (DataTable)dgvExperiences.DataSource;
                        }
                        else
                        {
                                ClearDtExperience();
                                ObjBll.DtExperience = (DataTable)dgvExperiences.DataSource;

                        }


                        if (btnNew.Text == "Save")
                        {

                                ObjBll.Save(1);


                        }
                        if (btnEdit.Text == "Update")
                        {
                                ObjBll.EmployeeId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["EmployeeId"].Value);
                                ObjBll.Save(7);
                        }

                }

                public void EditFieldGender()
                {
                        if (dgvHistory.CurrentRow.Cells["Gender"].Value.ToString() == "Male")
                                rdbMale.Checked = true;
                        if (dgvHistory.CurrentRow.Cells["Gender"].Value.ToString() == "Female")
                                rdbFemale.Checked = true;
                }

                public void fillAllComboboxes()
                {
                        FillCmbBloodGroup();
                        FillcmbMaritalStatus();
                        FillCmbQualification();
                        fillCmbCountry();
                        fillCmbDesignation();
                        
                }

                public void FillcmbMaritalStatus()
                {
                        DataTable DtMaritalStatus = ObjBll.ReturnTable(14);
                        cmbMaritialStatus.ValueMember = "MaritalStatusId";
                        cmbMaritialStatus.DisplayMember = "MaritalStatus";
                        cmbMaritialStatus.DataSource = DtMaritalStatus;

                }

                public void FillCmbBloodGroup()
                {
                        DataTable dtBlood = ObjBll.ReturnTable(13);
                        cmbBloodGroup.ValueMember = "BloodGroupId";
                        cmbBloodGroup.DisplayMember = "BloodGroup";
                        cmbBloodGroup.DataSource = dtBlood;
                }

                public void EditFieldCmbEmployeeGrade()
                {
                        if (dgvHistory.CurrentRow.Cells["EmployeeGrade"].Value.ToString() == "A")
                                cmbEmployeeGrade.SelectedIndex = 0;
                        if (dgvHistory.CurrentRow.Cells["EmployeeGrade"].Value.ToString() == "B")
                                cmbEmployeeGrade.SelectedIndex = 1;
                        if (dgvHistory.CurrentRow.Cells["EmployeeGrade"].Value.ToString() == "C")
                                cmbEmployeeGrade.SelectedIndex = 2;
                }

                public void EditFieldCmbEmployeeType()
                {
                        if (dgvHistory.CurrentRow.Cells["EmployeeType"].Value.ToString() == "Contracters")
                                cmbEmployeeType.SelectedIndex = 0;
                        if (dgvHistory.CurrentRow.Cells["EmployeeType"].Value.ToString() == "Permanent")
                                cmbEmployeeType.SelectedIndex = 1;
                        if (dgvHistory.CurrentRow.Cells["EmployeeType"].Value.ToString() == "Part time")
                                cmbEmployeeType.SelectedIndex = 2;
                        if (dgvHistory.CurrentRow.Cells["EmployeeType"].Value.ToString() == "Temperary")
                                cmbEmployeeType.SelectedIndex = 3;
                        if (dgvHistory.CurrentRow.Cells["EmployeeType"].Value.ToString() == "Other")
                                cmbEmployeeType.SelectedIndex = 4;
                }

                public void FillCmbQualification()
                {
                       DataTable DtQualification = ObjBll.ReturnTable(12);
                       cmbQualification.ValueMember = "QualificationId";
                       cmbQualification.DisplayMember = "Qualification";
                       cmbQualification.DataSource = DtQualification;

                }

                public void EditSingleExperience()
                {

                        txtExperienceCompany.Text = dgvExperiences.CurrentRow.Cells["Company"].Value.ToString();
                        dtpExperienceFromDate.Value = Convert.ToDateTime(dgvExperiences.CurrentRow.Cells["FromDate"].Value);
                        dtpExperienceToDate.Value = Convert.ToDateTime(dgvExperiences.CurrentRow.Cells["ToDate"].Value);
                        txtExperienceRole.Text = dgvExperiences.CurrentRow.Cells["ExpRole"].Value.ToString();

                }

                public void EditFieldExperiencedOrNot()
                {
                        if (dgvHistory.CurrentRow.Cells["ExperiencedOrNot"].Value.ToString() == "Yes")
                        {
                                rdbExperiencedYes.Checked = true;
                        }
                        else if (dgvHistory.CurrentRow.Cells["ExperiencedOrNot"].Value.ToString() == "No")
                        {
                                rdbExperiencedNo.Checked = true;
 
                        }
                        else
                        {
                                MessageBox.Show("Some error in Database");
                        }
                }

                public void EditFieldAll()
                {
                        txtName.Text = dgvHistory.CurrentRow.Cells["Name1"].Value.ToString();
                        txtAddress.Text = dgvHistory.CurrentRow.Cells["Address"].Value.ToString();
                        dtpDateOfBirth.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["DateOfBirth"].Value);
                        EditFieldGender();
                        FillcmbMaritalStatus();
                        cmbMaritialStatus.SelectedValue = Convert.ToInt32(dgvHistory.CurrentRow.Cells["MaritalStatusId"].Value.ToString());
                        txtReference.Text = dgvHistory.CurrentRow.Cells["Reference"].Value.ToString();
                        FillCmbBloodGroup();

                        fillCmbCountry();
                        cmbNationality.SelectedValue = Convert.ToInt32(dgvHistory.CurrentRow.Cells["NationalityId"].Value); 
                        
                        cmbState.SelectedValue = Convert.ToInt32(dgvHistory.CurrentRow.Cells["StateId"].Value); 
                        txtLocation.Text = dgvHistory.CurrentRow.Cells["Location"].Value.ToString(); 
                        txtPassportNumber.Text = dgvHistory.CurrentRow.Cells["PassportNumber"].Value.ToString();
                        txtPassportNumber.Text = dgvHistory.CurrentRow.Cells["PassportNumber"].Value.ToString();
                        txtDrivingLicenceNumber.Text = dgvHistory.CurrentRow.Cells["DrivingLicenceNo"].Value.ToString();

                        txtCompany.Text = dgvHistory.CurrentRow.Cells["Company1"].Value.ToString();
                        txtDepartment.Text = dgvHistory.CurrentRow.Cells["Department"].Value.ToString();
                        fillCmbDesignation();
                        cmbDesignation.SelectedValue = Convert.ToInt32(dgvHistory.CurrentRow.Cells["DesignationId"].Value);
                        dtpJoiningDate.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["JoiningDate"].Value);

                        txtProbationPeriod.Text = dgvHistory.CurrentRow.Cells["ProbationPeriod"].Value.ToString();
                        dtpConfirmationDate.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["ConfirmationDate"].Value);
                        txtPAN.Text = dgvHistory.CurrentRow.Cells["PAN"].Value.ToString();
                        txtPhone1.Text = dgvHistory.CurrentRow.Cells["Phone1"].Value.ToString();
                        txtPhone2.Text = dgvHistory.CurrentRow.Cells["Phone2"].Value.ToString();
                        txtEmail.Text = dgvHistory.CurrentRow.Cells["Email"].Value.ToString();
                        txtFax.Text = dgvHistory.CurrentRow.Cells["Fax"].Value.ToString();
                        EditFieldCmbEmployeeGrade();
                        EditFieldCmbEmployeeType();
                        txtReportingAuthority.Text = dgvHistory.CurrentRow.Cells["ReportingAuthority"].Value.ToString();
                        EditFieldExperiencedOrNot();

                        FillCmbQualification();


                        txtBordOrInstitute.Text = dgvHistory.CurrentRow.Cells["BoardOrUniversity"].Value.ToString();
                        txtPassoutYear.Text = dgvHistory.CurrentRow.Cells["PassoutYear"].Value.ToString();
                        txtClass.Text = dgvHistory.CurrentRow.Cells["Class"].Value.ToString();
                        txtMark.Text = dgvHistory.CurrentRow.Cells["Mark"].Value.ToString();
                        fillGridExperienceFromDatabase();
                        //picPhoto.BackgroundImage = ByteArrayToImage((byte[])dgvHistory.CurrentRow.Cells["Photo"].Value);
                        //ClearDtExperience();
                        fillGridExperienceFromDatabase();
                        pnlEntry.BringToFront();
                        pnlEntry.Enabled = true;

                }


                private void btnNew_Click(object sender, EventArgs e)
                {
                        if (btnNew.Text == "New")
                        {
                                pnlEntry.Enabled = true;

                                pnlEntry.BringToFront();

                                btnNew.Text = "Save";
                                btnClose.Text = "Cancel";
                                btnEdit.Enabled = false;
                                btnDelete.Enabled = false;
                                ClearFields();
                                fillCmbCountry();
                                fillGridHistory();
                                FillCmbQualification();
                                FillCmbBloodGroup();
                                FillcmbMaritalStatus();

                                
                        }
                        else
                        {
                                if (ValidationOfFields() == false)
                                {
                                        MessageBox.Show("Please fill all the fields?");
                                }
                                else
                                {
                                        SaveFields();
                                        ClearFields();


                                        //SaveExperience();


                                        fillGridHistory();
                                        btnNew.Text = "New";
                                        btnClose.Text = "Close";
                                        pnlHistory.BringToFront();
                                }

                        }
                }

                private void btnClose_Click(object sender, EventArgs e)
                {
                        if (btnClose.Text == "Close")
                        {
                                this.Close();
                        }
                        else
                        {
                                DialogResult dg = MessageBox.Show("Are you sure want to Cancel?", "Confirm to Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dg == DialogResult.Yes)
                                {
                                        ClearFields();
                                        pnlHistory.BringToFront();
                                        btnClose.Text = "Close";
                                        btnNew.Text = "New";
                                        btnNew.Enabled = true;
                                        btnDelete.Enabled = true;
                                        btnEdit.Enabled = true;

                                        btnEdit.Text = "Edit";
                                }

                        }
                }

                private void lnklblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        //OpenFileDialog ObjFile = new OpenFileDialog();
                        //ObjFile.Filter = "Image Files (*.jpg,*.jpeg,*.png,*.bmp,*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                        //ObjFile.ShowDialog(this);
                        //if (ObjFile.FileName != "")
                        //{
                        //    picPhoto.BackgroundImage = Image.FromFile(ObjFile.FileName);
                        //    picPhoto.BackgroundImageLayout = ImageLayout.Stretch;

                        //}

                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                                picPhoto.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                                //MessageBox.Show("path ");
                        }
                }






                private void txtName_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Enter)
                        {
                                SendKeys.Send("{TAB}");
                        }
                }

                private void cmbNationality_SelectedValueChanged(object sender, EventArgs e)
                {
                        fillCmbState();

                }

                private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        picPhoto.BackgroundImage = null;
                }

                private void txtFax_KeyUp(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Escape)
                                txtEmail.Focus();
                }

                private void txtEmail_KeyUp(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Escape)
                                txtPhone2.Focus();
                }

                private void txtPhone2_KeyUp(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Escape)
                                txtPhone1.Focus();
                }

                private void txtPhone1_KeyUp(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Escape)
                                dtpJoiningDate.Focus();
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                        DialogResult dg = MessageBox.Show("Are you want to delete?", "Confirem delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                                ObjBll.EmployeeId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["EmployeeId"].Value);
                                ObjBll.Delete();
                                fillGridHistory();

                        }


                }

                private void btnEdit_Click(object sender, EventArgs e)
                {
                        if (btnEdit.Text == "Update")
                        {
                                if (ValidationOfFields() == false)
                                {
                                        MessageBox.Show("Please fill all the fields?");
                                }
                                else
                                {
                                        DialogResult dg = MessageBox.Show("Do you want to Update?", "Confirem Update.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dg == DialogResult.Yes)
                                        {
                                                SaveFields();
                                                btnEdit.Text = "Edit";
                                                btnEdit.Enabled = true;
                                                btnNew.Enabled = true;
                                                btnDelete.Enabled = true;
                                                btnClose.Text = "Close";
                                                pnlHistory.BringToFront();
                                                fillGridHistory();
                                                MessageBox.Show("Updated Successfully");
                                        }
                                }
                        }
                        else
                        {
                                EditFieldAll();
                                btnClose.Text = "Cancel";
                                btnEdit.Text = "Update";
                                btnNew.Enabled = false;
                                btnDelete.Enabled = false;

                        }
                }

                private void dgvHistory_DoubleClick(object sender, EventArgs e)
                {
                        btnEdit.PerformClick();
                }

                private void dgvHistory_KeyDown(object sender, KeyEventArgs e)
                {
                        //if (e.KeyCode == Keys.Delete)
                        //{
                        //    if (dgvHistory.Rows.Count > 0)
                        //    {
                        //        DialogResult dg = MessageBox.Show("Do you want to delete?", "Confirmation to Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //        if (dg == DialogResult.Yes)
                        //        {
                        //            int intex = Convert.ToInt32(dgvHistory.CurrentRow.Index);
                        //            dgvHistory.Rows.RemoveAt(intex);
                        //            MessageBox.Show("Deleted Successfully!");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("No Data to delte");
                        //    }

                        //}
                }

                private void txtPhone1_KeyPress(object sender, KeyPressEventArgs e)
                {
                        if (e.KeyChar == (char)Keys.Back)
                        {
                                return;
                        }
                        if (Char.IsDigit(e.KeyChar))
                        {
                                return;

                        }
                        e.Handled = true;

                }

                private void txtPhone2_KeyPress(object sender, KeyPressEventArgs e)
                {
                        if (e.KeyChar == (char)Keys.Back)
                        {
                                return;
                        }
                        if (Char.IsDigit(e.KeyChar))
                        {
                                return;
                        }
                        e.Handled = true;
                }

                private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
                {
                        if (e.KeyChar == (char)Keys.Back)
                        {
                                return;
                        }
                        if (Char.IsDigit(e.KeyChar))
                        {
                                return;
                        }
                        if (e.KeyChar == '-' || e.KeyChar == '+')
                        {
                                return;
                        }
                        e.Handled = true;
                }


                private void btnPlus_Click(object sender, EventArgs e)
                {
                        if ((txtExperienceCompany.Text != "" && txtExperienceRole.Text != "") == true)
                        {
                                if (btnPlus.Text == "+")
                                {
                                        AddValuesToGridExperience();
                                }
                        }
                }

                private void dtpDateOfBirth_KeyUp(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Escape)
                        {
                                txtAddress.Focus();
                        }
                }

                private void txtReference_KeyUp(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Escape)
                        {
                                cmbMaritialStatus.Focus();
                        }
                }


               
                private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                }

                private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                btnEdit.PerformClick();
                        }
                }

                private void label29_Click(object sender, EventArgs e)
                {

                }

                private void rdbExperiencedYes_CheckedChanged(object sender, EventArgs e)
                {
                        if (rdbExperiencedYes.Checked == true)
                        {
                                grpExperience.Enabled = true;
                        }
                        else
                        {
                                grpExperience.Enabled = false;
                        }
                }

                private void dgvExperiences_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Delete)
                        {
                                DialogResult Dg = MessageBox.Show("Do you want to delete this row?", "Confirm Deleting row...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                                if (Dg == DialogResult.Yes)
                                {
                                        DeleteRowFromGridExperiences();
                                }

                        }

                        if (e.KeyCode == Keys.Space)
                        {
                                btnPlus.Tag = dgvExperiences.CurrentRow.Index + 1;
                                EditSingleExperience();

                        }
                }

                private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }

                private void pnlHistory_Paint(object sender, PaintEventArgs e)
                {

                }












        }
}
