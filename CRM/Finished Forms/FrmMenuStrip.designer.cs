namespace CRM
{
    partial class CRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seviceRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remailnderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createARemainderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRegReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.remailnderToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-19, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1296, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.viewAllCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(144, 33);
            this.customerToolStripMenuItem.Text = "Customer ";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.addNewCustomerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            this.viewAllCustomersToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.viewAllCustomersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            this.viewAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.viewAllCustomersToolStripMenuItem.Text = "View All Customers";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEmployeeToolStripMenuItem,
            this.viewAllEmployeesToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(142, 33);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // viewAllEmployeesToolStripMenuItem
            // 
            this.viewAllEmployeesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewAllEmployeesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewAllEmployeesToolStripMenuItem.Name = "viewAllEmployeesToolStripMenuItem";
            this.viewAllEmployeesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.viewAllEmployeesToolStripMenuItem.Text = "View All Employees";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.viewAllProductsToolStripMenuItem});
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(115, 33);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.addNewProductToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewProductToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // viewAllProductsToolStripMenuItem
            // 
            this.viewAllProductsToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.viewAllProductsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllProductsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewAllProductsToolStripMenuItem.Name = "viewAllProductsToolStripMenuItem";
            this.viewAllProductsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.viewAllProductsToolStripMenuItem.Text = "View All Products";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seviceRegistrationToolStripMenuItem,
            this.serviceEntryToolStripMenuItem,
            this.serviceScheduleToolStripMenuItem});
            this.serviceToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(113, 33);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // seviceRegistrationToolStripMenuItem
            // 
            this.seviceRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seviceRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seviceRegistrationToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.seviceRegistrationToolStripMenuItem.Name = "seviceRegistrationToolStripMenuItem";
            this.seviceRegistrationToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.seviceRegistrationToolStripMenuItem.Text = "Sevice Registration";
            this.seviceRegistrationToolStripMenuItem.Click += new System.EventHandler(this.seviceRegistrationToolStripMenuItem_Click);
            // 
            // serviceEntryToolStripMenuItem
            // 
            this.serviceEntryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serviceEntryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceEntryToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.serviceEntryToolStripMenuItem.Name = "serviceEntryToolStripMenuItem";
            this.serviceEntryToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.serviceEntryToolStripMenuItem.Text = "Service Entry";
            this.serviceEntryToolStripMenuItem.Click += new System.EventHandler(this.serviceEntryToolStripMenuItem_Click);
            // 
            // serviceScheduleToolStripMenuItem
            // 
            this.serviceScheduleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serviceScheduleToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceScheduleToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.serviceScheduleToolStripMenuItem.Name = "serviceScheduleToolStripMenuItem";
            this.serviceScheduleToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.serviceScheduleToolStripMenuItem.Text = "Service Schedule";
            this.serviceScheduleToolStripMenuItem.Click += new System.EventHandler(this.serviceScheduleToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.purchaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(134, 33);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEventToolStripMenuItem,
            this.eventReportsToolStripMenuItem});
            this.eventToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(90, 33);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // addNewEventToolStripMenuItem
            // 
            this.addNewEventToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewEventToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEventToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.addNewEventToolStripMenuItem.Name = "addNewEventToolStripMenuItem";
            this.addNewEventToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addNewEventToolStripMenuItem.Text = "Add New Event";
            this.addNewEventToolStripMenuItem.Click += new System.EventHandler(this.addNewEventToolStripMenuItem_Click);
            // 
            // eventReportsToolStripMenuItem
            // 
            this.eventReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.eventReportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventReportsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.eventReportsToolStripMenuItem.Name = "eventReportsToolStripMenuItem";
            this.eventReportsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eventReportsToolStripMenuItem.Text = "Event Reports";
            this.eventReportsToolStripMenuItem.Click += new System.EventHandler(this.eventReportsToolStripMenuItem_Click);
            // 
            // remailnderToolStripMenuItem
            // 
            this.remailnderToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.remailnderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createARemainderToolStripMenuItem,
            this.viewAllToolStripMenuItem});
            this.remailnderToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remailnderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remailnderToolStripMenuItem.Name = "remailnderToolStripMenuItem";
            this.remailnderToolStripMenuItem.Size = new System.Drawing.Size(153, 33);
            this.remailnderToolStripMenuItem.Text = "Remainder";
            // 
            // createARemainderToolStripMenuItem
            // 
            this.createARemainderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createARemainderToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createARemainderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.createARemainderToolStripMenuItem.Name = "createARemainderToolStripMenuItem";
            this.createARemainderToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.createARemainderToolStripMenuItem.Text = "Create a remainder";
            this.createARemainderToolStripMenuItem.Click += new System.EventHandler(this.createARemainderToolStripMenuItem_Click);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viewAllToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.viewAllToolStripMenuItem.Text = "View all";
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.companiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCompanyToolStripMenuItem,
            this.viewAllCompaniesToolStripMenuItem});
            this.companiesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companiesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(157, 33);
            this.companiesToolStripMenuItem.Text = "Companies";
            // 
            // addNewCompanyToolStripMenuItem
            // 
            this.addNewCompanyToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.addNewCompanyToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCompanyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewCompanyToolStripMenuItem.Name = "addNewCompanyToolStripMenuItem";
            this.addNewCompanyToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.addNewCompanyToolStripMenuItem.Text = "Add New Company";
            this.addNewCompanyToolStripMenuItem.Click += new System.EventHandler(this.addNewCompanyToolStripMenuItem_Click);
            // 
            // viewAllCompaniesToolStripMenuItem
            // 
            this.viewAllCompaniesToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.viewAllCompaniesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllCompaniesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewAllCompaniesToolStripMenuItem.Name = "viewAllCompaniesToolStripMenuItem";
            this.viewAllCompaniesToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.viewAllCompaniesToolStripMenuItem.Text = "View all companies";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem,
            this.serviceRegReportToolStripMenuItem,
            this.eventReportToolStripMenuItem,
            this.companyReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(117, 33);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customerReportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.employeeReportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.employeeReportToolStripMenuItem.Text = "Employee Report";
            // 
            // serviceRegReportToolStripMenuItem
            // 
            this.serviceRegReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.serviceRegReportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRegReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.serviceRegReportToolStripMenuItem.Name = "serviceRegReportToolStripMenuItem";
            this.serviceRegReportToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.serviceRegReportToolStripMenuItem.Text = "Service reg report";
            this.serviceRegReportToolStripMenuItem.Click += new System.EventHandler(this.serviceRegReportToolStripMenuItem_Click);
            // 
            // eventReportToolStripMenuItem
            // 
            this.eventReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.eventReportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eventReportToolStripMenuItem.Name = "eventReportToolStripMenuItem";
            this.eventReportToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.eventReportToolStripMenuItem.Text = "Event Report";
            this.eventReportToolStripMenuItem.Click += new System.EventHandler(this.eventReportToolStripMenuItem_Click);
            // 
            // companyReportToolStripMenuItem
            // 
            this.companyReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.companyReportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.companyReportToolStripMenuItem.Name = "companyReportToolStripMenuItem";
            this.companyReportToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.companyReportToolStripMenuItem.Text = "Company Report";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(117, 33);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1530, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1605, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "CRM";
            this.Text = "CRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuStrip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remailnderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seviceRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceEntryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem addNewEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createARemainderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCompaniesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceRegReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}