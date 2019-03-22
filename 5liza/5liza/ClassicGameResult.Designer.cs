namespace _5liza
{
    partial class ClassicGameResult
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
            this.ClassicResultLabel = new System.Windows.Forms.Label();
            this.ClassicRestartBtn = new System.Windows.Forms.Button();
            this.ClassicMenuBtn = new System.Windows.Forms.Button();
            this.ClassicQuitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassicResultLabel
            // 
            this.ClassicResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClassicResultLabel.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ClassicResultLabel.Location = new System.Drawing.Point(16, 27);
            this.ClassicResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClassicResultLabel.Name = "ClassicResultLabel";
            this.ClassicResultLabel.Size = new System.Drawing.Size(459, 188);
            this.ClassicResultLabel.TabIndex = 0;
            this.ClassicResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassicRestartBtn
            // 
            this.ClassicRestartBtn.Location = new System.Drawing.Point(39, 242);
            this.ClassicRestartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassicRestartBtn.Name = "ClassicRestartBtn";
            this.ClassicRestartBtn.Size = new System.Drawing.Size(116, 38);
            this.ClassicRestartBtn.TabIndex = 1;
            this.ClassicRestartBtn.Text = "Restart";
            this.ClassicRestartBtn.UseVisualStyleBackColor = true;
            this.ClassicRestartBtn.Click += new System.EventHandler(this.ClassicRestartBtn_Click);
            // 
            // ClassicMenuBtn
            // 
            this.ClassicMenuBtn.Location = new System.Drawing.Point(183, 242);
            this.ClassicMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassicMenuBtn.Name = "ClassicMenuBtn";
            this.ClassicMenuBtn.Size = new System.Drawing.Size(116, 38);
            this.ClassicMenuBtn.TabIndex = 2;
            this.ClassicMenuBtn.Text = "Main menu";
            this.ClassicMenuBtn.UseVisualStyleBackColor = true;
            this.ClassicMenuBtn.Click += new System.EventHandler(this.ClassicMenuBtn_Click);
            // 
            // ClassicQuitBtn
            // 
            this.ClassicQuitBtn.Location = new System.Drawing.Point(321, 242);
            this.ClassicQuitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassicQuitBtn.Name = "ClassicQuitBtn";
            this.ClassicQuitBtn.Size = new System.Drawing.Size(116, 38);
            this.ClassicQuitBtn.TabIndex = 3;
            this.ClassicQuitBtn.Text = "Quit";
            this.ClassicQuitBtn.UseVisualStyleBackColor = true;
            this.ClassicQuitBtn.Click += new System.EventHandler(this.ClassicQuitBtn_Click);
            // 
            // ClassicGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_5liza.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 313);
            this.Controls.Add(this.ClassicQuitBtn);
            this.Controls.Add(this.ClassicMenuBtn);
            this.Controls.Add(this.ClassicRestartBtn);
            this.Controls.Add(this.ClassicResultLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClassicGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassicGameResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ClassicResultLabel;
        private System.Windows.Forms.Button ClassicRestartBtn;
        private System.Windows.Forms.Button ClassicMenuBtn;
        private System.Windows.Forms.Button ClassicQuitBtn;
    }
}