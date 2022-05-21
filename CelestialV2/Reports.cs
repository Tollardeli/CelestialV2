using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialV2
{
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.кассаDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.calculate_all_ticket_sell". При необходимости она может быть перемещена или удалена.
            this.calculate_all_ticket_sellTableAdapter.Fill(this.кассаDataSet.calculate_all_ticket_sell);

        }
        private void квартальныйОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 form = new Report1();
            form.MdiParent = this;
            form.Show();
        }

        private void данныеЗаПериодВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDateTime form = new GetDateTime();
            form.MdiParent = this;
            form.Show();
        }
    }
}
