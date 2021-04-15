namespace CRM
{
    partial class CustomerMaster
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMaster));
            this.pnlhistory = new System.Windows.Forms.Panel();
            this.dgvEmployeeMaster = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlentry = new System.Windows.Forms.Panel();
            this.txtphone2 = new System.Windows.Forms.TextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtphone1 = new System.Windows.Forms.TextBox();
            this.txttinno = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.cmbnationality = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.erperror = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlSearch = new XPanderControl.XPander();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmbSearchType = new System.Windows.Forms.ComboBox();
            this.xPander2 = new XPanderControl.XPander();
            this.RdbEndsWithH = new System.Windows.Forms.RadioButton();
            this.RdbDoesNotContains = new System.Windows.Forms.RadioButton();
            this.RdbStartsWith = new System.Windows.Forms.RadioButton();
            this.RdbContains = new System.Windows.Forms.RadioButton();
            this.lblSearchKey = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picphoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).BeginInit();
            this.pnlhistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeMaster)).BeginInit();
            this.pnlentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erperror)).BeginInit();
            this.PnlSearch.SuspendLayout();
            this.xPander2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPanelSize
            // 
            this.tmrPanelSize.Tick += new System.EventHandler(this.tmrPanelSize_Tick);
            // 
            // pnlhistory
            // 
            this.pnlhistory.Controls.Add(this.PnlSearch);
            this.pnlhistory.Controls.Add(this.dgvEmployeeMaster);
            this.pnlhistory.Location = new System.Drawing.Point(19, 57);
            this.pnlhistory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlhistory.Name = "pnlhistory";
            this.pnlhistory.Size = new System.Drawing.Size(979, 446);
            this.pnlhistory.TabIndex = 10;
            // 
            // dgvEmployeeMaster
            // 
            this.dgvEmployeeMaster.AllowUserToAddRows = false;
            this.dgvEmployeeMaster.AllowUserToDeleteRows = false;
            this.dgvEmployeeMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvEmployeeMaster.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployeeMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.NationalityId,
            this.StateId,
            this.CustomerName,
            this.Address,
            this.Nationality,
            this.State,
            this.Locality,
            this.TinNo,
            this.Phone1,
            this.Phone2,
            this.EmailId,
            this.Fax,
            this.Photo});
            this.dgvEmployeeMaster.Location = new System.Drawing.Point(212, 11);
            this.dgvEmployeeMaster.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeMaster.Name = "dgvEmployeeMaster";
            this.dgvEmployeeMaster.ReadOnly = true;
            this.dgvEmployeeMaster.RowHeadersVisible = false;
            this.dgvEmployeeMaster.RowTemplate.Height = 24;
            this.dgvEmployeeMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeMaster.Size = new System.Drawing.Size(752, 407);
            this.dgvEmployeeMaster.TabIndex = 0;
            this.dgvEmployeeMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeMaster_CellDoubleClick);
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Width = 114;
            // 
            // NationalityId
            // 
            this.NationalityId.DataPropertyName = "NationalityId";
            this.NationalityId.HeaderText = "NationalityId";
            this.NationalityId.Name = "NationalityId";
            this.NationalityId.ReadOnly = true;
            this.NationalityId.Visible = false;
            this.NationalityId.Width = 123;
            // 
            // StateId
            // 
            this.StateId.DataPropertyName = "StateId";
            this.StateId.HeaderText = "StateId";
            this.StateId.Name = "StateId";
            this.StateId.ReadOnly = true;
            this.StateId.Visible = false;
            this.StateId.Width = 84;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 142;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 92;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "CountryName";
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            this.Nationality.Width = 110;
            // 
            // State
            // 
            this.State.DataPropertyName = "StateName";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 71;
            // 
            // Locality
            // 
            this.Locality.DataPropertyName = "Locality";
            this.Locality.HeaderText = "Locality";
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            this.Locality.Width = 89;
            // 
            // TinNo
            // 
            this.TinNo.DataPropertyName = "TinNo";
            this.TinNo.HeaderText = "TinNo";
            this.TinNo.Name = "TinNo";
            this.TinNo.ReadOnly = true;
            this.TinNo.Width = 76;
            // 
            // Phone1
            // 
            this.Phone1.DataPropertyName = "Phone1";
            this.Phone1.HeaderText = "Phone1";
            this.Phone1.Name = "Phone1";
            this.Phone1.ReadOnly = true;
            this.Phone1.Width = 88;
            // 
            // Phone2
            // 
            this.Phone2.DataPropertyName = "Phone2";
            this.Phone2.HeaderText = "Phone2";
            this.Phone2.Name = "Phone2";
            this.Phone2.ReadOnly = true;
            this.Phone2.Width = 88;
            // 
            // EmailId
            // 
            this.EmailId.DataPropertyName = "EmailId";
            this.EmailId.HeaderText = "EmailId";
            this.EmailId.Name = "EmailId";
            this.EmailId.ReadOnly = true;
            this.EmailId.Width = 85;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Width = 58;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "Photo";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Width = 75;
            // 
            // pnlentry
            // 
            this.pnlentry.Controls.Add(this.groupBox1);
            this.pnlentry.Controls.Add(this.txtphone2);
            this.pnlentry.Controls.Add(this.txtfax);
            this.pnlentry.Controls.Add(this.txtemailid);
            this.pnlentry.Controls.Add(this.label10);
            this.pnlentry.Controls.Add(this.label9);
            this.pnlentry.Controls.Add(this.label8);
            this.pnlentry.Controls.Add(this.txtphone1);
            this.pnlentry.Controls.Add(this.txttinno);
            this.pnlentry.Controls.Add(this.txtlocation);
            this.pnlentry.Controls.Add(this.cmbstate);
            this.pnlentry.Controls.Add(this.cmbnationality);
            this.pnlentry.Controls.Add(this.txtaddress);
            this.pnlentry.Controls.Add(this.txtname);
            this.pnlentry.Controls.Add(this.label7);
            this.pnlentry.Controls.Add(this.label6);
            this.pnlentry.Controls.Add(this.label5);
            this.pnlentry.Controls.Add(this.label4);
            this.pnlentry.Controls.Add(this.label3);
            this.pnlentry.Controls.Add(this.label2);
            this.pnlentry.Controls.Add(this.label1);
            this.pnlentry.Enabled = false;
            this.pnlentry.Location = new System.Drawing.Point(16, 54);
            this.pnlentry.Margin = new System.Windows.Forms.Padding(4);
            this.pnlentry.Name = "pnlentry";
            this.pnlentry.Size = new System.Drawing.Size(991, 449);
            this.pnlentry.TabIndex = 4;
            // 
            // txtphone2
            // 
            this.txtphone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone2.Location = new System.Drawing.Point(146, 328);
            this.txtphone2.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone2.Multiline = true;
            this.txtphone2.Name = "txtphone2";
            this.txtphone2.Size = new System.Drawing.Size(259, 34);
            this.txtphone2.TabIndex = 25;
            // 
            // txtfax
            // 
            this.txtfax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfax.Location = new System.Drawing.Point(146, 370);
            this.txtfax.Margin = new System.Windows.Forms.Padding(4);
            this.txtfax.Multiline = true;
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(259, 34);
            this.txtfax.TabIndex = 24;
            // 
            // txtemailid
            // 
            this.txtemailid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemailid.Location = new System.Drawing.Point(146, 412);
            this.txtemailid.Margin = new System.Windows.Forms.Padding(4);
            this.txtemailid.Multiline = true;
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(259, 32);
            this.txtemailid.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(17, 339);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone No2 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(85, 375);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fax :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(41, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email ID :";
            // 
            // txtphone1
            // 
            this.txtphone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone1.Location = new System.Drawing.Point(146, 288);
            this.txtphone1.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone1.Multiline = true;
            this.txtphone1.Name = "txtphone1";
            this.txtphone1.Size = new System.Drawing.Size(259, 32);
            this.txtphone1.TabIndex = 15;
            // 
            // txttinno
            // 
            this.txttinno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttinno.Location = new System.Drawing.Point(146, 248);
            this.txttinno.Margin = new System.Windows.Forms.Padding(4);
            this.txttinno.Multiline = true;
            this.txttinno.Name = "txttinno";
            this.txttinno.Size = new System.Drawing.Size(259, 31);
            this.txttinno.TabIndex = 14;
            // 
            // txtlocation
            // 
            this.txtlocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlocation.Location = new System.Drawing.Point(146, 209);
            this.txtlocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtlocation.Multiline = true;
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(259, 31);
            this.txtlocation.TabIndex = 13;
            // 
            // cmbstate
            // 
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Location = new System.Drawing.Point(148, 176);
            this.cmbstate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(257, 24);
            this.cmbstate.TabIndex = 12;
            // 
            // cmbnationality
            // 
            this.cmbnationality.FormattingEnabled = true;
            this.cmbnationality.Location = new System.Drawing.Point(148, 143);
            this.cmbnationality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbnationality.Name = "cmbnationality";
            this.cmbnationality.Size = new System.Drawing.Size(257, 24);
            this.cmbnationality.TabIndex = 11;
            this.cmbnationality.SelectedValueChanged += new System.EventHandler(this.cmbnationality_SelectedValueChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Location = new System.Drawing.Point(148, 69);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(257, 66);
            this.txtaddress.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(148, 34);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(259, 31);
            this.txtname.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(17, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone No1 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(57, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tin No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(40, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(70, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "State :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nationality :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnedit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.Black;
            this.btnedit.Location = new System.Drawing.Point(669, 510);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(103, 40);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(901, 510);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(105, 39);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(781, 510);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(111, 39);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(564, 511);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 39);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // erperror
            // 
            this.erperror.ContainerControl = this;
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.PnlSearch.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.PnlSearch.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.PnlSearch.CaptionFormatFlag = XPanderControl.XPander.FormatFlag.NoWrap;
            this.PnlSearch.CaptionStyle = XPanderControl.XPander.CaptionStyleEnum.Normal;
            this.PnlSearch.CaptionText = "Search";
            this.PnlSearch.CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Middle;
            this.PnlSearch.ChevronStyle = XPanderControl.XPander.ChevronStyleEnum.Image;
            this.PnlSearch.CollapsedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.CollapsedHighlightImage")));
            this.PnlSearch.CollapsedImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.CollapsedImage")));
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Controls.Add(this.CmbSearchType);
            this.PnlSearch.Controls.Add(this.xPander2);
            this.PnlSearch.Controls.Add(this.lblSearchKey);
            this.PnlSearch.Controls.Add(this.label20);
            this.PnlSearch.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.ExpandedHighlightImage")));
            this.PnlSearch.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.ExpandedImage")));
            this.PnlSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlSearch.Location = new System.Drawing.Point(6, 10);
            this.PnlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.PnlSearch.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.PnlSearch.PaneOutlineColor = System.Drawing.Color.Transparent;
            this.PnlSearch.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.PnlSearch.Size = new System.Drawing.Size(199, 408);
            this.PnlSearch.TabIndex = 24;
            this.PnlSearch.TooltipText = null;
            this.PnlSearch.Load += new System.EventHandler(this.PnlSearch_Load);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(6, 345);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(185, 29);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // CmbSearchType
            // 
            this.CmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSearchType.ForeColor = System.Drawing.Color.Navy;
            this.CmbSearchType.FormattingEnabled = true;
            this.CmbSearchType.Items.AddRange(new object[] {
            "CustomerName"});
            this.CmbSearchType.Location = new System.Drawing.Point(8, 80);
            this.CmbSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.CmbSearchType.Name = "CmbSearchType";
            this.CmbSearchType.Size = new System.Drawing.Size(182, 28);
            this.CmbSearchType.TabIndex = 0;
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
            this.xPander2.Controls.Add(this.RdbEndsWithH);
            this.xPander2.Controls.Add(this.RdbDoesNotContains);
            this.xPander2.Controls.Add(this.RdbStartsWith);
            this.xPander2.Controls.Add(this.RdbContains);
            this.xPander2.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.ExpandedHighlightImage")));
            this.xPander2.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.ExpandedImage")));
            this.xPander2.Location = new System.Drawing.Point(8, 133);
            this.xPander2.Margin = new System.Windows.Forms.Padding(4);
            this.xPander2.Name = "xPander2";
            this.xPander2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.xPander2.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.xPander2.PaneOutlineColor = System.Drawing.Color.Transparent;
            this.xPander2.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.xPander2.Size = new System.Drawing.Size(181, 156);
            this.xPander2.TabIndex = 1;
            this.xPander2.TooltipText = null;
            // 
            // RdbEndsWithH
            // 
            this.RdbEndsWithH.AutoSize = true;
            this.RdbEndsWithH.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbEndsWithH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RdbEndsWithH.Location = new System.Drawing.Point(9, 60);
            this.RdbEndsWithH.Margin = new System.Windows.Forms.Padding(4);
            this.RdbEndsWithH.Name = "RdbEndsWithH";
            this.RdbEndsWithH.Size = new System.Drawing.Size(105, 21);
            this.RdbEndsWithH.TabIndex = 4;
            this.RdbEndsWithH.Text = "Ends With";
            this.RdbEndsWithH.UseVisualStyleBackColor = true;
            // 
            // RdbDoesNotContains
            // 
            this.RdbDoesNotContains.AutoSize = true;
            this.RdbDoesNotContains.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbDoesNotContains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RdbDoesNotContains.Location = new System.Drawing.Point(9, 120);
            this.RdbDoesNotContains.Margin = new System.Windows.Forms.Padding(4);
            this.RdbDoesNotContains.Name = "RdbDoesNotContains";
            this.RdbDoesNotContains.Size = new System.Drawing.Size(165, 21);
            this.RdbDoesNotContains.TabIndex = 3;
            this.RdbDoesNotContains.Text = "Does Not Contain";
            this.RdbDoesNotContains.UseVisualStyleBackColor = true;
            // 
            // RdbStartsWith
            // 
            this.RdbStartsWith.AutoSize = true;
            this.RdbStartsWith.Checked = true;
            this.RdbStartsWith.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbStartsWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RdbStartsWith.Location = new System.Drawing.Point(9, 27);
            this.RdbStartsWith.Margin = new System.Windows.Forms.Padding(4);
            this.RdbStartsWith.Name = "RdbStartsWith";
            this.RdbStartsWith.Size = new System.Drawing.Size(113, 21);
            this.RdbStartsWith.TabIndex = 0;
            this.RdbStartsWith.TabStop = true;
            this.RdbStartsWith.Text = "Starts With";
            this.RdbStartsWith.UseVisualStyleBackColor = true;
            // 
            // RdbContains
            // 
            this.RdbContains.AutoSize = true;
            this.RdbContains.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbContains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RdbContains.Location = new System.Drawing.Point(9, 90);
            this.RdbContains.Margin = new System.Windows.Forms.Padding(4);
            this.RdbContains.Name = "RdbContains";
            this.RdbContains.Size = new System.Drawing.Size(98, 21);
            this.RdbContains.TabIndex = 2;
            this.RdbContains.Text = "Contains";
            this.RdbContains.UseVisualStyleBackColor = true;
            // 
            // lblSearchKey
            // 
            this.lblSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchKey.AutoSize = true;
            this.lblSearchKey.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchKey.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchKey.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSearchKey.Location = new System.Drawing.Point(13, 326);
            this.lblSearchKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchKey.Name = "lblSearchKey";
            this.lblSearchKey.Size = new System.Drawing.Size(102, 17);
            this.lblSearchKey.TabIndex = 25;
            this.lblSearchKey.Text = "Search Key :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Purple;
            this.label20.Location = new System.Drawing.Point(11, 59);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "Search Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.picphoto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 304);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(208, 210);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 27);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(122, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 27);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picphoto
            // 
            this.picphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picphoto.Location = new System.Drawing.Point(122, 29);
            this.picphoto.Margin = new System.Windows.Forms.Padding(4);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(171, 176);
            this.picphoto.TabIndex = 22;
            this.picphoto.TabStop = false;
            // 
            // CustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 559);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.pnlhistory);
            this.Controls.Add(this.pnlentry);
            this.Name = "CustomerMaster";
            this.Text = "CustomerMaster";
            this.Load += new System.EventHandler(this.CustomerMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpAttivo)).EndInit();
            this.pnlhistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeMaster)).EndInit();
            this.pnlentry.ResumeLayout(false);
            this.pnlentry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erperror)).EndInit();
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.xPander2.ResumeLayout(false);
            this.xPander2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhistory;
        private System.Windows.Forms.DataGridView dgvEmployeeMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.Panel pnlentry;
        private System.Windows.Forms.TextBox txtphone2;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtphone1;
        private System.Windows.Forms.TextBox txttinno;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.ComboBox cmbstate;
        private System.Windows.Forms.ComboBox cmbnationality;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ErrorProvider erperror;
        private XPanderControl.XPander PnlSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ComboBox CmbSearchType;
        private XPanderControl.XPander xPander2;
        private System.Windows.Forms.RadioButton RdbEndsWithH;
        private System.Windows.Forms.RadioButton RdbDoesNotContains;
        private System.Windows.Forms.RadioButton RdbStartsWith;
        private System.Windows.Forms.RadioButton RdbContains;
        private System.Windows.Forms.Label lblSearchKey;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picphoto;
    }
}