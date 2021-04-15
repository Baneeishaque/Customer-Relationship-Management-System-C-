namespace CRM
{
    partial class ServiceRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRegistration));
            this.txtRegistraionNo = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvServicesForSingleCustomer = new System.Windows.Forms.DataGridView();
            this.RegistrationId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.ServiceUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlServiceRegistrationEntry = new System.Windows.Forms.Panel();
            this.grpServiceCustomer = new System.Windows.Forms.GroupBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlServiceRegistrationHistory = new System.Windows.Forms.Panel();
            this.xPander1 = new XPanderControl.XPander();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.xPander2 = new XPanderControl.XPander();
            this.rdbStartWith = new System.Windows.Forms.RadioButton();
            this.rdbNotContain = new System.Windows.Forms.RadioButton();
            this.rdbEndWith = new System.Windows.Forms.RadioButton();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesForSingleCustomer)).BeginInit();
            this.grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlServiceRegistrationEntry.SuspendLayout();
            this.grpServiceCustomer.SuspendLayout();
            this.pnlServiceRegistrationHistory.SuspendLayout();
            this.xPander1.SuspendLayout();
            this.xPander2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegistraionNo
            // 
            this.txtRegistraionNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegistraionNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistraionNo.Location = new System.Drawing.Point(203, 12);
            this.txtRegistraionNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistraionNo.Name = "txtRegistraionNo";
            this.txtRegistraionNo.ReadOnly = true;
            this.txtRegistraionNo.Size = new System.Drawing.Size(133, 27);
            this.txtRegistraionNo.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(1162, 513);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 53);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvServicesForSingleCustomer
            // 
            this.dgvServicesForSingleCustomer.AllowUserToAddRows = false;
            this.dgvServicesForSingleCustomer.AllowUserToDeleteRows = false;
            this.dgvServicesForSingleCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicesForSingleCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicesForSingleCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationId2,
            this.RegistrationDetailsId,
            this.ServiceId,
            this.ProductId,
            this.ProductName,
            this.ServiceName,
            this.DeliveryDate,
            this.ServiceCost});
            this.dgvServicesForSingleCustomer.Location = new System.Drawing.Point(17, 103);
            this.dgvServicesForSingleCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServicesForSingleCustomer.Name = "dgvServicesForSingleCustomer";
            this.dgvServicesForSingleCustomer.ReadOnly = true;
            this.dgvServicesForSingleCustomer.RowHeadersVisible = false;
            this.dgvServicesForSingleCustomer.RowTemplate.Height = 24;
            this.dgvServicesForSingleCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicesForSingleCustomer.Size = new System.Drawing.Size(591, 222);
            this.dgvServicesForSingleCustomer.TabIndex = 64;
            this.dgvServicesForSingleCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvServicesForSingleCustomer_KeyDown);
            // 
            // RegistrationId2
            // 
            this.RegistrationId2.DataPropertyName = "RegistrationId";
            this.RegistrationId2.HeaderText = "RegistrationId";
            this.RegistrationId2.Name = "RegistrationId2";
            this.RegistrationId2.ReadOnly = true;
            this.RegistrationId2.Visible = false;
            // 
            // RegistrationDetailsId
            // 
            this.RegistrationDetailsId.DataPropertyName = "RegistrationDetailsId";
            this.RegistrationDetailsId.HeaderText = "Reg Details Id";
            this.RegistrationDetailsId.Name = "RegistrationDetailsId";
            this.RegistrationDetailsId.ReadOnly = true;
            this.RegistrationDetailsId.Visible = false;
            // 
            // ServiceId
            // 
            this.ServiceId.DataPropertyName = "ServiceId";
            this.ServiceId.HeaderText = "Service Id";
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Visible = false;
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
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Delivery Date";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // ServiceCost
            // 
            this.ServiceCost.DataPropertyName = "ServiceCost";
            this.ServiceCost.HeaderText = "Cost";
            this.ServiceCost.Name = "ServiceCost";
            this.ServiceCost.ReadOnly = true;
            // 
            // grpServices
            // 
            this.grpServices.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpServices.Controls.Add(this.btnPlus);
            this.grpServices.Controls.Add(this.dgvServicesForSingleCustomer);
            this.grpServices.Controls.Add(this.label9);
            this.grpServices.Controls.Add(this.txtCost);
            this.grpServices.Controls.Add(this.label8);
            this.grpServices.Controls.Add(this.dtpDeliveryDate);
            this.grpServices.Controls.Add(this.cmbService);
            this.grpServices.Controls.Add(this.label7);
            this.grpServices.Controls.Add(this.cmbProduct);
            this.grpServices.Controls.Add(this.label6);
            this.grpServices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServices.Location = new System.Drawing.Point(667, 53);
            this.grpServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpServices.Size = new System.Drawing.Size(617, 332);
            this.grpServices.TabIndex = 65;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlus.FlatAppearance.BorderSize = 2;
            this.btnPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(572, 17);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 65);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cost :";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCost.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(424, 52);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(144, 27);
            this.txtCost.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Delivery Date :";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "MM-dd-yyyy";
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(161, 52);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(175, 27);
            this.dtpDeliveryDate.TabIndex = 2;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(424, 18);
            this.cmbService.Margin = new System.Windows.Forms.Padding(4);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(144, 26);
            this.cmbService.TabIndex = 1;
            this.cmbService.SelectedValueChanged += new System.EventHandler(this.cmbService_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Service :";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(161, 18);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(175, 26);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectedValueChanged += new System.EventHandler(this.cmbProduct_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product :";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeColumns = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceUID,
            this.RegistrationId,
            this.CustomerId,
            this.CustomerName,
            this.Address,
            this.Phone1,
            this.OrderDate});
            this.dgvHistory.Location = new System.Drawing.Point(267, 15);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(991, 396);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceRegistrationHistory_CellDoubleClick);
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceRegistrationHistory_CellClick);
            // 
            // ServiceUID
            // 
            this.ServiceUID.DataPropertyName = "ServiceNo";
            this.ServiceUID.HeaderText = "Service No";
            this.ServiceUID.Name = "ServiceUID";
            this.ServiceUID.ReadOnly = true;
            // 
            // RegistrationId
            // 
            this.RegistrationId.DataPropertyName = "RegistrationId";
            this.RegistrationId.HeaderText = "RegistrationId";
            this.RegistrationId.Name = "RegistrationId";
            this.RegistrationId.ReadOnly = true;
            this.RegistrationId.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone1
            // 
            this.Phone1.DataPropertyName = "Phone1";
            this.Phone1.HeaderText = "Phone";
            this.Phone1.Name = "Phone1";
            this.Phone1.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(189, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Total Cost :";
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
            this.btnDelete.Location = new System.Drawing.Point(1024, 513);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 53);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalCost.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(313, 335);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(201, 27);
            this.txtTotalCost.TabIndex = 66;
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
            this.btnEdit.Location = new System.Drawing.Point(891, 513);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 53);
            this.btnEdit.TabIndex = 71;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone :";
            // 
            // pnlServiceRegistrationEntry
            // 
            this.pnlServiceRegistrationEntry.Controls.Add(this.label10);
            this.pnlServiceRegistrationEntry.Controls.Add(this.txtTotalCost);
            this.pnlServiceRegistrationEntry.Controls.Add(this.grpServices);
            this.pnlServiceRegistrationEntry.Controls.Add(this.grpServiceCustomer);
            this.pnlServiceRegistrationEntry.Controls.Add(this.dtpOrderDate);
            this.pnlServiceRegistrationEntry.Controls.Add(this.label5);
            this.pnlServiceRegistrationEntry.Controls.Add(this.label1);
            this.pnlServiceRegistrationEntry.Controls.Add(this.txtRegistraionNo);
            this.pnlServiceRegistrationEntry.Enabled = false;
            this.pnlServiceRegistrationEntry.Location = new System.Drawing.Point(3, 95);
            this.pnlServiceRegistrationEntry.Margin = new System.Windows.Forms.Padding(4);
            this.pnlServiceRegistrationEntry.Name = "pnlServiceRegistrationEntry";
            this.pnlServiceRegistrationEntry.Size = new System.Drawing.Size(1288, 410);
            this.pnlServiceRegistrationEntry.TabIndex = 74;
            // 
            // grpServiceCustomer
            // 
            this.grpServiceCustomer.Controls.Add(this.cmbCustomerName);
            this.grpServiceCustomer.Controls.Add(this.label4);
            this.grpServiceCustomer.Controls.Add(this.txtPhone);
            this.grpServiceCustomer.Controls.Add(this.label3);
            this.grpServiceCustomer.Controls.Add(this.txtAddress);
            this.grpServiceCustomer.Controls.Add(this.label2);
            this.grpServiceCustomer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServiceCustomer.Location = new System.Drawing.Point(9, 53);
            this.grpServiceCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grpServiceCustomer.Name = "grpServiceCustomer";
            this.grpServiceCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.grpServiceCustomer.Size = new System.Drawing.Size(628, 170);
            this.grpServiceCustomer.TabIndex = 19;
            this.grpServiceCustomer.TabStop = false;
            this.grpServiceCustomer.Text = "Cutomer";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(123, 17);
            this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(305, 28);
            this.cmbCustomerName.TabIndex = 68;
            this.cmbCustomerName.SelectedValueChanged += new System.EventHandler(this.cmbCustomerName_SelectedValueChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(123, 133);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(305, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Addrsess :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(123, 48);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(307, 82);
            this.txtAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(476, 12);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(128, 28);
            this.dtpOrderDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service UID :";
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
            this.btnNew.Location = new System.Drawing.Point(754, 513);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 53);
            this.btnNew.TabIndex = 70;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlServiceRegistrationHistory
            // 
            this.pnlServiceRegistrationHistory.Controls.Add(this.xPander1);
            this.pnlServiceRegistrationHistory.Controls.Add(this.dgvHistory);
            this.pnlServiceRegistrationHistory.Location = new System.Drawing.Point(12, 87);
            this.pnlServiceRegistrationHistory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlServiceRegistrationHistory.Name = "pnlServiceRegistrationHistory";
            this.pnlServiceRegistrationHistory.Size = new System.Drawing.Size(1269, 423);
            this.pnlServiceRegistrationHistory.TabIndex = 75;
            // 
            // xPander1
            // 
            this.xPander1.BackColor = System.Drawing.Color.Transparent;
            this.xPander1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.xPander1.CanToggle = false;
            this.xPander1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xPander1.CaptionFormatFlag = XPanderControl.XPander.FormatFlag.NoWrap;
            this.xPander1.CaptionStyle = XPanderControl.XPander.CaptionStyleEnum.Normal;
            this.xPander1.CaptionText = "Search";
            this.xPander1.CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Left;
            this.xPander1.ChevronStyle = XPanderControl.XPander.ChevronStyleEnum.Image;
            this.xPander1.CollapsedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander1.CollapsedHighlightImage")));
            this.xPander1.CollapsedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander1.CollapsedImage")));
            this.xPander1.Controls.Add(this.txtSearchKey);
            this.xPander1.Controls.Add(this.xPander2);
            this.xPander1.Controls.Add(this.label11);
            this.xPander1.Controls.Add(this.label12);
            this.xPander1.Controls.Add(this.cmbSearchType);
            this.xPander1.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander1.ExpandedHighlightImage")));
            this.xPander1.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander1.ExpandedImage")));
            this.xPander1.Location = new System.Drawing.Point(15, 44);
            this.xPander1.Margin = new System.Windows.Forms.Padding(4);
            this.xPander1.Name = "xPander1";
            this.xPander1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.xPander1.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.xPander1.PaneOutlineColor = System.Drawing.Color.Transparent;
            this.xPander1.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.xPander1.Size = new System.Drawing.Size(213, 321);
            this.xPander1.TabIndex = 43;
            this.xPander1.TooltipText = null;
            this.xPander1.Load += new System.EventHandler(this.xPander1_Load);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(15, 286);
            this.txtSearchKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(179, 22);
            this.txtSearchKey.TabIndex = 26;
            this.txtSearchKey.TextChanged += new System.EventHandler(this.txtSearchKey_TextChanged);
            // 
            // xPander2
            // 
            this.xPander2.Animated = true;
            this.xPander2.AnimationTime = 50;
            this.xPander2.BackColor = System.Drawing.Color.Transparent;
            this.xPander2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.xPander2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xPander2.CaptionFormatFlag = XPanderControl.XPander.FormatFlag.NoWrap;
            this.xPander2.CaptionLeftColor = System.Drawing.Color.Transparent;
            this.xPander2.CaptionRightColor = System.Drawing.Color.Transparent;
            this.xPander2.CaptionStyle = XPanderControl.XPander.CaptionStyleEnum.Normal;
            this.xPander2.CaptionText = "Advanced Search";
            this.xPander2.CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Left;
            this.xPander2.ChevronStyle = XPanderControl.XPander.ChevronStyleEnum.Image;
            this.xPander2.CollapsedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.CollapsedHighlightImage")));
            this.xPander2.CollapsedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.CollapsedImage")));
            this.xPander2.Controls.Add(this.rdbStartWith);
            this.xPander2.Controls.Add(this.rdbNotContain);
            this.xPander2.Controls.Add(this.rdbEndWith);
            this.xPander2.Controls.Add(this.rdbContains);
            this.xPander2.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.ExpandedHighlightImage")));
            this.xPander2.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.ExpandedImage")));
            this.xPander2.Location = new System.Drawing.Point(5, 102);
            this.xPander2.Margin = new System.Windows.Forms.Padding(4);
            this.xPander2.Name = "xPander2";
            this.xPander2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.xPander2.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.xPander2.PaneOutlineColor = System.Drawing.Color.Transparent;
            this.xPander2.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.xPander2.Size = new System.Drawing.Size(200, 155);
            this.xPander2.TabIndex = 1;
            this.xPander2.TooltipText = null;
            // 
            // rdbStartWith
            // 
            this.rdbStartWith.AutoSize = true;
            this.rdbStartWith.Checked = true;
            this.rdbStartWith.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdbStartWith.Location = new System.Drawing.Point(4, 28);
            this.rdbStartWith.Margin = new System.Windows.Forms.Padding(4);
            this.rdbStartWith.Name = "rdbStartWith";
            this.rdbStartWith.Size = new System.Drawing.Size(111, 21);
            this.rdbStartWith.TabIndex = 0;
            this.rdbStartWith.TabStop = true;
            this.rdbStartWith.Text = "Starts With";
            this.rdbStartWith.UseVisualStyleBackColor = true;
            // 
            // rdbNotContain
            // 
            this.rdbNotContain.AutoSize = true;
            this.rdbNotContain.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdbNotContain.Location = new System.Drawing.Point(3, 113);
            this.rdbNotContain.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNotContain.Name = "rdbNotContain";
            this.rdbNotContain.Size = new System.Drawing.Size(154, 21);
            this.rdbNotContain.TabIndex = 3;
            this.rdbNotContain.Text = "Does Not Contain";
            this.rdbNotContain.UseVisualStyleBackColor = true;
            // 
            // rdbEndWith
            // 
            this.rdbEndWith.AutoSize = true;
            this.rdbEndWith.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdbEndWith.Location = new System.Drawing.Point(3, 57);
            this.rdbEndWith.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEndWith.Name = "rdbEndWith";
            this.rdbEndWith.Size = new System.Drawing.Size(102, 21);
            this.rdbEndWith.TabIndex = 1;
            this.rdbEndWith.Text = "Ends With";
            this.rdbEndWith.UseVisualStyleBackColor = true;
            // 
            // rdbContains
            // 
            this.rdbContains.AutoSize = true;
            this.rdbContains.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.rdbContains.Location = new System.Drawing.Point(3, 85);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(4);
            this.rdbContains.Name = "rdbContains";
            this.rdbContains.Size = new System.Drawing.Size(91, 21);
            this.rdbContains.TabIndex = 2;
            this.rdbContains.Text = "Contains";
            this.rdbContains.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(36, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Search Key :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Search Type:";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Customer Name",
            "Service No",
            "Address"});
            this.cmbSearchType.Location = new System.Drawing.Point(5, 71);
            this.cmbSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(195, 24);
            this.cmbSearchType.TabIndex = 0;
            // 
            // ServiceRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 575);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlServiceRegistrationHistory);
            this.Controls.Add(this.pnlServiceRegistrationEntry);
            this.Name = "ServiceRegistration";
            this.Text = "Service Registration";
            this.Load += new System.EventHandler(this.ServiceRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesForSingleCustomer)).EndInit();
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlServiceRegistrationEntry.ResumeLayout(false);
            this.pnlServiceRegistrationEntry.PerformLayout();
            this.grpServiceCustomer.ResumeLayout(false);
            this.grpServiceCustomer.PerformLayout();
            this.pnlServiceRegistrationHistory.ResumeLayout(false);
            this.xPander1.ResumeLayout(false);
            this.xPander1.PerformLayout();
            this.xPander2.ResumeLayout(false);
            this.xPander2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistraionNo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvServicesForSingleCustomer;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlServiceRegistrationEntry;
        private System.Windows.Forms.GroupBox grpServiceCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlServiceRegistrationHistory;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCost;
        private XPanderControl.XPander xPander1;
        private XPanderControl.XPander xPander2;
        private System.Windows.Forms.RadioButton rdbStartWith;
        private System.Windows.Forms.RadioButton rdbNotContain;
        private System.Windows.Forms.RadioButton rdbEndWith;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}