namespace CRM
{
    partial class EventMaster
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.grpNotification = new System.Windows.Forms.GroupBox();
            this.grpDays = new System.Windows.Forms.GroupBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.dtpNotificationEndDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNotificatonStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNotificationTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNotificationType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPrioroty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.chkNotifivation = new System.Windows.Forms.CheckBox();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.dgvEventMaster = new System.Windows.Forms.DataGridView();
            this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).BeginInit();
            this.pnlEntry.SuspendLayout();
            this.grpNotification.SuspendLayout();
            this.grpDays.SuspendLayout();
            this.grpEvent.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(362, 638);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(125, 46);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(492, 638);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 46);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(621, 638);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 46);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(750, 638);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 46);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlEntry
            // 
            this.pnlEntry.Controls.Add(this.grpNotification);
            this.pnlEntry.Controls.Add(this.grpEvent);
            this.pnlEntry.Controls.Add(this.chkNotifivation);
            this.pnlEntry.Location = new System.Drawing.Point(12, 63);
            this.pnlEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(864, 569);
            this.pnlEntry.TabIndex = 53;
            this.pnlEntry.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEntry_Paint);
            // 
            // grpNotification
            // 
            this.grpNotification.Controls.Add(this.grpDays);
            this.grpNotification.Controls.Add(this.dtpNotificationEndDate);
            this.grpNotification.Controls.Add(this.label10);
            this.grpNotification.Controls.Add(this.dtpNotificatonStartDate);
            this.grpNotification.Controls.Add(this.label11);
            this.grpNotification.Controls.Add(this.dtpNotificationTime);
            this.grpNotification.Controls.Add(this.label9);
            this.grpNotification.Controls.Add(this.cmbNotificationType);
            this.grpNotification.Controls.Add(this.label8);
            this.grpNotification.Enabled = false;
            this.grpNotification.Location = new System.Drawing.Point(17, 310);
            this.grpNotification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNotification.Name = "grpNotification";
            this.grpNotification.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNotification.Size = new System.Drawing.Size(836, 251);
            this.grpNotification.TabIndex = 61;
            this.grpNotification.TabStop = false;
            // 
            // grpDays
            // 
            this.grpDays.Controls.Add(this.chkSat);
            this.grpDays.Controls.Add(this.chkFri);
            this.grpDays.Controls.Add(this.chkThu);
            this.grpDays.Controls.Add(this.chkWed);
            this.grpDays.Controls.Add(this.chkTue);
            this.grpDays.Controls.Add(this.chkMon);
            this.grpDays.Controls.Add(this.chkSun);
            this.grpDays.Enabled = false;
            this.grpDays.Location = new System.Drawing.Point(229, 55);
            this.grpDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDays.Name = "grpDays";
            this.grpDays.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDays.Size = new System.Drawing.Size(504, 57);
            this.grpDays.TabIndex = 70;
            this.grpDays.TabStop = false;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSat.ForeColor = System.Drawing.Color.Maroon;
            this.chkSat.Location = new System.Drawing.Point(429, 22);
            this.chkSat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(54, 21);
            this.chkSat.TabIndex = 64;
            this.chkSat.Text = "Sat";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFri.ForeColor = System.Drawing.Color.Maroon;
            this.chkFri.Location = new System.Drawing.Point(371, 22);
            this.chkFri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(49, 21);
            this.chkFri.TabIndex = 63;
            this.chkFri.Text = "Fri";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThu.ForeColor = System.Drawing.Color.Maroon;
            this.chkThu.Location = new System.Drawing.Point(301, 22);
            this.chkThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(58, 21);
            this.chkThu.TabIndex = 62;
            this.chkThu.Text = "Thu";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWed.ForeColor = System.Drawing.Color.Maroon;
            this.chkWed.Location = new System.Drawing.Point(229, 22);
            this.chkWed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(62, 21);
            this.chkWed.TabIndex = 61;
            this.chkWed.Text = "Wed";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTue.ForeColor = System.Drawing.Color.Maroon;
            this.chkTue.Location = new System.Drawing.Point(163, 22);
            this.chkTue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(58, 21);
            this.chkTue.TabIndex = 60;
            this.chkTue.Text = "Tue";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMon.ForeColor = System.Drawing.Color.Maroon;
            this.chkMon.Location = new System.Drawing.Point(96, 22);
            this.chkMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(60, 21);
            this.chkMon.TabIndex = 59;
            this.chkMon.Text = "Mon";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSun.ForeColor = System.Drawing.Color.Maroon;
            this.chkSun.Location = new System.Drawing.Point(28, 22);
            this.chkSun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(58, 21);
            this.chkSun.TabIndex = 58;
            this.chkSun.Text = "Sun";
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // dtpNotificationEndDate
            // 
            this.dtpNotificationEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpNotificationEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotificationEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNotificationEndDate.Location = new System.Drawing.Point(591, 177);
            this.dtpNotificationEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNotificationEndDate.Name = "dtpNotificationEndDate";
            this.dtpNotificationEndDate.Size = new System.Drawing.Size(232, 29);
            this.dtpNotificationEndDate.TabIndex = 4;
            this.dtpNotificationEndDate.ValueChanged += new System.EventHandler(this.dtpNotificationEndDate_ValueChanged);
            this.dtpNotificationEndDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(469, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "End Date :";
            // 
            // dtpNotificatonStartDate
            // 
            this.dtpNotificatonStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpNotificatonStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotificatonStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNotificatonStartDate.Location = new System.Drawing.Point(228, 176);
            this.dtpNotificatonStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNotificatonStartDate.Name = "dtpNotificatonStartDate";
            this.dtpNotificatonStartDate.Size = new System.Drawing.Size(232, 29);
            this.dtpNotificatonStartDate.TabIndex = 3;
            this.dtpNotificatonStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(92, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 66;
            this.label11.Text = "Start Date  :";
            // 
            // dtpNotificationTime
            // 
            this.dtpNotificationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotificationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpNotificationTime.Location = new System.Drawing.Point(227, 128);
            this.dtpNotificationTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNotificationTime.Name = "dtpNotificationTime";
            this.dtpNotificationTime.Size = new System.Drawing.Size(232, 29);
            this.dtpNotificationTime.TabIndex = 2;
            this.dtpNotificationTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(23, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Notification Time  :";
            // 
            // cmbNotificationType
            // 
            this.cmbNotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotificationType.FormattingEnabled = true;
            this.cmbNotificationType.Items.AddRange(new object[] {
            "Once",
            "Daily",
            "Weekly",
            "Monthly"});
            this.cmbNotificationType.Location = new System.Drawing.Point(227, 26);
            this.cmbNotificationType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNotificationType.Name = "cmbNotificationType";
            this.cmbNotificationType.Size = new System.Drawing.Size(293, 32);
            this.cmbNotificationType.TabIndex = 0;
            this.cmbNotificationType.SelectedIndexChanged += new System.EventHandler(this.cmbNotificationType_SelectedIndexChanged);
            this.cmbNotificationType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(23, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Notification Type  :  ";
            // 
            // grpEvent
            // 
            this.grpEvent.Controls.Add(this.txtDescription);
            this.grpEvent.Controls.Add(this.label12);
            this.grpEvent.Controls.Add(this.cmbPrioroty);
            this.grpEvent.Controls.Add(this.label7);
            this.grpEvent.Controls.Add(this.dtpEndTime);
            this.grpEvent.Controls.Add(this.label5);
            this.grpEvent.Controls.Add(this.dtpStartTime);
            this.grpEvent.Controls.Add(this.label6);
            this.grpEvent.Controls.Add(this.txtLocation);
            this.grpEvent.Controls.Add(this.label4);
            this.grpEvent.Controls.Add(this.dtpEndDate);
            this.grpEvent.Controls.Add(this.label3);
            this.grpEvent.Controls.Add(this.dtpStartDate);
            this.grpEvent.Controls.Add(this.label2);
            this.grpEvent.Controls.Add(this.label1);
            this.grpEvent.Controls.Add(this.txtEventName);
            this.grpEvent.Enabled = false;
            this.grpEvent.Location = new System.Drawing.Point(17, 5);
            this.grpEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEvent.Size = new System.Drawing.Size(836, 279);
            this.grpEvent.TabIndex = 60;
            this.grpEvent.TabStop = false;
            this.grpEvent.Enter += new System.EventHandler(this.grpEvent_Enter);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(215, 66);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 54);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(76, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "Descripton :";
            // 
            // cmbPrioroty
            // 
            this.cmbPrioroty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioroty.FormattingEnabled = true;
            this.cmbPrioroty.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPrioroty.Location = new System.Drawing.Point(593, 193);
            this.cmbPrioroty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPrioroty.Name = "cmbPrioroty";
            this.cmbPrioroty.Size = new System.Drawing.Size(231, 32);
            this.cmbPrioroty.TabIndex = 7;
            this.cmbPrioroty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(492, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Priority :";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(593, 160);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(231, 29);
            this.dtpEndTime.TabIndex = 5;
            this.dtpEndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(461, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "End Time  :";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(215, 158);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(232, 29);
            this.dtpStartTime.TabIndex = 4;
            this.dtpStartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(73, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Start Time  :";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(215, 191);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(232, 29);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(97, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Location :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(593, 128);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(231, 29);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(464, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "End Date  :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(215, 128);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(232, 29);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(75, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Start Date  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Event Name  :";
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(215, 32);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(232, 29);
            this.txtEventName.TabIndex = 0;
            this.txtEventName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // chkNotifivation
            // 
            this.chkNotifivation.AutoSize = true;
            this.chkNotifivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotifivation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkNotifivation.Location = new System.Drawing.Point(228, 288);
            this.chkNotifivation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNotifivation.Name = "chkNotifivation";
            this.chkNotifivation.Size = new System.Drawing.Size(227, 28);
            this.chkNotifivation.TabIndex = 8;
            this.chkNotifivation.Text = "Notification Required";
            this.chkNotifivation.UseVisualStyleBackColor = true;
            this.chkNotifivation.CheckedChanged += new System.EventHandler(this.chkNotifivation_CheckedChanged_1);
            this.chkNotifivation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventName_KeyDown);
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.dgvEventMaster);
            this.pnlHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHistory.Location = new System.Drawing.Point(11, 70);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(861, 558);
            this.pnlHistory.TabIndex = 54;
            // 
            // dgvEventMaster
            // 
            this.dgvEventMaster.AllowUserToAddRows = false;
            this.dgvEventMaster.AllowUserToDeleteRows = false;
            this.dgvEventMaster.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEventMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventId,
            this.EventName,
            this.Description,
            this.StartDate,
            this.EndDate,
            this.StartTime,
            this.EndTime,
            this.Location,
            this.Priority,
            this.NotificationRequired,
            this.NotificationType,
            this.NotificationTime,
            this.NotificationStartDate,
            this.NotificationEndDate,
            this.Sunday,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            this.dgvEventMaster.Location = new System.Drawing.Point(8, 9);
            this.dgvEventMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEventMaster.Name = "dgvEventMaster";
            this.dgvEventMaster.RowHeadersVisible = false;
            this.dgvEventMaster.RowTemplate.Height = 24;
            this.dgvEventMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventMaster.Size = new System.Drawing.Size(847, 539);
            this.dgvEventMaster.TabIndex = 0;
            this.dgvEventMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventMaster_CellDoubleClick);
            // 
            // EventId
            // 
            this.EventId.DataPropertyName = "EventId";
            this.EventId.HeaderText = "EventId";
            this.EventId.Name = "EventId";
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "EventName";
            this.EventName.Name = "EventName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            // 
            // NotificationRequired
            // 
            this.NotificationRequired.DataPropertyName = "NotificationRequired";
            this.NotificationRequired.HeaderText = "NotificationRequired";
            this.NotificationRequired.Name = "NotificationRequired";
            // 
            // NotificationType
            // 
            this.NotificationType.DataPropertyName = "NotificationType";
            this.NotificationType.HeaderText = "NotificationType";
            this.NotificationType.Name = "NotificationType";
            // 
            // NotificationTime
            // 
            this.NotificationTime.DataPropertyName = "NotificationTime";
            this.NotificationTime.HeaderText = "NotificationTime";
            this.NotificationTime.Name = "NotificationTime";
            // 
            // NotificationStartDate
            // 
            this.NotificationStartDate.DataPropertyName = "NotificationStartDate";
            this.NotificationStartDate.HeaderText = "NotificationStartDate";
            this.NotificationStartDate.Name = "NotificationStartDate";
            // 
            // NotificationEndDate
            // 
            this.NotificationEndDate.DataPropertyName = "NotificationEndDate";
            this.NotificationEndDate.HeaderText = "NotificationEndDate";
            this.NotificationEndDate.Name = "NotificationEndDate";
            // 
            // Sunday
            // 
            this.Sunday.DataPropertyName = "Sunday";
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.Name = "Sunday";
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.HeaderText = "Monday";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.DataPropertyName = "Tuesday";
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.DataPropertyName = "Wednesday";
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.DataPropertyName = "Thursday";
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.DataPropertyName = "Friday";
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.DataPropertyName = "Saturday";
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.Name = "Saturday";
            // 
            // EventMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(892, 693);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlEntry);
            this.Controls.Add(this.pnlHistory);
            this.MinimizeBox = false;
            this.Name = "EventMaster";
            this.Text = "EventMaster";
            this.Load += new System.EventHandler(this.EventMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).EndInit();
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.grpNotification.ResumeLayout(false);
            this.grpNotification.PerformLayout();
            this.grpDays.ResumeLayout(false);
            this.grpDays.PerformLayout();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.GroupBox grpNotification;
        private System.Windows.Forms.DateTimePicker dtpNotificationEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNotificatonStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNotificationTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNotificationType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkNotifivation;
        private System.Windows.Forms.ComboBox cmbPrioroty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.DataGridView dgvEventMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.GroupBox grpDays;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.CheckBox chkSun;

    }
}