using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_station
{
    public partial class form_hub_application : Form
    {
        public form_hub_application()
        {
            InitializeComponent();
        }

        private void form_hub_application_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckStation_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            form_check_station f_check_station= new form_check_station();
            f_check_station.TopLevel = false;
            panel1.Controls.Add(f_check_station);
            f_check_station.BringToFront();
            f_check_station.Show();
        }
    }
}
