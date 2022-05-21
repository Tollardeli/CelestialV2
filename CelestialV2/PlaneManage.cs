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
    public partial class PlaneManage : MetroFramework.Forms.MetroForm
    {
        private int Check { get; set; }

        SqlConnection conn;
        public PlaneManage(int Check)
        {
            this.Check = Check;
            InitializeComponent();
            this.Text = "Составить договор";
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Check == 0)
            {
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                    conn.Open();
                    SqlCommand query = conn.CreateCommand();
                    string AircraftQuery = $"SELECT Count(НомерСамолёта) FROM Самолёты WHERE НомерСамолёта = '{textBox1.Text}'";
                    SqlCommand command = new SqlCommand(AircraftQuery, conn);
                    int AircraftNumbert = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if (AircraftNumbert == 0)
                    {
                        query.CommandText = $"INSERT INTO Самолёты(НомерСамолёта,АвиакомпанияВладелец,МодельСамолёта,ЧислоМестЭконом,ЧислоМестПервый,ЧислоМестБизнес) VALUES(@AircraftNumber,@AirlineOwner,@AircraftModels,@NumberEconomySeats,@NumberSeatsFirst,@NumberSeatsBusiness)";
                        query.Parameters.Add("@AircraftNumber", SqlDbType.Int);
                        query.Parameters["@AircraftNumber"].Value = guna2TextBox1.Text;
                        query.Parameters.Add("@AirlineOwner", SqlDbType.NVarChar, 50);
                        query.Parameters["@AirlineOwner"].Value = guna2TextBox2.Text;
                        query.Parameters.Add("@AircraftModels", SqlDbType.NVarChar, 50);
                        query.Parameters["@AircraftModels"].Value = guna2TextBox3.Text;
                        query.Parameters.Add("@NumberEconomySeats", SqlDbType.Int);
                        query.Parameters["@NumberEconomySeats"].Value = guna2TextBox4.Text;
                        query.Parameters.Add("@NumberSeatsFirst", SqlDbType.Int);
                        query.Parameters["@NumberSeatsFirst"].Value = guna2TextBox5.Text;
                        query.Parameters.Add("@NumberSeatsBusiness", SqlDbType.Int);
                        query.Parameters["@NumberSeatsBusiness"].Value = guna2TextBox6.Text;
                        int UspeshnoeIzmenenie = query.ExecuteNonQuery();
                        if (UspeshnoeIzmenenie == 0)
                        {
                            MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Такой самолёт уже существует ", "Ошибка");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { conn.Close(); this.Close(); }

            }
            else if (Check == 1)
            {
                Plane plane = new Plane();
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                    conn.Open();
                    SqlCommand query = conn.CreateCommand();
                    string AircraftQuery = $"SELECT Count(НомерСамолёта) FROM Самолёты WHERE НомерСамолёта = '{textBox1.Text}'";
                    SqlCommand command = new SqlCommand(AircraftQuery, conn);
                    int AircraftNumbert = Convert.ToInt32(command.ExecuteScalar().ToString());
                    query.CommandText = $"UPDATE Самолёты SET АвиакомпанияВладелец = @AirlineOwner, МодельСамолёта = @AircraftModels,ЧислоМестЭконом = @NumberEconomySeats,ЧислоМестПервый = @NumberSeatsFirst,ЧислоМестБизнес = @NumberSeatsBusiness WHERE НомерСамолёта = '{textBox1.Text}'";
                    query.Parameters.Add("@AirlineOwner", SqlDbType.NVarChar, 50);
                    query.Parameters["@AirlineOwner"].Value = guna2TextBox2.Text;
                    query.Parameters.Add("@AircraftModels", SqlDbType.NVarChar, 50);
                    query.Parameters["@AircraftModels"].Value = guna2TextBox3.Text;
                    query.Parameters.Add("@NumberEconomySeats", SqlDbType.Int);
                    query.Parameters["@NumberEconomySeats"].Value = guna2TextBox4.Text;
                    query.Parameters.Add("@NumberSeatsFirst", SqlDbType.Int);
                    query.Parameters["@NumberSeatsFirst"].Value = guna2TextBox5.Text;
                    query.Parameters.Add("@NumberSeatsBusiness", SqlDbType.Int);
                    query.Parameters["@NumberSeatsBusiness"].Value = guna2TextBox6.Text;
                    if (guna2TextBox1.Text != textBox1.Text)
                    {
                        if (AircraftNumbert==0)
                        {
                            query.CommandText = $"UPDATE Самолёты SET НомерСамолёта=@AircraftNumber WHERE НомерСамолёта = '{textBox1.Text}'";
                            query.Parameters.Add("@AircraftNumber", SqlDbType.Int);
                            query.Parameters["@AircraftNumber"].Value = guna2TextBox1.Text;
                            MessageBox.Show("Изменения внесены успешно", "Редактирование");
                        }
                        else if (AircraftNumbert == 1)
                        {
                            MessageBox.Show("Такой самолёт уже существует ", "Ошибка");
                        }
                    }
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
                finally { conn.Close(); this.Close(); }
            }
        }

        private void PlaneManage_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = textBox1.Text;
        }
    }
}
