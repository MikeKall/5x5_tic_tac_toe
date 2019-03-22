using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5liza
{
    class PlayerMode 
    {
        private int[,] position;
        private bool[] draw_array;
        private int pl_turn;
        private bool first_wins;
        private bool second_wins;
        private bool draw_mode;
        private bool game_end;
        private int first_score;
        private int second_score;
        private bool arcade_term;

        public int Pl_turn
        {
            get
            {
                return pl_turn;
            }
            set
            {
                pl_turn = value;
            }
        }
        public bool First_wins
        {
            get
            {
                return first_wins;
            }
            set
            {
                first_wins = value;
            }
        }
        public bool Second_wins
        {
            get
            {
                return second_wins;
            }
            set
            {
                second_wins = value;
            }
        }
        public bool Draw_mode
        {
            get
            {
                return draw_mode;
            }
            set
            {
                draw_mode = value;
            }
        }
        public bool Game_end
        {
            get
            {
                return game_end;
            }
            set
            {
                game_end = value;
            }
        }
        public int First_score
        {
            get
            {
                return first_score;
            }
            set
            {
                first_score = value;
            }
        }
        public int Second_score
        {
            get
            {
                return second_score;
            }
            set
            {
                second_score = value;
            }
        }
        public bool Arcade_term
        {
            get
            {
                return arcade_term;
            }
            set
            {
                arcade_term = value;
            }
        }
        //Constructor
        public PlayerMode(int mode)
        {
            if (mode == 1)
            {
                //player_classic_mode
                pl_turn = 1;
                first_wins = false;
                second_wins = false;
                draw_mode = false;
                game_end = false;
                position = new int[5, 5];
                draw_array = new bool[12];
                for (int i = 0; i < 12; i++)
                {
                    draw_array[i] = false;
                }
                //-------------------------------------
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        position[i, j] = 0;
                    }
                }
            }
            else if (mode == 2)
            {
                //player_arcade_mode
                pl_turn = 1;
                first_wins = false;
                second_wins = false;
                draw_mode = false;
                game_end = false;
                position = new int[5, 5];
                draw_array = new bool[12];
                for (int i = 0; i < 12; i++)
                {
                    draw_array[i] = false;
                }
                //-------------------------------------
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        position[i, j] = 0;
                    }
                }
                first_score = 0;
                second_score = 0;
                arcade_term = false;
            }
        }

        public void proper_change()
        {
            if (pl_turn == 1)
            {
                pl_turn = 2;
            }
            else if (pl_turn == 2)
            {
                pl_turn = 1;
            }
        }

        public void game_status(int i, int j)
        {
            if (pl_turn == 1)
            {
                position[i, j] = 1;
            }
            else if (pl_turn == 2)
            {
                position[i, j] = 2;
            }
        }

        public void Win_Check()
        {
            int checker_X_hor = 0;
            int checker_O_hor = 0;
            int checker_X_ver = 0;
            int checker_O_ver = 0;
            int checker_X_diag1 = 0;
            int checker_O_diag1 = 0;
            int checker_X_diag2 = 0;
            int checker_O_diag2 = 0;
            for (int i = 0; i < 5; i++)
            {
                checker_X_hor = 0;
                checker_O_hor = 0;
                for (int j = 0; j < 5; j++)
                {
                    //Ελεγχος για 5 Ο ή Χ στην διαγωνιο 1
                    if ((i == j) && (position[i, j] == 1))
                    {
                        checker_X_diag1++;
                    }
                    else if ((i == j) && (position[i, j] == 2))
                    {
                        checker_O_diag1++;
                    }
                    //-----------------------------------
                    //Ελεγχος για 5 Ο ή Χ στην διαγωνιο 2
                    if ((i + j == 4) && (position[i, j] == 2))
                    {
                        checker_O_diag2++;
                    }
                    else if ((i + j == 4) && (position[i, j] == 1))
                    {
                        checker_X_diag2++;
                    }
                    //-----------------------------
                    //Ελεγχος για 5 Ο ή Χ οριζοντια
                    if (position[i, j] == 1)
                    {
                        checker_X_hor++;
                    }
                    else if (position[i, j] == 2)
                    {
                        checker_O_hor++;
                    }
                    //-----------------------------
                }
                //Ελεγχος για νικη οριζοντια
                if (checker_X_hor == 5)
                {
                    game_end = true;
                    first_wins = true;
                    second_wins = false;
                    draw_mode = false;
                    break;
                }
                if (checker_O_hor == 5)
                {
                    game_end = true;
                    first_wins = false;
                    second_wins = true;
                    draw_mode = false;
                    break;
                }
                //---------------------------
            }
            //Ελεγχος για νικη στις διαγωνιους
            if (checker_X_diag1 == 5 || checker_X_diag2 == 5)
            {
                game_end = true;
                first_wins = true;
                second_wins = false;
                draw_mode = false;
            }
            if (checker_O_diag1 == 5 || checker_O_diag2 == 5)
            {
                game_end = true;
                first_wins = false;
                second_wins = true;
                draw_mode = false;
            }
            //------------------------
            for (int j = 0; j < 5; j++)
            {
                checker_X_ver = 0;
                checker_O_ver = 0;
                for (int i = 0; i < 5; i++)
                {
                    //Ελεγχος για 5 Ο ή Χ κάθετα
                    if (position[i, j] == 1)
                    {
                        checker_X_ver++;
                    }
                    else if (position[i, j] == 2)
                    {
                        checker_O_ver++;
                    }
                    //-------------------------------
                }
                //Ελεγχος για νικη καθετα
                if (checker_X_ver == 5)
                {
                    game_end = true;
                    first_wins = true;
                    second_wins = false;
                    draw_mode = false;
                    break;
                }
                if (checker_O_ver == 5)
                {
                    game_end = true;
                    first_wins = false;
                    second_wins = true;
                    draw_mode = false;
                    break;
                }
                //----------------------------------
            }
            //Eλεγχος για ισοπαλια 
            draw_check_total();
        }

        public void draw_check_total()
        {
            //ελεγχος ισοπαλίας στις γραμμες
            for (int i = 0; i < 5; i++)
            {
                bool temp_x_grammi = false;
                bool temp_o_grammi = false;
                for (int j = 0; j < 5; j++)
                {
                    if (position[i, j] == 1)
                    {
                        temp_x_grammi = true;
                    }
                    else if (position[i, j] == 2)
                    {
                        temp_o_grammi = true;
                    }
                }
                if ((temp_x_grammi == true) && (temp_o_grammi == true))
                {
                    draw_array[i] = true;

                }
            }
            //ελεγχος ισοπαλίας στις στηλες
            for (int j = 0; j < 5; j++)
            {
                bool temp_x_stili = false;
                bool temp_o_stili = false;
                for (int i = 0; i < 5; i++)
                {
                    if (position[i, j] == 1)
                    {
                        temp_x_stili = true;
                    }
                    else if (position[i, j] == 2)
                    {
                        temp_o_stili = true;
                    }
                }
                if ((temp_x_stili == true) && (temp_o_stili == true))
                {
                    draw_array[j + 5] = true;
                }
            }
            //ελεγχος ισοπαλίας στην κυρια διαγώνιο
            bool temp_x_diag1 = false;
            bool temp_o_diag1 = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i == j) && (position[i, j] == 1))
                    {
                        temp_x_diag1 = true;
                    }
                    else if ((i == j) && (position[i, j] == 2))
                    {
                        temp_o_diag1 = true;
                    }
                }
            }
            if ((temp_x_diag1 == true) && (temp_o_diag1 == true))
            {
                draw_array[10] = true;
            }
            //ελεγχος ισοπαλίας στην δευτερεύουσα διαγώνιο
            bool temp_x_diag2 = false;
            bool temp_o_diag2 = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j == 4) && (position[i, j] == 1))
                    {
                        temp_x_diag2 = true;
                    }
                    else if ((i + j == 4) && (position[i, j] == 2))
                    {
                        temp_o_diag2 = true;
                    }
                }
            }
            if ((temp_x_diag2 == true) && (temp_o_diag2 == true))
            {
                draw_array[11] = true;
            }
            //καθολικός έλεγχος ισσοπαλίας
            int draw = 0;
            for (int i = 0; i < 12; i++)
            {
                if (draw_array[i] == true)
                {
                    draw++;
                }
            }
            if (draw == 12)
            {
                game_end = true;
                first_wins = false;
                second_wins = false;
                draw_mode = true;
            }
        }

        public void proper_score_change()
        {
            if (first_wins)
            {
                first_score += 10;
            }
            else if (second_wins)
            {
                second_score += 10;
            }
            else if (draw_mode)
            {
                first_score += 10;
                second_score += 10;
            }
        } 

        public void arcade_game_terminator()
        {
            //arcade_Schwarzenegger
            if ((first_score == 30) || (second_score == 30) || (first_score == 30 && second_score == 30))
            {
                arcade_term = true;
            }
            else
            {
                arcade_term = false;
            }
        }

        public void initialize_game()
        {
            //player_arcade_mode
            pl_turn = 1;
            first_wins = false;
            second_wins = false;
            draw_mode = false;
            game_end = false;
            position = new int[5, 5];
            draw_array = new bool[12];

            for (int i = 0; i < 12; i++)
            {
                draw_array[i] = false;
            }
            //-------------------------------------

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    position[i, j] = 0;
                }
            }
            arcade_term = false;
        }
    }
}
