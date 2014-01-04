#region

using System.Diagnostics;
using System.Windows.Forms;

#endregion

namespace Vanitygen_Explorer.Forms
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            lblname.Text += string.Format(" {0}", CommonUtils.TruncateVersion(Application.ProductVersion));
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(((LinkLabel) sender).Text);
        }
    }
}