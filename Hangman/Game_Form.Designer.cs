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
            this.Pic_panel = new System.Windows.Forms.Panel();
            this.def_txt = new System.Windows.Forms.Label();
            this.hint_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyboard1 = new Hangman.Keyboard();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_panel
            // 
            this.Pic_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_panel.Controls.Add(this.label2);
            this.Pic_panel.Location = new System.Drawing.Point(444, 125);
            this.Pic_panel.Name = "Pic_panel";
            this.Pic_panel.Size = new System.Drawing.Size(198, 251);
            this.Pic_panel.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "هنا صورة حد مشنوق";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.Pic_panel);
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Pic_panel.ResumeLayout(false);
            this.Pic_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keyboard keyboard1;
        private System.Windows.Forms.Panel Pic_panel;
        private System.Windows.Forms.Label def_txt;
        private System.Windows.Forms.Label hint_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}