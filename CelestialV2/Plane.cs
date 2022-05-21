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
    public partial class Plane : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        PlaneManage form;
        private int Check=1;
        public Plane()
        {
            InitializeComponent();
        }

        private void Plane_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Самолёты". При необходимости она может быть перемещена или удалена.
            this.самолётыTableAdapter.Fill(this.кассаDataSet.Самолёты);

        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.самолётыTableAdapter.Fill(this.кассаDataSet.Самолёты);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new PlaneManage(Check);
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.Text = "Редактировать данные";
            form.guna2Button1.Text = "Редактировать данные";
            form.textBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            form.guna2TextBox2.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            form.guna2TextBox3.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            form.guna2TextBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            form.guna2TextBox5.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            form.guna2TextBox6.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            form.Show();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            int index = guna2DataGridView1.Columns[guna2ComboBox2.Text + "DataGridViewTextBoxColumn"].Index;
            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                guna2DataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < guna2DataGridView1.ColumnCount; j++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (guna2DataGridView1[index, i].Value.ToString().Contains(guna2TextBox2.Text))
                        {
                            guna2DataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            самолётыBindingSource.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", guna2ComboBox2.Text, guna2TextBox12.Text);
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            самолётыBindingSource.RemoveFilter();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int AircraftNum = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить данные о самлёте # " + Convert.ToString(AircraftNum) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
                            myCommand.CommandText = $"DELETE Самолёты WHERE НомерСамолёта = {AircraftNum}";
                            myCommand.Parameters.Add("@AircraftNum", SqlDbType.Int, 4);
                            myCommand.Parameters["@AircraftNum"].Value = AircraftNum;
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
    }
}
