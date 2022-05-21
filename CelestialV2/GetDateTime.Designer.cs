namespace CelestialV2
{
    partial class GetDateTime
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
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(23, 63);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 0;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 5, 10, 19, 41, 2, 352);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(23, 105);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker2.TabIndex = 1;
            this.guna2DateTimePicker2.Value = new System.DateTime(2022, 5, 10, 19, 41, 2, 352);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(23, 157);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(200, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Вывести выбранный за заданный период ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // GetDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 231);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Name = "GetDateTime";
            this.Resizable = false;
            this.Text = "Выбор даты";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}