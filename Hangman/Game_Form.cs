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
            g.words_mode = "Random";
            Category_lbl.Hide();
            Category_cb.Hide();
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
            GamingOptions_panel.Show();
        }
    }
}
