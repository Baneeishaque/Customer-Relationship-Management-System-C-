namespace CRM
{
        partial class FrmRemainderMaster
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
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemainderMaster));
                    this.txtName = new System.Windows.Forms.TextBox();
                    this.label1 = new System.Windows.Forms.Label();
                    this.dtpStart = new System.Windows.Forms.DateTimePicker();
                    this.label2 = new System.Windows.Forms.Label();
                    this.label3 = new System.Windows.Forms.Label();
                    this.cmbPriority = new System.Windows.Forms.ComboBox();
                    this.label4 = new System.Windows.Forms.Label();
                    this.txtMessage = new System.Windows.Forms.TextBox();
                    this.label5 = new System.Windows.Forms.Label();
                    this.dtpStop = new System.Windows.Forms.DateTimePicker();
                    this.grpName = new System.Windows.Forms.GroupBox();
                    this.label6 = new System.Windows.Forms.Label();
                    this.grpIntervals = new System.Windows.Forms.GroupBox();
                    this.rdbMonthly = new System.Windows.Forms.RadioButton();
                    this.rdbWeekly = new System.Windows.Forms.RadioButton();
                    this.rdbDaily = new System.Windows.Forms.RadioButton();
                    this.rdbOnce = new System.Windows.Forms.RadioButton();
                    this.grpDays = new System.Windows.Forms.GroupBox();
                    this.chkSaturday = new System.Windows.Forms.CheckBox();
                    this.chkFriday = new System.Windows.Forms.CheckBox();
                    this.chkThursday = new System.Windows.Forms.CheckBox();
                    this.chkWednesday = new System.Windows.Forms.CheckBox();
                    this.chkTuesday = new System.Windows.Forms.CheckBox();
                    this.chkMonday = new System.Windows.Forms.CheckBox();
                    this.chkSunday = new System.Windows.Forms.CheckBox();
                    this.label7 = new System.Windows.Forms.Label();
                    this.grpApplicables = new System.Windows.Forms.GroupBox();
                    this.dgvApplicables = new System.Windows.Forms.DataGridView();
                    this.CheckBoxes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                    this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.btnClose = new System.Windows.Forms.Button();
                    this.btnDelete = new System.Windows.Forms.Button();
                    this.btnEdit = new System.Windows.Forms.Button();
                    this.btnNew = new System.Windows.Forms.Button();
                    this.pnlEntry = new System.Windows.Forms.Panel();
                    this.pnlHistory = new System.Windows.Forms.Panel();
                    this.dgvHistory = new System.Windows.Forms.DataGridView();
                    this.ReminderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ReminderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.PriorityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.RemainderMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.StopTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.IntervalsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Intervals = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ApplicableUsersIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.ApplicabeUserNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
                    this.grpName.SuspendLayout();
                    this.grpIntervals.SuspendLayout();
                    this.grpDays.SuspendLayout();
                    this.grpApplicables.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)(this.dgvApplicables)).BeginInit();
                    this.pnlEntry.SuspendLayout();
                    this.pnlHistory.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
                    this.xPander1.SuspendLayout();
                    this.xPander2.SuspendLayout();
                    this.SuspendLayout();
                    // 
                    // txtName
                    // 
                    this.txtName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtName.Location = new System.Drawing.Point(101, 34);
                    this.txtName.Name = "txtName";
                    this.txtName.Size = new System.Drawing.Size(176, 27);
                    this.txtName.TabIndex = 0;
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label1.Location = new System.Drawing.Point(35, 37);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(62, 23);
                    this.label1.TabIndex = 1;
                    this.label1.Text = "Name :";
                    // 
                    // dtpStart
                    // 
                    this.dtpStart.CustomFormat = "MM-dd-yyyy H:mm tt";
                    this.dtpStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    this.dtpStart.Location = new System.Drawing.Point(101, 125);
                    this.dtpStart.Name = "dtpStart";
                    this.dtpStart.Size = new System.Drawing.Size(176, 27);
                    this.dtpStart.TabIndex = 2;
                    // 
                    // label2
                    // 
                    this.label2.AutoSize = true;
                    this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label2.Location = new System.Drawing.Point(41, 128);
                    this.label2.Name = "label2";
                    this.label2.Size = new System.Drawing.Size(54, 23);
                    this.label2.TabIndex = 3;
                    this.label2.Text = "Start :";
                    // 
                    // label3
                    // 
                    this.label3.AutoSize = true;
                    this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label3.Location = new System.Drawing.Point(24, 85);
                    this.label3.Name = "label3";
                    this.label3.Size = new System.Drawing.Size(73, 23);
                    this.label3.TabIndex = 4;
                    this.label3.Text = "Priority :";
                    // 
                    // cmbPriority
                    // 
                    this.cmbPriority.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.cmbPriority.FormattingEnabled = true;
                    this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
                    this.cmbPriority.Location = new System.Drawing.Point(101, 82);
                    this.cmbPriority.Name = "cmbPriority";
                    this.cmbPriority.Size = new System.Drawing.Size(175, 27);
                    this.cmbPriority.TabIndex = 5;
                    // 
                    // label4
                    // 
                    this.label4.AutoSize = true;
                    this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label4.Location = new System.Drawing.Point(279, 37);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(87, 23);
                    this.label4.TabIndex = 7;
                    this.label4.Text = "Message :";
                    // 
                    // txtMessage
                    // 
                    this.txtMessage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtMessage.Location = new System.Drawing.Point(368, 34);
                    this.txtMessage.Multiline = true;
                    this.txtMessage.Name = "txtMessage";
                    this.txtMessage.Size = new System.Drawing.Size(276, 83);
                    this.txtMessage.TabIndex = 6;
                    // 
                    // label5
                    // 
                    this.label5.AutoSize = true;
                    this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label5.Location = new System.Drawing.Point(312, 127);
                    this.label5.Name = "label5";
                    this.label5.Size = new System.Drawing.Size(54, 23);
                    this.label5.TabIndex = 9;
                    this.label5.Text = "Stop :";
                    // 
                    // dtpStop
                    // 
                    this.dtpStop.CustomFormat = "MM-dd-yyyy H:mm tt";
                    this.dtpStop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    this.dtpStop.Location = new System.Drawing.Point(369, 123);
                    this.dtpStop.Name = "dtpStop";
                    this.dtpStop.Size = new System.Drawing.Size(183, 27);
                    this.dtpStop.TabIndex = 8;
                    // 
                    // grpName
                    // 
                    this.grpName.Controls.Add(this.label5);
                    this.grpName.Controls.Add(this.dtpStop);
                    this.grpName.Controls.Add(this.label4);
                    this.grpName.Controls.Add(this.txtMessage);
                    this.grpName.Controls.Add(this.cmbPriority);
                    this.grpName.Controls.Add(this.label3);
                    this.grpName.Controls.Add(this.label2);
                    this.grpName.Controls.Add(this.dtpStart);
                    this.grpName.Controls.Add(this.label1);
                    this.grpName.Controls.Add(this.txtName);
                    this.grpName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.grpName.Location = new System.Drawing.Point(20, 22);
                    this.grpName.Name = "grpName";
                    this.grpName.Size = new System.Drawing.Size(648, 166);
                    this.grpName.TabIndex = 10;
                    this.grpName.TabStop = false;
                    // 
                    // label6
                    // 
                    this.label6.AutoSize = true;
                    this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label6.Location = new System.Drawing.Point(10, 21);
                    this.label6.Name = "label6";
                    this.label6.Size = new System.Drawing.Size(260, 22);
                    this.label6.TabIndex = 11;
                    this.label6.Text = "Intervals and Reccurance:";
                    // 
                    // grpIntervals
                    // 
                    this.grpIntervals.Controls.Add(this.rdbMonthly);
                    this.grpIntervals.Controls.Add(this.rdbWeekly);
                    this.grpIntervals.Controls.Add(this.rdbDaily);
                    this.grpIntervals.Controls.Add(this.rdbOnce);
                    this.grpIntervals.Controls.Add(this.grpDays);
                    this.grpIntervals.Controls.Add(this.label6);
                    this.grpIntervals.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.grpIntervals.Location = new System.Drawing.Point(29, 198);
                    this.grpIntervals.Name = "grpIntervals";
                    this.grpIntervals.Size = new System.Drawing.Size(646, 121);
                    this.grpIntervals.TabIndex = 12;
                    this.grpIntervals.TabStop = false;
                    // 
                    // rdbMonthly
                    // 
                    this.rdbMonthly.AutoSize = true;
                    this.rdbMonthly.Location = new System.Drawing.Point(491, 23);
                    this.rdbMonthly.Name = "rdbMonthly";
                    this.rdbMonthly.Size = new System.Drawing.Size(92, 23);
                    this.rdbMonthly.TabIndex = 23;
                    this.rdbMonthly.TabStop = true;
                    this.rdbMonthly.Text = "Monthly";
                    this.rdbMonthly.UseVisualStyleBackColor = true;
                    this.rdbMonthly.CheckedChanged += new System.EventHandler(this.rdbDaily_CheckedChanged);
                    // 
                    // rdbWeekly
                    // 
                    this.rdbWeekly.AutoSize = true;
                    this.rdbWeekly.Location = new System.Drawing.Point(406, 23);
                    this.rdbWeekly.Name = "rdbWeekly";
                    this.rdbWeekly.Size = new System.Drawing.Size(87, 23);
                    this.rdbWeekly.TabIndex = 22;
                    this.rdbWeekly.TabStop = true;
                    this.rdbWeekly.Text = "Weekly";
                    this.rdbWeekly.UseVisualStyleBackColor = true;
                    this.rdbWeekly.CheckedChanged += new System.EventHandler(this.rdbDaily_CheckedChanged);
                    // 
                    // rdbDaily
                    // 
                    this.rdbDaily.AutoSize = true;
                    this.rdbDaily.Location = new System.Drawing.Point(335, 22);
                    this.rdbDaily.Name = "rdbDaily";
                    this.rdbDaily.Size = new System.Drawing.Size(68, 23);
                    this.rdbDaily.TabIndex = 21;
                    this.rdbDaily.TabStop = true;
                    this.rdbDaily.Text = "Daily";
                    this.rdbDaily.UseVisualStyleBackColor = true;
                    this.rdbDaily.CheckedChanged += new System.EventHandler(this.rdbDaily_CheckedChanged);
                    // 
                    // rdbOnce
                    // 
                    this.rdbOnce.AutoSize = true;
                    this.rdbOnce.Location = new System.Drawing.Point(265, 22);
                    this.rdbOnce.Name = "rdbOnce";
                    this.rdbOnce.Size = new System.Drawing.Size(71, 23);
                    this.rdbOnce.TabIndex = 20;
                    this.rdbOnce.TabStop = true;
                    this.rdbOnce.Text = "Once";
                    this.rdbOnce.UseVisualStyleBackColor = true;
                    this.rdbOnce.CheckedChanged += new System.EventHandler(this.rdbDaily_CheckedChanged);
                    // 
                    // grpDays
                    // 
                    this.grpDays.Controls.Add(this.chkSaturday);
                    this.grpDays.Controls.Add(this.chkFriday);
                    this.grpDays.Controls.Add(this.chkThursday);
                    this.grpDays.Controls.Add(this.chkWednesday);
                    this.grpDays.Controls.Add(this.chkTuesday);
                    this.grpDays.Controls.Add(this.chkMonday);
                    this.grpDays.Controls.Add(this.chkSunday);
                    this.grpDays.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.grpDays.Location = new System.Drawing.Point(18, 61);
                    this.grpDays.Name = "grpDays";
                    this.grpDays.Size = new System.Drawing.Size(577, 42);
                    this.grpDays.TabIndex = 19;
                    this.grpDays.TabStop = false;
                    this.grpDays.Visible = false;
                    // 
                    // chkSaturday
                    // 
                    this.chkSaturday.AutoSize = true;
                    this.chkSaturday.Location = new System.Drawing.Point(468, 16);
                    this.chkSaturday.Name = "chkSaturday";
                    this.chkSaturday.Size = new System.Drawing.Size(102, 23);
                    this.chkSaturday.TabIndex = 84;
                    this.chkSaturday.Text = "Saturday";
                    this.chkSaturday.UseVisualStyleBackColor = true;
                    // 
                    // chkFriday
                    // 
                    this.chkFriday.AutoSize = true;
                    this.chkFriday.Location = new System.Drawing.Point(399, 16);
                    this.chkFriday.Name = "chkFriday";
                    this.chkFriday.Size = new System.Drawing.Size(80, 23);
                    this.chkFriday.TabIndex = 83;
                    this.chkFriday.Text = "Friday";
                    this.chkFriday.UseVisualStyleBackColor = true;
                    // 
                    // chkThursday
                    // 
                    this.chkThursday.AutoSize = true;
                    this.chkThursday.Location = new System.Drawing.Point(314, 16);
                    this.chkThursday.Name = "chkThursday";
                    this.chkThursday.Size = new System.Drawing.Size(105, 23);
                    this.chkThursday.TabIndex = 82;
                    this.chkThursday.Text = "Thursday";
                    this.chkThursday.UseVisualStyleBackColor = true;
                    // 
                    // chkWednesday
                    // 
                    this.chkWednesday.AutoSize = true;
                    this.chkWednesday.Location = new System.Drawing.Point(220, 16);
                    this.chkWednesday.Name = "chkWednesday";
                    this.chkWednesday.Size = new System.Drawing.Size(123, 23);
                    this.chkWednesday.TabIndex = 81;
                    this.chkWednesday.Text = "Wednesday";
                    this.chkWednesday.UseVisualStyleBackColor = true;
                    // 
                    // chkTuesday
                    // 
                    this.chkTuesday.AutoSize = true;
                    this.chkTuesday.Location = new System.Drawing.Point(143, 16);
                    this.chkTuesday.Name = "chkTuesday";
                    this.chkTuesday.Size = new System.Drawing.Size(96, 23);
                    this.chkTuesday.TabIndex = 80;
                    this.chkTuesday.Text = "Tuesday";
                    this.chkTuesday.UseVisualStyleBackColor = true;
                    // 
                    // chkMonday
                    // 
                    this.chkMonday.AutoSize = true;
                    this.chkMonday.Location = new System.Drawing.Point(74, 16);
                    this.chkMonday.Name = "chkMonday";
                    this.chkMonday.Size = new System.Drawing.Size(92, 23);
                    this.chkMonday.TabIndex = 79;
                    this.chkMonday.Text = "Monday";
                    this.chkMonday.UseVisualStyleBackColor = true;
                    // 
                    // chkSunday
                    // 
                    this.chkSunday.AutoSize = true;
                    this.chkSunday.Location = new System.Drawing.Point(4, 16);
                    this.chkSunday.Name = "chkSunday";
                    this.chkSunday.Size = new System.Drawing.Size(90, 23);
                    this.chkSunday.TabIndex = 78;
                    this.chkSunday.Text = "Sunday";
                    this.chkSunday.UseVisualStyleBackColor = true;
                    // 
                    // label7
                    // 
                    this.label7.AutoSize = true;
                    this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label7.Location = new System.Drawing.Point(22, 18);
                    this.label7.Name = "label7";
                    this.label7.Size = new System.Drawing.Size(180, 19);
                    this.label7.TabIndex = 13;
                    this.label7.Text = "Applicable User/Roles";
                    // 
                    // grpApplicables
                    // 
                    this.grpApplicables.Controls.Add(this.dgvApplicables);
                    this.grpApplicables.Controls.Add(this.label7);
                    this.grpApplicables.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.grpApplicables.Location = new System.Drawing.Point(696, 16);
                    this.grpApplicables.Name = "grpApplicables";
                    this.grpApplicables.Size = new System.Drawing.Size(230, 303);
                    this.grpApplicables.TabIndex = 16;
                    this.grpApplicables.TabStop = false;
                    // 
                    // dgvApplicables
                    // 
                    this.dgvApplicables.AllowUserToAddRows = false;
                    this.dgvApplicables.AllowUserToDeleteRows = false;
                    this.dgvApplicables.AllowUserToResizeColumns = false;
                    this.dgvApplicables.AllowUserToResizeRows = false;
                    this.dgvApplicables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvApplicables.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.dgvApplicables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    this.dgvApplicables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dgvApplicables.ColumnHeadersVisible = false;
                    this.dgvApplicables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxes,
            this.RoleName,
            this.RoleId});
                    this.dgvApplicables.Location = new System.Drawing.Point(11, 41);
                    this.dgvApplicables.Name = "dgvApplicables";
                    this.dgvApplicables.RowHeadersVisible = false;
                    this.dgvApplicables.RowTemplate.Height = 24;
                    this.dgvApplicables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                    this.dgvApplicables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    this.dgvApplicables.Size = new System.Drawing.Size(213, 256);
                    this.dgvApplicables.TabIndex = 14;
                    // 
                    // CheckBoxes
                    // 
                    this.CheckBoxes.HeaderText = "CheckBoxes";
                    this.CheckBoxes.Name = "CheckBoxes";
                    this.CheckBoxes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                    this.CheckBoxes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                    // 
                    // RoleName
                    // 
                    this.RoleName.DataPropertyName = "RoleName";
                    this.RoleName.HeaderText = "RoleName";
                    this.RoleName.Name = "RoleName";
                    // 
                    // RoleId
                    // 
                    this.RoleId.DataPropertyName = "RoleId";
                    this.RoleId.HeaderText = "RoleId";
                    this.RoleId.Name = "RoleId";
                    this.RoleId.Visible = false;
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
                    this.btnClose.Location = new System.Drawing.Point(877, 439);
                    this.btnClose.Name = "btnClose";
                    this.btnClose.Size = new System.Drawing.Size(97, 43);
                    this.btnClose.TabIndex = 77;
                    this.btnClose.Text = "Close";
                    this.btnClose.UseVisualStyleBackColor = false;
                    this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
                    // 
                    // btnDelete
                    // 
                    this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    this.btnDelete.Enabled = false;
                    this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.btnDelete.FlatAppearance.BorderSize = 2;
                    this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
                    this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnDelete.ForeColor = System.Drawing.Color.White;
                    this.btnDelete.Location = new System.Drawing.Point(774, 439);
                    this.btnDelete.Name = "btnDelete";
                    this.btnDelete.Size = new System.Drawing.Size(97, 43);
                    this.btnDelete.TabIndex = 76;
                    this.btnDelete.Text = "Delete";
                    this.btnDelete.UseVisualStyleBackColor = false;
                    this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
                    // 
                    // btnEdit
                    // 
                    this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    this.btnEdit.Enabled = false;
                    this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    this.btnEdit.FlatAppearance.BorderSize = 2;
                    this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
                    this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.btnEdit.ForeColor = System.Drawing.Color.White;
                    this.btnEdit.Location = new System.Drawing.Point(674, 439);
                    this.btnEdit.Name = "btnEdit";
                    this.btnEdit.Size = new System.Drawing.Size(97, 43);
                    this.btnEdit.TabIndex = 75;
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
                    this.btnNew.Location = new System.Drawing.Point(571, 439);
                    this.btnNew.Name = "btnNew";
                    this.btnNew.Size = new System.Drawing.Size(97, 43);
                    this.btnNew.TabIndex = 74;
                    this.btnNew.Text = "New";
                    this.btnNew.UseVisualStyleBackColor = false;
                    this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
                    // 
                    // pnlEntry
                    // 
                    this.pnlEntry.Controls.Add(this.grpApplicables);
                    this.pnlEntry.Controls.Add(this.grpIntervals);
                    this.pnlEntry.Controls.Add(this.grpName);
                    this.pnlEntry.Location = new System.Drawing.Point(0, 70);
                    this.pnlEntry.Name = "pnlEntry";
                    this.pnlEntry.Size = new System.Drawing.Size(974, 363);
                    this.pnlEntry.TabIndex = 78;
                    // 
                    // pnlHistory
                    // 
                    this.pnlHistory.Controls.Add(this.xPander1);
                    this.pnlHistory.Controls.Add(this.dgvHistory);
                    this.pnlHistory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.pnlHistory.Location = new System.Drawing.Point(0, 62);
                    this.pnlHistory.Name = "pnlHistory";
                    this.pnlHistory.Size = new System.Drawing.Size(974, 362);
                    this.pnlHistory.TabIndex = 79;
                    this.pnlHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHistory_Paint);
                    // 
                    // dgvHistory
                    // 
                    this.dgvHistory.AllowUserToAddRows = false;
                    this.dgvHistory.AllowUserToDeleteRows = false;
                    this.dgvHistory.AllowUserToResizeColumns = false;
                    this.dgvHistory.AllowUserToResizeRows = false;
                    this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
                    this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReminderId,
            this.ReminderName,
            this.PriorityId,
            this.Priority,
            this.RemainderMessage,
            this.StartTime,
            this.StopTime,
            this.IntervalsId,
            this.Intervals,
            this.Days,
            this.ApplicableUsersIds,
            this.ApplicabeUserNames});
                    this.dgvHistory.Location = new System.Drawing.Point(177, 11);
                    this.dgvHistory.Name = "dgvHistory";
                    this.dgvHistory.ReadOnly = true;
                    this.dgvHistory.RowHeadersVisible = false;
                    this.dgvHistory.RowTemplate.Height = 24;
                    this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    this.dgvHistory.Size = new System.Drawing.Size(795, 339);
                    this.dgvHistory.TabIndex = 0;
                    this.dgvHistory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentDoubleClick);
                    this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
                    // 
                    // ReminderId
                    // 
                    this.ReminderId.DataPropertyName = "ReminderId";
                    this.ReminderId.HeaderText = "RemainderId";
                    this.ReminderId.Name = "ReminderId";
                    this.ReminderId.ReadOnly = true;
                    this.ReminderId.Visible = false;
                    // 
                    // ReminderName
                    // 
                    this.ReminderName.DataPropertyName = "ReminderName";
                    this.ReminderName.HeaderText = "Name";
                    this.ReminderName.Name = "ReminderName";
                    this.ReminderName.ReadOnly = true;
                    // 
                    // PriorityId
                    // 
                    this.PriorityId.DataPropertyName = "PriorityId";
                    this.PriorityId.HeaderText = "PriorityId";
                    this.PriorityId.Name = "PriorityId";
                    this.PriorityId.ReadOnly = true;
                    this.PriorityId.Visible = false;
                    // 
                    // Priority
                    // 
                    this.Priority.DataPropertyName = "Priority";
                    this.Priority.FillWeight = 75F;
                    this.Priority.HeaderText = "Priority";
                    this.Priority.Name = "Priority";
                    this.Priority.ReadOnly = true;
                    // 
                    // RemainderMessage
                    // 
                    this.RemainderMessage.DataPropertyName = "RemainderMessage";
                    this.RemainderMessage.HeaderText = "Message";
                    this.RemainderMessage.Name = "RemainderMessage";
                    this.RemainderMessage.ReadOnly = true;
                    // 
                    // StartTime
                    // 
                    this.StartTime.DataPropertyName = "StartTime";
                    this.StartTime.HeaderText = "StartTime";
                    this.StartTime.Name = "StartTime";
                    this.StartTime.ReadOnly = true;
                    // 
                    // StopTime
                    // 
                    this.StopTime.DataPropertyName = "StopTime";
                    this.StopTime.HeaderText = "StopTime";
                    this.StopTime.Name = "StopTime";
                    this.StopTime.ReadOnly = true;
                    // 
                    // IntervalsId
                    // 
                    this.IntervalsId.DataPropertyName = "IntervalsId";
                    this.IntervalsId.HeaderText = "IntervalsId";
                    this.IntervalsId.Name = "IntervalsId";
                    this.IntervalsId.ReadOnly = true;
                    this.IntervalsId.Visible = false;
                    // 
                    // Intervals
                    // 
                    this.Intervals.DataPropertyName = "Intervals";
                    this.Intervals.FillWeight = 75F;
                    this.Intervals.HeaderText = "Intervals";
                    this.Intervals.Name = "Intervals";
                    this.Intervals.ReadOnly = true;
                    // 
                    // Days
                    // 
                    this.Days.DataPropertyName = "Days";
                    this.Days.HeaderText = "Days";
                    this.Days.Name = "Days";
                    this.Days.ReadOnly = true;
                    // 
                    // ApplicableUsersIds
                    // 
                    this.ApplicableUsersIds.DataPropertyName = "ApplicableUsersIds";
                    this.ApplicableUsersIds.HeaderText = "Applicable UsersIds";
                    this.ApplicableUsersIds.Name = "ApplicableUsersIds";
                    this.ApplicableUsersIds.ReadOnly = true;
                    this.ApplicableUsersIds.Visible = false;
                    // 
                    // ApplicabeUserNames
                    // 
                    this.ApplicabeUserNames.DataPropertyName = "ApplicabeUserNames";
                    this.ApplicabeUserNames.HeaderText = "Applicabe User Names";
                    this.ApplicabeUserNames.Name = "ApplicabeUserNames";
                    this.ApplicabeUserNames.ReadOnly = true;
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
                    this.xPander1.Location = new System.Drawing.Point(9, 8);
                    this.xPander1.Name = "xPander1";
                    this.xPander1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
                    this.xPander1.PaneBottomRightColor = System.Drawing.Color.Transparent;
                    this.xPander1.PaneOutlineColor = System.Drawing.Color.Transparent;
                    this.xPander1.PaneTopLeftColor = System.Drawing.Color.Transparent;
                    this.xPander1.Size = new System.Drawing.Size(160, 342);
                    this.xPander1.TabIndex = 44;
                    this.xPander1.TooltipText = null;
                    this.xPander1.Load += new System.EventHandler(this.xPander1_Load);
                    // 
                    // txtSearchKey
                    // 
                    this.txtSearchKey.Location = new System.Drawing.Point(11, 280);
                    this.txtSearchKey.Name = "txtSearchKey";
                    this.txtSearchKey.Size = new System.Drawing.Size(135, 27);
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
                    this.xPander2.Location = new System.Drawing.Point(4, 120);
                    this.xPander2.Name = "xPander2";
                    this.xPander2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
                    this.xPander2.PaneBottomRightColor = System.Drawing.Color.Transparent;
                    this.xPander2.PaneOutlineColor = System.Drawing.Color.Transparent;
                    this.xPander2.PaneTopLeftColor = System.Drawing.Color.Transparent;
                    this.xPander2.Size = new System.Drawing.Size(150, 126);
                    this.xPander2.TabIndex = 1;
                    this.xPander2.TooltipText = null;
                    // 
                    // rdbStartWith
                    // 
                    this.rdbStartWith.AutoSize = true;
                    this.rdbStartWith.Checked = true;
                    this.rdbStartWith.Font = new System.Drawing.Font("Verdana", 8.25F);
                    this.rdbStartWith.Location = new System.Drawing.Point(3, 28);
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
                    this.rdbNotContain.Location = new System.Drawing.Point(3, 97);
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
                    this.rdbEndWith.Location = new System.Drawing.Point(2, 51);
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
                    this.rdbContains.Location = new System.Drawing.Point(2, 74);
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
                    this.label11.Location = new System.Drawing.Point(14, 257);
                    this.label11.Name = "label11";
                    this.label11.Size = new System.Drawing.Size(110, 19);
                    this.label11.TabIndex = 25;
                    this.label11.Text = "Search Key :";
                    // 
                    // label12
                    // 
                    this.label12.AutoSize = true;
                    this.label12.BackColor = System.Drawing.Color.Transparent;
                    this.label12.Location = new System.Drawing.Point(5, 42);
                    this.label12.Name = "label12";
                    this.label12.Size = new System.Drawing.Size(112, 19);
                    this.label12.TabIndex = 23;
                    this.label12.Text = "Search Type:";
                    // 
                    // cmbSearchType
                    // 
                    this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    this.cmbSearchType.FormattingEnabled = true;
                    this.cmbSearchType.Items.AddRange(new object[] {
            "Reminder Name",
            "Priority"});
                    this.cmbSearchType.Location = new System.Drawing.Point(4, 74);
                    this.cmbSearchType.Name = "cmbSearchType";
                    this.cmbSearchType.Size = new System.Drawing.Size(147, 27);
                    this.cmbSearchType.TabIndex = 0;
                    // 
                    // FrmRemainderMaster
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(977, 485);
                    this.Controls.Add(this.btnClose);
                    this.Controls.Add(this.btnDelete);
                    this.Controls.Add(this.btnNew);
                    this.Controls.Add(this.btnEdit);
                    this.Controls.Add(this.pnlHistory);
                    this.Controls.Add(this.pnlEntry);
                    this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.Name = "FrmRemainderMaster";
                    this.Text = "Remainder Master";
                    this.Load += new System.EventHandler(this.FrmRemainderMaster_Load);
                    ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).EndInit();
                    this.grpName.ResumeLayout(false);
                    this.grpName.PerformLayout();
                    this.grpIntervals.ResumeLayout(false);
                    this.grpIntervals.PerformLayout();
                    this.grpDays.ResumeLayout(false);
                    this.grpDays.PerformLayout();
                    this.grpApplicables.ResumeLayout(false);
                    this.grpApplicables.PerformLayout();
                    ((System.ComponentModel.ISupportInitialize)(this.dgvApplicables)).EndInit();
                    this.pnlEntry.ResumeLayout(false);
                    this.pnlHistory.ResumeLayout(false);
                    ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
                    this.xPander1.ResumeLayout(false);
                    this.xPander1.PerformLayout();
                    this.xPander2.ResumeLayout(false);
                    this.xPander2.PerformLayout();
                    this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.TextBox txtName;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.DateTimePicker dtpStart;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.ComboBox cmbPriority;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.TextBox txtMessage;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.DateTimePicker dtpStop;
                private System.Windows.Forms.GroupBox grpName;
                private System.Windows.Forms.GroupBox grpIntervals;
                private System.Windows.Forms.Label label6;
                private System.Windows.Forms.RadioButton rdbDaily;
                private System.Windows.Forms.RadioButton rdbOnce;
                private System.Windows.Forms.GroupBox grpDays;
                private System.Windows.Forms.RadioButton rdbMonthly;
                private System.Windows.Forms.RadioButton rdbWeekly;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.GroupBox grpApplicables;
                private System.Windows.Forms.Button btnClose;
                private System.Windows.Forms.Button btnDelete;
                private System.Windows.Forms.Button btnEdit;
                private System.Windows.Forms.Button btnNew;
                private System.Windows.Forms.DataGridView dgvApplicables;
                private System.Windows.Forms.CheckBox chkSunday;
                private System.Windows.Forms.CheckBox chkSaturday;
                private System.Windows.Forms.CheckBox chkFriday;
                private System.Windows.Forms.CheckBox chkThursday;
                private System.Windows.Forms.CheckBox chkWednesday;
                private System.Windows.Forms.CheckBox chkTuesday;
                private System.Windows.Forms.CheckBox chkMonday;
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
                private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxes;
                private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
                private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
                private System.Windows.Forms.DataGridViewTextBoxColumn ReminderId;
                private System.Windows.Forms.DataGridViewTextBoxColumn ReminderName;
                private System.Windows.Forms.DataGridViewTextBoxColumn PriorityId;
                private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
                private System.Windows.Forms.DataGridViewTextBoxColumn RemainderMessage;
                private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
                private System.Windows.Forms.DataGridViewTextBoxColumn StopTime;
                private System.Windows.Forms.DataGridViewTextBoxColumn IntervalsId;
                private System.Windows.Forms.DataGridViewTextBoxColumn Intervals;
                private System.Windows.Forms.DataGridViewTextBoxColumn Days;
                private System.Windows.Forms.DataGridViewTextBoxColumn ApplicableUsersIds;
                private System.Windows.Forms.DataGridViewTextBoxColumn ApplicabeUserNames;
        }
}