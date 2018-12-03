namespace Hangman
{
    partial class Game_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            this.masn2a = new System.Windows.Forms.Panel();
            this.regl_shemal = new System.Windows.Forms.Panel();
            this.Eed_shemal = new System.Windows.Forms.Panel();
            this.regl_ymeen = new System.Windows.Forms.Panel();
            this.Eed_ymeen = new System.Windows.Forms.Panel();
            this.gesm = new System.Windows.Forms.Panel();
            this.ra2s = new System.Windows.Forms.Panel();
            this.def_txt = new System.Windows.Forms.Label();
            this.hint_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyboard1 = new Hangman.Keyboard();
            this.masn2a.SuspendLayout();
            this.SuspendLayout();
            // 
            // masn2a
            // 
            this.masn2a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("masn2a.BackgroundImage")));
            this.masn2a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.masn2a.Controls.Add(this.regl_shemal);
            this.masn2a.Controls.Add(this.Eed_shemal);
            this.masn2a.Controls.Add(this.regl_ymeen);
            this.masn2a.Controls.Add(this.Eed_ymeen);
            this.masn2a.Controls.Add(this.gesm);
            this.masn2a.Controls.Add(this.ra2s);
            this.masn2a.Location = new System.Drawing.Point(444, 125);
            this.masn2a.Name = "masn2a";
            this.masn2a.Size = new System.Drawing.Size(198, 251);
            this.masn2a.TabIndex = 1;
            // 
            // regl_shemal
            // 
            this.regl_shemal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regl_shemal.BackgroundImage")));
            this.regl_shemal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regl_shemal.Location = new System.Drawing.Point(144, 126);
            this.regl_shemal.Name = "regl_shemal";
            this.regl_shemal.Size = new System.Drawing.Size(24, 25);
            this.regl_shemal.TabIndex = 7;
            // 
            // Eed_shemal
            // 
            this.Eed_shemal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eed_shemal.BackgroundImage")));
            this.Eed_shemal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eed_shemal.Location = new System.Drawing.Point(146, 101);
            this.Eed_shemal.Name = "Eed_shemal";
            this.Eed_shemal.Size = new System.Drawing.Size(24, 25);
            this.Eed_shemal.TabIndex = 6;
            // 
            // regl_ymeen
            // 
            this.regl_ymeen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regl_ymeen.BackgroundImage")));
            this.regl_ymeen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regl_ymeen.Location = new System.Drawing.Point(115, 127);
            this.regl_ymeen.Name = "regl_ymeen";
            this.regl_ymeen.Size = new System.Drawing.Size(24, 25);
            this.regl_ymeen.TabIndex = 5;
            // 
            // Eed_ymeen
            // 
            this.Eed_ymeen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eed_ymeen.BackgroundImage")));
            this.Eed_ymeen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eed_ymeen.Location = new System.Drawing.Point(113, 101);
            this.Eed_ymeen.Name = "Eed_ymeen";
            this.Eed_ymeen.Size = new System.Drawing.Size(24, 25);
            this.Eed_ymeen.TabIndex = 4;
            // 
            // gesm
            // 
            this.gesm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gesm.BackgroundImage")));
            this.gesm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gesm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gesm.Location = new System.Drawing.Point(124, 102);
            this.gesm.Name = "gesm";
            this.gesm.Size = new System.Drawing.Size(37, 37);
            this.gesm.TabIndex = 3;
            // 
            // ra2s
            // 
            this.ra2s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ra2s.BackgroundImage")));
            this.ra2s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ra2s.Location = new System.Drawing.Point(123, 69);
            this.ra2s.Name = "ra2s";
            this.ra2s.Size = new System.Drawing.Size(37, 37);
            this.ra2s.TabIndex = 2;
            // 
            // def_txt
            // 
            this.def_txt.AutoSize = true;
            this.def_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_txt.Location = new System.Drawing.Point(262, 25);
            this.def_txt.Name = "def_txt";
            this.def_txt.Size = new System.Drawing.Size(172, 20);
            this.def_txt.TabIndex = 0;
            this.def_txt.Text = "this is the  difinition text";
            // 
            // hint_txt
            // 
            this.hint_txt.AutoSize = true;
            this.hint_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_txt.Location = new System.Drawing.Point(262, 416);
            this.hint_txt.Name = "hint_txt";
            this.hint_txt.Size = new System.Drawing.Size(136, 20);
            this.hint_txt.TabIndex = 2;
            this.hint_txt.Text = "this is the hint text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "- - - - - -";
            // 
            // keyboard1
            // 
            this.keyboard1.BackColor = System.Drawing.Color.Bisque;
            this.keyboard1.Location = new System.Drawing.Point(12, 132);
            this.keyboard1.Name = "keyboard1";
            this.keyboard1.Size = new System.Drawing.Size(253, 229);
            this.keyboard1.TabIndex = 0;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.hint_txt);
            this.Controls.Add(this.keyboard1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.def_txt);
            this.Controls.Add(this.masn2a);
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.masn2a.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keyboard keyboard1;
        private System.Windows.Forms.Panel masn2a;
        private System.Windows.Forms.Label def_txt;
        private System.Windows.Forms.Label hint_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel regl_shemal;
        private System.Windows.Forms.Panel Eed_shemal;
        private System.Windows.Forms.Panel regl_ymeen;
        private System.Windows.Forms.Panel Eed_ymeen;
        private System.Windows.Forms.Panel gesm;
        private System.Windows.Forms.Panel ra2s;
    }
}