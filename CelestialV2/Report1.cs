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
    public partial class Report1 : MetroFramework.Forms.MetroForm
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Earned_for_the_quarter". При необходимости она может быть перемещена или удалена.
            this.earned_for_the_quarterTableAdapter.Fill(this.кассаDataSet.Earned_for_the_quarter);

            this.reportViewer1.RefreshReport();
        }
    }
}
