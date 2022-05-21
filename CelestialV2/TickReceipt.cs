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
    public partial class TickReceipt : MetroFramework.Forms.MetroForm
    {
        public int _id;
        public TickReceipt(int id)
        {
            InitializeComponent();
            _id = id;

        }
        private void TickReceipt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кассаDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.кассаDataSet.Ticket,this._id);
            this.reportViewer1.RefreshReport();
        }
    }
}
