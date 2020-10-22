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
    public partial class frmFoodApp : Form
    {
        public frmFoodApp()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            pnlOnButtonFood.Height = btnFood.Height;
            pnlOnButtonFood.Top = btnFood.Top;
            pnlOnButtonFood.Visible = true;

            pnlOnBtnHelp.Visible = false;
            pnlOnBtnDeserts.Visible = false;
            pnlOnbtnDrinnks.Visible = false;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            pnlOnbtnDrinnks.Height = btnDrinks.Height;
            pnlOnbtnDrinnks.Top = btnDrinks.Top;
            pnlOnbtnDrinnks.Visible = true;

            pnlOnBtnHelp.Visible = false;
            pnlOnBtnDeserts.Visible = false;
            pnlOnButtonFood.Visible = false;
        }

        private void btnDeserts_Click(object sender, EventArgs e)
        {
            pnlOnBtnDeserts.Height = btnDeserts.Height;
            pnlOnBtnDeserts.Top = btnDeserts.Top;
            pnlOnBtnDeserts.Visible = true;

            pnlOnBtnHelp.Visible = false;
            pnlOnButtonFood.Visible = false;
            pnlOnbtnDrinnks.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlOnBtnHelp.Height = btnHelp.Height;
            pnlOnBtnHelp.Top = btnHelp.Top;
            pnlOnBtnHelp.Visible = true;

            pnlOnBtnDeserts.Visible = false;
            pnlOnButtonFood.Visible = false;
            pnlOnbtnDrinnks.Visible = false;
        }
    }
}
