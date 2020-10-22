using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class ContactUserControl : UserControl
    {
        public ContactUserControl()
        {
            InitializeComponent();
        }
        public Image ProfilePic
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string txtName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string txtStatus
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }
    }
}
