namespace CelestialV2
{
    partial class DateRep
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
            this.spagrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассаDataSet = new CelestialV2.КассаDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_agrTableAdapter = new CelestialV2.КассаDataSetTableAdapters.sp_agrTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spagrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spagrBindingSource
            // 
            this.spagrBindingSource.DataMember = "sp_agr";
            this.spagrBindingSource.DataSource = this.кассаDataSet;
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
            reportDataSource1.Value = this.spagrBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CelestialV2.TimeSum.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_agrTableAdapter
            // 
            this.sp_agrTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // DateRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DateRep";
            this.Load += new System.EventHandler(this.DateRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spagrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spagrBindingSource;
        private КассаDataSet кассаDataSet;
        private КассаDataSetTableAdapters.sp_agrTableAdapter sp_agrTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}