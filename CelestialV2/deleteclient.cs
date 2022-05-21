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
    public partial class deleteclient : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = null;
        public deleteclient()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int CodeTicket = int.Parse(guna2TextBox1.Text);
            DialogResult result = MessageBox.Show("Отменить регистрацию № " + Convert.ToString(CodeTicket) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
                            myCommand.CommandText = $"DELETE Клиент WHERE КодКлиента = {CodeTicket}";
                            myCommand.Parameters.Add("@CodeTicket", SqlDbType.Int, 4);
                            myCommand.Parameters["@CodeTicket"].Value = CodeTicket;
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
                            this.Close();
                        }
                        break;
                    }
            }
        }
    }
}
