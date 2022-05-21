using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CelestialV2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ID { get; set; }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var login = guna2TextBox1.Text;
            var password = guna2TextBox2.Text;
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-QPT6DT7\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=True");
            string query = $"SELECT КодСотрудника,Логин,Пароль FROM Сотрудники WHERE Логин = '{login}' AND Пароль = '{password}'";
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connect);
            ad.SelectCommand = command;
            ad.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                ID = dt.Rows[0][0].ToString();
                Form2 form = new Form2(ID);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Выйди разбийник");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
            metroSetLink2.Visible = false;
            guna2TextBox1.MaxLength = 50;
            guna2TextBox2.MaxLength = 50;

        }
        private void metroSetLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = false;
            metroSetLink1.Visible = false;
            metroSetLink2.Visible = true;
        }
        private void metroSetLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
            metroSetLink1.Visible = true;
            metroSetLink2.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1_Click(sender, e);
            }
        }
    }
}