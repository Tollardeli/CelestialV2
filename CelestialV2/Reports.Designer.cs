namespace CelestialV2
{
    partial class Reports
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квартальныйОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеЗаПериодВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кассаDataSet = new CelestialV2.КассаDataSet();
            this.calculateallticketsellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculate_all_ticket_sellTableAdapter = new CelestialV2.КассаDataSetTableAdapters.calculate_all_ticket_sellTableAdapter();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new CelestialV2.КассаDataSetTableAdapters.View_1TableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculateallticketsellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квартальныйОтчётToolStripMenuItem,
            this.данныеЗаПериодВремениToolStripMenuItem});
            this.открытьToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // квартальныйОтчётToolStripMenuItem
            // 
            this.квартальныйОтчётToolStripMenuItem.Name = "квартальныйОтчётToolStripMenuItem";
            this.квартальныйОтчётToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.квартальныйОтчётToolStripMenuItem.Text = "Квартальный отчёт";
            this.квартальныйОтчётToolStripMenuItem.Click += new System.EventHandler(this.квартальныйОтчётToolStripMenuItem_Click);
            // 
            // данныеЗаПериодВремениToolStripMenuItem
            // 
            this.данныеЗаПериодВремениToolStripMenuItem.Name = "данныеЗаПериодВремениToolStripMenuItem";
            this.данныеЗаПериодВремениToolStripMenuItem.Size = new System.Drawing.Size(290, 24);
            this.данныеЗаПериодВремениToolStripMenuItem.Text = "Данные за период времени";
            this.данныеЗаПериодВремениToolStripMenuItem.Click += new System.EventHandler(this.данныеЗаПериодВремениToolStripMenuItem_Click);
            // 
            // кассаDataSet
            // 
            this.кассаDataSet.DataSetName = "КассаDataSet";
            this.кассаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculateallticketsellBindingSource
            // 
            this.calculateallticketsellBindingSource.DataMember = "calculate_all_ticket_sell";
            this.calculateallticketsellBindingSource.DataSource = this.кассаDataSet;
            // 
            // calculate_all_ticket_sellTableAdapter
            // 
            this.calculate_all_ticket_sellTableAdapter.ClearBeforeFill = true;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.кассаDataSet;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.Text = "Отчёты";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculateallticketsellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private КассаDataSet кассаDataSet;
        private System.Windows.Forms.BindingSource calculateallticketsellBindingSource;
        private КассаDataSetTableAdapters.calculate_all_ticket_sellTableAdapter calculate_all_ticket_sellTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квартальныйОтчётToolStripMenuItem;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private КассаDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.ToolStripMenuItem данныеЗаПериодВремениToolStripMenuItem;
    }
}