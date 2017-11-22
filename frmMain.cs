using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_GUI
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            HangmanGamer currentGamer = new HangmanGamer(txtNewPlayerName.Text);
            frmHangman playHangman = new frmHangman(currentGamer);
            
            this.Hide();
            playHangman.Show();
        }

     
    }
}
