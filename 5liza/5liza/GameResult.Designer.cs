namespace _5liza
{
    partial class GameResult
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
            this.Name1ResultLabel = new System.Windows.Forms.Label();
            this.Score1ResultLabel = new System.Windows.Forms.Label();
            this.Name2ResultLabel = new System.Windows.Forms.Label();
            this.Score2ResultLabel = new System.Windows.Forms.Label();
            this.RestarBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name1ResultLabel
            // 
            this.Name1ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.Name1ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1ResultLabel.Location = new System.Drawing.Point(87, 134);
            this.Name1ResultLabel.Name = "Name1ResultLabel";
            this.Name1ResultLabel.Size = new System.Drawing.Size(189, 38);
            this.Name1ResultLabel.TabIndex = 0;
            this.Name1ResultLabel.Text = "Player1";
            // 
            // Score1ResultLabel
            // 
            this.Score1ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.Score1ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1ResultLabel.Location = new System.Drawing.Point(460, 134);
            this.Score1ResultLabel.Name = "Score1ResultLabel";
            this.Score1ResultLabel.Size = new System.Drawing.Size(115, 32);
            this.Score1ResultLabel.TabIndex = 1;
            this.Score1ResultLabel.Text = "Score1";
            // 
            // Name2ResultLabel
            // 
            this.Name2ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.Name2ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name2ResultLabel.Location = new System.Drawing.Point(87, 235);
            this.Name2ResultLabel.Name = "Name2ResultLabel";
            this.Name2ResultLabel.Size = new System.Drawing.Size(193, 38);
            this.Name2ResultLabel.TabIndex = 2;
            this.Name2ResultLabel.Text = "Player2";
            // 
            // Score2ResultLabel
            // 
            this.Score2ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.Score2ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2ResultLabel.Location = new System.Drawing.Point(460, 235);
            this.Score2ResultLabel.Name = "Score2ResultLabel";
            this.Score2ResultLabel.Size = new System.Drawing.Size(117, 32);
            this.Score2ResultLabel.TabIndex = 3;
            this.Score2ResultLabel.Text = "Score2";
            // 
            // RestarBtn
            // 
            this.RestarBtn.Location = new System.Drawing.Point(60, 361);
            this.RestarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestarBtn.Name = "RestarBtn";
            this.RestarBtn.Size = new System.Drawing.Size(141, 38);
            this.RestarBtn.TabIndex = 4;
            this.RestarBtn.Text = "Restart";
            this.RestarBtn.UseVisualStyleBackColor = true;
            this.RestarBtn.Click += new System.EventHandler(this.RestarBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(277, 361);
            this.MainMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(141, 38);
            this.MainMenuBtn.TabIndex = 5;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(496, 361);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(141, 38);
            this.QuitBtn.TabIndex = 6;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_5liza.Properties.Resources.ResultBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 437);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.RestarBtn);
            this.Controls.Add(this.Score2ResultLabel);
            this.Controls.Add(this.Name2ResultLabel);
            this.Controls.Add(this.Score1ResultLabel);
            this.Controls.Add(this.Name1ResultLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Name1ResultLabel;
        private System.Windows.Forms.Label Score1ResultLabel;
        private System.Windows.Forms.Label Name2ResultLabel;
        private System.Windows.Forms.Label Score2ResultLabel;
        private System.Windows.Forms.Button RestarBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button QuitBtn;
    }
}