using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialV2
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        private string ID { get; set; }
        private int Check = 0;
        public Form2(string ID)
        {
            this.ID = ID;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int post;
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-QPT6DT7\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=True");
            string query = $"SELECT НомерДолжности FROM Сотрудники WHERE КодСотрудника = {ID}";
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connect);
            ad.SelectCommand = command;
            ad.Fill(dt);
            post = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (post == 1)
            {

            }
            else if (post == 2)
            {
                guna2Button3.Hide();
                guna2Button4.Hide();
                guna2Button7.Hide();
                guna2Button6.Hide();
                guna2Button9.Hide();
                guna2Button5.Location = new Point(211, 198);
            }
            else if (post == 3)
            {

                guna2Button1.Hide();
                guna2Button2.Hide();
                guna2Button10.Hide();
                guna2Button8.Hide();
                guna2Button7.Hide();
                guna2Button4.Location = new Point(15, 96); 
                guna2Button3.Location = new Point(15, 147); 
                guna2Button9.Location = new Point(211, 96); 
                guna2Button6.Location = new Point(211, 147); 
                guna2Button5.Location = new Point(211, 198);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            Hide();
            form.SelectTabItem(0);
            form.ShowDialog(this);
            Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            Hide();
            form.SelectTabItem(1);
            form.ShowDialog(this);
            Show();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            aeroForm form = new aeroForm();
            form.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            dgvr form = new dgvr(ID);
            form.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            cnsldgvr cnsl = new cnsldgvr();
            cnsl.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            aeroForm form = new aeroForm();
            form.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Reports form = new Reports();
            form.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            PlaneManage form = new PlaneManage(Check);
            form.Show();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Plane form = new Plane();
            form.Show();
        }
    }
}
