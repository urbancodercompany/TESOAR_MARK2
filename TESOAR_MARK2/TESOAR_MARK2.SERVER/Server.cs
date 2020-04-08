using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESOAR_MARK2.SERVER
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load( object sender, EventArgs e )
        {

        }

        private void manualMenu_Click( object sender, EventArgs e )
        {
            string filename = "manual.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void helpMenu_Click( object sender, EventArgs e )
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void optionsMenu_Click( object sender, EventArgs e )
        {
            Options options = new Options();
            options.ShowDialog();
        }

        private void settingsMenu_Click( object sender, EventArgs e )
        {
            Options options = new Options();
            options.ShowDialog();
        }
    }
}
