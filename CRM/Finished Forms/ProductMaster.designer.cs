namespace CRM
{
    partial class ProductMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlProductHistory = new System.Windows.Forms.Panel();
            this.dgvProductHistory = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDimensionUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingWeightUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbShippingWeightUnit = new System.Windows.Forms.ComboBox();
            this.cmbProductDimensionUnit = new System.Windows.Forms.ComboBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShippingWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductDimension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProductEntry = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).BeginInit();
            this.pnlProductHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductHistory)).BeginInit();
            this.grpProductEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductHistory
            // 
            this.pnlProductHistory.Controls.Add(this.dgvProductHistory);
            this.pnlProductHistory.Location = new System.Drawing.Point(1, 335);
            this.pnlProductHistory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProductHistory.Name = "pnlProductHistory";
            this.pnlProductHistory.Size = new System.Drawing.Size(1083, 223);
            this.pnlProductHistory.TabIndex = 39;
            // 
            // dgvProductHistory
            // 
            this.dgvProductHistory.AllowUserToAddRows = false;
            this.dgvProductHistory.AllowUserToDeleteRows = false;
            this.dgvProductHistory.AllowUserToResizeColumns = false;
            this.dgvProductHistory.AllowUserToResizeRows = false;
            this.dgvProductHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvProductHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Manufacturer,
            this.ModelNo,
            this.Supplier,
            this.ProductDimension,
            this.ProductDimensionUnit,
            this.ShippingWeight,
            this.ShippingWeightUnit,
            this.ProductPrice});
            this.dgvProductHistory.Location = new System.Drawing.Point(8, 7);
            this.dgvProductHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductHistory.Name = "dgvProductHistory";
            this.dgvProductHistory.ReadOnly = true;
            this.dgvProductHistory.RowHeadersVisible = false;
            this.dgvProductHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvProductHistory.RowTemplate.Height = 24;
            this.dgvProductHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductHistory.Size = new System.Drawing.Size(1071, 202);
            this.dgvProductHistory.TabIndex = 0;
            this.dgvProductHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductHistory_CellDoubleClick);
            this.dgvProductHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductHistory_CellClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 113;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Width = 117;
            // 
            // ModelNo
            // 
            this.ModelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ModelNo.DataPropertyName = "ModelNo";
            this.ModelNo.HeaderText = "ModelNo";
            this.ModelNo.Name = "ModelNo";
            this.ModelNo.ReadOnly = true;
            this.ModelNo.Width = 89;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 85;
            // 
            // ProductDimension
            // 
            this.ProductDimension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductDimension.DataPropertyName = "ProductDimension";
            this.ProductDimension.HeaderText = "Product Dimension";
            this.ProductDimension.Name = "ProductDimension";
            this.ProductDimension.ReadOnly = true;
            this.ProductDimension.Width = 139;
            // 
            // ProductDimensionUnit
            // 
            this.ProductDimensionUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductDimensionUnit.DataPropertyName = "ProductDimensionUnit";
            this.ProductDimensionUnit.HeaderText = "Dimenion Unit";
            this.ProductDimensionUnit.Name = "ProductDimensionUnit";
            this.ProductDimensionUnit.ReadOnly = true;
            this.ProductDimensionUnit.Width = 111;
            // 
            // ShippingWeight
            // 
            this.ShippingWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShippingWeight.DataPropertyName = "ShippingWeight";
            this.ShippingWeight.HeaderText = "ShippingWeight";
            this.ShippingWeight.Name = "ShippingWeight";
            this.ShippingWeight.ReadOnly = true;
            this.ShippingWeight.Width = 132;
            // 
            // ShippingWeightUnit
            // 
            this.ShippingWeightUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShippingWeightUnit.DataPropertyName = "ShippingWeightUnit";
            this.ShippingWeightUnit.HeaderText = "Weight Unit";
            this.ShippingWeightUnit.Name = "ShippingWeightUnit";
            this.ShippingWeightUnit.ReadOnly = true;
            this.ShippingWeightUnit.Width = 97;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 114;
            // 
            // cmbShippingWeightUnit
            // 
            this.cmbShippingWeightUnit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShippingWeightUnit.FormattingEnabled = true;
            this.cmbShippingWeightUnit.Items.AddRange(new object[] {
            "mg",
            "g",
            "Kg",
            "lb"});
            this.cmbShippingWeightUnit.Location = new System.Drawing.Point(397, 151);
            this.cmbShippingWeightUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShippingWeightUnit.Name = "cmbShippingWeightUnit";
            this.cmbShippingWeightUnit.Size = new System.Drawing.Size(92, 26);
            this.cmbShippingWeightUnit.TabIndex = 8;
            this.cmbShippingWeightUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // cmbProductDimensionUnit
            // 
            this.cmbProductDimensionUnit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductDimensionUnit.FormattingEnabled = true;
            this.cmbProductDimensionUnit.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "ft",
            "in"});
            this.cmbProductDimensionUnit.Location = new System.Drawing.Point(397, 117);
            this.cmbProductDimensionUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductDimensionUnit.Name = "cmbProductDimensionUnit";
            this.cmbProductDimensionUnit.Size = new System.Drawing.Size(92, 26);
            this.cmbProductDimensionUnit.TabIndex = 6;
            this.cmbProductDimensionUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(657, 84);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(331, 26);
            this.txtProductPrice.TabIndex = 4;
            this.txtProductPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Product Price :";
            // 
            // txtShippingWeight
            // 
            this.txtShippingWeight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingWeight.Location = new System.Drawing.Point(204, 151);
            this.txtShippingWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtShippingWeight.Name = "txtShippingWeight";
            this.txtShippingWeight.Size = new System.Drawing.Size(189, 26);
            this.txtShippingWeight.TabIndex = 7;
            this.txtShippingWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            this.txtShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Shipping Weight :";
            // 
            // txtProductDimension
            // 
            this.txtProductDimension.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDimension.Location = new System.Drawing.Point(204, 117);
            this.txtProductDimension.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductDimension.Name = "txtProductDimension";
            this.txtProductDimension.Size = new System.Drawing.Size(189, 26);
            this.txtProductDimension.TabIndex = 5;
            this.txtProductDimension.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Product Dimension :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(657, 16);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(331, 26);
            this.txtSupplier.TabIndex = 1;
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Supplier :";
            // 
            // txtModelNo
            // 
            this.txtModelNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelNo.Location = new System.Drawing.Point(657, 52);
            this.txtModelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(331, 26);
            this.txtModelNo.TabIndex = 3;
            this.txtModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Model No :";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(204, 52);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(281, 26);
            this.txtManufacturer.TabIndex = 2;
            this.txtManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Manufacturer :";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(204, 16);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(281, 26);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Product Name :";
            // 
            // grpProductEntry
            // 
            this.grpProductEntry.Controls.Add(this.cmbShippingWeightUnit);
            this.grpProductEntry.Controls.Add(this.cmbProductDimensionUnit);
            this.grpProductEntry.Controls.Add(this.txtProductPrice);
            this.grpProductEntry.Controls.Add(this.label7);
            this.grpProductEntry.Controls.Add(this.txtShippingWeight);
            this.grpProductEntry.Controls.Add(this.label6);
            this.grpProductEntry.Controls.Add(this.txtProductDimension);
            this.grpProductEntry.Controls.Add(this.label5);
            this.grpProductEntry.Controls.Add(this.txtSupplier);
            this.grpProductEntry.Controls.Add(this.label4);
            this.grpProductEntry.Controls.Add(this.txtModelNo);
            this.grpProductEntry.Controls.Add(this.label3);
            this.grpProductEntry.Controls.Add(this.txtManufacturer);
            this.grpProductEntry.Controls.Add(this.label2);
            this.grpProductEntry.Controls.Add(this.txtProductName);
            this.grpProductEntry.Controls.Add(this.label1);
            this.grpProductEntry.Enabled = false;
            this.grpProductEntry.Location = new System.Drawing.Point(27, 107);
            this.grpProductEntry.Margin = new System.Windows.Forms.Padding(4);
            this.grpProductEntry.Name = "grpProductEntry";
            this.grpProductEntry.Padding = new System.Windows.Forms.Padding(4);
            this.grpProductEntry.Size = new System.Drawing.Size(1053, 220);
            this.grpProductEntry.TabIndex = 56;
            this.grpProductEntry.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(953, 566);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 53);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(816, 566);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 53);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(683, 566);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 53);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(545, 566);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 53);
            this.btnNew.TabIndex = 56;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 632);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpProductEntry);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlProductHistory);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductMaster";
            this.Text = "Product Mater";
            this.Load += new System.EventHandler(this.ProductMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).EndInit();
            this.pnlProductHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductHistory)).EndInit();
            this.grpProductEntry.ResumeLayout(false);
            this.grpProductEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductHistory;
        private System.Windows.Forms.DataGridView dgvProductHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDimensionUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingWeightUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.ComboBox cmbShippingWeightUnit;
        private System.Windows.Forms.ComboBox cmbProductDimensionUnit;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShippingWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductDimension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProductEntry;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
    }
}