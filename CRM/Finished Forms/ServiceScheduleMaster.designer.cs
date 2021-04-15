namespace CRM
{
        partial class ServiceSchedule
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
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceSchedule));
                    this.grpScheduleNo = new System.Windows.Forms.GroupBox();
                    this.btnAdd = new System.Windows.Forms.Button();
                    this.cmbServiceNo = new System.Windows.Forms.ComboBox();
                    this.dtpdate = new System.Windows.Forms.DateTimePicker();
                    this.label3 = new System.Windows.Forms.Label();
                    this.label2 = new System.Windows.Forms.Label();
                    this.txtScheduleNo = new System.Windows.Forms.TextBox();
                    this.label1 = new System.Windows.Forms.Label();
                    this.groupBox2 = new System.Windows.Forms.GroupBox();
                    this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
                    this.cmbEmployees = new System.Windows.Forms.ComboBox();
                    this.dgvServiceDetails = new System.Windows.Forms.DataGridView();
                    this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.RegistrationDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.AssignNow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                    this.ScheduleDetailsId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.grpServicedetails = new System.Windows.Forms.GroupBox();
                    this.txtphonenumber = new System.Windows.Forms.TextBox();
                    this.label6 = new System.Windows.Forms.Label();
                    this.txtAddress = new System.Windows.Forms.TextBox();
                    this.label5 = new System.Windows.Forms.Label();
                    this.txtCustomerName = new System.Windows.Forms.TextBox();
                    this.label4 = new System.Windows.Forms.Label();
                    this.btnClose = new System.Windows.Forms.Button();
                    this.btnDelete = new System.Windows.Forms.Button();
                    this.btnEdit = new System.Windows.Forms.Button();
                    this.btnNew = new System.Windows.Forms.Button();
                    this.pnlEntry = new System.Windows.Forms.Panel();
                    this.pnlHistory = new System.Windows.Forms.Panel();
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
                    this.dgvHistory = new System.Windows.Forms.DataGridView();
                    this.ScheduleDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ScheduleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.RegistrationDetailsId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ProductId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ProductName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ServiceId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ServiceName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.EmployeeId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.EmployeeName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.DeliveryDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.RegistrationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).BeginInit();
                    this.grpScheduleNo.SuspendLayout();
                    this.groupBox2.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetails)).BeginInit();
                    this.grpServicedetails.SuspendLayout();
                    this.pnlEntry.SuspendLayout();
                    this.pnlHistory.SuspendLayout();
                    this.xPander1.SuspendLayout();
                    this.xPander2.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
                    this.SuspendLayout();
                    // 
                    // grpScheduleNo
                    // 
                    this.grpScheduleNo.Controls.Add(this.btnAdd);
                    this.grpScheduleNo.Controls.Add(this.cmbServiceNo);
                    this.grpScheduleNo.Controls.Add(this.dtpdate);
                    this.grpScheduleNo.Controls.Add(this.label3);
                    this.grpScheduleNo.Controls.Add(this.label2);
                    this.grpScheduleNo.Controls.Add(this.txtScheduleNo);
                    this.grpScheduleNo.Controls.Add(this.label1);
                    this.grpScheduleNo.Enabled = false;
                    this.grpScheduleNo.Location = new System.Drawing.Point(12, 7);
                    this.grpScheduleNo.Margin = new System.Windows.Forms.Padding(4);
                    this.grpScheduleNo.Name = "grpScheduleNo";
                    this.grpScheduleNo.Padding = new System.Windows.Forms.Padding(4);
                    this.grpScheduleNo.Size = new System.Drawing.Size(1241, 85);
                    this.grpScheduleNo.TabIndex = 26;
                    this.grpScheduleNo.TabStop = false;
                    // 
                    // btnAdd
                    // 
                    this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnAdd.ForeColor = System.Drawing.Color.Navy;
                    this.btnAdd.Location = new System.Drawing.Point(399, 44);
                    this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
                    this.btnAdd.Name = "btnAdd";
                    this.btnAdd.Size = new System.Drawing.Size(36, 33);
                    this.btnAdd.TabIndex = 30;
                    this.btnAdd.Text = "+";
                    this.btnAdd.UseVisualStyleBackColor = false;
                    // 
                    // cmbServiceNo
                    // 
                    this.cmbServiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.cmbServiceNo.FormattingEnabled = true;
                    this.cmbServiceNo.Location = new System.Drawing.Point(185, 48);
                    this.cmbServiceNo.Margin = new System.Windows.Forms.Padding(4);
                    this.cmbServiceNo.Name = "cmbServiceNo";
                    this.cmbServiceNo.Size = new System.Drawing.Size(213, 28);
                    this.cmbServiceNo.TabIndex = 29;
                    this.cmbServiceNo.SelectedValueChanged += new System.EventHandler(this.cmbServiceNo_SelectedValueChanged);
                    // 
                    // dtpdate
                    // 
                    this.dtpdate.CustomFormat = "MM/dd/yyyy";
                    this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    this.dtpdate.Location = new System.Drawing.Point(1013, 44);
                    this.dtpdate.Margin = new System.Windows.Forms.Padding(4);
                    this.dtpdate.Name = "dtpdate";
                    this.dtpdate.Size = new System.Drawing.Size(213, 29);
                    this.dtpdate.TabIndex = 28;
                    // 
                    // label3
                    // 
                    this.label3.AutoSize = true;
                    this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                    this.label3.Location = new System.Drawing.Point(48, 49);
                    this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label3.Name = "label3";
                    this.label3.Size = new System.Drawing.Size(125, 24);
                    this.label3.TabIndex = 25;
                    this.label3.Text = "Service No :";
                    // 
                    // label2
                    // 
                    this.label2.AutoSize = true;
                    this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                    this.label2.Location = new System.Drawing.Point(943, 46);
                    this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label2.Name = "label2";
                    this.label2.Size = new System.Drawing.Size(64, 24);
                    this.label2.TabIndex = 27;
                    this.label2.Text = "Date :";
                    // 
                    // txtScheduleNo
                    // 
                    this.txtScheduleNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.txtScheduleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.txtScheduleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtScheduleNo.Location = new System.Drawing.Point(185, 14);
                    this.txtScheduleNo.Margin = new System.Windows.Forms.Padding(4);
                    this.txtScheduleNo.Name = "txtScheduleNo";
                    this.txtScheduleNo.ReadOnly = true;
                    this.txtScheduleNo.Size = new System.Drawing.Size(214, 29);
                    this.txtScheduleNo.TabIndex = 26;
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                    this.label1.Location = new System.Drawing.Point(31, 16);
                    this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(144, 24);
                    this.label1.TabIndex = 24;
                    this.label1.Text = "Schedule No :";
                    // 
                    // groupBox2
                    // 
                    this.groupBox2.Controls.Add(this.dtpDeliveryDate);
                    this.groupBox2.Controls.Add(this.cmbEmployees);
                    this.groupBox2.Controls.Add(this.dgvServiceDetails);
                    this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
                    this.groupBox2.Location = new System.Drawing.Point(453, 92);
                    this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
                    this.groupBox2.Name = "groupBox2";
                    this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
                    this.groupBox2.Size = new System.Drawing.Size(799, 372);
                    this.groupBox2.TabIndex = 25;
                    this.groupBox2.TabStop = false;
                    this.groupBox2.Text = "Service Details";
                    // 
                    // dtpDeliveryDate
                    // 
                    this.dtpDeliveryDate.CustomFormat = "MM-dd-yyyy";
                    this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    this.dtpDeliveryDate.Location = new System.Drawing.Point(368, 75);
                    this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(4);
                    this.dtpDeliveryDate.Name = "dtpDeliveryDate";
                    this.dtpDeliveryDate.Size = new System.Drawing.Size(173, 26);
                    this.dtpDeliveryDate.TabIndex = 60;
                    // 
                    // cmbEmployees
                    // 
                    this.cmbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.cmbEmployees.FormattingEnabled = true;
                    this.cmbEmployees.Location = new System.Drawing.Point(543, 74);
                    this.cmbEmployees.Margin = new System.Windows.Forms.Padding(4);
                    this.cmbEmployees.Name = "cmbEmployees";
                    this.cmbEmployees.Size = new System.Drawing.Size(173, 28);
                    this.cmbEmployees.TabIndex = 59;
                    this.cmbEmployees.SelectedValueChanged += new System.EventHandler(this.cmbEmployees_SelectedValueChanged);
                    // 
                    // dgvServiceDetails
                    // 
                    this.dgvServiceDetails.AllowUserToAddRows = false;
                    this.dgvServiceDetails.AllowUserToOrderColumns = true;
                    this.dgvServiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvServiceDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.dgvServiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dgvServiceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.RegistrationDetailsId,
            this.ProductName,
            this.ServiceId,
            this.ServiceName,
            this.DeliveryDate,
            this.EmployeeName,
            this.EmployeeId,
            this.AssignNow,
            this.ScheduleDetailsId1});
                    this.dgvServiceDetails.Location = new System.Drawing.Point(16, 25);
                    this.dgvServiceDetails.Margin = new System.Windows.Forms.Padding(4);
                    this.dgvServiceDetails.Name = "dgvServiceDetails";
                    this.dgvServiceDetails.RowHeadersVisible = false;
                    this.dgvServiceDetails.RowTemplate.Height = 24;
                    this.dgvServiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    this.dgvServiceDetails.Size = new System.Drawing.Size(777, 339);
                    this.dgvServiceDetails.TabIndex = 29;
                    this.dgvServiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceDetails_CellClick);
                    this.dgvServiceDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceDetails_CellContentClick);
                    // 
                    // ProductId
                    // 
                    this.ProductId.DataPropertyName = "ProductId";
                    this.ProductId.HeaderText = "ProductId";
                    this.ProductId.Name = "ProductId";
                    this.ProductId.Visible = false;
                    // 
                    // RegistrationDetailsId
                    // 
                    this.RegistrationDetailsId.DataPropertyName = "RegistrationDetailsId";
                    this.RegistrationDetailsId.HeaderText = "RegistrationDetailsId";
                    this.RegistrationDetailsId.Name = "RegistrationDetailsId";
                    this.RegistrationDetailsId.Visible = false;
                    // 
                    // ProductName
                    // 
                    this.ProductName.DataPropertyName = "ProductName";
                    this.ProductName.HeaderText = "ProductName";
                    this.ProductName.Name = "ProductName";
                    this.ProductName.ReadOnly = true;
                    // 
                    // ServiceId
                    // 
                    this.ServiceId.DataPropertyName = "ServiceId";
                    this.ServiceId.HeaderText = "ServiceId";
                    this.ServiceId.Name = "ServiceId";
                    this.ServiceId.Visible = false;
                    // 
                    // ServiceName
                    // 
                    this.ServiceName.DataPropertyName = "ServiceName";
                    this.ServiceName.HeaderText = "ServiceName";
                    this.ServiceName.Name = "ServiceName";
                    this.ServiceName.ReadOnly = true;
                    // 
                    // DeliveryDate
                    // 
                    this.DeliveryDate.DataPropertyName = "DeliveryDate";
                    this.DeliveryDate.HeaderText = "DeliveryDate";
                    this.DeliveryDate.Name = "DeliveryDate";
                    this.DeliveryDate.ReadOnly = true;
                    // 
                    // EmployeeName
                    // 
                    this.EmployeeName.DataPropertyName = "EmployeeName";
                    this.EmployeeName.HeaderText = "EmployeeName";
                    this.EmployeeName.Name = "EmployeeName";
                    this.EmployeeName.ReadOnly = true;
                    // 
                    // EmployeeId
                    // 
                    this.EmployeeId.DataPropertyName = "EmployeeId";
                    this.EmployeeId.HeaderText = "EmployeeId";
                    this.EmployeeId.Name = "EmployeeId";
                    this.EmployeeId.Visible = false;
                    // 
                    // AssignNow
                    // 
                    this.AssignNow.FillWeight = 43F;
                    this.AssignNow.HeaderText = "Assign Now";
                    this.AssignNow.Name = "AssignNow";
                    this.AssignNow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                    this.AssignNow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                    // 
                    // ScheduleDetailsId1
                    // 
                    this.ScheduleDetailsId1.DataPropertyName = "ScheduleDetailsId";
                    this.ScheduleDetailsId1.HeaderText = "ScheduleDetailsId";
                    this.ScheduleDetailsId1.Name = "ScheduleDetailsId1";
                    this.ScheduleDetailsId1.Visible = false;
                    // 
                    // grpServicedetails
                    // 
                    this.grpServicedetails.Controls.Add(this.txtphonenumber);
                    this.grpServicedetails.Controls.Add(this.label6);
                    this.grpServicedetails.Controls.Add(this.txtAddress);
                    this.grpServicedetails.Controls.Add(this.label5);
                    this.grpServicedetails.Controls.Add(this.txtCustomerName);
                    this.grpServicedetails.Controls.Add(this.label4);
                    this.grpServicedetails.Enabled = false;
                    this.grpServicedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.grpServicedetails.ForeColor = System.Drawing.Color.DarkRed;
                    this.grpServicedetails.Location = new System.Drawing.Point(13, 94);
                    this.grpServicedetails.Margin = new System.Windows.Forms.Padding(4);
                    this.grpServicedetails.Name = "grpServicedetails";
                    this.grpServicedetails.Padding = new System.Windows.Forms.Padding(4);
                    this.grpServicedetails.Size = new System.Drawing.Size(435, 371);
                    this.grpServicedetails.TabIndex = 24;
                    this.grpServicedetails.TabStop = false;
                    this.grpServicedetails.Text = "Customer Details";
                    this.grpServicedetails.Enter += new System.EventHandler(this.grpServicedetails_Enter);
                    // 
                    // txtphonenumber
                    // 
                    this.txtphonenumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.txtphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.txtphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtphonenumber.Location = new System.Drawing.Point(185, 200);
                    this.txtphonenumber.Margin = new System.Windows.Forms.Padding(4);
                    this.txtphonenumber.Name = "txtphonenumber";
                    this.txtphonenumber.ReadOnly = true;
                    this.txtphonenumber.Size = new System.Drawing.Size(214, 29);
                    this.txtphonenumber.TabIndex = 19;
                    // 
                    // label6
                    // 
                    this.label6.AutoSize = true;
                    this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                    this.label6.Location = new System.Drawing.Point(66, 204);
                    this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label6.Name = "label6";
                    this.label6.Size = new System.Drawing.Size(116, 24);
                    this.label6.TabIndex = 18;
                    this.label6.Text = "Phone No :";
                    // 
                    // txtAddress
                    // 
                    this.txtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtAddress.Location = new System.Drawing.Point(185, 87);
                    this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
                    this.txtAddress.Multiline = true;
                    this.txtAddress.Name = "txtAddress";
                    this.txtAddress.ReadOnly = true;
                    this.txtAddress.Size = new System.Drawing.Size(214, 108);
                    this.txtAddress.TabIndex = 17;
                    // 
                    // label5
                    // 
                    this.label5.AutoSize = true;
                    this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                    this.label5.Location = new System.Drawing.Point(85, 88);
                    this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label5.Name = "label5";
                    this.label5.Size = new System.Drawing.Size(99, 24);
                    this.label5.TabIndex = 16;
                    this.label5.Text = "Address :";
                    // 
                    // txtCustomerName
                    // 
                    this.txtCustomerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtCustomerName.Location = new System.Drawing.Point(185, 51);
                    this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
                    this.txtCustomerName.Name = "txtCustomerName";
                    this.txtCustomerName.ReadOnly = true;
                    this.txtCustomerName.Size = new System.Drawing.Size(214, 29);
                    this.txtCustomerName.TabIndex = 15;
                    // 
                    // label4
                    // 
                    this.label4.AutoSize = true;
                    this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                    this.label4.Location = new System.Drawing.Point(11, 55);
                    this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(172, 24);
                    this.label4.TabIndex = 14;
                    this.label4.Text = "Customer Name :";
                    // 
                    // btnClose
                    // 
                    this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.btnClose.FlatAppearance.BorderSize = 2;
                    this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
                    this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnClose.ForeColor = System.Drawing.Color.Black;
                    this.btnClose.Location = new System.Drawing.Point(1145, 550);
                    this.btnClose.Margin = new System.Windows.Forms.Padding(4);
                    this.btnClose.Name = "btnClose";
                    this.btnClose.Size = new System.Drawing.Size(117, 49);
                    this.btnClose.TabIndex = 58;
                    this.btnClose.Text = "Close";
                    this.btnClose.UseVisualStyleBackColor = false;
                    this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
                    // 
                    // btnDelete
                    // 
                    this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.btnDelete.Enabled = false;
                    this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.btnDelete.FlatAppearance.BorderSize = 2;
                    this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
                    this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnDelete.ForeColor = System.Drawing.Color.Black;
                    this.btnDelete.Location = new System.Drawing.Point(1029, 550);
                    this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
                    this.btnDelete.Name = "btnDelete";
                    this.btnDelete.Size = new System.Drawing.Size(115, 49);
                    this.btnDelete.TabIndex = 57;
                    this.btnDelete.Text = "Delete";
                    this.btnDelete.UseVisualStyleBackColor = false;
                    this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
                    // 
                    // btnEdit
                    // 
                    this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.btnEdit.Enabled = false;
                    this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.btnEdit.FlatAppearance.BorderSize = 2;
                    this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
                    this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnEdit.ForeColor = System.Drawing.Color.Black;
                    this.btnEdit.Location = new System.Drawing.Point(906, 550);
                    this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
                    this.btnEdit.Name = "btnEdit";
                    this.btnEdit.Size = new System.Drawing.Size(115, 49);
                    this.btnEdit.TabIndex = 56;
                    this.btnEdit.Text = "Edit";
                    this.btnEdit.UseVisualStyleBackColor = false;
                    this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
                    // 
                    // btnNew
                    // 
                    this.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
                    this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.btnNew.FlatAppearance.BorderSize = 2;
                    this.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
                    this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnNew.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnNew.ForeColor = System.Drawing.Color.Black;
                    this.btnNew.Location = new System.Drawing.Point(784, 550);
                    this.btnNew.Margin = new System.Windows.Forms.Padding(4);
                    this.btnNew.Name = "btnNew";
                    this.btnNew.Size = new System.Drawing.Size(115, 49);
                    this.btnNew.TabIndex = 55;
                    this.btnNew.Text = "New";
                    this.btnNew.UseVisualStyleBackColor = false;
                    this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
                    // 
                    // pnlEntry
                    // 
                    this.pnlEntry.Controls.Add(this.grpServicedetails);
                    this.pnlEntry.Controls.Add(this.grpScheduleNo);
                    this.pnlEntry.Controls.Add(this.groupBox2);
                    this.pnlEntry.Location = new System.Drawing.Point(6, 70);
                    this.pnlEntry.Margin = new System.Windows.Forms.Padding(4);
                    this.pnlEntry.Name = "pnlEntry";
                    this.pnlEntry.Size = new System.Drawing.Size(1256, 472);
                    this.pnlEntry.TabIndex = 59;
                    // 
                    // pnlHistory
                    // 
                    this.pnlHistory.Controls.Add(this.xPander1);
                    this.pnlHistory.Controls.Add(this.dgvHistory);
                    this.pnlHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.pnlHistory.Location = new System.Drawing.Point(11, 58);
                    this.pnlHistory.Margin = new System.Windows.Forms.Padding(4);
                    this.pnlHistory.Name = "pnlHistory";
                    this.pnlHistory.Size = new System.Drawing.Size(1251, 484);
                    this.pnlHistory.TabIndex = 60;
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
                    this.xPander1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.xPander1.Location = new System.Drawing.Point(9, 41);
                    this.xPander1.Margin = new System.Windows.Forms.Padding(4);
                    this.xPander1.Name = "xPander1";
                    this.xPander1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
                    this.xPander1.PaneBottomRightColor = System.Drawing.Color.Transparent;
                    this.xPander1.PaneOutlineColor = System.Drawing.Color.Transparent;
                    this.xPander1.PaneTopLeftColor = System.Drawing.Color.Transparent;
                    this.xPander1.Size = new System.Drawing.Size(231, 435);
                    this.xPander1.TabIndex = 44;
                    this.xPander1.TooltipText = null;
                    this.xPander1.Load += new System.EventHandler(this.xPander1_Load);
                    // 
                    // txtSearchKey
                    // 
                    this.txtSearchKey.Location = new System.Drawing.Point(8, 382);
                    this.txtSearchKey.Margin = new System.Windows.Forms.Padding(4);
                    this.txtSearchKey.Name = "txtSearchKey";
                    this.txtSearchKey.Size = new System.Drawing.Size(179, 29);
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
                    this.xPander2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.xPander2.Location = new System.Drawing.Point(5, 166);
                    this.xPander2.Margin = new System.Windows.Forms.Padding(4);
                    this.xPander2.Name = "xPander2";
                    this.xPander2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
                    this.xPander2.PaneBottomRightColor = System.Drawing.Color.Transparent;
                    this.xPander2.PaneOutlineColor = System.Drawing.Color.Transparent;
                    this.xPander2.PaneTopLeftColor = System.Drawing.Color.Transparent;
                    this.xPander2.Size = new System.Drawing.Size(219, 155);
                    this.xPander2.TabIndex = 1;
                    this.xPander2.TooltipText = null;
                    // 
                    // rdbStartWith
                    // 
                    this.rdbStartWith.AutoSize = true;
                    this.rdbStartWith.Checked = true;
                    this.rdbStartWith.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.rdbStartWith.Location = new System.Drawing.Point(4, 28);
                    this.rdbStartWith.Margin = new System.Windows.Forms.Padding(4);
                    this.rdbStartWith.Name = "rdbStartWith";
                    this.rdbStartWith.Size = new System.Drawing.Size(138, 27);
                    this.rdbStartWith.TabIndex = 0;
                    this.rdbStartWith.TabStop = true;
                    this.rdbStartWith.Text = "Starts With";
                    this.rdbStartWith.UseVisualStyleBackColor = true;
                    // 
                    // rdbNotContain
                    // 
                    this.rdbNotContain.AutoSize = true;
                    this.rdbNotContain.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.rdbNotContain.Location = new System.Drawing.Point(3, 113);
                    this.rdbNotContain.Margin = new System.Windows.Forms.Padding(4);
                    this.rdbNotContain.Name = "rdbNotContain";
                    this.rdbNotContain.Size = new System.Drawing.Size(199, 27);
                    this.rdbNotContain.TabIndex = 3;
                    this.rdbNotContain.Text = "Does Not Contain";
                    this.rdbNotContain.UseVisualStyleBackColor = true;
                    // 
                    // rdbEndWith
                    // 
                    this.rdbEndWith.AutoSize = true;
                    this.rdbEndWith.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.rdbEndWith.Location = new System.Drawing.Point(3, 57);
                    this.rdbEndWith.Margin = new System.Windows.Forms.Padding(4);
                    this.rdbEndWith.Name = "rdbEndWith";
                    this.rdbEndWith.Size = new System.Drawing.Size(128, 27);
                    this.rdbEndWith.TabIndex = 1;
                    this.rdbEndWith.Text = "Ends With";
                    this.rdbEndWith.UseVisualStyleBackColor = true;
                    // 
                    // rdbContains
                    // 
                    this.rdbContains.AutoSize = true;
                    this.rdbContains.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.rdbContains.Location = new System.Drawing.Point(3, 85);
                    this.rdbContains.Margin = new System.Windows.Forms.Padding(4);
                    this.rdbContains.Name = "rdbContains";
                    this.rdbContains.Size = new System.Drawing.Size(114, 27);
                    this.rdbContains.TabIndex = 2;
                    this.rdbContains.Text = "Contains";
                    this.rdbContains.UseVisualStyleBackColor = true;
                    // 
                    // label11
                    // 
                    this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    this.label11.AutoSize = true;
                    this.label11.BackColor = System.Drawing.Color.Transparent;
                    this.label11.Location = new System.Drawing.Point(9, 347);
                    this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label11.Name = "label11";
                    this.label11.Size = new System.Drawing.Size(117, 24);
                    this.label11.TabIndex = 25;
                    this.label11.Text = "Search Key :";
                    // 
                    // label12
                    // 
                    this.label12.AutoSize = true;
                    this.label12.BackColor = System.Drawing.Color.Transparent;
                    this.label12.Location = new System.Drawing.Point(5, 69);
                    this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    this.label12.Name = "label12";
                    this.label12.Size = new System.Drawing.Size(123, 24);
                    this.label12.TabIndex = 23;
                    this.label12.Text = "Search Type:";
                    // 
                    // cmbSearchType
                    // 
                    this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    this.cmbSearchType.FormattingEnabled = true;
                    this.cmbSearchType.Items.AddRange(new object[] {
            "Schedule No",
            "Product Name",
            "Service Name",
            "Employee Name"});
                    this.cmbSearchType.Location = new System.Drawing.Point(5, 109);
                    this.cmbSearchType.Margin = new System.Windows.Forms.Padding(4);
                    this.cmbSearchType.Name = "cmbSearchType";
                    this.cmbSearchType.Size = new System.Drawing.Size(215, 32);
                    this.cmbSearchType.TabIndex = 0;
                    // 
                    // dgvHistory
                    // 
                    this.dgvHistory.AllowUserToAddRows = false;
                    this.dgvHistory.AllowUserToDeleteRows = false;
                    this.dgvHistory.AllowUserToResizeRows = false;
                    this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleDetailsId,
            this.ScheduleId,
            this.ScheduleNo,
            this.RegistrationDetailsId1,
            this.ProductId1,
            this.ProductName1,
            this.ServiceId1,
            this.ServiceName1,
            this.EmployeeId1,
            this.EmployeeName1,
            this.DeliveryDate1,
            this.RegistrationId});
                    this.dgvHistory.Location = new System.Drawing.Point(261, 41);
                    this.dgvHistory.Margin = new System.Windows.Forms.Padding(4);
                    this.dgvHistory.Name = "dgvHistory";
                    this.dgvHistory.ReadOnly = true;
                    this.dgvHistory.RowHeadersVisible = false;
                    this.dgvHistory.RowTemplate.Height = 24;
                    this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    this.dgvHistory.Size = new System.Drawing.Size(981, 435);
                    this.dgvHistory.TabIndex = 0;
                    this.dgvHistory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentDoubleClick);
                    this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
                    this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
                    // 
                    // ScheduleDetailsId
                    // 
                    this.ScheduleDetailsId.DataPropertyName = "ScheduleDetailsId";
                    this.ScheduleDetailsId.HeaderText = "ScheduleDetailsId";
                    this.ScheduleDetailsId.Name = "ScheduleDetailsId";
                    this.ScheduleDetailsId.ReadOnly = true;
                    this.ScheduleDetailsId.Visible = false;
                    // 
                    // ScheduleId
                    // 
                    this.ScheduleId.DataPropertyName = "ScheduleId";
                    this.ScheduleId.HeaderText = "ScheduleId";
                    this.ScheduleId.Name = "ScheduleId";
                    this.ScheduleId.ReadOnly = true;
                    this.ScheduleId.Visible = false;
                    // 
                    // ScheduleNo
                    // 
                    this.ScheduleNo.DataPropertyName = "ScheduleNo";
                    this.ScheduleNo.HeaderText = "ScheduleNo";
                    this.ScheduleNo.Name = "ScheduleNo";
                    this.ScheduleNo.ReadOnly = true;
                    // 
                    // RegistrationDetailsId1
                    // 
                    this.RegistrationDetailsId1.DataPropertyName = "RegistrationDetailsId";
                    this.RegistrationDetailsId1.HeaderText = "RegistrationDetailsId";
                    this.RegistrationDetailsId1.Name = "RegistrationDetailsId1";
                    this.RegistrationDetailsId1.ReadOnly = true;
                    this.RegistrationDetailsId1.Visible = false;
                    // 
                    // ProductId1
                    // 
                    this.ProductId1.DataPropertyName = "ProductId";
                    this.ProductId1.HeaderText = "ProductId";
                    this.ProductId1.Name = "ProductId1";
                    this.ProductId1.ReadOnly = true;
                    this.ProductId1.Visible = false;
                    // 
                    // ProductName1
                    // 
                    this.ProductName1.DataPropertyName = "ProductName";
                    this.ProductName1.HeaderText = "ProductName";
                    this.ProductName1.Name = "ProductName1";
                    this.ProductName1.ReadOnly = true;
                    // 
                    // ServiceId1
                    // 
                    this.ServiceId1.DataPropertyName = "ServiceId";
                    this.ServiceId1.HeaderText = "ServiceId";
                    this.ServiceId1.Name = "ServiceId1";
                    this.ServiceId1.ReadOnly = true;
                    this.ServiceId1.Visible = false;
                    // 
                    // ServiceName1
                    // 
                    this.ServiceName1.DataPropertyName = "ServiceName";
                    this.ServiceName1.HeaderText = "ServiceName";
                    this.ServiceName1.Name = "ServiceName1";
                    this.ServiceName1.ReadOnly = true;
                    // 
                    // EmployeeId1
                    // 
                    this.EmployeeId1.DataPropertyName = "EmployeeId";
                    this.EmployeeId1.HeaderText = "EmployeeId";
                    this.EmployeeId1.Name = "EmployeeId1";
                    this.EmployeeId1.ReadOnly = true;
                    this.EmployeeId1.Visible = false;
                    // 
                    // EmployeeName1
                    // 
                    this.EmployeeName1.DataPropertyName = "EmployeeName";
                    this.EmployeeName1.HeaderText = "EmployeeName";
                    this.EmployeeName1.Name = "EmployeeName1";
                    this.EmployeeName1.ReadOnly = true;
                    // 
                    // DeliveryDate1
                    // 
                    this.DeliveryDate1.DataPropertyName = "DeliveryDate";
                    this.DeliveryDate1.HeaderText = "DeliveryDate";
                    this.DeliveryDate1.Name = "DeliveryDate1";
                    this.DeliveryDate1.ReadOnly = true;
                    // 
                    // RegistrationId
                    // 
                    this.RegistrationId.DataPropertyName = "RegistrationId";
                    this.RegistrationId.HeaderText = "RegistrationId";
                    this.RegistrationId.Name = "RegistrationId";
                    this.RegistrationId.ReadOnly = true;
                    this.RegistrationId.Visible = false;
                    // 
                    // ServiceSchedule
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(1267, 603);
                    this.Controls.Add(this.btnClose);
                    this.Controls.Add(this.btnDelete);
                    this.Controls.Add(this.btnEdit);
                    this.Controls.Add(this.btnNew);
                    this.Controls.Add(this.pnlHistory);
                    this.Controls.Add(this.pnlEntry);
                    this.Name = "ServiceSchedule";
                    this.Text = "ServiceSchedule";
                    this.Load += new System.EventHandler(this.ServiceSchedule_Load);
                    ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).EndInit();
                    this.grpScheduleNo.ResumeLayout(false);
                    this.grpScheduleNo.PerformLayout();
                    this.groupBox2.ResumeLayout(false);
                    ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetails)).EndInit();
                    this.grpServicedetails.ResumeLayout(false);
                    this.grpServicedetails.PerformLayout();
                    this.pnlEntry.ResumeLayout(false);
                    this.pnlHistory.ResumeLayout(false);
                    this.xPander1.ResumeLayout(false);
                    this.xPander1.PerformLayout();
                    this.xPander2.ResumeLayout(false);
                    this.xPander2.PerformLayout();
                    ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
                    this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.GroupBox grpScheduleNo;
                private System.Windows.Forms.Button btnAdd;
                private System.Windows.Forms.ComboBox cmbServiceNo;
                private System.Windows.Forms.DateTimePicker dtpdate;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.TextBox txtScheduleNo;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.GroupBox groupBox2;
                private System.Windows.Forms.DataGridView dgvServiceDetails;
                private System.Windows.Forms.GroupBox grpServicedetails;
                private System.Windows.Forms.TextBox txtphonenumber;
                private System.Windows.Forms.Label label6;
                private System.Windows.Forms.TextBox txtAddress;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.TextBox txtCustomerName;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.Button btnClose;
                private System.Windows.Forms.Button btnDelete;
                private System.Windows.Forms.Button btnEdit;
                private System.Windows.Forms.Button btnNew;
                private System.Windows.Forms.ComboBox cmbEmployees;
                private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
                private System.Windows.Forms.Panel pnlEntry;
                private System.Windows.Forms.Panel pnlHistory;
                private System.Windows.Forms.DataGridView dgvHistory;
                private XPanderControl.XPander xPander1;
                private System.Windows.Forms.TextBox txtSearchKey;
                private XPanderControl.XPander xPander2;
                private System.Windows.Forms.RadioButton rdbStartWith;
                private System.Windows.Forms.RadioButton rdbNotContain;
                private System.Windows.Forms.RadioButton rdbEndWith;
                private System.Windows.Forms.RadioButton rdbContains;
                private System.Windows.Forms.Label label11;
                private System.Windows.Forms.Label label12;
                private System.Windows.Forms.ComboBox cmbSearchType;
                private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
                private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDetailsId;
                private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
                private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
                private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
                private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
                private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
                private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
                private System.Windows.Forms.DataGridViewCheckBoxColumn AssignNow;
                private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDetailsId1;
                private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDetailsId;
                private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleId;
                private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleNo;
                private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDetailsId1;
                private System.Windows.Forms.DataGridViewTextBoxColumn ProductId1;
                private System.Windows.Forms.DataGridViewTextBoxColumn ProductName1;
                private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId1;
                private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName1;
                private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId1;
                private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName1;
                private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate1;
                private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationId;
        }
}