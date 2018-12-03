using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hangman
{
    public partial class InterfaceForm : Form
    {
        Game g = new Game();
        public InterfaceForm()
        {
            InitializeComponent();
            Category_lbl.Hide();
            Category_cb.Hide();
            Game_panel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     
        }

        private void EasyMode_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyMode_rb.Checked)
                g.game_mode = "Easy";           
        }

        private void MediumMode_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (MediumMode_rb.Checked)
                g.game_mode = "Medium";
        }

        private void HardMode_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (HardMode_rb.Checked)
                g.game_mode = "Hard";
        }

        private void Randomly_rb_CheckedChanged(object sender, EventArgs e)
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

        private void Play_bt_Click(object sender, EventArgs e)
        {           
            try
            {
                GamingOptions_panel.Hide();
                Game_panel.Show();

                string generated_Word = g.Generate_Word();
                Word_lbl.Text = g.CreatDashes(generated_Word);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the game settings correctly","Game settings is missing",MessageBoxButtons.OK,MessageBoxIcon.Error);
                GamingOptions_panel.Show();
                Game_panel.Hide();
            }           
        }

        private void Category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.category = Category_cb.SelectedItem.ToString();
        }
    }
}
