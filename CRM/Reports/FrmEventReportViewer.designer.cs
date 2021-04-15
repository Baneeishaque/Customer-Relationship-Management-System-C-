namespace CRM
{
    partial class FrmEventReportViewer
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
            this.CrvEventReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvEventReport
            // 
            this.CrvEventReport.ActiveViewIndex = -1;
            this.CrvEventReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvEventReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvEventReport.Location = new System.Drawing.Point(0, 0);
            this.CrvEventReport.Name = "CrvEventReport";
            this.CrvEventReport.SelectionFormula = "";
            this.CrvEventReport.Size = new System.Drawing.Size(1212, 634);
            this.CrvEventReport.TabIndex = 0;
            this.CrvEventReport.ViewTimeSelectionFormula = "";
            this.CrvEventReport.Load += new System.EventHandler(this.CrvEventReport_Load);
            // 
            // FrmEventReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 634);
            this.Controls.Add(this.CrvEventReport);
            this.Name = "FrmEventReportViewer";
            this.Text = "FrmEventReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrvEventReport;
    }
}