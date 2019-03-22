using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5liza
{
    public partial class ClassicGameResult : Form
    {
       
        Game GameObj = new Game();

        public ClassicGameResult()
        {
            InitializeComponent();
            if (Game.who_wins == 1)
            {
                ClassicResultLabel.Text = UserData.player1.ToString()+" WON!";
            }
            else if(Game.who_wins == 2)
            {
                ClassicResultLabel.Text = UserData.player2.ToString() + " WON!";
            }
            else if(Game.who_wins == 3)
            {
                ClassicResultLabel.Text = "IT'S A DRAW!";
            }
            
        }

        private void ClassicRestartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
            GameObj.ShowDialog();
            
        }

        private void ClassicMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GameObj.Dispose();
            Form1 FormObj = new Form1();
            FormObj.ShowDialog();
        }

        private void ClassicQuitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
