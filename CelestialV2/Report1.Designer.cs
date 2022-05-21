namespace CelestialV2
{
    partial class Report1
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
            this.earnedForTheQuarterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассаDataSet = new CelestialV2.КассаDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.earned_for_the_quarterTableAdapter = new CelestialV2.КассаDataSetTableAdapters.Earned_for_the_quarterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.earnedForTheQuarterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // earnedForTheQuarterBindingSource
            // 
            this.earnedForTheQuarterBindingSource.DataMember = "Earned for the quarter";
            this.earnedForTheQuarterBindingSource.DataSource = this.кассаDataSet;
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
            reportDataSource1.Value = this.earnedForTheQuarterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CelestialV2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // earned_for_the_quarterTableAdapter
            // 
            this.earned_for_the_quarterTableAdapter.ClearBeforeFill = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report1";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 15);
            this.Text = "Квартальный отчёт";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.earnedForTheQuarterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private КассаDataSet кассаDataSet;
        private System.Windows.Forms.BindingSource earnedForTheQuarterBindingSource;
        private КассаDataSetTableAdapters.Earned_for_the_quarterTableAdapter earned_for_the_quarterTableAdapter;
    }
}