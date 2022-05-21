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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = null;
        cnsldgvr form;
        deleteclient form1;
        private int find=1;
        public Form3()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                string query = $"SELECT DISTINCT Направление FROM Рейс";
                SqlCommand command = new SqlCommand(query, conn);
                DataTable tbl = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tbl);
                this.guna2ComboBox1.DataSource = tbl;
                this.guna2ComboBox1.DisplayMember = "Направление";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            ToolStripMenuItem Tick = new ToolStripMenuItem("Билет");
            metroSetContextMenuStrip1.Items.AddRange(new[] { Tick });
            guna2DataGridView1.ContextMenuStrip = metroSetContextMenuStrip1;
            Tick.Click += TickItem_Click;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.кассаDataSet.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.ID_Класса". При необходимости она может быть перемещена или удалена.
            this.iD_КлассаTableAdapter.Fill(this.кассаDataSet.ID_Класса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.кассаDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.кассаDataSet.Клиент);
            groupBox5.Hide();
        }

        private void TickItem_Click(object sender, EventArgs e)
        {
            TickReceipt form = new TickReceipt(Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            form.Show();
            
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                guna2DataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < guna2DataGridView1.ColumnCount; j++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (guna2DataGridView1[find, i].Value.ToString().Contains(guna2TextBox1.Text))
                        {
                            guna2DataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            find = 1;
        }
        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            find = 4;
        }
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            view1BindingSource.Filter = string.Format("[Направление] LIKE '{0}%'", guna2ComboBox1.Text);
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                string query = $"SELECT DISTINCT ВремяОтправления FROM Рейс WHERE Направление = '{guna2ComboBox1.Text}'";
                SqlCommand command = new SqlCommand(query, conn);
                DataTable tbl = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tbl);
                this.guna2ComboBox3.DataSource = tbl;
                this.guna2ComboBox3.DisplayMember = "ВремяОтправления";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            groupBox2.Hide();
            groupBox5.Show();

        }
        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            view1BindingSource.Filter = string.Format("Convert([ВремяОтправления], 'System.String') LIKE '{0}%'", guna2ComboBox3.Text);
        }
        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            view1BindingSource.RemoveFilter();
            groupBox5.Hide();
            groupBox2.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new cnsldgvr();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
            }
            form.Show();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Width = 1349;
            guna2DataGridView1.Location = new Point(355, 5);
            guna2DataGridView1.Width = this.Width - 365;
            groupBox1.Left = 355;
            groupBox2.Left = 763;
            groupBox5.Left = 763;
            guna2Button2.Visible = false;
            panel1.Visible = true;
            guna2Button4.Visible = true;
            metroSetDivider1.Visible = true;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int CodeClient;
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                string ClientENunique = $"SELECT КодКлиента FROM Клиент WHERE Фамилия = '{guna2DataGridView1.SelectedRows[0].Cells[1].Value}' " +
                    $"and Имя= '{guna2DataGridView1.SelectedRows[0].Cells[2].Value}' and Отчество= '{guna2DataGridView1.SelectedRows[0].Cells[3].Value}' and " +
                    $"НомерДокумента= '{guna2DataGridView1.SelectedRows[0].Cells[4].Value}'";
                SqlCommand command = new SqlCommand(ClientENunique, conn);
                CodeClient = Convert.ToInt32(command.ExecuteScalar().ToString());
                SqlCommand query = conn.CreateCommand();
                query.CommandText = $"UPDATE Клиент SET Фамилия = @LastName, Имя = @Firstname,Отчество = @MidName,ДатаРождения = " +
                    $"@birth,НомерДокумента = @serialnumb,Гражданство = @citizen,Пол = @gender WHERE КодКлиента = '{CodeClient}'";
                query.Parameters.Add("@LastName", SqlDbType.NVarChar, 50);
                query.Parameters["@LastName"].Value = guna2TextBox3.Text;
                query.Parameters.Add("@Firstname", SqlDbType.NVarChar, 50);
                query.Parameters["@Firstname"].Value = guna2TextBox4.Text;
                query.Parameters.Add("@MidName", SqlDbType.NVarChar, 50);
                query.Parameters["@MidName"].Value = guna2TextBox5.Text;
                query.Parameters.Add("@birth", SqlDbType.Date);
                query.Parameters["@birth"].Value = guna2TextBox13.Text;
                query.Parameters.Add("@serialnumb", SqlDbType.NVarChar, 50);
                query.Parameters["@serialnumb"].Value = guna2TextBox6.Text;
                query.Parameters.Add("@citizen", SqlDbType.NVarChar, 50);
                query.Parameters["@citizen"].Value = guna2TextBox14.Text;
                query.Parameters.Add("@gender", SqlDbType.NVarChar, 50);
                query.Parameters["@gender"].Value = guna2ComboBox4.Text;
                query.CommandText = $"UPDATE Билет SET Багаж=@bag, СтоимостьБилета=@SumPrice WHERE КодКлиента = '{CodeClient}'";
                query.Parameters.Add("@bag", SqlDbType.NVarChar, 50);
                query.Parameters["@bag"].Value = guna2ComboBox5.Text;
                query.Parameters.Add("@SumPrice", SqlDbType.Int);
                query.Parameters["@SumPrice"].Value = Convert.ToInt32(guna2TextBox19.Text);
                if (guna2TextBox15.Text != guna2DataGridView1.SelectedRows[0].Cells[11].Value.ToString())
                {
                    string query2 = $"SELECT Count(Место) FROM Билет WHERE КодРейса = '{comboBox1.SelectedValue}' and Место = '{guna2TextBox15.Text}'";
                    SqlCommand command1 = new SqlCommand(query2, conn);
                    int Place = Convert.ToInt32(command1.ExecuteScalar().ToString());
                    string query3 = $"SELECT ЧислоМест FROM View_2 WHERE КодРейса = '{comboBox1.SelectedValue}'";
                    SqlCommand command2 = new SqlCommand(query3, conn);
                    int CountPlace = Convert.ToInt32(command2.ExecuteScalar().ToString()); // Если место не равно месту то вызывать проверку а если место равно месту то пропускать 
                    if (Place > 0 && Place <= CountPlace)
                    {
                        MessageBox.Show("Выбранное место уже занято или самолёт заполнен.", "Ошибка регистрации");
                    }
                    else
                    {
                        query.CommandText = $"UPDATE Билет SET Место=@Place WHERE КодКлиента = '{CodeClient}'";
                        query.Parameters.Add("@Place", SqlDbType.Int);
                        query.Parameters["@Place"].Value = Convert.ToInt32(guna2TextBox15.Text);
                        MessageBox.Show("Изменения внесены успешно", "Редактирование");
                    }
                }
                else
                {
                    MessageBox.Show("Изменения внесены успешно", "Редактирование");
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
            finally {; conn.Close(); this.view_1TableAdapter.Fill(this.кассаDataSet.View_1); }

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Width = 1005;
            guna2DataGridView1.Location = new Point(12, 5);
            guna2DataGridView1.Width = this.Width - 17;
            groupBox1.Left = 12;
            groupBox2.Left = 420;
            groupBox5.Left = 420;
            guna2Button2.Visible = true;
            panel1.Visible = false; ;
            guna2Button4.Visible = false;
            metroSetDivider1.Visible = false;
        }
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            view1BindingSource.RemoveFilter();
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                guna2TextBox3.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                guna2TextBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                guna2TextBox5.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                guna2TextBox6.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                guna2TextBox13.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                guna2TextBox14.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                guna2ComboBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox1.Text= guna2DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                guna2TextBox15.Text = guna2DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                guna2ComboBox5.Text = guna2DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                guna2TextBox19.Text = guna2DataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            }
        }
        public void SelectTabItem(int index)
        {
            metroSetTabControl1.SelectTab(index);
        }
        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            клиентBindingSource.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", guna2ComboBox2.Text, guna2TextBox12.Text);
        }
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            клиентBindingSource.RemoveFilter();
        }
        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            int index = guna2DataGridView2.Columns[guna2ComboBox2.Text+"DataGridViewTextBoxColumn2"].Index;
            for (int i = 0; i < guna2DataGridView2.RowCount; i++)
            {
                guna2DataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < guna2DataGridView2.ColumnCount; j++)
                {
                    if (guna2DataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        if (guna2DataGridView2[index, i].Value.ToString().Contains(guna2TextBox2.Text))
                        {
                            guna2DataGridView2.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (form1 == null) //Функция запрета на повторное открытие окна
            {
                form1 = new deleteclient();
                form1.FormClosed += (x, y) => { form1 = null; }; //для избежания проблем с повторным открытием после закрытия
            }
            form1.Show();
        }
    }
}