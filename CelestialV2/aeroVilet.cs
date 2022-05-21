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
    public partial class aeroVilet : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = null;
        public aeroVilet()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = Convert.ToString(this.guna2TextBox1.Text);
                string Сountry = Convert.ToString(this.guna2TextBox2.Text);
                string City = Convert.ToString(this.guna2TextBox3.Text);
                string TimeZone = Convert.ToString(this.guna2TextBox4.Text);
                string Address = Convert.ToString(this.guna2TextBox5.Text);
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                SqlCommand query1 = conn.CreateCommand();
                query1.CommandText = "INSERT INTO АэропортОтправления(Название, СтранаОтправления, ГородОтправления, ЧасовойПояс, Адрес) VALUES(@Name,@Сountry,@City,@TimeZone,@Address)";
                query1.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                query1.Parameters["@Name"].Value = Name;
                query1.Parameters.Add("@Сountry", SqlDbType.NVarChar, 50);
                query1.Parameters["@Сountry"].Value = Сountry;
                query1.Parameters.Add("@City", SqlDbType.NVarChar, 50);
                query1.Parameters["@City"].Value = City;
                query1.Parameters.Add("@TimeZone", SqlDbType.Int);
                query1.Parameters["@TimeZone"].Value = TimeZone;
                query1.Parameters.Add("@Address", SqlDbType.NVarChar, 50);
                query1.Parameters["@Address"].Value = Address;
                int UspeshnoeIzmenenie = query1.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }

        private void aeroVilet_Load(object sender, EventArgs e)
        {

        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}