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
    public partial class GameResult : Form
    {
        public Form1 form1 = new Form1();
        public Game gameObj = new Game();

        PlayerMode obj = new PlayerMode(2);

        public GameResult()
        {
            InitializeComponent();

            Name1ResultLabel.Text = UserData.player1;
            Name2ResultLabel.Text = UserData.player2;
            Score1ResultLabel.Text = Game.score1.ToString();
            Score2ResultLabel.Text = Game.score2.ToString();
            

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sistema = new Form1();
            sistema.ShowDialog();
            this.Close();

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void RestarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            gameObj.ShowDialog();
            obj.initialize_game();
        }
    }
}
