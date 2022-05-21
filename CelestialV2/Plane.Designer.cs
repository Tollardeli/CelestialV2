namespace CelestialV2
{
    partial class Plane
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.номерСамолётаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авиакомпанияВладелецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельСамолётаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоМестЭкономDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоМестПервыйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоМестБизнесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.самолётыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассаDataSet = new CelestialV2.КассаDataSet();
            this.самолётыTableAdapter = new CelestialV2.КассаDataSetTableAdapters.СамолётыTableAdapter();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guna2TextBox12 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолётыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 22;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСамолётаDataGridViewTextBoxColumn,
            this.авиакомпанияВладелецDataGridViewTextBoxColumn,
            this.модельСамолётаDataGridViewTextBoxColumn,
            this.числоМестЭкономDataGridViewTextBoxColumn,
            this.числоМестПервыйDataGridViewTextBoxColumn,
            this.числоМестБизнесDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.самолётыBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(23, 63);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1010, 489);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // номерСамолётаDataGridViewTextBoxColumn
            // 
            this.номерСамолётаDataGridViewTextBoxColumn.DataPropertyName = "НомерСамолёта";
            this.номерСамолётаDataGridViewTextBoxColumn.HeaderText = "НомерСамолёта";
            this.номерСамолётаDataGridViewTextBoxColumn.Name = "номерСамолётаDataGridViewTextBoxColumn";
            this.номерСамолётаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авиакомпанияВладелецDataGridViewTextBoxColumn
            // 
            this.авиакомпанияВладелецDataGridViewTextBoxColumn.DataPropertyName = "АвиакомпанияВладелец";
            this.авиакомпанияВладелецDataGridViewTextBoxColumn.HeaderText = "АвиакомпанияВладелец";
            this.авиакомпанияВладелецDataGridViewTextBoxColumn.Name = "авиакомпанияВладелецDataGridViewTextBoxColumn";
            this.авиакомпанияВладелецDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельСамолётаDataGridViewTextBoxColumn
            // 
            this.модельСамолётаDataGridViewTextBoxColumn.DataPropertyName = "МодельСамолёта";
            this.модельСамолётаDataGridViewTextBoxColumn.HeaderText = "МодельСамолёта";
            this.модельСамолётаDataGridViewTextBoxColumn.Name = "модельСамолётаDataGridViewTextBoxColumn";
            this.модельСамолётаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // числоМестЭкономDataGridViewTextBoxColumn
            // 
            this.числоМестЭкономDataGridViewTextBoxColumn.DataPropertyName = "ЧислоМестЭконом";
            this.числоМестЭкономDataGridViewTextBoxColumn.HeaderText = "ЧислоМестЭконом";
            this.числоМестЭкономDataGridViewTextBoxColumn.Name = "числоМестЭкономDataGridViewTextBoxColumn";
            this.числоМестЭкономDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // числоМестПервыйDataGridViewTextBoxColumn
            // 
            this.числоМестПервыйDataGridViewTextBoxColumn.DataPropertyName = "ЧислоМестПервый";
            this.числоМестПервыйDataGridViewTextBoxColumn.HeaderText = "ЧислоМестПервый";
            this.числоМестПервыйDataGridViewTextBoxColumn.Name = "числоМестПервыйDataGridViewTextBoxColumn";
            this.числоМестПервыйDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // числоМестБизнесDataGridViewTextBoxColumn
            // 
            this.числоМестБизнесDataGridViewTextBoxColumn.DataPropertyName = "ЧислоМестБизнес";
            this.числоМестБизнесDataGridViewTextBoxColumn.HeaderText = "ЧислоМестБизнес";
            this.числоМестБизнесDataGridViewTextBoxColumn.Name = "числоМестБизнесDataGridViewTextBoxColumn";
            this.числоМестБизнесDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // самолётыBindingSource
            // 
            this.самолётыBindingSource.DataMember = "Самолёты";
            this.самолётыBindingSource.DataSource = this.кассаDataSet;
            // 
            // кассаDataSet
            // 
            this.кассаDataSet.DataSetName = "КассаDataSet";
            this.кассаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // самолётыTableAdapter
            // 
            this.самолётыTableAdapter.ClearBeforeFill = true;
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroSetLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetLabel10.IsDerivedStyle = true;
            this.metroSetLabel10.Location = new System.Drawing.Point(23, 558);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(175, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 17;
            this.metroSetLabel10.Text = "Выберите условие";
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.FormattingEnabled = true;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 44;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "НомерСамолёта",
            "АвиакомпанияВладелец",
            "МодельСамолёта",
            "ЧислоМестЭконом",
            "ЧислоМестПервый",
            "ЧислоМестБизнес"});
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(23, 586);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(175, 50);
            this.guna2ComboBox2.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.guna2TextBox2);
            this.groupBox3.Controls.Add(this.guna2CircleButton4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(204, 558);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 98);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск записей";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(7, 28);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 50);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.CheckedState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.CustomImages.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2CircleButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.HoverState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Location = new System.Drawing.Point(213, 28);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.ShadowDecoration.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Size = new System.Drawing.Size(55, 50);
            this.guna2CircleButton4.TabIndex = 3;
            this.guna2CircleButton4.Text = "Поиск";
            this.guna2CircleButton4.Click += new System.EventHandler(this.guna2CircleButton4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.guna2TextBox12);
            this.groupBox4.Controls.Add(this.guna2CircleButton5);
            this.groupBox4.Controls.Add(this.guna2CircleButton6);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(488, 558);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 95);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтр записей";
            // 
            // guna2TextBox12
            // 
            this.guna2TextBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox12.DefaultText = "";
            this.guna2TextBox12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox12.DisabledState.Parent = this.guna2TextBox12;
            this.guna2TextBox12.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox12.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox12.FocusedState.Parent = this.guna2TextBox12;
            this.guna2TextBox12.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox12.HoverState.Parent = this.guna2TextBox12;
            this.guna2TextBox12.Location = new System.Drawing.Point(7, 28);
            this.guna2TextBox12.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox12.Name = "guna2TextBox12";
            this.guna2TextBox12.PasswordChar = '\0';
            this.guna2TextBox12.PlaceholderText = "";
            this.guna2TextBox12.SelectedText = "";
            this.guna2TextBox12.ShadowDecoration.Parent = this.guna2TextBox12;
            this.guna2TextBox12.Size = new System.Drawing.Size(195, 50);
            this.guna2TextBox12.TabIndex = 6;
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.CheckedState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.CustomImages.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2CircleButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.HoverState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Location = new System.Drawing.Point(285, 28);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.ShadowDecoration.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Size = new System.Drawing.Size(60, 50);
            this.guna2CircleButton5.TabIndex = 5;
            this.guna2CircleButton5.Text = "Снять";
            this.guna2CircleButton5.Click += new System.EventHandler(this.guna2CircleButton5_Click);
            // 
            // guna2CircleButton6
            // 
            this.guna2CircleButton6.CheckedState.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.CustomImages.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2CircleButton6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton6.HoverState.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.Location = new System.Drawing.Point(209, 28);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.ShadowDecoration.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.Size = new System.Drawing.Size(60, 50);
            this.guna2CircleButton6.TabIndex = 4;
            this.guna2CircleButton6.Text = "Фильтр";
            this.guna2CircleButton6.Click += new System.EventHandler(this.guna2CircleButton6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BorderRadius = 13;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(853, 558);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(180, 45);
            this.guna2Button5.TabIndex = 15;
            this.guna2Button5.Text = "Удалить запись";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(853, 609);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Редактировать запись";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 664);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.metroSetLabel10);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "Plane";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Самолёты";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Plane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолётыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private КассаDataSet кассаDataSet;
        private System.Windows.Forms.BindingSource самолётыBindingSource;
        private КассаDataSetTableAdapters.СамолётыTableAdapter самолётыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСамолётаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авиакомпанияВладелецDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельСамолётаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоМестЭкономDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоМестПервыйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоМестБизнесDataGridViewTextBoxColumn;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox12;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}