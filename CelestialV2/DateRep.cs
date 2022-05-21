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
    public partial class DateRep : MetroFramework.Forms.MetroForm
    {
        public DateRep()
        {
            InitializeComponent();
        }

        private void DateRep_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.sp_agr". При необходимости она может быть перемещена или удалена.
            this.sp_agrTableAdapter.Fill(this.кассаDataSet.sp_agr,Convert.ToDateTime(this.textBox1.Text),Convert.ToDateTime(this.textBox2.Text));
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDateStart",this.textBox1.Text),
                new Microsoft.Reporting.WinForms.ReportParameter("pDateStop",this.textBox2.Text),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
        public void setContent(string txt1,string txt2)
        {
            this.textBox1.Text = txt1;
            this.textBox2.Text = txt2;
        }
    }
}
