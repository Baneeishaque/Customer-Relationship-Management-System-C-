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
        public partial class ServiceRegistration : FormBase.FormBase
        {
                public ServiceRegistration()
                {
                        InitializeComponent();
                }

                ClsBllServiceRegistration ObjBll = new ClsBllServiceRegistration();

                public void Save()
                {
                        //if (btnNew.Text == "Save")
                        //{
                        //    ObjBll.RegistrationNo = Convert.ToInt32(txtRegistraionNo.Text);
                        //}

                        ObjBll.CustomerId = Convert.ToInt32(cmbCustomerName.SelectedValue);
                        ObjBll.ServiceUID = txtRegistraionNo.Text;

                        //ObjBll.Name = txtName.Text;
                        //ObjBll.Address = txtAddress.Text;
                        //ObjBll.Phone = txtPhone.Text;
                        ObjBll.OrderDate = Convert.ToDateTime(dtpOrderDate.Value);
                        ObjBll.DataTableToSave = (DataTable)dgvServicesForSingleCustomer.DataSource;
                        if (btnEdit.Text == "Update")
                        {
                                ObjBll.RegistrationId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["RegistrationId"].Value);
                                ObjBll.Save(4);
                                MessageBox.Show("Updating Successful");
                        }

                        if (btnNew.Text == "Save")
                        {
                                ObjBll.Save(1);
                                MessageBox.Show("Saving Successful");
                        }


                        ClearFields();
                        ResetButtonsServiceCustomerMaster();
                        pnlServiceRegistrationHistory.BringToFront();
                        txtCost.ResetText();
                }

                public void Search()
                {
                        
                        DataTable DtSearch = (DataTable)dgvHistory.DataSource;

                        string searchKey = txtSearchKey.Text.Trim();
                        string searchType = cmbSearchType.SelectedItem.ToString().Replace(" ", "");
                        


                        DataView DvSearch = new DataView(DtSearch);

                        //DvSearch.RowFilter = "CustomerName LIKE 'u*' ";
                        if (rdbStartWith.Checked == true) DvSearch.RowFilter = searchType + " LIKE '" + searchKey + "*'";
                        if (rdbContains.Checked == true) DvSearch.RowFilter = searchType + " LIKE '%" + searchKey + "%'";
                        if (rdbEndWith.Checked == true) DvSearch.RowFilter = searchType + " LIKE '%" + searchKey + "'";
                        if (rdbNotContain.Checked == true) DvSearch.RowFilter = searchType + " NOT LIKE '%" + searchKey + "%'";

                        dgvHistory.DataSource = DvSearch.ToTable();
 
                }

                public void AddingTheCosts()
                {

                        DataTable DtAddCost = (DataTable)dgvServicesForSingleCustomer.DataSource;
                        int i = DtAddCost.Rows.Count;
                        if (i > 0)
                        {
                                int sum = 0;
                                int k = i - 1;
                                while (k < i && k > -1)
                                {
                                        sum = sum + Convert.ToInt32(DtAddCost.Rows[k]["ServiceCost"].ToString());
                                        k--;
                                }
                                txtTotalCost.Text = sum.ToString();
                        }
                }



                public void ClearSingleCustFields()
                {
                        fillCmbProduct();
                        dtpDeliveryDate.Value = DateTime.Now;
                        //txtCost.ResetText();
                }

                public DataTable DtSingleCustExp = new DataTable();

                public void AddValuesToDgvSingleCustomer()
                {
                        if (DtSingleCustExp.Columns.Count < 1)
                        {

                                //DtSingleCustExp.Columns.Add("RegistrationId");
                                DtSingleCustExp.Columns.Add("RegistrationDetailsId");
                                DtSingleCustExp.Columns.Add("ServiceId");
                                DtSingleCustExp.Columns.Add("ProductId");

                                DtSingleCustExp.Columns.Add("ProductName");
                                DtSingleCustExp.Columns.Add("ServiceName");
                                DtSingleCustExp.Columns.Add("DeliveryDate");
                                DtSingleCustExp.Columns.Add("ServiceCost");

                        }

                        if (Convert.ToInt32(btnPlus.Tag) == 0)
                        {
                                DataRow DtRow = DtSingleCustExp.NewRow();

                                DtRow["ProductId"] = cmbProduct.SelectedValue;
                                DtRow["ProductName"] = cmbProduct.Text;

                                DtRow["ServiceId"] = cmbService.SelectedValue;
                                DtRow["ServiceName"] = cmbService.Text;
                                DtRow["DeliveryDate"] = dtpDeliveryDate.Text;
                                DtRow["ServiceCost"] = txtCost.Text;
                                
                                DtRow["RegistrationDetailsId"] = 0;
                                DtSingleCustExp.Rows.Add(DtRow);
                        }
                        else
                        {
                                DtSingleCustExp.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ProductId"] = cmbProduct.SelectedValue;
                                DtSingleCustExp.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ProductName"] = cmbProduct.Text;
                                DtSingleCustExp.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ServiceId"] = cmbService.SelectedValue;
                                DtSingleCustExp.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ServiceName"] = cmbService.Text;
                                DtSingleCustExp.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["DeliveryDate"] = dtpDeliveryDate.Text;
                                DtSingleCustExp.Rows[Convert.ToInt32(btnPlus.Tag) - 1]["ServiceCost"] = txtCost.Text;
                                MessageBox.Show("Updated Successfully");
                        }

                        //DtSingleCustExp.Rows.Add(DtRow);

                        dgvServicesForSingleCustomer.DataSource = DtSingleCustExp;
                        AddingTheCosts();
                        ClearSingleCustFields();
                        btnPlus.Tag = 0;

                }




                public void EditServiceCustomerFields()
                {
                        if (dgvHistory.RowCount > 0)
                        {
                                filltxtRegistrationNoUpdate();
                                
                                fillCmbCustomerName();
                                
                                cmbCustomerName.SelectedValue = Convert.ToInt32(dgvHistory.CurrentRow.Cells["CustomerId"].Value.ToString());
                                //cmbCustomerName.SelectedValue = dgvServiceCustomerHistory.CurrentRow.Cells["CustomerName"].Value.ToString();
                                fillGridSingleCustomerServices();
                                fillCmbProduct();

                                txtAddress.Text = dgvHistory.CurrentRow.Cells["Address"].Value.ToString();
                                txtPhone.Text = dgvHistory.CurrentRow.Cells["Phone1"].Value.ToString();
                                string checkdate = dgvHistory.CurrentRow.Cells["OrderDate"].Value.ToString();
                                dtpOrderDate.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["OrderDate"].Value.ToString());
                                AddingTheCosts();
                                pnlServiceRegistrationEntry.BringToFront();
                                btnClose.Text = "Cancel";
                                btnEdit.Text = "Update";
                                pnlServiceRegistrationHistory.Enabled = true;
                                pnlServiceRegistrationEntry.Enabled = true;
                                btnNew.Enabled = false;
                                btnDelete.Enabled = false;

                        }
                        else
                        {
                                MessageBox.Show("No Rows to edit.");
                        }
                }

                public void EditSingleService()
                {

                        btnPlus.Tag = dgvServicesForSingleCustomer.CurrentRow.Index + 1;
                        cmbProduct.SelectedValue = Convert.ToInt32(dgvServicesForSingleCustomer.CurrentRow.Cells["ProductId"].Value);
                        cmbService.SelectedValue = Convert.ToInt32(dgvServicesForSingleCustomer.CurrentRow.Cells["ServiceId"].Value);
                        dtpDeliveryDate.Value = Convert.ToDateTime(dgvServicesForSingleCustomer.CurrentRow.Cells["DeliveryDate"].Value);
                }

                public void filltxtRegistraionNoNew()
                {
                        DataTable DtmaxRegNo = ObjBll.ReturnDT(9);
                        //DataTable DtTxtCost = ObjBll.ReturnDT(7);
                        txtRegistraionNo.Text = "SRV" + Convert.ToString(DtmaxRegNo.Rows[0][0]);
                }
                public void filltxtRegistrationNoUpdate()
                {
                        txtRegistraionNo.Text = "SRV" + dgvHistory.CurrentRow.Cells["RegistrationId"].Value.ToString();
                }


                public void fillCmbCustomerName()
                {
                        DataTable DtCmbCustomerName = new DataTable();
                        DtCmbCustomerName = ObjBll.ReturnDT(10);
                        cmbCustomerName.DisplayMember = "CustomerName";
                        cmbCustomerName.ValueMember = "CustomerId";
                        cmbCustomerName.DataSource = DtCmbCustomerName;
                }

                public void fillCustmerNameAndDetails()
                {
                        DataTable DtCustomerNameAndDetails = new DataTable();
                        ObjBll.CustomerId = Convert.ToInt32(cmbCustomerName.SelectedValue);
                        if (ObjBll.CustomerId > 0)
                        {
                                DtCustomerNameAndDetails = ObjBll.ReturnDT(11);
                                txtAddress.Text = Convert.ToString(DtCustomerNameAndDetails.Rows[0]["Address"]);
                                txtPhone.Text = DtCustomerNameAndDetails.Rows[0]["Phone1"].ToString();
                        }
                }

                public void fillGridCustomer()
                {
                        DataTable DtGirdCustomer = new DataTable();
                        DtGirdCustomer = ObjBll.ReturnDT(2);
                        dgvHistory.DataSource = DtGirdCustomer;

                }

                public void fillGridSingleCustomerServices()
                {
                        ObjBll.RegistrationId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["RegistrationId"].Value);
                        DtSingleCustExp = ObjBll.ReturnDT(8);
                        dgvServicesForSingleCustomer.DataSource = DtSingleCustExp;
                }

                public void fillCmbProduct()
                {
                        DataTable DtCmbProduct = new DataTable();
                        DtCmbProduct = ObjBll.ReturnDT(5);
                        cmbProduct.DisplayMember = "ProductName";
                        cmbProduct.ValueMember = "ProductId";
                        cmbProduct.DataSource = DtCmbProduct;

                }

                public void fillCmbService()
                {
                        DataTable DtCmbService = new DataTable();
                        ObjBll.ProductId = Convert.ToInt32(cmbProduct.SelectedValue);
                        if (ObjBll.ProductId > 0)
                        {
                                DtCmbService = ObjBll.ReturnDT(6);
                                cmbService.DisplayMember = "ServiceName";
                                cmbService.ValueMember = "ServiceId";
                                cmbService.DataSource = DtCmbService;
                        }
                }

                public void fillTxtCost()
                {
                        ObjBll.ServiceId = Convert.ToInt32(cmbService.SelectedValue);
                        if (ObjBll.ServiceId > 0)
                        {
                                DataTable DtTxtCost = ObjBll.ReturnDT(7);
                                //txtCost.Text = Convert.ToString(DtTxtCost.Rows[0][0]);
                                txtCost.Text = Convert.ToString(DtTxtCost.Rows[0]["ServiceCost"]);
                        }
                }

                public void Delete()
                {
                        if (dgvHistory.RowCount > 0)
                        {
                                ObjBll.RegistrationId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["RegistrationId"].Value);
                                ObjBll.Delete(3);
                        }
                        else
                        {
                                MessageBox.Show("No Row to Delete");
                        }
                }

                public void DeleteFromGridServices()
                {
                        //int DelId = Convert.ToInt32(dgvServicesForSingleCustomer.CurrentRow.Cells["ServiceId"].Value);
                        DialogResult Dg = MessageBox.Show("Are you Delete the service?", "Confirm Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (Dg == DialogResult.Yes)
                        {
                                dgvServicesForSingleCustomer.Rows.RemoveAt(dgvServicesForSingleCustomer.CurrentRow.Index);
                        }
                }



                public void Clear_dgvServicesForSingleCustomer()
                {
                        int i = dgvServicesForSingleCustomer.Rows.Count;
                        int k = i - 1;
                        while (k < i && k > -1)
                        {
                                dgvServicesForSingleCustomer.Rows.RemoveAt(k);
                                k--;
                        }

                }

                public void ClearFields()
                {
                        txtRegistraionNo.ResetText();
                        //txtName.ResetText();
                        txtAddress.ResetText();
                        txtPhone.ResetText();
                        dtpOrderDate.Value = DateTime.Now;
                        Clear_dgvServicesForSingleCustomer();
                        ObjBll.RegistrationId = 0;
                        fillGridCustomer();
                        fillTxtCost();

                }

                public void ResetButtonsServiceCustomerMaster()
                {
                        btnNew.Text = "New";
                        btnEdit.Text = "Edit";
                        btnDelete.Text = "Delete";
                        btnClose.Text = "Close";
                        btnNew.Enabled = true;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        fillGridCustomer();
                        pnlServiceRegistrationHistory.BringToFront();

                }

                public bool Validation()
                {
                        if (dgvServicesForSingleCustomer.DataSource == null)
                        {
                                MessageBox.Show("Service to be registered befor saving");
                                return false;
                        }

                        return true;
                }

                public bool ValidationForBtnPlus()
                {


                        if (Convert.ToInt32(btnPlus.Tag) > 0)
                        {
                                return true;

                        }
                        else
                        {
                                DataTable DtValidBtn = new DataTable();
                                DtValidBtn = (DataTable)dgvServicesForSingleCustomer.DataSource;
                                //DataView ObjView = new DataView() ;
                                if (DtValidBtn != null)
                                {

                                        int DtValidBtnCount = DtValidBtn.Rows.Count;
                                        string servId = Convert.ToString(cmbService.SelectedValue);
                                        DataView dv = new DataView(DtValidBtn);

                                        dv.RowFilter = "ServiceId = " + servId;

                                        int j = dv.Count;
                                        if (j == 0)
                                        {
                                                return true;

                                        }
                                        else
                                        {

                                                MessageBox.Show("Already in the Grid");
                                                return false;
                                        }
                                }
                                else
                                {
                                        return true;
                                }

                        }

                        //return true;

                }

                private void ServiceCustomerMaster_Load(object sender, EventArgs e)
                {
                        fillGridCustomer();
                        fillCmbProduct();

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
                                if (Dg == DialogResult.Yes)
                                {
                                        ClearFields();
                                        ResetButtonsServiceCustomerMaster();
                                        dgvHistory.Enabled = true;
                                        pnlServiceRegistrationEntry.Enabled = false;
                                }
                        }
                }

                private void btnNew_Click(object sender, EventArgs e)
                {
                        if (btnNew.Text == "Save")
                        {
                                if (Validation() == true)
                                {
                                        Save();
                                        ResetButtonsServiceCustomerMaster();
                                        dgvHistory.BringToFront();
                                        dgvHistory.Enabled = true;
                                }
                        }
                        else
                        {
                                filltxtRegistraionNoNew();
                                pnlServiceRegistrationEntry.BringToFront();
                                btnNew.Text = "Save";
                                pnlServiceRegistrationEntry.Enabled = true;
                                dgvHistory.Enabled = false;
                                btnEdit.Enabled = false;
                                btnDelete.Enabled = false;
                                btnClose.Text = "Cancel";
                                fillCmbProduct();
                                fillCmbCustomerName();
                        }
                }

                private void btnEdit_Click(object sender, EventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                EditServiceCustomerFields();

                        }
                        else
                        {
                                if (Validation() == true)
                                {
                                        DialogResult Dg = MessageBox.Show("Are you updating?", "Confirm updating...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                        if (Dg == DialogResult.Yes)
                                        {
                                                Save();
                                        }
                                }
                        }
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                        DialogResult dg3 = MessageBox.Show("Are you Deleting selected row?", "Confirm Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dg3 == DialogResult.Yes)
                        {
                                Delete();
                                fillGridCustomer();
                        }
                }

                private void dgvServiceCustomerHistory_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                }

                private void cmbProduct_SelectedValueChanged(object sender, EventArgs e)
                {
                        fillCmbService();
                }

                private void cmbService_SelectedValueChanged(object sender, EventArgs e)
                {
                        fillTxtCost();
                }

                private void btnPlus_Click(object sender, EventArgs e)
                {
                        if (ValidationForBtnPlus() == true)
                        {
                                AddValuesToDgvSingleCustomer();
                        }
                }

                private void txtName_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Enter)
                        {
                                SendKeys.Send("{TAB}");
                        }
                }

                private void dgvServiceCustomerHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                btnEdit.PerformClick();
                        }
                }

                private void cmbCustomerName_SelectedValueChanged(object sender, EventArgs e)
                {
                        fillCustmerNameAndDetails();

                }

                private void ServiceRegistration_Load(object sender, EventArgs e)
                {
                    MaximizeBox = false;
                    SetTitle(this);
                    SetContainerColor(this);
                    SetControlColor(btnClose, btnEdit, btnDelete, btnNew);
           
                    
                        fillGridCustomer();
                        btnPlus.Tag = 0;

                }

                private void dgvServiceRegistrationHistory_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                }

                private void dgvServiceRegistrationHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        if (btnEdit.Text == "Edit")
                        {
                                btnEdit.PerformClick();
                        }
                }

                private void dgvServicesForSingleCustomer_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Delete)
                        {
                                DeleteFromGridServices();

                        }
                        else if (e.KeyCode == Keys.Space)
                        {
                                EditSingleService();
                        }
                        else
                        {

                        }
                }

                private void txtSearchKey_TextChanged(object sender, EventArgs e)
                {
                        if (txtSearchKey.Text == "")
                        {
                                fillGridCustomer();
                        }
                        else
                        {
                                Search();
                        }
                }

                private void xPander1_Load(object sender, EventArgs e)
                {
                        cmbSearchType.SelectedIndex = 0;
                }

                private void rdbStartWith_CheckedChanged(object sender, EventArgs e)
                {

                }



        }
}
