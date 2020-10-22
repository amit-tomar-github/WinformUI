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
    public partial class PlayerUI : Form
    {
        public PlayerUI()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelPlaylistSubMenu.Visible = false;
            panelMediaSubMenu.Visible = false;
            panelEqualizerSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;

            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;

            if (panelEqualizerSubMenu.Visible == true)
                panelEqualizerSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void PlayerUI_Load(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMediaSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPlaylistSubMenu);
        }

        private void buttonEqualizer_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEqualizerSubMenu);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //code then hide
            HideSubMenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Visible)
                panelSideMenu.Visible = false;
            else
                panelSideMenu.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
