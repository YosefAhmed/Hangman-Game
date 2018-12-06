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
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            InitializeComponent();
        }
        //for maxmize
        public void appearanceMax()
        {
            GamingOptions_panel.Size = new Size(1366, 650);
            Play_btn.Size = new Size(190, 70);
            Play_btn.Location = new Point(1100, 25);
            choos_lbl.Location = new Point(660, 70);
            hard_btn.Size = new Size(400, 100);
            hard_btn.Location = new Point(500,112 );
            med_btn.Size = new Size(400, 100);
            med_btn.Location = new Point(500, 262);
            esy_btn.Size = new Size(400, 100);
            esy_btn.Location = new Point(500, 412);
            category_pnl.Location = new Point(530, 530);

            Quit_btn.Size = new Size(150, 70);
            Quit_btn.Location = new Point(1200, 25);
           // keyboard1.Size = new Size(350, 330);
            keyboard1.Location = new Point(280, 280);
            masn2a.Size = new Size(450, 400);
            masn2a.Location = new Point(800, 150);
            def_txt.Location = new Point(350, 80);
            hint_txt.Location = new Point(350, 600);
        }
        //for Normal
        public void appearanceNormal()
        {
            GamingOptions_panel.Size = new Size(660, 437);
        }
        private void resetControls() //resets controls in GamingOptions_panel when quit button is pressed
        {
           // resetControls game level
            g.game_mode = "Medium";
            hard_btn.BackColor = Color.Silver;
            esy_btn.BackColor = Color.Silver;
            med_btn.BackColor = Color.Red;
            //reset game mod
            Random_rb.Checked = true;
            Category_cb.Text = "History";
            g.words_mode = "Random";
            Category_lbl.Hide();
            Category_cb.Hide();
        }
        Game g = new Game();

        private void Play_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string generated_Word = g.Generate_Word();
                Word_lbl.Text = g.CreatDashes(generated_Word);
                GamingOptions_panel.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the game settings correctly", "Game settings is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void esy_btn_Click(object sender, EventArgs e)
        {
            g.game_mode = "Easy";
            hard_btn.BackColor = Color.Silver;
            esy_btn.BackColor = Color.Red;
            med_btn.BackColor = Color.Silver;
        }

        private void med_btn_Click(object sender, EventArgs e)
        {
            g.game_mode = "Medium";
            hard_btn.BackColor = Color.Silver;
            esy_btn.BackColor = Color.Silver;
            med_btn.BackColor = Color.Red;
        }

        private void hard_btn_Click(object sender, EventArgs e)
        {
            g.game_mode = "Hard";
            hard_btn.BackColor = Color.Red;
            esy_btn.BackColor = Color.Silver;
            med_btn.BackColor = Color.Silver;
        }

        private void Random_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (Random_rb.Checked)
            {
            g.words_mode = "Random";
            Category_lbl.Hide();
            Category_cb.Hide();
            }

        }

        private void ByCategory_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (ByCategory_rb.Checked)
            {
                g.words_mode = "ByCategory";
                Category_lbl.Show();
                Category_cb.Show();
            }
        }

        private void Category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.category = Category_cb.SelectedItem.ToString();
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            resetControls();
            GamingOptions_panel.Show();
        }

        private void Game_Form_Load(object sender, EventArgs e)
        {
            appearanceMax();
        }
        int i = 0;
        private void Game_Form_Resize(object sender, EventArgs e)
        {
            if (i == 1)
            {
                appearanceNormal();
                i = 0;
            }
            else
            {
                appearanceMax();
                i = 1;
            }
        }
    }
}
