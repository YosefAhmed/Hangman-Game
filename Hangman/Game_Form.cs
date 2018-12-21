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
//using System.Collections;
namespace Hangman
{
    public partial class Game_Form : Form
    {
        public Game_Form()
        {

            InitializeComponent();
        }
        //ArrayList worng_keys = new ArrayList();
        Game g = new Game();
        Game.DATA gd = new Game.DATA();
        public void hide_arrows()
        {
            Hard_arow_L.Hide();Hard_arow_R.Hide();easy_arow_L.Hide();easy_arow_R.Hide();Med_arow_L.Hide(); Med_arow_R.Hide();
        }
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
                    dead.Show();
                    break;

            }
        }
        private void resetControls() //resets controls in GamingOptions_panel when quit button is pressed
        {
            Game.score = 0;
            score_lbl.Text = Game.score.ToString();
            hide_arrows();
            arw1.Show(); arw2.Hide(); arw3.Hide(); arw4.Hide(); arw5.Hide(); arw6.Hide();
            Med_arow_L.Show();Med_arow_R.Show(); Category_lbl.Hide();
            hint_txt.Text = "Give me a hint";
            a = true; s = true; d = true; f = true; gg = true; h = true; j = true; k = true; l = true; m = true; n = true; o = true; p = true;
            q = true; w = true; ee = true; r = true; t = true; y = true; u = true; i = true; bb = true; v = true; c = true; x = true; z = true;
            KA3DA.Hide(); masn2a.Hide(); Habl.Hide(); ra2s.Hide(); regl_shemal.Hide();
            gesm.Hide(); dead.Hide(); Eed_ymeen.Hide(); regl_ymeen.Hide(); Eed_shemal.Hide();         
            ranom.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode fill.png", true);
            by_category.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode.png", true);
            Reset_keyboard();
            category__pnl.Hide();
        }
        public void Reset_keyboard()
        {
            ICollection MyKeys;
            Hashtable Images = new Hashtable();
            Images.Add("AA", @"E:\projects\Hangman\Hangman\Hangman\Resources\A.png"); Images.Add("B", @"E:\projects\Hangman\Hangman\Hangman\Resources\B.png");
            Images.Add("C", @"E:\projects\Hangman\Hangman\Hangman\Resources\C.png"); Images.Add("D", @"E:\projects\Hangman\Hangman\Hangman\Resources\D.png");
            Images.Add("E", @"E:\projects\Hangman\Hangman\Hangman\Resources\E.png"); Images.Add("F", @"E:\projects\Hangman\Hangman\Hangman\Resources\F.png");
            Images.Add("GG", @"E:\projects\Hangman\Hangman\Hangman\Resources\G.png"); Images.Add("H", @"E:\projects\Hangman\Hangman\Hangman\Resources\H.png");
            Images.Add("J", @"E:\projects\Hangman\Hangman\Hangman\Resources\J.png"); Images.Add("K", @"E:\projects\Hangman\Hangman\Hangman\Resources\K.png");
            Images.Add("L", @"E:\projects\Hangman\Hangman\Hangman\Resources\L.png"); Images.Add("M", @"E:\projects\Hangman\Hangman\Hangman\Resources\M.png");
            Images.Add("N", @"E:\projects\Hangman\Hangman\Hangman\Resources\N.png"); Images.Add("O", @"E:\projects\Hangman\Hangman\Hangman\Resources\O.png");
            Images.Add("P", @"E:\projects\Hangman\Hangman\Hangman\Resources\P.png"); Images.Add("Q", @"E:\projects\Hangman\Hangman\Hangman\Resources\Q.png");
            Images.Add("R", @"E:\projects\Hangman\Hangman\Hangman\Resources\R.png"); Images.Add("S", @"E:\projects\Hangman\Hangman\Hangman\Resources\S.png");
            Images.Add("T", @"E:\projects\Hangman\Hangman\Hangman\Resources\T.png"); Images.Add("U", @"E:\projects\Hangman\Hangman\Hangman\Resources\U.png");
            Images.Add("V", @"E:\projects\Hangman\Hangman\Hangman\Resources\V.png"); Images.Add("W", @"E:\projects\Hangman\Hangman\Hangman\Resources\W.png");
            Images.Add("X", @"E:\projects\Hangman\Hangman\Hangman\Resources\X BUTTON.png"); Images.Add("Y", @"E:\projects\Hangman\Hangman\Hangman\Resources\Y.png");
            Images.Add("Z", @"E:\projects\Hangman\Hangman\Hangman\Resources\Z.png"); Images.Add("II", @"E:\projects\Hangman\Hangman\Hangman\Resources\I.png");


            foreach (PictureBox b in Keyboard.Controls)
            {

                MyKeys = Images.Keys;
                foreach (string Key in MyKeys)
                {
                    if (b.Name == Key)
                    {
                        b.Image = new Bitmap(Images[Key].ToString());
                        b.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                }

            }

        }
        private void Game_Form_Load(object sender, EventArgs e)
        {
            Category_lbl.Hide(); Category_lbltxt.Hide();
            Category_lblgame.Hide(); KA3DA.Hide();
            masn2a.Hide(); Habl.Hide(); ra2s.Hide(); gesm.Hide(); dead.Hide(); Eed_ymeen.Hide();
            regl_ymeen.Hide(); regl_shemal.Hide();  Eed_shemal.Hide();
            hide_arrows();
            Med_arow_L.Show(); Med_arow_R.Show();
            category__pnl.Hide();
            arw1.Show(); arw2.Hide(); arw3.Hide(); arw4.Hide(); arw5.Hide(); arw6.Hide();
            ranom.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode fill.png", true);
            by_category.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode.png", true);
        }
        private void hint_txt_Click(object sender, EventArgs e)
        {
            hint_txt.Text = gd.hint;
        }
        private void next_word()
        {
            Reset_keyboard();
            ranom.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode.png", true);
            by_category.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode.png", true);
            arw1.Hide(); arw2.Hide(); arw3.Hide(); arw4.Hide(); arw5.Hide(); arw6.Hide();
            KA3DA.Hide(); masn2a.Hide(); Habl.Hide(); ra2s.Hide(); gesm.Hide();  dead.Hide();  Eed_ymeen.Hide();
            regl_ymeen.Hide(); regl_shemal.Hide(); Eed_shemal.Hide();
            gd = g.Generate_Game_Data();
            string generated_Word = gd.word;
            def_txt.Text = gd.defenition;
            Word_lbl.Text = g.CreatDashes(generated_Word);
            Category_lblgame.Text = gd.category_st;
            g.trials = 9;
            your_trials_lbl.Show();  trials_lbl.Show();  trials_lbl.Text = g.trials.ToString(); Category_lbltxt.Show(); Category_lblgame.Show();
            hint_txt.Text = "Give me a hint";
            a = true; s = true; d = true; f = true; gg = true; h = true; j = true; k = true; l = true; m = true; n = true; o = true; p = true;
            q = true; w = true; ee = true; r = true; t = true; y = true; u = true; i = true; bb = true; v = true; c = true; x = true; z = true;
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
            gd = g.Generate_Game_Data();
            string generated_Word = gd.word;
            def_txt.Text = gd.defenition;
            Word_lbl.Text = g.CreatDashes(generated_Word);
            Category_lblgame.Text = gd.category_st;
            GamingOptions_panel.Hide();
            Quit_btn.Show();

        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            resetControls();
            GamingOptions_panel.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Image img_opacity(Image img)//this function reduces the opacity of letters
        {
            Bitmap image1 = new Bitmap(img);
            for (int w = 0; w < image1.Width; w++)
            {

                for (int h = 0; h < image1.Height; h++)
                {

                    Color c = image1.GetPixel(w, h);

                    Color newC = Color.FromArgb(40, c);

                    image1.SetPixel(w, h, newC);

                }

            }

            return image1;
        }


        private void ranom_Click(object sender, EventArgs e)
        {
            ranom.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode fill.png", true);
            by_category.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode.png", true);
            g.words_mode = "Random";
            Category_lbl.Hide();
            category__pnl.Hide();
        }

        private void by_category_Click(object sender, EventArgs e)
        {
            by_category.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode fill.png", true);
            ranom.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\mode.png", true);
            g.words_mode = "ByCategory";
            Category_lbl.Show();
            category__pnl.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            g.category = "History";
            arw1.Show(); arw2.Hide(); arw3.Hide(); arw4.Hide(); arw5.Hide(); arw6.Hide();
        }
        private void Geography_Click(object sender, EventArgs e)
        {
            g.category = "Geography";
            arw1.Hide(); arw2.Show(); arw3.Hide(); arw4.Hide(); arw5.Hide(); arw6.Hide();
        }
        private void Science_Click(object sender, EventArgs e)
        {
            g.category = "Science";
            arw1.Hide(); arw2.Hide(); arw3.Show(); ; arw4.Hide(); arw5.Hide(); arw6.Hide();
        }
        private void Animals_Click(object sender, EventArgs e)
        {
            g.category = "Animals";
            arw1.Hide(); arw2.Hide(); arw3.Hide(); ; arw4.Show(); arw5.Hide(); arw6.Hide();
        }
        private void Sports_Click(object sender, EventArgs e)
        {
            g.category = "Sports";
            arw1.Hide(); arw2.Hide(); arw3.Hide(); ; arw4.Hide(); arw5.Show(); arw6.Hide();
        }
        private void Movies_Click(object sender, EventArgs e)
        {
            g.category = "Movies";
            arw1.Hide(); arw2.Hide(); arw3.Hide(); ; arw4.Hide(); arw5.Hide(); arw6.Show();
        }


        bool z = true;//if it is False it means that the letter is wrong and has been already pressed
        private void Z_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('z', 'Z');
            if (get == true)
            {
                Z.Image = img_opacity(Z.Image);
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
                if (z)
                {
                    show_img(g.trials);
                    Z.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\ZW.png", true);
                    Z.Image = img_opacity(Z.Image);
                    z = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        g.Win_or_not();
                        var button = sender as Button;
                      //  worng_keys.Add(button);
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

        bool y = true;
        private void Y_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('y', 'Y');
            if (get == true)
            {
                Y.Image = img_opacity(Y.Image);
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
                if (y)
                {
                    show_img(g.trials);
                    Y.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\YW.png", true);
                    Y.Image = img_opacity(Y.Image);
                    y = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('x', 'X');
            if (get == true)
            {
                X.Image = img_opacity(X.Image);
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
                if (x)
                {
                    show_img(g.trials);
                    X.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\XW.png", true);
                    X.Image = img_opacity(X.Image);
                    x = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('w', 'W');
            if (get == true)
            {
                W.Image = img_opacity(W.Image);
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
                if (w)
                {
                    show_img(g.trials);
                    W.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\WW.png", true);
                    W.Image = img_opacity(W.Image); w = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

            bool get = g.check_find('v', 'V');
            if (get == true)
            {
                V.Image = img_opacity(V.Image);
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
                if (v)
                {
                    show_img(g.trials);
                    V.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\VW.png", true);
                    V.Image = img_opacity(V.Image);
                    v = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('u', 'U');
            if (get == true)
            {
                U.Image = img_opacity(U.Image);
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
                if (u)
                {
                    show_img(g.trials);
                    U.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\UW.png", true);
                    U.Image = img_opacity(U.Image);
                    u = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

            bool get = g.check_find('t', 'T');
            if (get == true)
            {
                T.Image = img_opacity(T.Image);
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
                if (t)
                {
                    show_img(g.trials);
                    T.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\TW.png", true);
                    T.Image = img_opacity(T.Image);
                    t = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

            bool get = g.check_find('s', 'S');
            if (get == true)
            {
                S.Image = img_opacity(S.Image);
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
                if (s)
                {
                    show_img(g.trials);
                    S.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\SW.png", true);
                    S.Image = img_opacity(S.Image);
                    s = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('r', 'R');
            if (get == true)
            {
                R.Image = img_opacity(R.Image);
                Word_lbl.Text = g.evaluate('r', 'R');
                if (g.Win_or_not())
                {
                    MessageBox.Show("4atr");
                    next_word();
                }
            }
            else
            {
                if (r)
                {
                    show_img(g.trials);
                    R.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\RW.png", true);
                    R.Image = img_opacity(R.Image);
                    r = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

            bool get = g.check_find('q', 'Q');
            if (get == true)
            {
                Q.Image = img_opacity(Q.Image);
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
                if (q)
                {
                    show_img(g.trials);
                    Q.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\QW.png", true);
                    Q.Image = img_opacity(Q.Image);
                    q = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('p', 'P');
            if (get == true)
            {
                P.Image = img_opacity(P.Image);
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
                if (p)
                {
                    show_img(g.trials);
                    P.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\PW.png", true);
                    P.Image = img_opacity(P.Image);
                    p = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                 //       worng_keys.Add(button);
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

            bool get = g.check_find('o', 'O');
            if (get == true)
            {
                O.Image = img_opacity(O.Image);
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
                if (o)
                {
                    show_img(g.trials);
                    O.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\OW.png", true);
                    O.Image = img_opacity(O.Image);
                    o = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                     //   worng_keys.Add(button);
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

            bool get = g.check_find('n', 'N');
            if (get == true)
            {
                N.Image = img_opacity(N.Image);
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
                if (n)
                {
                    show_img(g.trials);
                    N.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\NW.png", true);
                    N.Image = img_opacity(N.Image);
                    n = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

        bool m = true;
        private void M_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('m', 'M');
            if (get == true)
            {
                M.Image = img_opacity(M.Image);
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
                if (m)
                {
                    show_img(g.trials);
                    M.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\MW.png", true);
                    M.Image = img_opacity(M.Image);
                    m = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                        //worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('l', 'L');
            if (get == true)
            {
                L.Image = img_opacity(L.Image);
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
                if (l)
                {
                    show_img(g.trials);
                    L.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\LW.png", true);
                    L.Image = img_opacity(L.Image);
                    l = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                     //   worng_keys.Add(button);
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

        bool k = true;
        private void K_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('k', 'K');
            if (get == true)
            {
                K.Image = img_opacity(K.Image);
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
                if (k)
                {
                    show_img(g.trials);
                    K.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\KW.png", true);
                    K.Image = img_opacity(K.Image);
                    k = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                     //   worng_keys.Add(button);
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

            bool get = g.check_find('j', 'J');
            if (get == true)
            {
                J.Image = img_opacity(J.Image);
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
                if (j)
                {
                    show_img(g.trials);
                    J.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\JW.png", true);
                    J.Image = img_opacity(J.Image);
                    j = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                     //   worng_keys.Add(button);
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
        private void II_Click(object sender, EventArgs e)
        {
            bool get = g.check_find('i', 'I');
            if (get == true)
            {
                II.Image = img_opacity(II.Image);
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
                if (i)
                {
                    show_img(g.trials);
                    II.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\IW.png", true);
                    II.Image = img_opacity(II.Image);
                    i = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

            bool get = g.check_find('h', 'H');
            if (get == true)
            {
                H.Image = img_opacity(H.Image);
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
                if (h)
                {
                    show_img(g.trials);
                    H.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\HW.png", true);
                    H.Image = img_opacity(H.Image); h = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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
        private void GG_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('g', 'G');
            if (get == true)
            {
                GG.Image = img_opacity(GG.Image);
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
                if (gg)
                {
                    show_img(g.trials);
                    GG.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\GW.png", true);
                    GG.Image = img_opacity(GG.Image);
                    gg = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

        bool f = true;
        private void F_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('f', 'F');
            if (get == true)
            {
                F.Image = img_opacity(F.Image);
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
                if (f)
                {
                    show_img(g.trials);
                    F.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\FW.png", true);
                    F.Image = img_opacity(F.Image);
                    f = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

            bool get = g.check_find('e', 'E');
            if (get == true)
            {
                E.Image = img_opacity(E.Image);
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
                if (ee)
                {
                    show_img(g.trials);
                    E.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\EW.png", true);
                    E.Image = img_opacity(E.Image);
                    ee = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

        bool d = true;
        private void D_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('d', 'D');
            if (get == true)
            {
                D.Image = img_opacity(D.Image);
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
                if (d)
                {
                    show_img(g.trials);
                    D.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\DW.png", true);
                    D.Image = img_opacity(D.Image);
                    d = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                      //  worng_keys.Add(button);
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

        bool c = true;
        private void C_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('c', 'C');
            if (get == true)
            {
                C.Image = img_opacity(C.Image);
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
                if (c)
                {
                    show_img(g.trials);
                    C.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\CW.png", true);
                    C.Image = img_opacity(C.Image);
                    c = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;
                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

        bool bb = true;
        private void B_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('b', 'B');
            if (get == true)
            {
                B.Image = img_opacity(AA.Image);
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
                if (bb)
                {
                    show_img(g.trials);
                    B.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\BW.png", true);
                    B.Image = img_opacity(B.Image);
                    bb = false;
                    if (g.trials != 1)
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
                        g.trials--;

                    }

                    else
                    {
                        var button = sender as PictureBox;
                       // worng_keys.Add(button);
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

        bool a = true;
        private void AA_Click(object sender, EventArgs e)
        {

            bool get = g.check_find('a', 'A');
            if (get == true)
            {
                AA.Image = img_opacity(AA.Image);
                Word_lbl.Text = g.evaluate('a', 'A');

                if (g.Win_or_not())
                {
                    MessageBox.Show("4atr", Game.score.ToString());
                    score_lbl.Text = Game.score.ToString();
                    next_word();
                }
            }

            else
            {
                if (a)
                {
                show_img(g.trials);
                AA.Image = new Bitmap(@"E:\projects\Hangman\Hangman\Hangman\Resources\AW.png", true);
                AA.Image = img_opacity(AA.Image);
                a = false;
                if (g.trials != 1)
                {
                    var button = sender as PictureBox;
                   // worng_keys.Add(button);
                    g.trials--;

                }

                else
                {
                       var button = sender as PictureBox;
                       // worng_keys.Add(button);
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







    }
}


