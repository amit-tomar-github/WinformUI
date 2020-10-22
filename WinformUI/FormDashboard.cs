using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormDashboardMain ofrm = new FormDashboardMain();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }
        private void Ofrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
