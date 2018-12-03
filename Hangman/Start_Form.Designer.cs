namespace Hangman
{
    partial class InterfaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EasyMode_rb = new System.Windows.Forms.RadioButton();
            this.MediumMode_rb = new System.Windows.Forms.RadioButton();
            this.HardMode_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Random_rb = new System.Windows.Forms.RadioButton();
            this.ByCategory_rb = new System.Windows.Forms.RadioButton();
            this.Play_bt = new System.Windows.Forms.Button();
            this.Category_lbl = new System.Windows.Forms.Label();
            this.Category_cb = new System.Windows.Forms.ComboBox();
            this.GamingOptions_panel = new System.Windows.Forms.Panel();
            this.Game_panel = new System.Windows.Forms.Panel();
            this.Word_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GamingOptions_panel.SuspendLayout();
            this.Game_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select game mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select words mode:";
            // 
            // EasyMode_rb
            // 
            this.EasyMode_rb.AutoSize = true;
            this.EasyMode_rb.Location = new System.Drawing.Point(6, 19);
            this.EasyMode_rb.Name = "EasyMode_rb";
            this.EasyMode_rb.Size = new System.Drawing.Size(48, 17);
            this.EasyMode_rb.TabIndex = 5;
            this.EasyMode_rb.TabStop = true;
            this.EasyMode_rb.Text = "Easy";
            this.EasyMode_rb.UseVisualStyleBackColor = true;
            this.EasyMode_rb.CheckedChanged += new System.EventHandler(this.EasyMode_rb_CheckedChanged);
            // 
            // MediumMode_rb
            // 
            this.MediumMode_rb.AutoSize = true;
            this.MediumMode_rb.Location = new System.Drawing.Point(60, 19);
            this.MediumMode_rb.Name = "MediumMode_rb";
            this.MediumMode_rb.Size = new System.Drawing.Size(62, 17);
            this.MediumMode_rb.TabIndex = 6;
            this.MediumMode_rb.TabStop = true;
            this.MediumMode_rb.Text = "Medium";
            this.MediumMode_rb.UseVisualStyleBackColor = true;
            this.MediumMode_rb.CheckedChanged += new System.EventHandler(this.MediumMode_rb_CheckedChanged);
            // 
            // HardMode_rb
            // 
            this.HardMode_rb.AutoSize = true;
            this.HardMode_rb.Location = new System.Drawing.Point(128, 19);
            this.HardMode_rb.Name = "HardMode_rb";
            this.HardMode_rb.Size = new System.Drawing.Size(48, 17);
            this.HardMode_rb.TabIndex = 7;
            this.HardMode_rb.TabStop = true;
            this.HardMode_rb.Text = "Hard";
            this.HardMode_rb.UseVisualStyleBackColor = true;
            this.HardMode_rb.CheckedChanged += new System.EventHandler(this.HardMode_rb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EasyMode_rb);
            this.groupBox1.Controls.Add(this.HardMode_rb);
            this.groupBox1.Controls.Add(this.MediumMode_rb);
            this.groupBox1.Location = new System.Drawing.Point(107, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Random_rb);
            this.groupBox2.Controls.Add(this.ByCategory_rb);
            this.groupBox2.Location = new System.Drawing.Point(107, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 45);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Random_rb
            // 
            this.Random_rb.AutoSize = true;
            this.Random_rb.Location = new System.Drawing.Point(6, 19);
            this.Random_rb.Name = "Random_rb";
            this.Random_rb.Size = new System.Drawing.Size(65, 17);
            this.Random_rb.TabIndex = 5;
            this.Random_rb.TabStop = true;
            this.Random_rb.Text = "Random";
            this.Random_rb.UseVisualStyleBackColor = true;
            this.Random_rb.CheckedChanged += new System.EventHandler(this.Randomly_rb_CheckedChanged);
            // 
            // ByCategory_rb
            // 
            this.ByCategory_rb.AutoSize = true;
            this.ByCategory_rb.Location = new System.Drawing.Point(84, 19);
            this.ByCategory_rb.Name = "ByCategory_rb";
            this.ByCategory_rb.Size = new System.Drawing.Size(81, 17);
            this.ByCategory_rb.TabIndex = 6;
            this.ByCategory_rb.TabStop = true;
            this.ByCategory_rb.Text = "By category";
            this.ByCategory_rb.UseVisualStyleBackColor = true;
            this.ByCategory_rb.CheckedChanged += new System.EventHandler(this.ByCategory_rb_CheckedChanged);
            // 
            // Play_bt
            // 
            this.Play_bt.Location = new System.Drawing.Point(479, 236);
            this.Play_bt.Name = "Play_bt";
            this.Play_bt.Size = new System.Drawing.Size(75, 23);
            this.Play_bt.TabIndex = 10;
            this.Play_bt.Text = "Play";
            this.Play_bt.UseVisualStyleBackColor = true;
            this.Play_bt.Click += new System.EventHandler(this.Play_bt_Click);
            // 
            // Category_lbl
            // 
            this.Category_lbl.AutoSize = true;
            this.Category_lbl.Location = new System.Drawing.Point(26, 105);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.Size = new System.Drawing.Size(85, 13);
            this.Category_lbl.TabIndex = 11;
            this.Category_lbl.Text = "Select Category:";
            // 
            // Category_cb
            // 
            this.Category_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_cb.FormattingEnabled = true;
            this.Category_cb.Items.AddRange(new object[] {
            "History",
            "Geography",
            "Animals",
            "Movies",
            "Science",
            "Sports"});
            this.Category_cb.Location = new System.Drawing.Point(117, 102);
            this.Category_cb.Name = "Category_cb";
            this.Category_cb.Size = new System.Drawing.Size(121, 21);
            this.Category_cb.TabIndex = 12;
            this.Category_cb.SelectedIndexChanged += new System.EventHandler(this.Category_cb_SelectedIndexChanged);
            // 
            // GamingOptions_panel
            // 
            this.GamingOptions_panel.Controls.Add(this.label1);
            this.GamingOptions_panel.Controls.Add(this.Category_cb);
            this.GamingOptions_panel.Controls.Add(this.label2);
            this.GamingOptions_panel.Controls.Add(this.Category_lbl);
            this.GamingOptions_panel.Controls.Add(this.groupBox1);
            this.GamingOptions_panel.Controls.Add(this.groupBox2);
            this.GamingOptions_panel.Location = new System.Drawing.Point(12, 12);
            this.GamingOptions_panel.Name = "GamingOptions_panel";
            this.GamingOptions_panel.Size = new System.Drawing.Size(449, 134);
            this.GamingOptions_panel.TabIndex = 13;
            // 
            // Game_panel
            // 
            this.Game_panel.Controls.Add(this.Word_lbl);
            this.Game_panel.Location = new System.Drawing.Point(24, 194);
            this.Game_panel.Name = "Game_panel";
            this.Game_panel.Size = new System.Drawing.Size(449, 254);
            this.Game_panel.TabIndex = 14;
            // 
            // Word_lbl
            // 
            this.Word_lbl.AutoSize = true;
            this.Word_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_lbl.Location = new System.Drawing.Point(201, 46);
            this.Word_lbl.Name = "Word_lbl";
            this.Word_lbl.Size = new System.Drawing.Size(105, 25);
            this.Word_lbl.TabIndex = 0;
            this.Word_lbl.Text = "Word_lbl";
            // 
            // InterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 349);
            this.Controls.Add(this.Game_panel);
            this.Controls.Add(this.GamingOptions_panel);
            this.Controls.Add(this.Play_bt);
            this.Name = "InterfaceForm";
            this.Text = "Hangman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GamingOptions_panel.ResumeLayout(false);
            this.GamingOptions_panel.PerformLayout();
            this.Game_panel.ResumeLayout(false);
            this.Game_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton EasyMode_rb;
        private System.Windows.Forms.RadioButton MediumMode_rb;
        private System.Windows.Forms.RadioButton HardMode_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Random_rb;
        private System.Windows.Forms.RadioButton ByCategory_rb;
        private System.Windows.Forms.Button Play_bt;
        private System.Windows.Forms.Label Category_lbl;
        private System.Windows.Forms.ComboBox Category_cb;
        private System.Windows.Forms.Panel GamingOptions_panel;
        private System.Windows.Forms.Panel Game_panel;
        private System.Windows.Forms.Label Word_lbl;
    }
}

