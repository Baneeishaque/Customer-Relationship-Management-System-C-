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
    public partial class ServiceEntry : FormBase.FormBase
    {
        public ServiceEntry()
        {
            InitializeComponent();
        }

        ClsBllServiceEntry ObjBll = new ClsBllServiceEntry();

        public void SaveService()
        {
            ObjBll.ServiceName = txtServiceName.Text;
            ObjBll.ProductId = Convert.ToInt32(cmbProductName.SelectedValue);
            ObjBll.TimeRequiredDays = txtTimeRequiredDays.Text;
            ObjBll.TimeRequiredHours = txtTimeRequiredHours.Text;
            ObjBll.TimeRequiredMinutes = txtTimeRequiredMinutes.Text;
            ObjBll.ServiceCost = txtServiceCost.Text;
            if (btnNew.Text == "Save")
            {
                ObjBll.Save(1);
            }
            if (btnEdit.Text == "Update")
            {
                ObjBll.Save(3);
            }
            pnlServiceEntry.Enabled = false;
            dgvServiceEntryMaster.Enabled = true;

        }

        public void DeleteServiceRow()
        {
            ObjBll.ServiceId = Convert.ToInt32(dgvServiceEntryMaster.CurrentRow.Cells["ServiceId"].Value);
            ObjBll.Delete(4);
        }

        public void ClearServiceFields()
        {
            txtServiceName.ResetText();
            txtTimeRequiredMinutes.ResetText();
            txtTimeRequiredHours.ResetText();
            txtTimeRequiredDays.ResetText();
            txtServiceCost.ResetText();
            fillComboboxProductName();
        }

        public void CancelFunctions()
        {
                DialogResult Dg = MessageBox.Show("Are you cancelling?", "Confirm deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Dg == DialogResult.Yes)
                {
                        ClearServiceFields();
                        btnNew.Enabled = true;

                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;

                        btnClose.Text = "Close";
                        btnNew.Text = "New";
                        btnEdit.Text = "Edit";
                        pnlServiceEntry.Enabled = false;
                        dgvServiceEntryMaster.Enabled = true;
                }
        }

        public bool ValidationServiceEntry()
        {
            if (txtServiceName.Text == "")
            {
                MessageBox.Show("Type the service name");
                txtServiceName.Focus();
                return false;
            }
            if (txtTimeRequiredDays.Text == "")
            {
                MessageBox.Show("Enter the days");
                txtTimeRequiredDays.Focus();
                return false;
            }
            if (txtTimeRequiredHours.Text == "")
            {
                MessageBox.Show("Enter the hours");
                txtTimeRequiredHours.Focus();
                return false;
            }
            if (txtTimeRequiredMinutes.Text == "")
            {
                MessageBox.Show("Enter the minutes");
                txtTimeRequiredMinutes.Focus();
                return false;
            }

            if (txtServiceCost.Text == "")
            {
                MessageBox.Show("Enter the cost");
                txtTimeRequiredMinutes.Focus();
                return false;
            }


            return true;
        }


        public void fillComboboxProductName()
        {
            DataTable DtProductName = new DataTable();
            DtProductName = ObjBll.ReturnData(5);
            cmbProductName.DisplayMember = "ProductName";
            cmbProductName.ValueMember = "ProductId";
            cmbProductName.DataSource = DtProductName;
        }

        public void fillGridService()
        {
            DataTable DtGridService = new DataTable();
            DtGridService = ObjBll.ReturnData(2);
            dgvServiceEntryMaster.DataSource = DtGridService;
        }

        public void editServiceEntry()
        {
            fillComboboxProductName();
            txtServiceName.Text = dgvServiceEntryMaster.CurrentRow.Cells["ServiceName"].Value.ToString();
            cmbProductName.SelectedValue = Convert.ToInt32(dgvServiceEntryMaster.CurrentRow.Cells["ProductId"].Value);
            txtTimeRequiredDays.Text = dgvServiceEntryMaster.CurrentRow.Cells["TimeRequiredDays"].Value.ToString();
            txtTimeRequiredHours.Text = dgvServiceEntryMaster.CurrentRow.Cells["TimeRequiredHours"].Value.ToString();
            txtTimeRequiredMinutes.Text = dgvServiceEntryMaster.CurrentRow.Cells["TimeRequiredMinutes"].Value.ToString();
            txtServiceCost.Text = dgvServiceEntryMaster.CurrentRow.Cells["ServiceCost"].Value.ToString();
            ObjBll.ServiceId = Convert.ToInt32(dgvServiceEntryMaster.CurrentRow.Cells["ServiceId"].Value);
            pnlServiceEntry.Enabled = true;
            btnEdit.Text = "Update";
            btnNew.Text = "New";
            btnClose.Text = "Cancel";
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            pnlServiceEntry.Enabled = true;
            dgvServiceEntryMaster.Enabled = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Close")
            {
                this.Close();
            }
            else
            {
                CancelFunctions();

            }
        }

        private void txtServiceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                pnlServiceEntry.Enabled = true;
                ClearServiceFields();
                btnNew.Text = "Save";
                btnClose.Text = "Cancel";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                dgvServiceEntryMaster.Enabled = false;

            }

            else
            {
                if (ValidationServiceEntry() == true)
                {
                    SaveService();
                    fillGridService();
                    btnClose.Text = "Close";
                    btnNew.Text = "New";
                    ClearServiceFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Dg = MessageBox.Show("Delete this Row?", "Confirm Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dg == DialogResult.Yes)
            {
                DeleteServiceRow();
                fillGridService();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                editServiceEntry();
                
            }
            else
            {
                DialogResult Dg = MessageBox.Show("Update Row?", "Confirm update...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Dg == DialogResult.Yes)
                {
                    if (ValidationServiceEntry() == true)
                    {
                        SaveService();
                        btnEdit.Text = "Edit";
                        btnEdit.Enabled = false;
                        btnNew.Enabled = true;
                        fillGridService();
                    }
                }

            }
        }

        private void dgvServiceEntryMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.PerformClick();
            }
        }

        private void dgvServiceEntryMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void ServiceEntry_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;
            SetTitle(this);
            SetContainerColor(this);
            SetControlColor(btnClose, btnEdit, btnDelete, btnNew);
            fillGridService();

        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
