using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hangman
{
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            
            InitializeComponent();
        }
        ArrayList worng_keys = new ArrayList();
        Game g = new Game();
        Game.DATA gd = new Game.DATA();
        public void hide_arrows()
        {
            Hard_arow_L.Hide();
            Hard_arow_R.Hide();
            easy_arow_L.Hide();
            easy_arow_R.Hide();
            Med_arow_L.Hide();
            Med_arow_R.Hide();
        }
        public void show_letters()
        {
            A.Show(); B.Show(); C.Show(); D.Show();
            E.Show(); F.Show(); GG.Show();H.Show();
            J.Show(); K.Show(); L.Show(); M.Show();
            N.Show(); II.Show(); S.Show(); T.Show();
            R.Show(); O.Show(); P.Show(); Q.Show();
            U.Show(); V.Show(); W.Show(); X.Show();
            Y.Show(); Z.Show();
        }
        ////for maxmize
        //public void appearanceMax()
        //{
        //    GamingOptions_panel.Size = new Size(1366, 650);
        //    Play_btn.Size = new Size(190, 80);
        //    Play_btn.Location = new Point(1100, 25);
        //    choos_lbl.Location = new Point(615, 70);
        //    hard_btn.Size = new Size(400, 110);
        //    hard_btn.Location = new Point(470, 112);
        //    Hard_arow_L.Location = new Point(405, 155);
        //    Hard_arow_R.Location = new Point(890, 155);
        //    med_btn.Size = new Size(400, 110);
        //    med_btn.Location = new Point(470, 262);
        //    Med_arow_L.Location = new Point(405, 305);
        //    Med_arow_R.Location = new Point(890, 305);
        //    esy_btn.Size = new Size(400, 110);
        //    esy_btn.Location = new Point(470, 412);
        //    easy_arow_L.Location = new Point(405, 450);
        //    easy_arow_R.Location = new Point(890, 450);
        //    category_pnl.Location = new Point(470, 540);

        //    Quit_btn.Size = new Size(150, 70);
        //    Quit_btn.Location = new Point(1200, 25);
        //    // keyboard1.Size = new Size(350, 330);
        //    //keyboard1.Location = new Point(280, 280);
        //    masn2a.Size = new Size(450, 400);
        //    masn2a.Location = new Point(800, 150);
        //    def_txt.Location = new Point(350, 80);
        //    hint_txt.Location = new Point(350, 600);
        //}
        ////for Normal
        //public void appearanceNormal()
        //{
        //    GamingOptions_panel.Size = new Size(669, 456);
        //    Play_btn.Size = new Size(130, 55);
        //    Play_btn.Location = new Point(486, 25);
        //    choos_lbl.Location = new Point(225, 79);
        //    hard_btn.Size = new Size(176, 55);
        //    hard_btn.Location = new Point(195, 112);
        //    Hard_arow_L.Location = new Point(140, 123);
        //    Hard_arow_R.Location = new Point(385, 123);
        //    med_btn.Size = new Size(176, 55);
        //    med_btn.Location = new Point(195, 184);
        //    Med_arow_L.Location = new Point(140, 198);
        //    Med_arow_R.Location = new Point(385, 198);
        //    esy_btn.Size = new Size(176, 55);
        //    esy_btn.Location = new Point(195, 257);
        //    easy_arow_L.Location = new Point(140, 270);
        //    easy_arow_R.Location = new Point(385, 269);
        //    category_pnl.Location = new Point(80, 340);

        //    Quit_btn.Size = new Size(115, 53);
        //    Quit_btn.Location = new Point(557, 12);
        //    //keyboard1.Location = new Point(12, 132);
        //    masn2a.Size = new Size(198, 251);
        //    masn2a.Location = new Point(444, 125);
        //    def_txt.Location = new Point(139, 25);
        //    hint_txt.Location = new Point(262, 416);
        //}

        public void show_img(int trys)
        {
            switch (trys)
            {
                case 9:
                    KA3DA.Show();
                    break;
                case 8:
                    masn2a.Show();
                    break;
                case 7:
                    Habl.Show();
                    break;
                case 6:
                    ra2s.Show();
                    break;
                case 5:
                    gesm.Show();
                    break;
                case 4:
                    Eed_ymeen.Show();
                    break;
                case 3:
                    Eed_shemal.Show();
                    break;
                case 2:
                    regl_ymeen.Show();
                    break;
                case 1:
                    regl_shemal.Show();
                    break;

            }
        }
        private void resetControls() //resets controls in GamingOptions_panel when quit button is pressed
        {
            Game.score = 0;
            score_lbl.Text = Game.score.ToString();
            g.game_mode = "Medium";
            hide_arrows();
            Med_arow_L.Show();
            Med_arow_R.Show();
            Random_rb.Checked = true;
            Category_cb.Text = "History";
            g.words_mode = "Random";
            Category_lbl.Hide();
            Category_cb.Hide();
            hint_txt.Text = "Give me a hint";
            foreach (PictureBox b in worng_keys)
            {
                b.BackColor = Color.Transparent;
            }
            a = true; s = true; d = true; f = true; gg = true; h = true; j = true; k = true; l = true; m = true; n = true; o = true; p = true;
            q = true; w = true; ee = true; r = true; t = true; y = true; u = true; i = true; bb = true; v = true; c = true; x = true; z = true;
            show_letters();
            worng_keys.Clear();
            KA3DA.Hide();
            masn2a.Hide();
            Habl.Hide();
            ra2s.Hide();
            gesm.Hide();
            Eed_ymeen.Hide();
            regl_ymeen.Hide();
            regl_shemal.Hide();
            Eed_shemal.Hide();
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

        private void hint_txt_Click(object sender, EventArgs e)
        {
            hint_txt.Text = gd.hint;
        }

        private void next_word()
        {
            
            foreach (PictureBox b in worng_keys)
            {
                b.BackColor = Color.Transparent;
            }
            KA3DA.Hide();
            masn2a.Hide();
            Habl.Hide();
            ra2s.Hide();
            gesm.Hide();
            Eed_ymeen.Hide();
            regl_ymeen.Hide();
            regl_shemal.Hide();
            Eed_shemal.Hide();
            show_letters();
            gd = g.Generate_Game_Data();
            string generated_Word = gd.word;
            def_txt.Text = gd.defenition;
            Word_lbl.Text = g.CreatDashes(generated_Word);
            Category_lblgame.Text = gd.category_st;
            g.trials = 9;
            your_trials_lbl.Show();
            trials_lbl.Show();
            trials_lbl.Text = g.trials.ToString();
            Category_lbltxt.Show();
            Category_lblgame.Show();
            hint_txt.Text = "Give me a hint";
            worng_keys.Clear();
        }
               

        private void hard_btn_Click(object sender, EventArgs e)
        {
            g.game_mode = "Hard";
            hide_arrows();
            Hard_arow_L.Show();
            Hard_arow_R.Show();
            
        }

        private void med_btn_Click(object sender, EventArgs e)
        {
            g.game_mode = "Medium";
            hide_arrows();
            Med_arow_R.Show();
            Med_arow_L.Show();
        }


        private void esy_btn_Click(object sender, EventArgs e)
        {
            g.game_mode = "Easy";
            hide_arrows();
            easy_arow_R.Show();
            easy_arow_L.Show();

        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            g.trials = 9;
            your_trials_lbl.Show();
            trials_lbl.Show();
            Category_lbltxt.Show();
            Category_lblgame.Show();
            trials_lbl.Text = g.trials.ToString();
          //  try
           // {
                gd = g.Generate_Game_Data();
                string generated_Word = gd.word;
                def_txt.Text = gd.defenition;
                Word_lbl.Text = g.CreatDashes(generated_Word);
                Category_lblgame.Text = gd.category_st;
                GamingOptions_panel.Hide();
                Quit_btn.Show();
           // }
            //catch (Exception)
            //{
            //    MessageBox.Show("Please fill the game settings correctly", "Game settings is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            resetControls();
            GamingOptions_panel.Show();
        }

        bool a = true;
        private void A_Click(object sender, EventArgs e)
        {
            if (a)
            {
                bool get = g.check_find('a', 'A');
                if (get == true)
                {
                    Word_lbl.Text = g.evaluate('a', 'A');
                    A.Hide();
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }

                else
                {
                    show_img(g.trials);
                    A.BackColor = Color.Red;
                    a = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        Game.score = 0;
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;

                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool bb = true;
        private void B_Click(object sender, EventArgs e)
        {
            if (bb)
            {
                bool get = g.check_find('b', 'B');
                if (get == true)
                {
                    B.Hide();
                    Word_lbl.Text = g.evaluate('b', 'B');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    B.BackColor = Color.Red;
                    bb = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool c = true;
        private void C_Click(object sender, EventArgs e)
        {
            if (c)
            {
                bool get = g.check_find('c', 'C');
                if (get == true)
                {
                    C.Hide();
                    Word_lbl.Text = g.evaluate('c', 'C');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    C.BackColor = Color.Red;
                    c = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool d = true;
        private void D_Click(object sender, EventArgs e)
        {
            if (d)
            {
                bool get = g.check_find('d', 'D');
                if (get == true)
                {
                    D.Hide();
                    Word_lbl.Text = g.evaluate('d', 'D');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    D.BackColor = Color.Red;
                    d = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool ee = true;
        private void E_Click(object sender, EventArgs e)
        {
            if (ee)
            {
                bool get = g.check_find('e', 'E');
                if (get == true)
                {
                    E.Hide();
                    Word_lbl.Text = g.evaluate('e', 'E');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }

                else
                {
                    show_img(g.trials);
                    E.BackColor = Color.Red;
                    ee = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        Game.score = 0;
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;

                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool f = true;
        private void F_Click(object sender, EventArgs e)
        {
            if (f)
            {
                bool get = g.check_find('f', 'F');
                if (get == true)
                {
                    F.Hide();
                    Word_lbl.Text = g.evaluate('f', 'F');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    F.BackColor = Color.Red;
                    f = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool gg = true;
        private void G_Click(object sender, EventArgs e)
        {
            if (gg)
            {
                bool get = g.check_find('g', 'G');
                if (get == true)
                {
                    GG.Hide();
                    Word_lbl.Text = g.evaluate('g', 'G');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    GG.BackColor = Color.Red;
                    gg = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool h = true;
        private void H_Click(object sender, EventArgs e)
        {
            if (h)
            {
                bool get = g.check_find('h', 'H');
                if (get == true)
                {
                    H.Hide();
                    Word_lbl.Text = g.evaluate('h', 'H');

                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    H.BackColor = Color.Red;
                    h = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool i = true;
        private void I_Click(object sender, EventArgs e)
        {
            if (i)
            {
                bool get = g.check_find('i', 'I');
                if (get == true)
                {
                    II.Hide();
                    Word_lbl.Text = g.evaluate('i', 'I');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    II.BackColor = Color.Red;
                    i = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool j = true;
        private void J_Click(object sender, EventArgs e)
        {
            if (j)
            {
                bool get = g.check_find('j', 'J');
                if (get == true)
                {
                    J.Hide();
                    Word_lbl.Text = g.evaluate('j', 'J');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    J.BackColor = Color.Red;
                    j = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool k = true;
        private void K_Click(object sender, EventArgs e)
        {
            if (k)
            {
                bool get = g.check_find('k', 'K');
                if (get == true)
                {
                    K.Hide();
                    Word_lbl.Text = g.evaluate('k', 'K');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    K.BackColor = Color.Red;
                    k = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool l = true;
        private void L_Click(object sender, EventArgs e)
        {
            if (l)
            {
                bool get = g.check_find('l', 'L');
                if (get == true)
                {
                    L.Hide();
                    Word_lbl.Text = g.evaluate('l', 'L');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr", Game.score.ToString());
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }

                else
                {
                    show_img(g.trials);
                    L.BackColor = Color.Red;
                    l = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        Game.score = 0;
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;

                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool m = true;
        private void M_Click(object sender, EventArgs e)
        {
            if (m)
            {
                bool get = g.check_find('m', 'M');
                if (get == true)
                {
                    M.Hide();
                    Word_lbl.Text = g.evaluate('m', 'M');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }

                else
                {
                    show_img(g.trials);
                    M.BackColor = Color.Red;
                    m = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool n = true;
        private void N_Click(object sender, EventArgs e)
        {
            if (n)
            {
                bool get = g.check_find('n', 'N');
                if (get == true)
                {
                    N.Hide();
                    Word_lbl.Text = g.evaluate('n', 'N');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    N.BackColor = Color.Red;
                    n = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool o = true;
        private void O_Click(object sender, EventArgs e)
        {
            if (o)
            {
                bool get = g.check_find('o', 'O');
                if (get == true)
                {
                    O.Hide();
                    Word_lbl.Text = g.evaluate('o', 'O');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    O.BackColor = Color.Red;
                    o = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool p = true;
        private void P_Click(object sender, EventArgs e)
        {
            if (p)
            {
                bool get = g.check_find('p', 'P');
                if (get == true)
                {
                    P.Hide();
                    Word_lbl.Text = g.evaluate('p', 'P');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    P.BackColor = Color.Red;
                    p = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool q = true;
        private void Q_Click(object sender, EventArgs e)
        {
            if (q)
            {
                bool get = g.check_find('q', 'Q');
                if (get == true)
                {
                    Q.Hide();
                    Word_lbl.Text = g.evaluate('q', 'Q');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    Q.BackColor = Color.Red;
                    q = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool r = true;
        private void R_Click(object sender, EventArgs e)
        {
            if (r)
            {
                bool get = g.check_find('r', 'R');
                if (get == true)
                {
                    R.Hide();
                    Word_lbl.Text = g.evaluate('r', 'R');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    R.BackColor = Color.Red;
                    r = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool s = true;
        private void S_Click(object sender, EventArgs e)
        {
            if (s)
            {
                bool get = g.check_find('s', 'S');
                if (get == true)
                {
                    S.Hide();
                    Word_lbl.Text = g.evaluate('s', 'S');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    S.BackColor = Color.Red;
                    s = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool t = true;
        private void T_Click(object sender, EventArgs e)
        {
            if (t)
            {
                bool get = g.check_find('t', 'T');
                if (get == true)
                {
                    T.Hide();
                    Word_lbl.Text = g.evaluate('t', 'T');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    T.BackColor = Color.Red;
                    t = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool u = true;
        private void U_Click(object sender, EventArgs e)
        {
            if (u)
            {
                bool get = g.check_find('u', 'U');
                if (get == true)
                {
                    U.Hide();
                    Word_lbl.Text = g.evaluate('u', 'U');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }

                else
                {
                    show_img(g.trials);
                    U.BackColor = Color.Red;
                    u = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool v = true;
        private void V_Click(object sender, EventArgs e)
        {
            if (v)
            {
                bool get = g.check_find('v', 'V');
                if (get == true)
                {
                    V.Hide();
                    Word_lbl.Text = g.evaluate('v', 'V');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    V.BackColor = Color.Red;
                    v = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool w = true;
        private void W_Click(object sender, EventArgs e)
        {
            if (w)
            {
                bool get = g.check_find('w', 'W');
                if (get == true)
                {
                    W.Hide();
                    Word_lbl.Text = g.evaluate('w', 'W');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    W.BackColor = Color.Red;
                    w = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }
       
        bool x = true;
        private void X_Click(object sender, EventArgs e)
        {
            if (x)
            {
                bool get = g.check_find('x', 'X');
                if (get == true)
                {
                    X.Hide();
                    Word_lbl.Text = g.evaluate('x', 'X');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    X.BackColor = Color.Red;
                    x = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool y = true;
        private void Y_Click(object sender, EventArgs e)
        {
            if (y)
            {
                bool get = g.check_find('y', 'Y');
                if (get == true)
                {
                    Y.Hide();
                    Word_lbl.Text = g.evaluate('y', 'Y');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    Y.BackColor = Color.Red;
                    y = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                        Game.score = 0;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        bool z=true;
        private void Z_Click(object sender, EventArgs e)
        {
            if (z)
            {
                bool get = g.check_find('z', 'Z');
                if (get == true)
                {
                    Z.Hide();
                    Word_lbl.Text = g.evaluate('z', 'Z');
                    if (g.Win_or_not())
                    {
                        MessageBox.Show("4atr");
                        score_lbl.Text = Game.score.ToString();
                        next_word();
                    }
                }
                else
                {
                    show_img(g.trials);
                    Z.BackColor = Color.Red;
                    z = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        g.Win_or_not();
                        var button = sender as Button;
                        worng_keys.Add(button);
                        MessageBox.Show("You Lost!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetControls();
                        GamingOptions_panel.Show();
                        your_trials_lbl.Hide();
                        trials_lbl.Hide();
                        Category_lbltxt.Hide();
                        Category_lblgame.Hide();
                        g.trials = 9;
                    }
                    trials_lbl.Text = g.trials.ToString();
                }
            }
        }

        private void Game_Form_Load(object sender, EventArgs e)
        {
            Category_cb.Hide();
            Category_lbl.Hide();
            Category_lbltxt.Hide();
            Category_lblgame.Hide();
            Hard_arow_L.Hide();
            Hard_arow_R.Hide();
            easy_arow_L.Hide();
            easy_arow_R.Hide();
            KA3DA.Hide();
            masn2a.Hide();
            Habl.Hide();
            ra2s.Hide();
            gesm.Hide();
            Eed_ymeen.Hide();
            regl_ymeen.Hide();
            regl_shemal.Hide();
            Eed_shemal.Hide();
        }


    
    }
}

        
