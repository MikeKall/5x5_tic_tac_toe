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
    public partial class Game : Form
    {
        PlayerMode vs_player_classic = new PlayerMode(1);
        PlayerMode vs_player_arcade = new PlayerMode(2);
        ComputerMode vs_computer_classic = new ComputerMode(1);
        ComputerMode vs_computer_arcade = new ComputerMode(2);
        public static int score1=0;
        public static int score2=0;
        public static int who_wins = 0;

        PictureBox[,] picturebox_array =new PictureBox [5,5];
        Button[,] button_array = new Button[5, 5];

        public Game()
        {
            //============================
            InitializeComponent();
            if (Form1.classic_player_radio)
            {
                timer1.Start();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                player_score_1_picbox.Visible = false;
                player_score_2_picbox.Visible = false;
                label_player_1.Text = UserData.player1;
                label_player_2.Text = UserData.player2;
            }
            else if (Form1.arcade_player_radio)
            {
                timer1.Stop();
                timer2.Start();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                player_score_1_picbox.Visible = true;
                player_score_2_picbox.Visible = true;
                label_player_1.Text = UserData.player1;
                label_player_2.Text = UserData.player2;
            }
            else if (Form1.classic_computer_radio)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Start();
                timer4.Start();
                timer5.Stop();
                player_score_1_picbox.Visible = false;
                player_score_2_picbox.Visible = false;
                label_player_1.Text = UserData.player1;
                label_player_2.Text = "Computer";
            }
            else if(Form1.arcade_computer_radio)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Start();
                timer5.Start();
                player_score_1_picbox.Visible = true;
                player_score_2_picbox.Visible = true;
                label_player_1.Text = UserData.player1;
                label_player_2.Text = "Computer";
            }
            //===========================

            picturebox_array[0, 0] = picbox_0_0;
            picturebox_array[0, 1] = picbox_0_1;
            picturebox_array[0, 2] = picbox_0_2;
            picturebox_array[0, 3] = picbox_0_3;
            picturebox_array[0, 4] = picbox_0_4;

            picturebox_array[1, 0] = picbox_1_0;
            picturebox_array[1, 1] = picbox_1_1;
            picturebox_array[1, 2] = picbox_1_2;
            picturebox_array[1, 3] = picbox_1_3;
            picturebox_array[1, 4] = picbox_1_4;

            picturebox_array[2, 0] = picbox_2_0;
            picturebox_array[2, 1] = picbox_2_1;
            picturebox_array[2, 2] = picbox_2_2;
            picturebox_array[2, 3] = picbox_2_3;
            picturebox_array[2, 4] = picbox_2_4;

            picturebox_array[3, 0] = picbox_3_0;
            picturebox_array[3, 1] = picbox_3_1;
            picturebox_array[3, 2] = picbox_3_2;
            picturebox_array[3, 3] = picbox_3_3;
            picturebox_array[3, 4] = picbox_3_4;

            picturebox_array[4, 0] = picbox_4_0;
            picturebox_array[4, 1] = picbox_4_1;
            picturebox_array[4, 2] = picbox_4_2;
            picturebox_array[4, 3] = picbox_4_3;
            picturebox_array[4, 4] = picbox_4_4;

            //----------------------------------

            button_array[0, 0] = btn__0_0;
            button_array[0, 1] = btn__0_1;
            button_array[0, 2] = btn__0_2;
            button_array[0, 3] = btn__0_3;
            button_array[0, 4] = btn__0_4;

            button_array[1, 0] = btn__1_0;
            button_array[1, 1] = btn__1_1;
            button_array[1, 2] = btn__1_2;
            button_array[1, 3] = btn__1_3;
            button_array[1, 4] = btn__1_4;

            button_array[2, 0] = btn__2_0;
            button_array[2, 1] = btn__2_1;
            button_array[2, 2] = btn__2_2;
            button_array[2, 3] = btn__2_3;
            button_array[2, 4] = btn__2_4;

            button_array[3, 0] = btn__3_0;
            button_array[3, 1] = btn__3_1;
            button_array[3, 2] = btn__3_2;
            button_array[3, 3] = btn__3_3;
            button_array[3, 4] = btn__3_4;

            button_array[4, 0] = btn__4_0;
            button_array[4, 1] = btn__4_1;
            button_array[4, 2] = btn__4_2;
            button_array[4, 3] = btn__4_3;
            button_array[4, 4] = btn__4_4;
        }
       

        

        public void proper_button_function(int i,int j)
        {
            if (Form1.classic_player_radio)
            {
                vs_player_classic.game_status(i, j);
                proper_image_change(i, j);
                vs_player_classic.proper_change();
            }
            else if (Form1.arcade_player_radio)
            {
                vs_player_arcade.game_status(i, j);
                proper_image_change(i, j);
                vs_player_arcade.proper_change();
            }
            else if (Form1.classic_computer_radio)
            {
                vs_computer_classic.game_status(i, j);
                proper_image_change(i, j);
                vs_computer_classic.proper_change();
            }
            else if (Form1.arcade_computer_radio)
            {
                vs_computer_arcade.game_status(i, j);
                proper_image_change(i, j);
                vs_computer_arcade.proper_change();
            }
        }
        public void proper_image_change(int i, int j)
        {
            if (Form1.classic_player_radio)
            {
                if (vs_player_classic.Pl_turn == 1)
                {
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Xpic;
                    picturebox_array[i, j].Visible = true;
                }
                else if (vs_player_classic.Pl_turn == 2)
                {
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Opic;
                    picturebox_array[i, j].Visible = true;
                }
            }
            else if(Form1.arcade_player_radio)
            {
                if (vs_player_arcade.Pl_turn == 1)
                {
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Xpic;
                    picturebox_array[i, j].Visible = true;
                }
                else if (vs_player_arcade.Pl_turn == 2)
                {
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Opic;
                    picturebox_array[i, j].Visible = true;
                }   
            }
            else if (Form1.classic_computer_radio)
            {
                if (vs_computer_classic.Pl_turn == 1)
                {
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Xpic;
                    picturebox_array[i, j].Visible = true;
                }
                else if (vs_computer_classic.Pl_turn == 2)
                {
                    
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Opic;
                    picturebox_array[i, j].Visible = true;
                }
            }
            else if (Form1.arcade_computer_radio)
            {
                if (vs_computer_arcade.Pl_turn == 1)
                {
                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Xpic;
                    picturebox_array[i, j].Visible = true;
                }
                else if (vs_computer_arcade.Pl_turn == 2)
                {

                    picturebox_array[i, j].BackgroundImage = _5liza.Properties.Resources.Opic;
                    picturebox_array[i, j].Visible = true;
                }
            }
        }
        public void proper_computer_game()
        {
            if (Form1.classic_computer_radio)
            {
                vs_computer_classic.proper_computer_play();
                proper_image_change(vs_computer_classic.K, vs_computer_classic.L);
                vs_computer_classic.proper_change();
            }
            else if (Form1.arcade_computer_radio)
            {
                vs_computer_arcade.proper_computer_play();
                proper_image_change(vs_computer_arcade.K, vs_computer_arcade.L);
                vs_computer_arcade.proper_change();
            }
        }
        private void btn__0_0_Click(object sender, EventArgs e)
        {
            proper_button_function(0, 0);
            
        }

        private void btn__0_1_Click(object sender, EventArgs e)
        {
            proper_button_function(0, 1);
            
        }

        private void btn__0_2_Click(object sender, EventArgs e)
        {
            proper_button_function(0, 2);
            
        }

        private void btn__0_3_Click(object sender, EventArgs e)
        {
            proper_button_function(0, 3);
            
        }

        private void btn__0_4_Click(object sender, EventArgs e)
        {
            proper_button_function(0, 4);
            
        }

        private void btn__1_0_Click(object sender, EventArgs e)
        {
            proper_button_function(1, 0);
            
        }

        private void btn__1_1_Click(object sender, EventArgs e)
        {
            proper_button_function(1, 1);
           
        }

        private void btn__1_2_Click(object sender, EventArgs e)
        {
            proper_button_function(1,2);
           
        }

        private void btn__1_3_Click(object sender, EventArgs e)
        {
            proper_button_function(1,3);
            
        }

        private void btn__1_4_Click(object sender, EventArgs e)
        {
            proper_button_function(1,4);
           
        }

        private void btn__2_0_Click(object sender, EventArgs e)
        {
            proper_button_function(2, 0);
          
        }

        private void btn__2_1_Click(object sender, EventArgs e)
        {
            proper_button_function(2,1);
            
        }

        private void btn__2_2_Click(object sender, EventArgs e)
        {
            proper_button_function(2, 2);
        }

        private void btn__2_3_Click(object sender, EventArgs e)
        {
            proper_button_function(2,3);
            
        }

        private void btn__2_4_Click(object sender, EventArgs e)
        {
            proper_button_function(2, 4);
        }

        private void btn__3_0_Click(object sender, EventArgs e)
        {
            proper_button_function(3,0);
            
        }

        private void btn__3_1_Click(object sender, EventArgs e)
        {
            proper_button_function(3,1);
           
        }

        private void btn__3_2_Click(object sender, EventArgs e)
        {
            proper_button_function(3, 2);
        }

        private void btn__3_3_Click(object sender, EventArgs e)
        {
            proper_button_function(3, 3);
            
        }

        private void btn__3_4_Click(object sender, EventArgs e)
        {
            proper_button_function(3,4);
           
        }

        private void btn__4_0_Click(object sender, EventArgs e)
        {
            proper_button_function(4,0);
          
        }

        private void btn__4_1_Click(object sender, EventArgs e)
        {
            proper_button_function(4,1);
           
        }

        private void btn__4_2_Click(object sender, EventArgs e)
        {
            proper_button_function(4,2); 
        }

        private void btn__4_3_Click(object sender, EventArgs e)
        {
            proper_button_function(4,3);
        }

        private void btn__4_4_Click(object sender, EventArgs e)
        {
            proper_button_function(4,4);  
        }
        private void timer1_Tick(object sender, EventArgs e)//classic, pvp timer
        {
            
            if (vs_player_classic.Game_end)
            {
                timer1.Stop();
                for(int i=0; i < 5; i++)
                {
                    for(int j = 0; j<5; j++)
                    {
                        button_array[i, j].Enabled = false;
                    }
                }
            }
            else
            {
                vs_player_classic.Win_Check();
                
                if (vs_player_classic.First_wins || vs_player_classic.Second_wins || vs_player_classic.Draw_mode)
                {
                    if (vs_player_classic.First_wins)
                    {
                        who_wins = 1;
                    }
                    else if (vs_player_classic.Second_wins)
                    {
                        who_wins = 2;
                    }
                    else if (vs_player_classic.Draw_mode)
                    {
                        who_wins = 3;
                    }
                    ClassicGameResult ClassicObj = new ClassicGameResult();
                    ClassicObj.ShowDialog();
                }
            }
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void GameMainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gameObj = new Form1();
            gameObj.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)//arcade, pvp timer
        {
            vs_player_arcade.arcade_game_terminator();
            if (vs_player_arcade.Game_end)
            {
                vs_player_arcade.initialize_game();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        button_array[i, j].Enabled = true;
                        picturebox_array[i, j].Visible = false;
                    }
                }                
            }
            else
            {
                vs_player_arcade.Win_Check();
                if (vs_player_arcade.First_score == 0)
                {
                    player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__1_;
                }
                else if(vs_player_arcade.Second_score == 0)
                {
                    player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__1_;
                }
                if (vs_player_arcade.First_wins)
                {
                    vs_player_arcade.proper_score_change();
                    if(vs_player_arcade.First_score == 10)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_player_arcade.First_score == 20)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_player_arcade.First_score == 30)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }
                }
                else if (vs_player_arcade.Second_wins)
                {
                    vs_player_arcade.proper_score_change();
                    if (vs_player_arcade.Second_score == 10)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_player_arcade.Second_score == 20)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_player_arcade.Second_score == 30)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }
                    
                }
                else if (vs_player_arcade.Draw_mode)
                {
                    vs_player_arcade.proper_score_change();
                    if (vs_player_arcade.First_score == 10)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_player_arcade.First_score == 20)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_player_arcade.First_score == 30)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }

                    if (vs_player_arcade.Second_score == 10)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_player_arcade.Second_score == 20)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_player_arcade.Second_score == 30)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }
                }
            }
            if (vs_player_arcade.Arcade_term)
            {
                score1 = vs_player_arcade.First_score;
                score2 = vs_player_arcade.Second_score;
                GameResult game_result = new GameResult();
                timer2.Stop();
                this.Hide();
                game_result.ShowDialog();
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)//classic, pve timer
        {
            if (vs_computer_classic.Game_end)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        button_array[i, j].Enabled = false;
                    }
                }
            }
            else
            {
                vs_computer_classic.Win_Check();

                if (vs_computer_classic.First_wins || vs_computer_classic.Computer_wins || vs_computer_classic.Draw_mode)
                {
                    if (vs_computer_classic.First_wins)
                    {
                        who_wins = 1;
                    }
                    else if (vs_computer_classic.Computer_wins)
                    {
                        who_wins = 2;
                    }
                    else if (vs_computer_classic.Draw_mode)
                    {
                        who_wins = 3;
                    }
                    ClassicGameResult ClassicObj = new ClassicGameResult();
                    ClassicObj.ShowDialog();
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)//Delay στο PC turn
        {
            if (vs_computer_classic.Pl_turn == 2 || vs_computer_arcade.Pl_turn == 2)
            {
                proper_computer_game();
            }            
        }

        private void timer5_Tick(object sender, EventArgs e)//arcade, pve timer
        {
            vs_computer_arcade.arcade_game_terminator();
            if (vs_computer_arcade.Game_end)
            {
                vs_computer_arcade.initialize_game();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        button_array[i, j].Enabled = true;
                        picturebox_array[i, j].Visible = false;
                    }
                }
            }
            else
            {
                vs_computer_arcade.Win_Check();
                if (vs_computer_arcade.First_score == 0)
                {
                    player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__1_;
                }
                else if (vs_computer_arcade.Computer_score == 0)
                {
                    player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__1_;
                }
                if (vs_computer_arcade.First_wins)
                {
                    vs_computer_arcade.proper_score_change();
                    if (vs_computer_arcade.First_score == 10)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_computer_arcade.First_score == 20)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_computer_arcade.First_score == 30)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }
                }
                else if (vs_computer_arcade.Computer_wins)
                {
                    vs_computer_arcade.proper_score_change();
                    if (vs_computer_arcade.Computer_score == 10)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_computer_arcade.Computer_score == 20)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_computer_arcade.Computer_score == 30)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }

                }
                else if (vs_computer_arcade.Draw_mode)
                {
                    vs_computer_arcade.proper_score_change();
                    if (vs_computer_arcade.First_score == 10)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_computer_arcade.First_score == 20)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_computer_arcade.First_score == 30)
                    {
                        player_score_1_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }

                    if (vs_computer_arcade.Computer_score == 10)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer;
                    }
                    else if (vs_computer_arcade.Computer_score == 20)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__2_;
                    }
                    else if (vs_computer_arcade.Computer_score == 30)
                    {
                        player_score_2_picbox.Image = _5liza.Properties.Resources.arcade_font_writer__3_;
                    }
                }
            }
            if (vs_computer_arcade.Arcade_term)
            {
                score1 = vs_computer_arcade.First_score;
                score2 = vs_computer_arcade.Computer_score;
                GameResult game_result = new GameResult();
                timer5.Stop();
                this.Hide();
                game_result.ShowDialog();
            }
        }
    }
}
