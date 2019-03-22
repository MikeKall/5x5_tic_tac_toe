namespace _5liza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Classic_Btn = new System.Windows.Forms.Button();
            this.Classic_Player_Radio = new System.Windows.Forms.RadioButton();
            this.Classic_Computer_Radio = new System.Windows.Forms.RadioButton();
            this.Arcade_Computer_Radio = new System.Windows.Forms.RadioButton();
            this.Arcade_Player_Radio = new System.Windows.Forms.RadioButton();
            this.Start_Game = new System.Windows.Forms.Button();
            this.Arcade_Btn = new System.Windows.Forms.Button();
            this.QuitMenuBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Classic_Btn
            // 
            this.Classic_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic_Btn.Location = new System.Drawing.Point(207, 151);
            this.Classic_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Classic_Btn.Name = "Classic_Btn";
            this.Classic_Btn.Size = new System.Drawing.Size(163, 36);
            this.Classic_Btn.TabIndex = 0;
            this.Classic_Btn.Text = "Classic";
            this.Classic_Btn.UseVisualStyleBackColor = true;
            this.Classic_Btn.Click += new System.EventHandler(this.Classic_Btn_Click);
            // 
            // Classic_Player_Radio
            // 
            this.Classic_Player_Radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Classic_Player_Radio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Classic_Player_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic_Player_Radio.Location = new System.Drawing.Point(236, 194);
            this.Classic_Player_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Classic_Player_Radio.Name = "Classic_Player_Radio";
            this.Classic_Player_Radio.Size = new System.Drawing.Size(97, 27);
            this.Classic_Player_Radio.TabIndex = 2;
            this.Classic_Player_Radio.TabStop = true;
            this.Classic_Player_Radio.Text = "vs Player";
            this.Classic_Player_Radio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Classic_Player_Radio.UseVisualStyleBackColor = false;
            this.Classic_Player_Radio.Visible = false;
            this.Classic_Player_Radio.CheckedChanged += new System.EventHandler(this.Classic_Player_Radio_CheckedChanged);
            // 
            // Classic_Computer_Radio
            // 
            this.Classic_Computer_Radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Classic_Computer_Radio.AutoSize = true;
            this.Classic_Computer_Radio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Classic_Computer_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic_Computer_Radio.Location = new System.Drawing.Point(236, 224);
            this.Classic_Computer_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Classic_Computer_Radio.Name = "Classic_Computer_Radio";
            this.Classic_Computer_Radio.Size = new System.Drawing.Size(97, 27);
            this.Classic_Computer_Radio.TabIndex = 3;
            this.Classic_Computer_Radio.TabStop = true;
            this.Classic_Computer_Radio.Text = "vs Computer";
            this.Classic_Computer_Radio.UseVisualStyleBackColor = false;
            this.Classic_Computer_Radio.Visible = false;
            this.Classic_Computer_Radio.CheckedChanged += new System.EventHandler(this.Classic_Computer_Radio_CheckedChanged);
            // 
            // Arcade_Computer_Radio
            // 
            this.Arcade_Computer_Radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Arcade_Computer_Radio.AutoSize = true;
            this.Arcade_Computer_Radio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Arcade_Computer_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arcade_Computer_Radio.Location = new System.Drawing.Point(478, 224);
            this.Arcade_Computer_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Arcade_Computer_Radio.Name = "Arcade_Computer_Radio";
            this.Arcade_Computer_Radio.Size = new System.Drawing.Size(97, 27);
            this.Arcade_Computer_Radio.TabIndex = 5;
            this.Arcade_Computer_Radio.TabStop = true;
            this.Arcade_Computer_Radio.Text = "vs Computer";
            this.Arcade_Computer_Radio.UseVisualStyleBackColor = false;
            this.Arcade_Computer_Radio.Visible = false;
            this.Arcade_Computer_Radio.CheckedChanged += new System.EventHandler(this.Arcade_Computer_Radio_CheckedChanged);
            // 
            // Arcade_Player_Radio
            // 
            this.Arcade_Player_Radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Arcade_Player_Radio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Arcade_Player_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arcade_Player_Radio.Location = new System.Drawing.Point(477, 194);
            this.Arcade_Player_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Arcade_Player_Radio.Name = "Arcade_Player_Radio";
            this.Arcade_Player_Radio.Size = new System.Drawing.Size(98, 27);
            this.Arcade_Player_Radio.TabIndex = 4;
            this.Arcade_Player_Radio.TabStop = true;
            this.Arcade_Player_Radio.Text = "vs Player";
            this.Arcade_Player_Radio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Arcade_Player_Radio.UseVisualStyleBackColor = false;
            this.Arcade_Player_Radio.Visible = false;
            this.Arcade_Player_Radio.CheckedChanged += new System.EventHandler(this.Arcade_Player_Radio_CheckedChanged);
            // 
            // Start_Game
            // 
            this.Start_Game.BackColor = System.Drawing.Color.Transparent;
            this.Start_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Game.Location = new System.Drawing.Point(323, 294);
            this.Start_Game.Margin = new System.Windows.Forms.Padding(4);
            this.Start_Game.Name = "Start_Game";
            this.Start_Game.Size = new System.Drawing.Size(163, 50);
            this.Start_Game.TabIndex = 6;
            this.Start_Game.Text = "Start Game";
            this.Start_Game.UseVisualStyleBackColor = false;
            this.Start_Game.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // Arcade_Btn
            // 
            this.Arcade_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arcade_Btn.Location = new System.Drawing.Point(445, 151);
            this.Arcade_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Arcade_Btn.Name = "Arcade_Btn";
            this.Arcade_Btn.Size = new System.Drawing.Size(163, 36);
            this.Arcade_Btn.TabIndex = 7;
            this.Arcade_Btn.Text = "Arcade";
            this.Arcade_Btn.UseVisualStyleBackColor = true;
            this.Arcade_Btn.Click += new System.EventHandler(this.Arcade_Btn_Click);
            // 
            // QuitMenuBtn
            // 
            this.QuitMenuBtn.Location = new System.Drawing.Point(348, 369);
            this.QuitMenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QuitMenuBtn.Name = "QuitMenuBtn";
            this.QuitMenuBtn.Size = new System.Drawing.Size(111, 33);
            this.QuitMenuBtn.TabIndex = 9;
            this.QuitMenuBtn.Text = "Quit";
            this.QuitMenuBtn.UseVisualStyleBackColor = true;
            this.QuitMenuBtn.Click += new System.EventHandler(this.QuitMenuBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_5liza.Properties.Resources.BoredGame;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(113, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::_5liza.Properties.Resources.tic_tac_toe__paper__pencil__rubber__ruler_218385;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuitMenuBtn);
            this.Controls.Add(this.Arcade_Btn);
            this.Controls.Add(this.Start_Game);
            this.Controls.Add(this.Arcade_Computer_Radio);
            this.Controls.Add(this.Arcade_Player_Radio);
            this.Controls.Add(this.Classic_Computer_Radio);
            this.Controls.Add(this.Classic_Player_Radio);
            this.Controls.Add(this.Classic_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(825, 468);
            this.MinimumSize = new System.Drawing.Size(825, 468);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Classic_Btn;
        private System.Windows.Forms.RadioButton Classic_Player_Radio;
        private System.Windows.Forms.RadioButton Classic_Computer_Radio;
        private System.Windows.Forms.RadioButton Arcade_Computer_Radio;
        private System.Windows.Forms.RadioButton Arcade_Player_Radio;
        private System.Windows.Forms.Button Start_Game;
        private System.Windows.Forms.Button Arcade_Btn;
        private System.Windows.Forms.Button QuitMenuBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

