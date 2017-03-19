using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SDComputer
{
    public partial class Shutdown : Form
    {
        public Shutdown()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (rb30.Checked)
            {
                i = 1800; // 30 minutes
            }
            else if (rb60.Checked)
            {
                i = 3600; // 60 minutes
            }

            Process.Start("shutdown", "/s /t " + i);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
        }
    }
}
