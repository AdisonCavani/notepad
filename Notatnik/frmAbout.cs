using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblUsername.Text = string.Format(Environment.UserName);
            lblWindowsBuild.Text = "Wersja 2004 (kompilacja systemu operacyjnego: 19041.685)";
            lblCopyrightInfo.Text = "©  2021 Adrian Środoń. Wszelkie prawa zastrzeżone.";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void separatorBar_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCopyrightInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
