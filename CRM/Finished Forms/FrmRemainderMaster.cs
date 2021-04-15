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
        public partial class FrmRemainderMaster : FormBase.FormBase
        {
                ClsBllRemainderMaster ObjBll = new ClsBllRemainderMaster();

                public DataTable DtApplicableUsers;
                public DataTable DtGridHistory;

                public FrmRemainderMaster()
                {
                        InitializeComponent();
                }

                private void FrmRemainderMaster_Load(object sender, EventArgs e)
                {
                    SetTitle(this);
                    SetContainerColor(this);
                    SetControlColor(btnClose, btnDelete, btnNew, btnEdit);


                        fillGridHistory();

                        //CheckTheDays();

                        FrmReportViewer ObjV = new FrmReportViewer();


                }

                public void Edit()
                {
                        txtName.Text = dgvHistory.CurrentRow.Cells["ReminderName"].Value.ToString();
                        txtMessage.Text = dgvHistory.CurrentRow.Cells["RemainderMessage"].Value.ToString();
                        SetPriority();
                        dtpStart.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["StartTime"].Value);
                        dtpStop.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["StopTime"].Value);
                        SetIntervals();
                        CheckTheDays();
                        fillGridApplicables();
                        CheckTheUsers();
                        pnlEntry.BringToFront();
                }

                public void fillGridApplicables()
                {

                        DtApplicableUsers = ObjBll.ReturnDT(1);

                        dgvApplicables.DataSource = DtApplicableUsers;
                }

                public void fillGridHistory()
                {
                        DtGridHistory = ObjBll.ReturnDT(3);
                        dgvHistory.DataSource = DtGridHistory;
                        
                        

                }

                public void Search()
                {

                        DataTable DtSearch = (DataTable)dgvHistory.DataSource;

                        string searchKey = txtSearchKey.Text.Trim().Replace(" ","");
                        string searchType = cmbSearchType.SelectedItem.ToString().Replace(" ", "");



                        DataView DvSearch = new DataView(DtSearch);

                        if (rdbStartWith.Checked == true) DvSearch.RowFilter = searchType + " LIKE '" + searchKey + "*'";
                        if (rdbContains.Checked == true) DvSearch.RowFilter = searchType + " LIKE '%" + searchKey + "%'";
                        if (rdbEndWith.Checked == true) DvSearch.RowFilter = searchType + " LIKE '%" + searchKey + "'";
                        if (rdbNotContain.Checked == true) DvSearch.RowFilter = searchType + " NOT LIKE '%" + searchKey + "%'";

                        dgvHistory.DataSource = DvSearch.ToTable();

                }

                public void SelectPriorityId()
                {
                        if (cmbPriority.SelectedIndex == 0)
                        {
                                ObjBll.PriorityId = 0;
                        }
                        if (cmbPriority.SelectedIndex == 1)
                        {
                                ObjBll.PriorityId = 1;
                        }
                        if (cmbPriority.SelectedIndex == 2)
                        {
                                ObjBll.PriorityId = 2;
                        }


                }

                public void SetPriority()
                {
                        string[] ids = { "0", "1", "2" };

                        foreach (string s in ids)
                        {
                                if (dgvHistory.CurrentRow.Cells["PriorityId"].Value.ToString() == s)
                                {
                                        cmbPriority.SelectedIndex = Convert.ToInt32(s);
                                }
                        }
                }

                public void SetIntervals()
                {
                        int i = Convert.ToInt32(dgvHistory.CurrentRow.Cells["IntervalsId"].Value.ToString());
                        if (i == 1) rdbOnce.Checked = true;
                        if (i == 2) rdbDaily.Checked = true;
                        if (i == 3) rdbWeekly.Checked = true;
                        if (i == 4) rdbMonthly.Checked = true;


                        //string intervals="";// = "";
                        //int i=0;
                        //foreach (RadioButton rdb in grpIntervals.Controls)
                        //{
                        //        intervals = rdb.Text +",";
                        //        i++;
                        //}
                        //Console.WriteLine( intervals);
                }

                public void SelectInterval()
                {
                        if (rdbOnce.Checked == true)
                        {
                                ObjBll.Intervals = 1;
                        }
                        if (rdbDaily.Checked == true)
                        {
                                ObjBll.Intervals = 2;
                        }
                        if (rdbWeekly.Checked == true)
                        {
                                ObjBll.Intervals = 3;
                        }
                        if (rdbMonthly.Checked == true)
                        {
                                ObjBll.Intervals = 4;
                        }
                }

                public string ReturnDays()
                {
                        string Days = "";

                        if (rdbDaily.Checked || rdbWeekly.Checked == true)
                        {

                                foreach (CheckBox c in grpDays.Controls)
                                {
                                        if (c.Checked == true)
                                        {
                                                Days += c.Text.Substring(0, 3) + ",";
                                        }
                                }

                                if (Days.Substring(Days.Length - 1, 1) == ",")
                                {

                                        Days = Days.Substring(0, Days.Length - 1);
                                }
                        }

                        return Days;
                }

                //public void SelectUsers()
                //{
                //        String ApplicableUsers = "";

                //        foreach (DataGridViewRow row in dgvApplicables.Rows)
                //        {


                //                //row.Cells[CheckBoxes.Name].Value = true;
                //                if (Convert.ToBoolean(row.Cells[CheckBoxes.Name].Value )== true)
                //                {
                //                         ApplicableUsers += "," + row.Cells["RoleId"].Value.ToString();
                //                }

                //        }
                //        ObjBll.ApplicableUsers = ApplicableUsers;
                //}

                public string ReturnApplicableUser()
                {
                        String ApplicableUsers = "";

                        foreach (DataGridViewRow row in dgvApplicables.Rows)
                        {
                                if (Convert.ToBoolean(row.Cells[CheckBoxes.Name].Value) == true)
                                {
                                        ApplicableUsers += row.Cells["RoleId"].Value.ToString() + ",";
                                }

                        }
                        if (ApplicableUsers.Length > 0)
                        {
                                if (ApplicableUsers.Substring(ApplicableUsers.Length - 1, 1) == ",")
                                {

                                        ApplicableUsers = ApplicableUsers.Substring(0, ApplicableUsers.Length - 1);
                                }
                        }

                        return ApplicableUsers;
                }

                public void Clear()
                {
                        txtName.ResetText();
                        txtMessage.ResetText();
                        cmbPriority.SelectedIndex = -1;
                        dtpStart.ResetText();
                        dtpStop.ResetText();


                        rdbOnce.Checked = false;
                        rdbDaily.Checked = false;
                        rdbWeekly.Checked = false;
                        rdbMonthly.Checked = false;

                        foreach (CheckBox chk in grpDays.Controls)
                        {
                                chk.Checked = false;
                        }
                        btnNew.Text = "New";
                        btnEdit.Text = "Edit";
                        btnClose.Text = "Close";

                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;

                        fillGridApplicables();
                }


                public void CheckTheDays()
                {
                        string Days = dgvHistory.CurrentRow.Cells["Days"].Value.ToString();

                        //string Useri = ApplicableUsers.Replace(",","");

                        string[] words = Days.Split(',');
                        foreach (string s in words)
                        {
                                foreach (CheckBox c in grpDays.Controls)
                                {
                                        if (c.Text.Substring(0, 3) == s)
                                        {
                                                c.Checked = true;
                                        }
                                }
                        }


                        //                        List<string> Users = new List<string>();

                }

                public void CheckTheUsers()
                {
                        string Users = dgvHistory.CurrentRow.Cells["ApplicableUsersIds"].Value.ToString();

                        string[] ids = Users.Split(',');
                        foreach (DataGridViewRow row in dgvApplicables.Rows)
                        {
                                foreach (string s in ids)
                                {
                                        if (row.Cells["RoleId"].Value.ToString() == s)
                                        {
                                                row.Cells[CheckBoxes.Name].Value = true;
                                        }

                                }
                                //if (Convert.ToBoolean(row.Cells[CheckBoxes.Name].Value) == true)
                                //{
                                //        ApplicableUsers += row.Cells["RoleId"].Value.ToString()+ ",";
                                //}

                        }

                }

                public void Delete()
                {
                        ObjBll.RemainderId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["RemainderId"].Value.ToString());
                        ObjBll.Delete(5);
                }

                public int ReturnCount()
                {
                        int i = 0;

                        foreach (CheckBox c in grpDays.Controls)
                        {
                                if (c.Checked == true)
                                {
                                        i++;
                                }
                        }

                        return i;
                }



                public bool Validation()
                {
                        if (txtName.Text == "")
                        {
                                MessageBox.Show("Enter Remainder Name");
                                return false;
                        }
                        else if (txtMessage.Text == "")
                        {
                                MessageBox.Show("Enter the Message");
                                return false;
                        }
                        else if (cmbPriority.Text == "")
                        {
                                MessageBox.Show("Select the Priority");
                                return false;
                        }
                        else if (Convert.ToDateTime(dtpStart.Value) > Convert.ToDateTime(dtpStop.Value))
                        {
                                MessageBox.Show("Start time must be before end time");
                                return false;
                        }
                        else if ((rdbOnce.Checked || rdbDaily.Checked || rdbWeekly.Checked || rdbMonthly.Checked) == false)
                        {
                                MessageBox.Show("Select the interval");
                                return false;
                        }
                        else if ((rdbDaily.Checked || rdbWeekly.Checked) && ReturnCount() == 0)
                        {
                                MessageBox.Show("Select Alteast One day");
                                return false;
                        }
                        else if ((rdbWeekly.Checked && ReturnCount() > 1) == true)
                        {
                                MessageBox.Show("Select only one day when Interval is Weekly");
                                return false;

                        }
                        else if (dgvApplicables.Rows.Count > 0 && ReturnApplicableUser() == "")
                        {
                                MessageBox.Show("Select Users");
                                return false;
                        }
                        else
                        {
                                return true;
                        }

                }

                public void Save()
                {
                        ObjBll.Name = txtName.Text;
                        ObjBll.Message = txtMessage.Text;
                        SelectPriorityId();
                        ObjBll.StartTime = dtpStart.Value;
                        ObjBll.StopTime = dtpStop.Value;
                        SelectInterval();
                        ObjBll.Days = ReturnDays();
                        ObjBll.ApplicableUsers = ReturnApplicableUser();

                        if (btnNew.Text == "Save") { ObjBll.Save(2); }
                        if (btnEdit.Text == "Update")
                        {
                                ObjBll.RemainderId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["RemainderId"].Value.ToString());
                                ObjBll.Save(4);
                        }

                        pnlHistory.BringToFront();
                        fillGridHistory();
                        btnNew.Text = "New";
                        btnEdit.Text = "Edit";
                        btnClose.Text = "Close";

                        Clear();

                }




                private void btnClose_Click(object sender, EventArgs e)
                {
                        if (btnClose.Text == "Close") this.Close();
                        else
                        {
                                Clear();
                                pnlHistory.BringToFront();
                        }

                }

                private void rdbDaily_CheckedChanged(object sender, EventArgs e)
                {
                        if (rdbDaily.Checked == true)
                        {
                                grpDays.Visible = true;
                        }
                        else if (rdbWeekly.Checked == true)
                        {
                                grpDays.Visible = true;
                        }
                        else if (rdbOnce.Checked == true)
                        {
                                grpDays.Visible = false;
                        }
                        else
                        {
                                grpDays.Visible = false;
                        }



                }

                private void btnNew_Click(object sender, EventArgs e)
                {
                        if (btnNew.Text == "Save")
                        {
                                if (Validation() == true)
                                {
                                        Save();
                                        MessageBox.Show("Saved Successfully!");

                                }
                        }

                        else
                        {
                                fillGridApplicables();
                                btnNew.Text = "Save";
                                btnClose.Text = "Cancel";
                                btnEdit.Enabled = false;
                                btnDelete.Enabled = false;
                                pnlEntry.BringToFront();
                        }


                }

                private void txtSearchKey_TextChanged(object sender, EventArgs e)
                {
                        if (txtSearchKey.Text != "")
                        {
                                Search();
                        }
                        else
                        {
                                fillGridHistory();
                        }
                }

                private void xPander1_Load(object sender, EventArgs e)
                {
                        cmbSearchType.SelectedIndex = 0;
                }

                private void btnEdit_Click(object sender, EventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                Edit();
                                btnEdit.Text = "Update";
                                btnClose.Text = "Cancel";
                        }
                        else
                        {
                                if (Validation() == true)
                                {
                                        DialogResult Dg = MessageBox.Show("Are you Updating?", "Confirm Updating...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                        if (Dg == DialogResult.Yes)
                                        {
                                                Save();
                                        }
                                }
                        }
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                        DialogResult Dg = MessageBox.Show("Are you deleting this Row?", "Confirm Deletin...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (Dg == DialogResult.Yes)
                        {
                                if (btnDelete.Text == "Delete")
                                {
                                        Delete();
                                        fillGridHistory();
                                }
                        }
                }

                private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                }

                private void dgvHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                btnEdit.PerformClick();
                        }
                }

                private void pnlHistory_Paint(object sender, PaintEventArgs e)
                {

                }




        }
}
