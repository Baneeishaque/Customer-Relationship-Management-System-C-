namespace CRM
{
    partial class ServiceEntry
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimeRequiredMinutes = new System.Windows.Forms.TextBox();
            this.txtTimeRequiredHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeRequiredDays = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.pnlServiceEntry = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvServiceEntryMaster = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRequiredDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRequiredHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRequiredMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlServiceEntryHistory = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlServiceEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceEntryMaster)).BeginInit();
            this.pnlServiceEntryHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "(Minutes)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "(Hours)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Service Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServiceCost);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTimeRequiredMinutes);
            this.groupBox1.Controls.Add(this.txtTimeRequiredHours);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTimeRequiredDays);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Controls.Add(this.cmbProductName);
            this.groupBox1.Location = new System.Drawing.Point(19, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(511, 276);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Name :";
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCost.Location = new System.Drawing.Point(180, 233);
            this.txtServiceCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(324, 30);
            this.txtServiceCost.TabIndex = 5;
            this.txtServiceCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 236);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Service Cost :";
            // 
            // txtTimeRequiredMinutes
            // 
            this.txtTimeRequiredMinutes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeRequiredMinutes.Location = new System.Drawing.Point(180, 198);
            this.txtTimeRequiredMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeRequiredMinutes.Name = "txtTimeRequiredMinutes";
            this.txtTimeRequiredMinutes.Size = new System.Drawing.Size(135, 30);
            this.txtTimeRequiredMinutes.TabIndex = 4;
            this.txtTimeRequiredMinutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // txtTimeRequiredHours
            // 
            this.txtTimeRequiredHours.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeRequiredHours.Location = new System.Drawing.Point(180, 165);
            this.txtTimeRequiredHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeRequiredHours.Name = "txtTimeRequiredHours";
            this.txtTimeRequiredHours.Size = new System.Drawing.Size(135, 30);
            this.txtTimeRequiredHours.TabIndex = 3;
            this.txtTimeRequiredHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Days)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time required :";
            // 
            // txtTimeRequiredDays
            // 
            this.txtTimeRequiredDays.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeRequiredDays.Location = new System.Drawing.Point(180, 133);
            this.txtTimeRequiredDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeRequiredDays.Name = "txtTimeRequiredDays";
            this.txtTimeRequiredDays.Size = new System.Drawing.Size(135, 30);
            this.txtTimeRequiredDays.TabIndex = 2;
            this.txtTimeRequiredDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(180, 98);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(324, 30);
            this.txtServiceName.TabIndex = 1;
            this.txtServiceName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // cmbProductName
            // 
            this.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(180, 63);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(324, 31);
            this.cmbProductName.TabIndex = 0;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            this.cmbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // pnlServiceEntry
            // 
            this.pnlServiceEntry.Controls.Add(this.groupBox1);
            this.pnlServiceEntry.Enabled = false;
            this.pnlServiceEntry.Location = new System.Drawing.Point(7, 158);
            this.pnlServiceEntry.Margin = new System.Windows.Forms.Padding(4);
            this.pnlServiceEntry.Name = "pnlServiceEntry";
            this.pnlServiceEntry.Size = new System.Drawing.Size(524, 284);
            this.pnlServiceEntry.TabIndex = 56;
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
            this.btnClose.Location = new System.Drawing.Point(1221, 448);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 49);
            this.btnClose.TabIndex = 54;
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
            this.btnDelete.Location = new System.Drawing.Point(1105, 448);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 49);
            this.btnDelete.TabIndex = 53;
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
            this.btnEdit.Location = new System.Drawing.Point(982, 448);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 49);
            this.btnEdit.TabIndex = 1;
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
            this.btnNew.Location = new System.Drawing.Point(859, 448);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 49);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // dgvServiceEntryMaster
            // 
            this.dgvServiceEntryMaster.AllowUserToAddRows = false;
            this.dgvServiceEntryMaster.AllowUserToDeleteRows = false;
            this.dgvServiceEntryMaster.AllowUserToResizeColumns = false;
            this.dgvServiceEntryMaster.AllowUserToResizeRows = false;
            this.dgvServiceEntryMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceEntryMaster.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvServiceEntryMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceEntryMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ServiceName,
            this.ServiceId,
            this.ProductId,
            this.TimeRequiredDays,
            this.TimeRequiredHours,
            this.TimeRequiredMinutes,
            this.ServiceCost});
            this.dgvServiceEntryMaster.Location = new System.Drawing.Point(4, 11);
            this.dgvServiceEntryMaster.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServiceEntryMaster.MultiSelect = false;
            this.dgvServiceEntryMaster.Name = "dgvServiceEntryMaster";
            this.dgvServiceEntryMaster.ReadOnly = true;
            this.dgvServiceEntryMaster.RowHeadersVisible = false;
            this.dgvServiceEntryMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceEntryMaster.Size = new System.Drawing.Size(799, 267);
            this.dgvServiceEntryMaster.TabIndex = 40;
            this.dgvServiceEntryMaster.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceEntryMaster_CellDoubleClick);
            this.dgvServiceEntryMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceEntryMaster_CellClick);
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 160F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 100;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.FillWeight = 150F;
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServiceId
            // 
            this.ServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceId.DataPropertyName = "ServiceId";
            this.ServiceId.HeaderText = "ServiceId";
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // TimeRequiredDays
            // 
            this.TimeRequiredDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeRequiredDays.DataPropertyName = "TimeRequiredDays";
            this.TimeRequiredDays.FillWeight = 60F;
            this.TimeRequiredDays.HeaderText = "Days";
            this.TimeRequiredDays.MinimumWidth = 30;
            this.TimeRequiredDays.Name = "TimeRequiredDays";
            this.TimeRequiredDays.ReadOnly = true;
            // 
            // TimeRequiredHours
            // 
            this.TimeRequiredHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeRequiredHours.DataPropertyName = "TimeRequiredHours";
            this.TimeRequiredHours.FillWeight = 60F;
            this.TimeRequiredHours.HeaderText = "Hours";
            this.TimeRequiredHours.MinimumWidth = 30;
            this.TimeRequiredHours.Name = "TimeRequiredHours";
            this.TimeRequiredHours.ReadOnly = true;
            // 
            // TimeRequiredMinutes
            // 
            this.TimeRequiredMinutes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeRequiredMinutes.DataPropertyName = "TimeRequiredMinutes";
            this.TimeRequiredMinutes.FillWeight = 60F;
            this.TimeRequiredMinutes.HeaderText = "Minute";
            this.TimeRequiredMinutes.MinimumWidth = 30;
            this.TimeRequiredMinutes.Name = "TimeRequiredMinutes";
            this.TimeRequiredMinutes.ReadOnly = true;
            // 
            // ServiceCost
            // 
            this.ServiceCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceCost.DataPropertyName = "ServiceCost";
            this.ServiceCost.HeaderText = "Cost";
            this.ServiceCost.MinimumWidth = 30;
            this.ServiceCost.Name = "ServiceCost";
            this.ServiceCost.ReadOnly = true;
            // 
            // pnlServiceEntryHistory
            // 
            this.pnlServiceEntryHistory.Controls.Add(this.dgvServiceEntryMaster);
            this.pnlServiceEntryHistory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlServiceEntryHistory.Location = new System.Drawing.Point(528, 158);
            this.pnlServiceEntryHistory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlServiceEntryHistory.Name = "pnlServiceEntryHistory";
            this.pnlServiceEntryHistory.Size = new System.Drawing.Size(809, 286);
            this.pnlServiceEntryHistory.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-61, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 52;
            // 
            // ServiceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 501);
            this.Controls.Add(this.pnlServiceEntry);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlServiceEntryHistory);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceEntry";
            this.Text = "ServiceEntry";
            this.Load += new System.EventHandler(this.ServiceEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlServiceEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceEntryMaster)).EndInit();
            this.pnlServiceEntryHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimeRequiredMinutes;
        private System.Windows.Forms.TextBox txtTimeRequiredHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeRequiredDays;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Panel pnlServiceEntry;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvServiceEntryMaster;
        private System.Windows.Forms.Panel pnlServiceEntryHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeRequiredDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeRequiredHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeRequiredMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCost;
    }
}