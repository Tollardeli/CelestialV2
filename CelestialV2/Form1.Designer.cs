
namespace CelestialV2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.metroSetLink2 = new MetroSet_UI.Controls.MetroSetLink();
            this.metroSetLink1 = new MetroSet_UI.Controls.MetroSetLink();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // metroSetLink2
            // 
            this.metroSetLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetLink2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetLink2.IsDerivedStyle = true;
            this.metroSetLink2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroSetLink2.Location = new System.Drawing.Point(218, 200);
            this.metroSetLink2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLink2.Name = "metroSetLink2";
            this.metroSetLink2.Size = new System.Drawing.Size(117, 26);
            this.metroSetLink2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLink2.StyleManager = null;
            this.metroSetLink2.TabIndex = 26;
            this.metroSetLink2.TabStop = true;
            this.metroSetLink2.Text = "Скрыть пароль";
            this.metroSetLink2.ThemeAuthor = "Narwin";
            this.metroSetLink2.ThemeName = "MetroLite";
            this.metroSetLink2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.metroSetLink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink2_LinkClicked);
            // 
            // metroSetLink1
            // 
            this.metroSetLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetLink1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetLink1.IsDerivedStyle = true;
            this.metroSetLink1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroSetLink1.Location = new System.Drawing.Point(218, 200);
            this.metroSetLink1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLink1.Name = "metroSetLink1";
            this.metroSetLink1.Size = new System.Drawing.Size(117, 26);
            this.metroSetLink1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLink1.StyleManager = null;
            this.metroSetLink1.TabIndex = 25;
            this.metroSetLink1.TabStop = true;
            this.metroSetLink1.Text = "Показать пароль";
            this.metroSetLink1.ThemeAuthor = "Narwin";
            this.metroSetLink1.ThemeName = "MetroLite";
            this.metroSetLink1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.metroSetLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Логин";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(72, 230);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(210, 52);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Войти";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(111, 146);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(205, 41);
            this.guna2TextBox2.TabIndex = 21;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(111, 79);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(205, 41);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 297);
            this.Controls.Add(this.metroSetLink2);
            this.Controls.Add(this.metroSetLink1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Text = "Авторизация";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private MetroSet_UI.Controls.MetroSetLink metroSetLink2;
        private MetroSet_UI.Controls.MetroSetLink metroSetLink1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}

