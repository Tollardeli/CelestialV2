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
    public partial class GetDateTime : MetroFramework.Forms.MetroForm
    {
        public GetDateTime()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateRep form = new DateRep();
            form.setContent(this.guna2DateTimePicker1.Text, this.guna2DateTimePicker2.Text);
            form.Show();
        }
    }
}
