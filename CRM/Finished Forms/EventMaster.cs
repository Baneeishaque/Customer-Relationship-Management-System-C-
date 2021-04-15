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
    public partial class EventMaster : FormBase.FormBase
    {
        ClsBllEventMaster objbll = new ClsBllEventMaster();
        public EventMaster()
        {
            InitializeComponent();
        }
        public void GridFill()
        {
            DataTable dt = new DataTable();
            dt = objbll.ReturnDateTable(2);
            dgvEventMaster.DataSource = dt;
        }
        public void save()
        {
            objbll.EventName = txtEventName.Text;
            objbll.Description = txtDescription.Text;
            objbll.StartDate = dtpStartDate.Value;
            objbll.EndDate = dtpEndDate.Value;
            objbll.StartTime = dtpStartTime.Value;
            objbll.EndTime = dtpEndTime.Value;
            objbll.Location = txtLocation.Text;
            objbll.Priority = cmbPrioroty.Text;
            if (chkNotifivation.Checked == true)
            {
                objbll.NotificationRequired = "Yes";
            }
            if (chkNotifivation.Checked == false)
            {

                objbll.NotificationRequired = "No";
            }
            objbll.NotificationType = cmbNotificationType.Text;
            objbll.NotificationTime = dtpNotificationTime.Value;
            objbll.NotificationStartDate = dtpNotificatonStartDate.Value;
            objbll.NotificationEndDate = dtpNotificationEndDate.Value;
            if (chkSun.Checked == true)
            {
                objbll.Sunday = "Yes";

            }
            else
            {
                objbll.Sunday = "No";

            }
            if (chkMon.Checked == true)
            {
                objbll.Monday = "Yes";
            }
            else
            {
                objbll.Monday = "No";

            }
            if (chkTue.Checked == true)
            {
                objbll.Tuesday = "Yes";
            }
            else
            {
                objbll.Tuesday = "No";
            }
            if (chkWed.Checked == true)
            {
                objbll.Wednesday = "Yes";
            }
            else
            {
                objbll.Wednesday = "No";

            }
            if (chkThu.Checked == true)
            {
                objbll.Thursday = "Yes";
            }
            else
            {
                objbll.Thursday = "No";

            }
            if (chkFri.Checked == true)
            {
                objbll.Friday = "Yes";

            }
            else
            {
                objbll.Friday = "No";


            }
            if (chkSat.Checked == true)
            {
                objbll.Saturday = "Yes";

            }
            else
            {
                objbll.Saturday = "No";

            }
            if (btnNew.Text == "Save")
            {
                objbll.save(1);
            }
            if (btnEdit.Text == "Update")
            {
                objbll.EventId = Convert.ToInt32(dgvEventMaster.CurrentRow.Cells["EventId"].Value);
                objbll.save(4);
            }

            
        
        }

        public void ClearControlls()
        {
            txtEventName.ResetText();
            txtDescription.ResetText();
            dtpStartDate.ResetText();
            dtpEndDate.ResetText();
            dtpStartTime.ResetText();
            dtpEndTime.ResetText();
            txtLocation.ResetText();
            cmbPrioroty.ResetText();
            chkNotifivation.Checked = false;
            cmbNotificationType.ResetText();
            dtpNotificationTime.ResetText();
            dtpNotificatonStartDate.ResetText();
            dtpNotificationEndDate.ResetText();

         }
        public bool Validation()
        {
            if (txtEventName.Text.Trim() ==string.Empty)
            {
                MessageBox.Show("Please enter EventName");
                return false;
            }
            if (txtDescription.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Please enter event description");
                return false;
            }
            DateTime StartDate = Convert.ToDateTime(dtpStartDate.Value);
            DateTime EndDate = Convert.ToDateTime(dtpEndDate.Value);
            if (StartDate== EndDate)
            {
                MessageBox.Show("Start Date must be less than End Date");
                return false;
            
            }
            DateTime StartTime = Convert.ToDateTime(dtpStartTime.Value);
            DateTime EndTime = Convert.ToDateTime(dtpEndTime.Value);
            if (StartTime== EndTime)
            {
                MessageBox.Show("Start Time must be less than End Time");
                return false;
            
            
            }
            if (txtLocation.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Pleaase enter location");
                return false;
            }
            if (cmbPrioroty.Text.Trim()==string.Empty)
            {
                
                MessageBox.Show("select priority");
                return false;
            
            
            }
            if (chkNotifivation.Checked == true)
            {
 
            
            
            
            }

            return true;
            

           

        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                txtEventName.Focus();
                grpEvent.Enabled = true;
                pnlEntry.BringToFront();
                
                btnNew.Text = "Save";
                btnClose.Text = "Cancel";
                ClearControlls();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                
                
            }
            else
            {
                if (Validation())
                {
                    save();
                    pnlHistory.BringToFront();
                    btnNew.Text = "New";
                    GridFill();
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                

            }
        }



        private void cmbNotificationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNotificationType.Text == "Daily" || cmbNotificationType.Text == "Weekly")
            {
                grpDays.Enabled = true;
            }
            else
            {
                grpDays.Enabled = false;
            }
            
        }


        private void chkNotifivation_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkNotifivation.Checked == true)
            {
                grpNotification.Enabled = true;


            }
            else
            {

                grpNotification.Enabled = false;

            }

        }

        private void EventMaster_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitle(this);
            SetContainerColor(this);
            SetControlColor(btnClose, btnNew,btnEdit, btnDelete);

            GridFill();
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objbll.EventId = Convert.ToInt32(dgvEventMaster.CurrentRow.Cells["EventId"].Value);
            objbll.delete(3);
            GridFill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Close")
            {
                this.Close();
                
                btnClose.Text = "Cancel";

            }
            else
            {
                ClearControlls();
                pnlHistory.BringToFront();
                btnNew.Text = "New";
                btnClose.Text = "Close";
                btnEdit.Text = "Edit";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnNew.Enabled = true;

                
            
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Update")
            {
                save();
                
                pnlHistory.BringToFront();
                btnEdit.Text = "Edit";
                btnNew.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled= true;





            }
            else
            {

                txtEventName.Text = dgvEventMaster.CurrentRow.Cells["EventName"].Value.ToString();
                txtDescription.Text = dgvEventMaster.CurrentRow.Cells["Description"].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["StartDate"].Value);
                dtpEndDate.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["EndDate"].Value);
                dtpStartTime.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["StartTime"].Value);
                dtpEndTime.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["EndTime"].Value);
                txtLocation.Text = dgvEventMaster.CurrentRow.Cells["Location"].Value.ToString();
                cmbPrioroty.Text = dgvEventMaster.CurrentRow.Cells["Priority"].Value.ToString();
                string check = dgvEventMaster.CurrentRow.Cells["NotificationRequired"].Value.ToString();
                if (check == "Yes")
                {
                    chkNotifivation.Checked = true;
                }
                if (check == "No")
                {
                    chkNotifivation.Checked = false;
                }
                cmbNotificationType.Text = dgvEventMaster.CurrentRow.Cells["NotificationType"].Value.ToString();
                dtpNotificationTime.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["NotificationTime"].Value);
                dtpNotificatonStartDate.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["NotificationStartDate"].Value);
                dtpNotificationEndDate.Value = Convert.ToDateTime(dgvEventMaster.CurrentRow.Cells["NotificationEndDate"].Value);
                if (dgvEventMaster.CurrentRow.Cells["Sunday"].Value.ToString() == "Yes")
                {
                    chkSun.Checked = true;
                }
                else
                {
                    chkSun.Checked = false;
                }
                if (dgvEventMaster.CurrentRow.Cells["Monday"].Value.ToString() == "Yes")
                {

                    chkMon.Checked = true;
                }
                else
                {
                    chkMon.Checked = false;

                }
                if (dgvEventMaster.CurrentRow.Cells["Tuesday"].Value.ToString() == "Yes")
                {

                    chkTue.Checked = true;
                }
                else
                {
                    chkTue.Checked = false;

                }
                if (dgvEventMaster.CurrentRow.Cells["Wednesday"].Value.ToString() == "Yes")
                {
                    chkWed.Checked = true;

                }
                else
                {
                    chkWed.Checked = false;
                }
                if (dgvEventMaster.CurrentRow.Cells["Thursday"].Value.ToString() == "Yes")
                {

                    chkThu.Checked = true;
                }
                else
                {

                    chkThu.Checked = false;
                }
                if (dgvEventMaster.CurrentRow.Cells["Friday"].Value.ToString() == "Yes")
                {
                    chkFri.Checked = true;
                }
                else
                {
                    chkFri.Checked = false;

                }
                if (dgvEventMaster.CurrentRow.Cells["Saturday"].Value.ToString() == "Yes")
                {
                    chkSat.Checked = true;

                }
                else
                {

                    chkSat.Checked = false;
                }




                pnlEntry.BringToFront();
                btnEdit.Text = "Update";
                btnClose.Text = "Cancel";
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                GridFill();
            }

        }

        private void dgvEventMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void dtpNotificationEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grpEvent_Enter(object sender, EventArgs e)
        {

        }

        private void txtEventName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            
            }
        }

        private void pnlEntry_Paint(object sender, PaintEventArgs e)
        {

        }
        //i was searching project requirements

         
        
       
       
       
    }
}
