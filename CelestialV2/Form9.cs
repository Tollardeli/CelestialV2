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
    public partial class Form9 : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommand command;
        BindingSource bindingSource = new BindingSource();
        public Form9()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=Касса;Integrated Security=SSPI;persist security info=False";
            command = new SqlCommand("Select * From Сотрудники");        //не автоматические размеры на форме в грид
            command.Connection = conn;
            adapter = new SqlDataAdapter(command);
            ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            conn.Open();
            adapter.Fill(ds);
            conn.Close();

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("Ошибка, результат не содежит строк");
                return;
            }
            guna2DataGridView1.AutoGenerateColumns = true;
            bindingSource.DataSource = ds.Tables[0];
            guna2DataGridView1.DataSource = bindingSource;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

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
            bindingSource.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", guna2ComboBox2.Text, guna2TextBox12.Text);
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveFilter();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            adapter.Update(ds);
        }
    }
}
