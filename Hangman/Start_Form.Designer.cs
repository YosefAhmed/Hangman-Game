namespace Hangman
{
    partial class Start_Form
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
            this.hard_btn = new System.Windows.Forms.Button();
            this.med_btn = new System.Windows.Forms.Button();
            this.esy_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hard_btn
            // 
            this.hard_btn.Location = new System.Drawing.Point(240, 108);
            this.hard_btn.Name = "hard_btn";
            this.hard_btn.Size = new System.Drawing.Size(176, 55);
            this.hard_btn.TabIndex = 0;
            this.hard_btn.Text = "Hard";
            this.hard_btn.UseVisualStyleBackColor = true;
            // 
            // med_btn
            // 
            this.med_btn.Location = new System.Drawing.Point(240, 180);
            this.med_btn.Name = "med_btn";
            this.med_btn.Size = new System.Drawing.Size(176, 55);
            this.med_btn.TabIndex = 1;
            this.med_btn.Text = "Medium";
            this.med_btn.UseVisualStyleBackColor = true;
            // 
            // esy_btn
            // 
            this.esy_btn.Location = new System.Drawing.Point(240, 253);
            this.esy_btn.Name = "esy_btn";
            this.esy_btn.Size = new System.Drawing.Size(176, 55);
            this.esy_btn.TabIndex = 2;
            this.esy_btn.Text = "Easy";
            this.esy_btn.UseVisualStyleBackColor = true;
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(542, 12);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(130, 55);
            this.Play_btn.TabIndex = 3;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Level";
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.esy_btn);
            this.Controls.Add(this.med_btn);
            this.Controls.Add(this.hard_btn);
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hard_btn;
        private System.Windows.Forms.Button med_btn;
        private System.Windows.Forms.Button esy_btn;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Label label1;
    }
}