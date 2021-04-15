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
    public partial class ProductMaster : FormBase.FormBase
    {
        ClsBllProductMaster ObjBll = new ClsBllProductMaster();
        public DataTable Dt = new DataTable();

        public ProductMaster()
        {
            InitializeComponent();
        }

        public void ComboBoxFill()
        {
            cmbProductDimensionUnit.SelectedIndex = 0;
            cmbShippingWeightUnit.SelectedIndex = 1;
        }

        public void fillGridProductHistory()
        {

            DataTable Dt = ObjBll.ReturnDataTable(2);
            dgvProductHistory.DataSource = Dt;
        }

        public void EditProductFields()
        {
            txtProductName.Text = dgvProductHistory.CurrentRow.Cells["ProductName"].Value.ToString();
            txtManufacturer.Text = dgvProductHistory.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txtModelNo.Text = dgvProductHistory.CurrentRow.Cells["ModelNo"].Value.ToString();
            txtSupplier.Text = dgvProductHistory.CurrentRow.Cells["Supplier"].Value.ToString();
            txtProductDimension.Text = dgvProductHistory.CurrentRow.Cells["ProductDimension"].Value.ToString();

            if(dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "mm")
                cmbProductDimensionUnit.SelectedIndex=0;
            if(dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "cm")
                cmbProductDimensionUnit.SelectedIndex=1;
            if(dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "m")
                cmbProductDimensionUnit.SelectedIndex=2;
            if (dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "ft")
                cmbProductDimensionUnit.SelectedIndex = 3;
            if (dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "in")
                cmbProductDimensionUnit.SelectedIndex = 4;



            txtShippingWeight.Text = dgvProductHistory.CurrentRow.Cells["ShippingWeight"].Value.ToString();

            if (dgvProductHistory.CurrentRow.Cells["ShippingWeightUnit"].Value.ToString() == "mg")
                cmbShippingWeightUnit.SelectedIndex = 0;
            if (dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "g")
                cmbShippingWeightUnit.SelectedIndex = 1;
            if (dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "Kg")
                cmbShippingWeightUnit.SelectedIndex = 2;
            if (dgvProductHistory.CurrentRow.Cells["ProductDimensionUnit"].Value.ToString() == "lb")
                cmbShippingWeightUnit.SelectedIndex = 3;

            txtProductPrice.Text = dgvProductHistory.CurrentRow.Cells["ProductPrice"].Value.ToString();
        }

        public void ClearProductFields()
        {
            txtProductName.ResetText();
            txtManufacturer.ResetText();
            txtModelNo.ResetText();
            txtSupplier.ResetText();
            txtProductDimension.ResetText();
            txtShippingWeight.ResetText();
            txtProductPrice.ResetText();
            ComboBoxFill();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            grpProductEntry.Enabled = false;
 
        }

        public bool ValidationProductMaster()
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Enter Prodcut Name");
                return false;
            }

            if (txtSupplier.Text == "")
            {
                MessageBox.Show("Enter supplier");
                return false;
            }

            if (txtManufacturer.Text == "")
            {
                MessageBox.Show("Enter Manufacturer");
                return false;
            }

            if (txtModelNo.Text == "")
            {
                MessageBox.Show("Enter Model Number");
                return false;
            }

            if (txtModelNo.Text == "")
            {
                MessageBox.Show("Enter Model Number");
                return false;
            
            }


            if (txtShippingWeight.Text == "")
            {
                MessageBox.Show("Enter the cost");
                return false;
            }




            return true;
 
        }

        public void SaveProduct()
        {
            ObjBll.ProductName= txtProductName.Text ;
            ObjBll.Manufacturer= txtManufacturer.Text ;
            ObjBll.ModelNo= txtModelNo.Text ;
            ObjBll.Supplier=txtSupplier.Text;
            ObjBll.ProductDimension = txtProductDimension.Text;
            ObjBll.ProductDimensionUnit = cmbProductDimensionUnit.SelectedItem.ToString();
            ObjBll.ShippingWeight = txtShippingWeight.Text;
            ObjBll.ShippingWeightUnit = cmbShippingWeightUnit.SelectedItem.ToString();
            ObjBll.ProductPrice = txtProductPrice.Text;
            if (btnEdit.Text == "Update")
            {
                ObjBll.ProductId = Convert.ToInt32(dgvProductHistory.CurrentRow.Cells["ProductId"].Value);
                ObjBll.Save(3);
            }
            if (btnNew.Text == "Save")
                ObjBll.Save(1);

        }

        private void ProductMaster_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitle(this);
            SetContainerColor(this);
            SetControlColor(btnClose, btnEdit, btnDelete, btnNew);
           

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            ComboBoxFill();
            txtProductName.Focus();
            fillGridProductHistory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Close")
            {
                this.Close();
            }
            else
            {
                DialogResult Dg = MessageBox.Show("Do you want to Cancel?", "Confirm Cancelling...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dg == DialogResult.Yes)
                {
                    btnNew.Text = "New";
                    btnClose.Text = "Close";
                    btnEdit.Text = "Edit";
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    fillGridProductHistory();
                    ClearProductFields();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "Save")
            {
                SaveProduct();
                fillGridProductHistory();
                btnNew.Text = "New";
                btnClose.Text = "Close";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                ClearProductFields();
                grpProductEntry.Enabled = false;
            }
            else
            {
                btnClose.Text = "Cancel";
                ClearProductFields();
                btnNew.Text = "Save";
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                grpProductEntry.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                EditProductFields();
                btnEdit.Text = "Update";
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnClose.Text = "Cancel";
                grpProductEntry.Enabled = true;
            }
            else
            {
                SaveProduct();
                fillGridProductHistory();
                btnEdit.Text = "Edit";
                btnNew.Text = "New";
                btnNew.Enabled = true;
 
            }
        }

        private void dgvProductHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Dg = MessageBox.Show("Do you want to Delete?", "Confirm Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dg == DialogResult.Yes)
            {
                ObjBll.ProductId = Convert.ToInt32(dgvProductHistory.CurrentRow.Cells["ProductId"].Value);
                ObjBll.Delete(4);
                fillGridProductHistory();
            }
        }

        private void dgvProductHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
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
  
    }
}
