using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESOAR_MARK2.SERVER
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            // 365 Mail
            var webLink = "https://www.solavinte.com/";
            Process.Start("iexplore.exe", webLink);
        }
    }
}
