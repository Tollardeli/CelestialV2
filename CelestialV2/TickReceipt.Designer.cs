namespace CelestialV2
{
    partial class TickReceipt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассаDataSet = new CelestialV2.КассаDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticketTableAdapter = new CelestialV2.КассаDataSetTableAdapters.TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.кассаDataSet;
            // 
            // кассаDataSet
            // 
            this.кассаDataSet.DataSetName = "КассаDataSet";
            this.кассаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ticketBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CelestialV2.Ticket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // TickReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TickReceipt";
            this.Load += new System.EventHandler(this.TickReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private КассаDataSet кассаDataSet;
        private КассаDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
    }
}