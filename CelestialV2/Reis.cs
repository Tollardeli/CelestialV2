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
    public partial class Reis : MetroFramework.Forms.MetroForm
    {
        Plane plane;
        SqlConnection conn;
        public Reis()
        {
            InitializeComponent();
        }

        private void Reis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Самолёты". При необходимости она может быть перемещена или удалена.
            this.самолётыTableAdapter.Fill(this.кассаDataSet.Самолёты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.АэропортПрибытия". При необходимости она может быть перемещена или удалена.
            this.аэропортПрибытияTableAdapter.Fill(this.кассаDataSet.АэропортПрибытия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.АэропортОтправления". При необходимости она может быть перемещена или удалена.
            this.аэропортОтправленияTableAdapter.Fill(this.кассаDataSet.АэропортОтправления);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int CodeAircraft = Convert.ToInt32(guna2ComboBox2.SelectedValue);
                string Direction = guna2ComboBox3.Text + "-" + guna2ComboBox1.Text;
                int CodeDepartureAirport = Convert.ToInt32(guna2ComboBox3.SelectedValue);
                int CodeArrivalAirport = Convert.ToInt32(guna2ComboBox1.SelectedValue);
                string DepartureDateTime = guna2DateTimePicker1.Text + " " + dateTimePicker2.Text;
                string ArrivalDateTime = guna2DateTimePicker2.Text + " " + dateTimePicker1.Text;
                int TicketSum = Convert.ToInt32(guna2TextBox2.Text);


                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                SqlCommand query = conn.CreateCommand();
                query.CommandText = "INSERT INTO Рейс(НомерСамолёта,Направление,КодАэропортаОтправления,КодАэропортаПрибытия,ВремяОтправления,ВремяПрибытия,Стоимость) VALUES(@CodeAircraft,@Direction,@CodeDepartureAirport,@CodeArrivalAirport,@DepartureDateTime,@ArrivalDateTime, @TicketSum)";
                query.Parameters.Add("@CodeAircraft", SqlDbType.Int);
                query.Parameters["@CodeAircraft"].Value = CodeAircraft;
                query.Parameters.Add("@Direction", SqlDbType.NVarChar, 50);
                query.Parameters["@Direction"].Value = Direction;
                query.Parameters.Add("@CodeDepartureAirport", SqlDbType.Int);
                query.Parameters["@CodeDepartureAirport"].Value = CodeDepartureAirport;
                query.Parameters.Add("@CodeArrivalAirport", SqlDbType.Int);
                query.Parameters["@CodeArrivalAirport"].Value = CodeArrivalAirport;
                query.Parameters.Add("@DepartureDateTime", SqlDbType.DateTime);
                query.Parameters["@DepartureDateTime"].Value = DepartureDateTime;
                query.Parameters.Add("@ArrivalDateTime", SqlDbType.DateTime);
                query.Parameters["@ArrivalDateTime"].Value = ArrivalDateTime;
                query.Parameters.Add("@TicketSum", SqlDbType.Int);
                query.Parameters["@TicketSum"].Value = TicketSum;

                int UspeshnoeIzmenenie = query.ExecuteNonQuery();
                if (UspeshnoeIzmenenie == 0)
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {; conn.Close(); this.Close(); }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (plane == null) //Функция запрета на повторное открытие окна
            {
                plane = new Plane();
                plane.FormClosed += (x, y) => { plane = null; }; //для избежания проблем с повторным открытием после закрытия
            }
            plane.Show();
        }
    }
}
