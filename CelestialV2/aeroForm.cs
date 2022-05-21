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
    public partial class aeroForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        aeroVilet vilet;
        aeroPrilet prilet;
        Reis reis;
        public static bool flag = false;
        public aeroForm()
        {
            InitializeComponent();

            ToolStripMenuItem Editing = new ToolStripMenuItem("Поиск и фильтр");
            ToolStripMenuItem CancelEditing = new ToolStripMenuItem("Отменить поиск и фильтр");
            metroSetContextMenuStrip1.Items.AddRange(new[] { Editing, CancelEditing });
            guna2DataGridView1.ContextMenuStrip = metroSetContextMenuStrip1;
            guna2DataGridView2.ContextMenuStrip = metroSetContextMenuStrip1;
            guna2DataGridView3.ContextMenuStrip = metroSetContextMenuStrip1;
            Editing.Click += EditingItem_Click;
            CancelEditing.Click += CancelEditingItem_Click;
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            guna2CircleButton4.Hide();
            guna2CircleButton2.Hide();
            guna2CircleButton8.Hide();
        }

        private void aeroForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.АэропортПрибытия". При необходимости она может быть перемещена или удалена.
            this.аэропортПрибытияTableAdapter.Fill(this.кассаDataSet.АэропортПрибытия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.АэропортОтправления". При необходимости она может быть перемещена или удалена.
            this.аэропортОтправленияTableAdapter.Fill(this.кассаDataSet.АэропортОтправления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.кассаDataSet.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Рейс". При необходимости она может быть перемещена или удалена.
        }
        private void EditingItem_Click(object sender, EventArgs e)
        {
            if (metroSetTabControl1.SelectedIndex == 0)
            {
                panel5.Hide();
                panel6.Hide();
                panel7.Show();
                guna2DataGridView1.Height = this.Height - 162;
            }
            else if (metroSetTabControl1.SelectedIndex == 1)
            {
                panel5.Hide();
                panel6.Show();
                guna2DataGridView2.Height = this.Height - 162;
                panel7.Hide();
            }
            else if (metroSetTabControl1.SelectedIndex == 2)
            {
                panel5.Show();
                guna2DataGridView3.Height = this.Height - 162;
                panel6.Hide();
                panel7.Hide();
            }
        }
        private void CancelEditingItem_Click(object sender, EventArgs e)
        {
            if (metroSetTabControl1.SelectedIndex == 0)
            {
                panel7.Hide();
                guna2DataGridView1.Height = this.Height - 89;
            }
            else if (metroSetTabControl1.SelectedIndex == 1)
            {
                panel6.Hide();
                guna2DataGridView2.Height = this.Height - 89;
            }
            else if (metroSetTabControl1.SelectedIndex == 2)
            {
                panel5.Hide();
                guna2DataGridView3.Height = this.Height - 89;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (prilet == null) //Функция запрета на повторное открытие окна
            {
                prilet = new aeroPrilet();
                prilet.FormClosed += (x, y) => { prilet = null; }; //для избежания проблем с повторным открытием после закрытия
                prilet.FormClosed += new FormClosedEventHandler(prilet_FormClosed);
            }
            prilet.Show();
        }
        private void prilet_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.аэропортПрибытияTableAdapter.Fill(this.кассаDataSet.АэропортПрибытия);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (vilet == null) //Функция запрета на повторное открытие окна
            {
                vilet = new aeroVilet();
                vilet.FormClosed += (x, y) => { vilet = null; }; //для избежания проблем с повторным открытием после закрытия
                vilet.FormClosed += new FormClosedEventHandler(vilet_FormClosed);
            }
            vilet.Show();
        }
        private void vilet_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.аэропортОтправленияTableAdapter.Fill(this.кассаDataSet.АэропортОтправления);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (reis == null) //Функция запрета на повторное открытие окна
            {
                reis = new Reis();
                reis.FormClosed += (x, y) => { reis = null; }; //для избежания проблем с повторным открытием после закрытия
                reis.FormClosed += new FormClosedEventHandler(reis_FormClosed);
            }
            reis.Show();
        }
        private void reis_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.рейсTableAdapter.Fill(this.кассаDataSet.Рейс);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button9.Visible = true;
            panel4.Hide();
            metroSetTabControl1_Click(sender, e);
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int CodePrib = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить Аэропорт # " + Convert.ToString(CodePrib) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = @"Data Source=DESKTOP-QPT6DT7\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=True";
                            conn.Open();
                            SqlCommand myCommand = conn.CreateCommand();
                            myCommand.CommandText = $"DELETE АэропортПрибытия WHERE КодАэропортаПрибытия = {CodePrib}";
                            myCommand.Parameters.Add("@CodePrib", SqlDbType.Int, 4);
                            myCommand.Parameters["@CodePrib"].Value = CodePrib;
                            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
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
                        }
                        break;
                    }
            }
        }
        private void metroSetTabControl1_Click(object sender, EventArgs e)
        {
            if (metroSetTabControl1.SelectedIndex == 0)
            {
                panel1.Show();
                guna2Button5.Show();
                panel2.Hide();
                guna2Button11.Hide();
                panel3.Hide();
                guna2Button10.Hide();
            }
            else if (metroSetTabControl1.SelectedIndex == 1)
            {
                panel1.Hide();
                guna2Button5.Hide();
                panel2.Show();
                guna2Button11.Show();
                panel3.Hide();
                guna2Button10.Hide();
            }
            else if (metroSetTabControl1.SelectedIndex == 2)
            {
                panel1.Hide();
                guna2Button5.Hide();
                panel2.Hide();
                guna2Button11.Hide();
                panel3.Show();
                guna2Button10.Show();
            }
        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2Button9.Visible = false;
            panel4.Show();
            metroSetTabControl1_Click(sender, e);
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                guna2TextBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                guna2TextBox2.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                guna2TextBox3.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                guna2TextBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                guna2TextBox5.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                guna2TextBox6.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                guna2TextBox7.Text = guna2DataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                guna2TextBox8.Text = guna2DataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                guna2TextBox9.Text = guna2DataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                guna2TextBox10.Text = guna2DataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                guna2TextBox11.Text = guna2DataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                guna2TextBox12.Text = guna2DataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                guna2TextBox13.Text = guna2DataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                guna2TextBox14.Text = guna2DataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                guna2TextBox15.Text = guna2DataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                guna2TextBox16.Text = guna2DataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                guna2TextBox17.Text = guna2DataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                guna2TextBox18.Text = guna2DataGridView3.SelectedRows[0].Cells[5].Value.ToString();
                guna2TextBox19.Text = guna2DataGridView3.SelectedRows[0].Cells[6].Value.ToString();
                guna2TextBox20.Text = guna2DataGridView3.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            int CodeOtprav = int.Parse(guna2DataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить Аэропорт # " + Convert.ToString(CodeOtprav) + "? ", "Предупреждение", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = @"Data Source=DESKTOP-QPT6DT7\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=True";
                            conn.Open();
                            SqlCommand myCommand = conn.CreateCommand();
                            myCommand.CommandText = $"DELETE АэропортОтправления WHERE КодАэропортаОтправления = {CodeOtprav}";
                            myCommand.Parameters.Add("@CodeOtprav", SqlDbType.Int, 4);
                            myCommand.Parameters["@CodeOtprav"].Value = CodeOtprav;
                            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
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
                        }
                        break;
                    }
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            int CodeReis = int.Parse(guna2DataGridView3.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить Аэропорт # " + Convert.ToString(CodeReis) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = @"Data Source=DESKTOP-QPT6DT7\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=True";
                            conn.Open();
                            SqlCommand myCommand = conn.CreateCommand();
                            myCommand.CommandText = $"DELETE Рейс WHERE КодРейса = {CodeReis}";
                            myCommand.Parameters.Add("@CodeReis", SqlDbType.Int, 4);
                            myCommand.Parameters["@CodeReis"].Value = CodeReis;
                            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
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
                        }
                        break;
                    }
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                int CodeReis= Convert.ToInt32(guna2DataGridView3.SelectedRows[0].Cells[0].Value);
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                SqlCommand query = conn.CreateCommand();
                query.CommandText = $"UPDATE Рейс SET НомерСамолёта = @CodeAircraft, Направление = @Direction ,КодАэропортаОтправления = @CodeDepartureAirport,КодАэропортаПрибытия = @CodeArrivalAirport,ВремяОтправления = @TimeDeparture,ВремяПрибытия = @TimeArrival,Стоимость = @Cost WHERE КодРейса = '{CodeReis}'";
                query.Parameters.Add("@CodeAircraft", SqlDbType.Int);
                query.Parameters["@CodeAircraft"].Value = guna2TextBox14.Text;
                query.Parameters.Add("@Direction", SqlDbType.NVarChar, 50);
                query.Parameters["@Direction"].Value = guna2TextBox15.Text;
                query.Parameters.Add("@CodeDepartureAirport", SqlDbType.Int);
                query.Parameters["@CodeDepartureAirport"].Value = guna2TextBox16.Text;
                query.Parameters.Add("@CodeArrivalAirport", SqlDbType.Int);
                query.Parameters["@CodeArrivalAirport"].Value = guna2TextBox17.Text;
                query.Parameters.Add("@TimeDeparture", SqlDbType.DateTime);
                query.Parameters["@TimeDeparture"].Value = guna2TextBox18.Text;
                query.Parameters.Add("@TimeArrival", SqlDbType.DateTime);
                query.Parameters["@TimeArrival"].Value = guna2TextBox19.Text;
                query.Parameters.Add("@Cost", SqlDbType.Int);
                query.Parameters["@Cost"].Value = guna2TextBox20.Text;
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
            finally { conn.Close(); this.рейсTableAdapter.Fill(this.кассаDataSet.Рейс); }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                int CodeDepartureAirport = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value);
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                SqlCommand query = conn.CreateCommand();
                query.CommandText = $"UPDATE АэропортОтправления SET Название = @Title, СтранаОтправления = @CountryDeparture,ГородОтправления = @DepartureCity,ЧасовойПояс = @TimeZone,Адрес = @Address WHERE КодАэропортаОтправления = '{CodeDepartureAirport}'";
                query.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                query.Parameters["@Title"].Value = guna2TextBox8.Text;
                query.Parameters.Add("@CountryDeparture", SqlDbType.NVarChar, 50);
                query.Parameters["@CountryDeparture"].Value = guna2TextBox9.Text;
                query.Parameters.Add("@DepartureCity", SqlDbType.NVarChar, 50);
                query.Parameters["@DepartureCity"].Value = guna2TextBox10.Text;
                query.Parameters.Add("@TimeZone", SqlDbType.Int);
                query.Parameters["@TimeZone"].Value = guna2TextBox11.Text;
                query.Parameters.Add("@Address", SqlDbType.NVarChar, 50);
                query.Parameters["@Address"].Value = guna2TextBox12.Text;
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
            finally { conn.Close(); this.аэропортОтправленияTableAdapter.Fill(this.кассаDataSet.АэропортОтправления); }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                int CodeArrivalAirport = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
                conn.Open();
                SqlCommand query = conn.CreateCommand();
                query.CommandText = $"UPDATE АэропортПрибытия SET Название = @Title, СтранаПрибытия = @CountryArrival,ГородПрибытия = @ArrivalCity,ЧасовойПояс = @TimeZone,Адрес = @Address WHERE КодАэропортаПрибытия = '{CodeArrivalAirport}'";
                query.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                query.Parameters["@Title"].Value = guna2TextBox2.Text;
                query.Parameters.Add("@CountryArrival", SqlDbType.NVarChar, 50);
                query.Parameters["@CountryArrival"].Value = guna2TextBox3.Text;
                query.Parameters.Add("@ArrivalCity", SqlDbType.NVarChar, 50);
                query.Parameters["@ArrivalCity"].Value = guna2TextBox4.Text;
                query.Parameters.Add("@TimeZone", SqlDbType.Int);
                query.Parameters["@TimeZone"].Value = guna2TextBox5.Text;
                query.Parameters.Add("@Address", SqlDbType.NVarChar, 50);
                query.Parameters["@Address"].Value = guna2TextBox6.Text;
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
            finally {; conn.Close(); this.аэропортПрибытияTableAdapter.Fill(this.кассаDataSet.АэропортПрибытия); }
        }

        private void metroSetRadioButton1_CheckedChanged(object sender)
        {
            guna2CircleButton4.Hide();
            guna2CircleButton5.Show();
            guna2CircleButton6.Show();
        }

        private void metroSetRadioButton2_CheckedChanged(object sender)
        {
            guna2CircleButton4.Show();
            guna2CircleButton5.Hide();
            guna2CircleButton6.Hide();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            int index = guna2DataGridView3.Columns[guna2ComboBox2.Text + "DataGridViewTextBoxColumn3"].Index;
            for (int i = 0; i < guna2DataGridView3.RowCount; i++)
            {
                guna2DataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < guna2DataGridView3.ColumnCount; j++)
                {
                    if (guna2DataGridView3.Rows[i].Cells[j].Value != null)
                    {
                        if (guna2DataGridView3[index, i].Value.ToString().Contains(guna2TextBox21.Text))
                        {
                            guna2DataGridView3.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            рейсBindingSource.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", guna2ComboBox2.Text, guna2TextBox21.Text);
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            рейсBindingSource.RemoveFilter();
        }

        private void metroSetRadioButton4_CheckedChanged(object sender)
        {
            guna2CircleButton2.Hide();
            guna2CircleButton3.Show();
            guna2CircleButton1.Show();
        }

        private void metroSetRadioButton3_CheckedChanged(object sender)
        {
            guna2CircleButton2.Show();
            guna2CircleButton3.Hide();
            guna2CircleButton1.Hide();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            int index = guna2DataGridView2.Columns[guna2ComboBox1.Text + "DataGridViewTextBoxColumn2"].Index;
            for (int i = 0; i < guna2DataGridView2.RowCount; i++)
            {
                guna2DataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < guna2DataGridView2.ColumnCount; j++)
                {
                    if (guna2DataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        if (guna2DataGridView2[index, i].Value.ToString().Contains(guna2TextBox22.Text))
                        {
                            guna2DataGridView2.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            аэропортОтправленияBindingSource.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", guna2ComboBox1.Text, guna2TextBox22.Text);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            аэропортОтправленияBindingSource.RemoveFilter();
        }

        private void metroSetRadioButton6_CheckedChanged(object sender)
        {
            guna2CircleButton8.Hide();
            guna2CircleButton9.Show();
            guna2CircleButton7.Show();
        }

        private void metroSetRadioButton5_CheckedChanged(object sender)
        {
            guna2CircleButton8.Show();
            guna2CircleButton9.Hide();
            guna2CircleButton7.Hide();
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            int index = guna2DataGridView1.Columns[guna2ComboBox3.Text + "DataGridViewTextBoxColumn1"].Index;
            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                guna2DataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < guna2DataGridView1.ColumnCount; j++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (guna2DataGridView1[index, i].Value.ToString().Contains(guna2TextBox23.Text))
                        {
                            guna2DataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            аэропортПрибытияBindingSource.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", guna2ComboBox3.Text, guna2TextBox23.Text);
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            аэропортПрибытияBindingSource.RemoveFilter();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetLabel22_Click(object sender, EventArgs e)
        {

        }
    }
}
