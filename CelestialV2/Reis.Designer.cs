
namespace CelestialV2
{
    partial class Reis
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
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.аэропортПрибытияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассаDataSet = new CelestialV2.КассаDataSet();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.аэропортОтправленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.аэропортОтправленияTableAdapter = new CelestialV2.КассаDataSetTableAdapters.АэропортОтправленияTableAdapter();
            this.аэропортПрибытияTableAdapter = new CelestialV2.КассаDataSetTableAdapters.АэропортПрибытияTableAdapter();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.самолётыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолётыTableAdapter = new CelestialV2.КассаDataSetTableAdapters.СамолётыTableAdapter();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортПрибытияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортОтправленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолётыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DataSource = this.аэропортПрибытияBindingSource;
            this.guna2ComboBox1.DisplayMember = "Название";
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(251, 83);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(174, 36);
            this.guna2ComboBox1.TabIndex = 3;
            this.guna2ComboBox1.ValueMember = "КодАэропортаПрибытия";
            // 
            // аэропортПрибытияBindingSource
            // 
            this.аэропортПрибытияBindingSource.DataMember = "АэропортПрибытия";
            this.аэропортПрибытияBindingSource.DataSource = this.кассаDataSet;
            // 
            // кассаDataSet
            // 
            this.кассаDataSet.DataSetName = "КассаDataSet";
            this.кассаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.DataSource = this.аэропортОтправленияBindingSource;
            this.guna2ComboBox3.DisplayMember = "Название";
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox3.FocusedState.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox3.FormattingEnabled = true;
            this.guna2ComboBox3.HoverState.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.ItemsAppearance.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Location = new System.Drawing.Point(23, 83);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.ShadowDecoration.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Size = new System.Drawing.Size(174, 36);
            this.guna2ComboBox3.TabIndex = 5;
            this.guna2ComboBox3.ValueMember = "КодАэропортаОтправления";
            // 
            // аэропортОтправленияBindingSource
            // 
            this.аэропортОтправленияBindingSource.DataMember = "АэропортОтправления";
            this.аэропортОтправленияBindingSource.DataSource = this.кассаDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Аэропорт отправления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(247, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Аэропорт прибытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Выбор самолёта";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BorderRadius = 17;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(23, 211);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(172, 36);
            this.guna2DateTimePicker1.TabIndex = 39;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 5, 5, 17, 15, 41, 18);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.AutoRoundedCorners = true;
            this.guna2DateTimePicker2.BorderRadius = 17;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(251, 211);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(174, 36);
            this.guna2DateTimePicker2.TabIndex = 40;
            this.guna2DateTimePicker2.Value = new System.DateTime(2022, 5, 5, 17, 15, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(76, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Выберите дату и введите время";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(151, 372);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(145, 45);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "Составить маршрут";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // аэропортОтправленияTableAdapter
            // 
            this.аэропортОтправленияTableAdapter.ClearBeforeFill = true;
            // 
            // аэропортПрибытияTableAdapter
            // 
            this.аэропортПрибытияTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox2.DataSource = this.самолётыBindingSource;
            this.guna2ComboBox2.DisplayMember = "НомерСамолёта";
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.FormattingEnabled = true;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(23, 149);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(174, 36);
            this.guna2ComboBox2.TabIndex = 44;
            this.guna2ComboBox2.ValueMember = "НомерСамолёта";
            // 
            // самолётыBindingSource
            // 
            this.самолётыBindingSource.DataMember = "Самолёты";
            this.самолётыBindingSource.DataSource = this.кассаDataSet;
            // 
            // самолётыTableAdapter
            // 
            this.самолётыTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(251, 138);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(174, 47);
            this.guna2Button2.TabIndex = 45;
            this.guna2Button2.Text = "Посмотреть сведения о самолёте";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.guna2TextBox2.Location = new System.Drawing.Point(123, 318);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox2.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(109, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Введите стоимость рейса";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(23, 253);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker2.TabIndex = 50;
            // 
            // Reis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 440);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ComboBox3);
            this.Controls.Add(this.guna2ComboBox1);
            this.Name = "Reis";
            this.Resizable = false;
            this.Text = "Составить рейс";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аэропортПрибытияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортОтправленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолётыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private КассаDataSet кассаDataSet;
        private System.Windows.Forms.BindingSource аэропортОтправленияBindingSource;
        private КассаDataSetTableAdapters.АэропортОтправленияTableAdapter аэропортОтправленияTableAdapter;
        private System.Windows.Forms.BindingSource аэропортПрибытияBindingSource;
        private КассаDataSetTableAdapters.АэропортПрибытияTableAdapter аэропортПрибытияTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.BindingSource самолётыBindingSource;
        private КассаDataSetTableAdapters.СамолётыTableAdapter самолётыTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}