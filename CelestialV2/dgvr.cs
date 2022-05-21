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
    public partial class dgvr : MetroFramework.Forms.MetroForm
    {
        private string ID { get; set; }
        SqlConnection conn = null;
        public dgvr(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }
        private int CodeTicket;
        private void dgvr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.кассаDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.ID_Класса". При необходимости она может быть перемещена или удалена.
            this.iD_КлассаTableAdapter.Fill(this.кассаDataSet.ID_Класса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.кассаDataSet.View_2);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UniquePlace();
            Check();
        }
        private void UniquePlace()
        {
            try
            {

                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                string query = $"SELECT Count(Место) FROM Билет WHERE КодРейса = '{guna2ComboBox2.SelectedValue}' and Место = '{guna2TextBox6.Text}'";
                string query1 = $"SELECT ЧислоМест FROM View_2 WHERE КодРейса = '{guna2ComboBox2.SelectedValue}'";
                SqlCommand command = new SqlCommand(query, conn);
                int Place = Convert.ToInt32(command.ExecuteScalar().ToString());
                SqlCommand command1 = new SqlCommand(query1, conn);
                int CountPlace = Convert.ToInt32(command1.ExecuteScalar().ToString());
                conn.Close();
                if (Place > 0&& Place <= CountPlace)
                {
                    MessageBox.Show("Выбранное место уже занято или самолёт заполнен.", "Ошибка регистрации");
                }
                else
                {
                    Client();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Client()
        {
            try
            {
                int CodeClient;
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                SqlCommand query = conn.CreateCommand();
                string ClientQuery = $"SELECT Count(КодКлиента) FROM Клиент WHERE Фамилия = '{guna2TextBox1.Text}' and " +
                    $"Имя= '{guna2TextBox2.Text}' and Отчество= '{guna2TextBox3.Text}' and НомерДокумента= '{guna2TextBox5.Text}'";
                SqlCommand command = new SqlCommand(ClientQuery, conn);
                int ClientCheckUnique = Convert.ToInt32(command.ExecuteScalar().ToString());
                if (ClientCheckUnique> 0)
                {
                    string ClientENunique = $"SELECT КодКлиента FROM Клиент WHERE Фамилия = '{guna2TextBox1.Text}' and " +
                        $"Имя= '{guna2TextBox2.Text}' and Отчество= '{guna2TextBox3.Text}' and НомерДокумента= '{guna2TextBox5.Text}'";
                    SqlCommand command1 = new SqlCommand(ClientENunique, conn);
                    CodeClient = Convert.ToInt32(command1.ExecuteScalar().ToString());
                }
                else
                {
                    string LastName = Convert.ToString(this.guna2TextBox1.Text);
                    string Firstname = Convert.ToString(this.guna2TextBox2.Text);
                    string MidName = Convert.ToString(this.guna2TextBox3.Text);
                    string birth = Convert.ToString(this.guna2TextBox4.Text);
                    int serialnumb = Convert.ToInt32(this.guna2TextBox5.Text);
                    string citizen = Convert.ToString(this.guna2TextBox7.Text);
                    string gender = Convert.ToString(this.guna2ComboBox1.Text);
                    query.CommandText = "INSERT INTO Клиент(Фамилия,Имя,Отчество,ДатаРождения,НомерДокумента," +
                        "Гражданство,Пол) VALUES(@LastName,@Firstname,@MidName,@birth,@serialnumb," +
                        "@citizen,@gender) SELECT SCOPE_IDENTITY()";
                    query.Parameters.Add("@LastName", SqlDbType.NVarChar, 50);
                    query.Parameters["@LastName"].Value = LastName;
                    query.Parameters.Add("@Firstname", SqlDbType.NVarChar, 50);
                    query.Parameters["@Firstname"].Value = Firstname;
                    query.Parameters.Add("@MidName", SqlDbType.NVarChar, 50);
                    query.Parameters["@MidName"].Value = MidName;
                    query.Parameters.Add("@birth", SqlDbType.Date);
                    query.Parameters["@birth"].Value = birth;
                    query.Parameters.Add("@serialnumb", SqlDbType.NVarChar, 50);
                    query.Parameters["@serialnumb"].Value = serialnumb;
                    query.Parameters.Add("@citizen", SqlDbType.NVarChar, 50);
                    query.Parameters["@citizen"].Value = citizen;
                    query.Parameters.Add("@gender", SqlDbType.NVarChar, 50);
                    query.Parameters["@gender"].Value = gender;
                    CodeClient = Convert.ToInt32(query.ExecuteScalar().ToString());
                }
                int CodeFlight = Convert.ToInt32(guna2ComboBox2.SelectedValue.ToString());
                int CodeClass = Convert.ToInt32(guna2ComboBox5.SelectedValue.ToString());
                int SumPrice = Convert.ToInt32(guna2TextBox8.Text);
                string bag = guna2ComboBox4.Text;
                int Place = Convert.ToInt32(guna2TextBox6.Text);
                int CodeEmployee = Convert.ToInt32(ID);
                query.CommandText = "INSERT INTO Билет(КодКлиента,КодРейса,КодКласса,КодСотрудника,СтоимостьБилета," +
                    "Багаж,Место) VALUES(@CodeClient,@CodeFlight,@CodeClass,@CodeEmployee,@SumPrice,@bag,@Place)";
                query.Parameters.Add("@CodeClient", SqlDbType.Int);
                query.Parameters["@CodeClient"].Value = CodeClient;
                query.Parameters.Add("@CodeFlight", SqlDbType.Int);
                query.Parameters["@CodeFlight"].Value = CodeFlight;
                query.Parameters.Add("@CodeClass", SqlDbType.Int);
                query.Parameters["@CodeClass"].Value = CodeClass;
                query.Parameters.Add("@CodeEmployee", SqlDbType.Int);
                query.Parameters["@CodeEmployee"].Value = CodeEmployee;
                query.Parameters.Add("@SumPrice", SqlDbType.Int);
                query.Parameters["@SumPrice"].Value = SumPrice;
                query.Parameters.Add("@bag", SqlDbType.NVarChar, 50);
                query.Parameters["@bag"].Value = bag;
                query.Parameters.Add("@Place", SqlDbType.Int);
                query.Parameters["@Place"].Value = Place;
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
            finally
            {
                conn.Close();
            }
        }


        private void Check()
        {

            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
            conn.Open();
            string CodeTicketQuery = $"SELECT КодБилета FROM View_1 WHERE Фамилия = '{guna2TextBox1.Text}' and Имя = '{guna2TextBox2.Text}' and НомерДокумента = '{guna2TextBox5.Text}'";
            SqlCommand command = new SqlCommand(CodeTicketQuery, conn);
            int CodeTicket = Convert.ToInt32(command.ExecuteScalar().ToString());
            conn.Close();
            TickReceipt form;
            DialogResult result = MessageBox.Show("Показать билет? ", "Билет", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        form = new TickReceipt(Convert.ToInt32(CodeTicket));
                        form.Show();
                        form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                        break;
                    }
                case DialogResult.No:
                    {
                        this.Close();
                        break;
                    }
            }
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void dgvr_MouseMove(object sender, MouseEventArgs e)
        {
            int SumPrice = Convert.ToInt32(guna2ComboBox3.Text) + Convert.ToInt32(guna2ComboBox6.Text);
            guna2TextBox8.Text = SumPrice.ToString();
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                string query = $"SELECT Count(Место) FROM Билет WHERE КодРейса = '{guna2ComboBox2.SelectedValue}' and Место = '{guna2TextBox6.Text}'";
                SqlCommand command = new SqlCommand(query, conn);
                int Place = Convert.ToInt32(command.ExecuteScalar().ToString());
                conn.Close();
                if (Place > 0)
                {
                    MessageBox.Show("Выбранное место уже занято", "Проверка");
                }
                else
                {
                    MessageBox.Show("Выбранное место свободно", "Проверка");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
        }
    }
}
