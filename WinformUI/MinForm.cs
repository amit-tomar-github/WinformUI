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
    public partial class MinForm : Form
    {
        public MinForm()
        {
            InitializeComponent();
        }

        private void btnDarkTheme_Click(object sender, EventArgs e)
        {
            Form1 ofrm = new Form1();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }

        private void Ofrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnPlayerUI_Click(object sender, EventArgs e)
        {
            PlayerUI ofrm = new PlayerUI();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            FastFoodDemo ofrm = new FastFoodDemo();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDashboard ofrm = new FormDashboard();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSkype ofrm = new frmSkype();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFoodApp ofrm = new frmFoodApp();
            ofrm.FormClosing += Ofrm_FormClosing;
            ofrm.Show();
            this.Hide();
        }
    }
}
