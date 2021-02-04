using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        public string osVersion;

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblUsername.Text = string.Format(Environment.UserName);
            osVersion = Environment.OSVersion.ToString();
            lblWindowsBuild.Text = osVersion;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
