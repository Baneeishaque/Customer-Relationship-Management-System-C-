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
        public partial class ServiceSchedule : FormBase.FormBase
        {
                public DataTable DtGridEntry;
                public DataTable DtGridHistory;
                public DataTable DtCmbEmployees;
                ClsBllSeviceScheduleMaster ObjBll = new ClsBllSeviceScheduleMaster();

                public ServiceSchedule()
                {
                        InitializeComponent();
                }

                public void Cancel()
                {
                        txtScheduleNo.ResetText();
                        cmbServiceNo.SelectedValue = -1;
                        txtCustomerName.ResetText();
                        txtphonenumber.ResetText();
                        txtAddress.ResetText();
                        try
                        {
                                DtGridEntry.Rows.Clear();
                        }
                        catch
                        { }
                        cmbEmployees.Visible = false;
                        dtpDeliveryDate.Visible = false;
                        btnEdit.Text = "Edit";
                        btnEdit.Enabled = false;
                        btnNew.Text = "New";
                        btnNew.Enabled = true;
                        fillGridHistory();

                }

                public void fillGridEntry()
                {
                        ObjBll.RegistrationId = Convert.ToInt32(cmbServiceNo.SelectedValue);
                        if (ObjBll.RegistrationId > 0)
                        {
                                DtGridEntry = ObjBll.returndatatable(3);
                                dgvServiceDetails.DataSource = DtGridEntry;
                        }
                }

                public void fillGridHistory()
                {
                        DtGridHistory = ObjBll.returndatatable(7);
                        dgvHistory.DataSource = DtGridHistory;
                }

                public void Delete()
                {
                        ObjBll.ScheduleId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["ScheduleId"].Value.ToString());
                        ObjBll.ScheduleDetailsId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["ScheduleDetailsId"].Value.ToString());
                        ObjBll.Delete(8);
                }

                public void Edit()
                {
                        btnEdit.Tag = "Edit";
                        txtScheduleNo.Text = dgvHistory.CurrentRow.Cells["ScheduleNo"].Value.ToString();
                        txtScheduleNo.Tag = dgvHistory.CurrentRow.Cells["ScheduleId"].Value.ToString();
                        cmbServiceNo.SelectedValue = Convert.ToInt32(dgvHistory.CurrentRow.Cells["RegistrationId"].Value.ToString());
                        EditSchedule();
                        pnlEntry.BringToFront();
                        btnNew.Enabled = false;
                        btnEdit.Text = "Update";
                        btnDelete.Enabled = false;
                        btnClose.Text = "Cancel";
                        grpScheduleNo.Enabled = true;
                        try
                        {
                                foreach (DataGridViewRow row in dgvServiceDetails.Rows)
                                {
                                        row.Cells[AssignNow.Name].Value = true;
                                }
                        }
                        catch
                        { }
                        grpServicedetails.Enabled = true;
                }

                public void EditSchedule()
                {
                        DataView ObjView = new DataView(DtGridHistory);
                        string scheduleEdit = dgvHistory.CurrentRow.Cells["ScheduleId"].Value.ToString();
                        int i = 0;
                        ObjView.RowFilter = "ScheduleId=" + scheduleEdit;
                        try
                        {
                                while (i < ObjView.Count)
                                {
                                        DataRow DtRow = DtGridEntry.NewRow();
                                        DtRow["ProductId"] = dgvHistory.CurrentRow.Cells["ProductId1"].Value.ToString();
                                        DtRow["ScheduleDetailsId"] = dgvHistory.CurrentRow.Cells["ScheduleDetailsId"].Value.ToString();
                                        DtRow["RegistrationDetailsId"] = dgvHistory.CurrentRow.Cells["RegistrationDetailsId1"].Value.ToString();
                                        DtRow["ProductName"] = dgvHistory.CurrentRow.Cells["ProductName1"].Value.ToString();
                                        DtRow["ServiceId"] = dgvHistory.CurrentRow.Cells["ServiceId1"].Value.ToString();
                                        DtRow["ServiceName"] = dgvHistory.CurrentRow.Cells["ServiceName1"].Value.ToString();
                                        DtRow["DeliveryDate"] = dgvHistory.CurrentRow.Cells["DeliveryDate1"].Value.ToString();

                                        DtRow["EmployeeId"] = dgvHistory.CurrentRow.Cells["EmployeeId1"].Value.ToString();
                                        DtRow["EmployeeName"] = dgvHistory.CurrentRow.Cells["EmployeeName1"].Value.ToString();
                                        DtGridEntry.Rows.Add(DtRow);
                                        i++;
                                }
                                dgvServiceDetails.DataSource = DtGridEntry;
                        }
                        catch
                        {
                                MessageBox.Show("Entry Grid Null!");
                        }
                }

                public void FillCmbEmployees()
                {
                        DtCmbEmployees = ObjBll.returndatatable(4);
                        cmbEmployees.ValueMember = "EmployeeId";
                        cmbEmployees.DisplayMember = "EmployeeName";
                        cmbEmployees.DataSource = DtCmbEmployees;
                }

                public void ResetCmbEmployees()
                {
                        cmbEmployees.Location = new System.Drawing.Point(411, 485);
                        cmbEmployees.Visible = false;
                }

                public void FillcmbServiceNo()
                {
                        DataTable dt = new DataTable();
                        dt = ObjBll.returndatatable(1);

                        cmbServiceNo.ValueMember = "RegistrationId";
                        cmbServiceNo.DisplayMember = "ServiceNo";
                        cmbServiceNo.DataSource = dt;

                }

                public void fillTxtSchedulNo()
                {
                        DataTable DtScheduleNo = ObjBll.returndatatable(6);
                        txtScheduleNo.Text = "Sch"+DtScheduleNo.Rows[0][0].ToString();
                }

                public void fillTextBoxes()
                {
                        ObjBll.RegistrationId = Convert.ToInt32(cmbServiceNo.SelectedValue);
                        if (ObjBll.RegistrationId > 0)
                        {
                                DataTable DtTextBoxes = ObjBll.returndatatable(2);
                                if (DtTextBoxes.Rows.Count > 0)
                                {
                                        txtCustomerName.Text = DtTextBoxes.Rows[0]["CustomerName"].ToString();
                                        txtAddress.Text = DtTextBoxes.Rows[0]["Address"].ToString();
                                        txtphonenumber.Text = DtTextBoxes.Rows[0]["Phone1"].ToString();
                                }
                        }
                }


                public bool Validation()
                {
                        if (Convert.ToInt32(cmbServiceNo.SelectedValue) < 1)
                        {
                                MessageBox.Show("Select a Service no");
                                return false;
                        }
                        DataView ObjViw = new DataView(DtGridEntry);
                        ObjViw.RowFilter = "EmployeeId>" + 0;
                        if (ObjViw.Count < 1)
                        {
                                MessageBox.Show("Atleast one Employee Should be assigned before Saving");
                                return false;
                        }
                        else
                        {
                                return true;
                        }
                }

                public void Save()
                {
                        DataView ObjView = new DataView(DtGridEntry);
                        ObjView.RowFilter = "EmployeeId>0";
                        DataTable DtAssigned = ObjView.ToTable("Selected",false,"ScheduleDetailsId","RegistrationDetailsId","EmployeeId","DeliveryDate");


                        ObjBll.RegistrationId = Convert.ToInt32( cmbServiceNo.SelectedValue);
                        ObjBll.ScheduleNo = txtScheduleNo.Text;
                        ObjBll.Date = dtpdate.Value;
                        ObjBll.MyTable = DtAssigned;
                        if (btnNew.Text == "Save")
                        {
                                ObjBll.Save(5);
                        }
                        else
                        {
                                ObjBll.ScheduleId = Convert.ToInt32(txtScheduleNo.Tag);
                                ObjBll.Save(9);
                        }
                        fillGridHistory();
                        pnlHistory.BringToFront();
                        Cancel();
                }

                public void Search()
                {

                        DtGridHistory = (DataTable)dgvHistory.DataSource;

                        string searchKey = txtSearchKey.Text.Trim();
                        string searchType = cmbSearchType.SelectedItem.ToString().Replace(" ","");



                        DataView DvSearch = new DataView(DtGridHistory);

                        if (rdbStartWith.Checked == true) DvSearch.RowFilter = searchType + " LIKE '" + searchKey + "*'";
                        if (rdbContains.Checked == true) DvSearch.RowFilter = searchType + " LIKE '%" + searchKey + "%'";
                        if (rdbEndWith.Checked == true) DvSearch.RowFilter = searchType + " LIKE '%" + searchKey + "'";
                        if (rdbNotContain.Checked == true) DvSearch.RowFilter = searchType + " NOT LIKE '%" + searchKey + "%'";

                        dgvHistory.DataSource = DvSearch.ToTable();

                }


                public void SetCmbAndDtpLocation()
                {
                        // Change the Xvalue and Yvalue according to the first row position in the Designer.cs file
                        int xCmb = 407, yCmb = 60;
                        int xDtp = 276, yDtp = 60;

                        int ydist = dgvServiceDetails.CurrentRow.Index;
                        cmbEmployees.Location = new System.Drawing.Point(xCmb, yCmb + ydist * 22);
                        dtpDeliveryDate.Location = new System.Drawing.Point(xDtp, yDtp + ydist * 22);

                  }

                public void SetfromDgv()
                {
                        int selectedId = Convert.ToInt32(dgvServiceDetails.CurrentRow.Cells["EmployeeId"].Value);
                        dtpDeliveryDate.Text = Convert.ToString(dgvServiceDetails.CurrentRow.Cells["DeliveryDate"].Value.ToString());
                        FillCmbEmployees();
                        if (selectedId > 0)
                        {
                                cmbEmployees.SelectedValue = selectedId;
                        }
                        else
                        {
                                cmbEmployees.SelectedValue = -1;
                                
                        }

                }

                public void SettoDgv()
                {
                        if (Convert.ToInt32(dgvServiceDetails.Rows.Count) > 0)
                        {
                                if (Convert.ToBoolean(dgvServiceDetails.CurrentRow.Cells["AssignNow"].Value) == true)
                                {
                                        dgvServiceDetails.CurrentRow.Cells["DeliveryDate"].Value = dtpDeliveryDate.Text;
                                        dgvServiceDetails.CurrentRow.Cells["EmployeeName"].Value = cmbEmployees.Text;
                                        dgvServiceDetails.CurrentRow.Cells["EmployeeId"].Value = cmbEmployees.SelectedValue;
                                }
                        }
                }

                public void SetCmbAndDtpVisibility()
                {
                        try
                        {
                                if (Convert.ToBoolean(dgvServiceDetails.CurrentRow.Cells["AssignNow"].Value) == true)
                                {
                                        dtpDeliveryDate.Visible = true;
                                        cmbEmployees.Visible = true;
                                }
                                else
                                {
                                        dtpDeliveryDate.Visible = false;
                                        cmbEmployees.Visible = false;
                                }
                        }
                        catch
                        {
                                //MessageBox.Show("Chance to error");
                        }
                }



                private void ServiceSchedule_Load(object sender, EventArgs e)
                {

                    SetTitle(this);
                    SetContainerColor(this);
                    SetControlColor(btnNew, btnClose, btnEdit, btnDelete);
                        btnEdit.Tag = "NA";
                        
                        FillcmbServiceNo();
                        cmbEmployees.Visible = false;
                        dtpDeliveryDate.Visible = false;
                        fillGridHistory();
                        FillCmbEmployees();
                        
                }

                private void btnClose_Click(object sender, EventArgs e)
                {
                        if (btnClose.Text == "Close")
                        {
                                this.Close();
                        }
                        else
                        {
                                DialogResult Dg = MessageBox.Show("Are you cancelling?", "Confirm Cancelling...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                if(Dg == DialogResult.Yes)
                                {
                                        Cancel();
                                        pnlHistory.BringToFront();
                                        btnNew.Text = "New";
                                        btnEdit.Text = "Edit";
                                        btnClose.Text = "Close";
                                        btnEdit.Enabled = false;
                                        btnDelete.Enabled = false;
                                }
                        }
                }

                private void btnNew_Click(object sender, EventArgs e)
                {
                        if (btnNew.Text == "New")
                        {
                                btnEdit.Tag = "NA";
                                fillTxtSchedulNo();

                                grpScheduleNo.Enabled = true;
                                grpServicedetails.Enabled = true;
                                btnNew.Text = "Save";
                                btnClose.Text = "Cancel";
                                btnEdit.Enabled = false;
                                btnDelete.Enabled = false;
                                pnlEntry.BringToFront();
                        }
                        else
                        {
                                if (Validation() == true)
                                {
                                        Save();
                                        SetCmbAndDtpVisibility();
                                        MessageBox.Show("Saved Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnNew.Text = "New";
                                        Cancel();
                                        btnClose.Text = "Close";
                                }
                        }
                }

                private void cmbServiceNo_SelectedValueChanged(object sender, EventArgs e)
                {
                        if (Convert.ToString(btnEdit.Tag) == "NA")
                        {
                                fillTextBoxes();

                                FillCmbEmployees();

                                fillGridEntry();
                        }
                        else
                        {
                                fillTextBoxes();

                                FillCmbEmployees();
                        }
                }

                private void dgvServiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                        SetCmbAndDtpVisibility();
                        SetCmbAndDtpLocation();
                        //SetfromDgv();
                        //SettoDgv();

                }

                private void dgvServiceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                        if (dgvServiceDetails.EndEdit())
                        {
                                if (Convert.ToBoolean(dgvServiceDetails.CurrentRow.Cells["AssignNow"].Value) == false)
                                {
                                        dgvServiceDetails.CurrentRow.Cells["EmployeeId"].Value = 0;
                                        dgvServiceDetails.CurrentRow.Cells["EmployeeName"].Value = "";
                                        cmbEmployees.SelectedValue = -1;

                                }
                                SetCmbAndDtpVisibility();
                                
                        }

                        SetCmbAndDtpLocation();
                }

                private void cmbEmployees_SelectedValueChanged(object sender, EventArgs e)
                {
                        if (Convert.ToInt32(cmbEmployees.SelectedValue) > 0)
                        {
                                SettoDgv();
                        }
                }

                private void txtSearchKey_TextChanged(object sender, EventArgs e)
                {
                        if (txtSearchKey.Text == "")
                        {
                                fillGridHistory();
                        }
                        else
                        {
                                Search();
                        }
                }

                private void xPander1_Load(object sender, EventArgs e)
                {
                        cmbSearchType.SelectedIndex = 1;
                }

                private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                }



                private void btnEdit_Click(object sender, EventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                if (DtGridHistory.Rows.Count < 1)
                                {
                                        MessageBox.Show("No row to edit");
                                }
                                else
                                {
                                        Edit();
                                }
                        }
                        else
                        {
                                if (Validation() == true)
                                {
                                        DialogResult Dg = MessageBox.Show("Do you want to update?", "Confirm upating..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                        if (Dg == DialogResult.Yes)
                                        {
                                                Save();
                                                MessageBox.Show("Updated Successfully");
                                                Cancel();
                                        }
                                }
                        }
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                        if (dgvHistory.Rows.Count < 1)
                        {
                                MessageBox.Show("No row to delete");
                        }
                        else
                        {
                                DialogResult Dg = MessageBox.Show("Do you want to Delete this row?", "Confirm Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                if (Dg == DialogResult.Yes)
                                {
                                        if (btnDelete.Text == "Delete")
                                        {
                                                Delete();
                                                MessageBox.Show("Deleted Successfully");
                                                fillGridHistory();
                                        }
                                }
                        }
                }

                private void dgvHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                btnEdit.PerformClick();
                        }
                }

                private void grpServicedetails_Enter(object sender, EventArgs e)
                {

                }




        }
}
