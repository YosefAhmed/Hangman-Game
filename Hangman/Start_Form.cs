using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            Game_Form G = new Game_Form();
            G.Show();
            this.Hide();
        }
    }
}
