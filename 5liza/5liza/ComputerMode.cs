using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5liza
{
    class ComputerMode
    {
        private int[,] position;
        private bool[] draw_array;
        private bool[] computer_check_offence;
        private bool[] computer_check_defence;
        private int[] x_sum;
        private int pl_turn;
        private bool first_wins;
        private bool computer_wins;
        private bool draw_mode;
        private bool game_end;
        private int first_score;
        private int computer_score;
        private bool arcade_term;
        private int k;
        private int l;
        private bool anazitisi = true;
        private int move_counter;
        private int[] counter_x_grammi;
        private int[] counter_x_stili;

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
        public bool Computer_wins
        {
            get
            {
                return computer_wins;
            }
            set
            {
                computer_wins = value;
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
        public int Computer_score
        {
            get
            {
                return computer_score;
            }
            set
            {
                computer_score = value;
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
        public int K
        {
            get
            {
                return k;
            }
            set
            {
                k = value;
            }
        }
        public int L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        public ComputerMode(int mode)
        {
            if (mode == 1)
            {
                //computer_classic_mode
                pl_turn = 1;
                first_wins = false;
                computer_wins = false;
                draw_mode = false;
                game_end = false;
                
                position = new int[5, 5];
                draw_array = new bool[12];
                computer_check_offence = new bool[12];
                computer_check_defence = new bool[12];
                x_sum = new int[12];
                move_counter = 0;
                for (int i = 0; i < 12; i++)
                {
                    draw_array[i] = false;
                    computer_check_offence[i] = false;
                    computer_check_defence[i] = false;
                    x_sum[i] = 0;
                }
                //-------------------------------------
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        position[i, j] = 0;
                    }
                }
                //--------------------------------------
            }
            else if (mode == 2)
            {
                //player_arcade_mode
                move_counter = 0;
                pl_turn = 1;
                first_wins = false;
                computer_wins = false;
                draw_mode = false;
                game_end = false;
                
                position = new int[5, 5];
                draw_array = new bool[12];
                x_sum = new int[12];
                computer_check_offence = new bool[12];
                computer_check_defence = new bool[12];
                for (int i = 0; i < 12; i++)
                {
                    draw_array[i] = false;
                    computer_check_offence[i] = false;
                    computer_check_defence[i] = false;
                    x_sum[i] = 0;
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
                computer_score = 0;
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
                    computer_wins = false;
                    draw_mode = false;
                    break;
                }
                if (checker_O_hor == 5)
                {
                    game_end = true;
                    first_wins = false;
                    computer_wins = true;
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
                computer_wins = false;
                draw_mode = false;
            }
            if (checker_O_diag1 == 5 || checker_O_diag2 == 5)
            {
                game_end = true;
                first_wins = false;
                computer_wins = true;
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
                    computer_wins = false;
                    draw_mode = false;
                    break;
                }
                if (checker_O_ver == 5)
                {
                    game_end = true;
                    first_wins = false;
                    computer_wins = true;
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
            for(int i = 0; i < 11; i++)
            {
                draw_array[i] = false;
            }
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
                computer_wins = false;
                draw_mode = true;
            }
        }
        public void proper_score_change()
        {
            if (first_wins)
            {
                first_score += 10;
            }
            else if (computer_wins)
            {
                computer_score += 10;
            }
            else if (draw_mode)
            {
                first_score += 10;
                computer_score += 10;
            }
        }
        public void arcade_game_terminator()
        {
            //arcade_Schwarzenegger
            if ((first_score == 30) || (computer_score == 30) || (first_score == 30 && computer_score == 30))
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
            computer_wins = false;
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
        public void proper_computer_play()
        {
            counter_x_grammi = new int [5];
            counter_x_stili = new int[5];

            //πρωτη επιλογή υπολογιστη
            //μια απο τις γωνιες ή κεντρο με random επιλογη
            Random proti_epilogi = new Random();
            if (move_counter == 0)
            {
                while (anazitisi)
                {
                    int thesi = proti_epilogi.Next(1, 5);
                    if ((position[2, 2] == 0) && (thesi == 1))//κεντρο(κενο?)
                    {
                        position[2, 2] = 2;
                        k = 2;
                        l = 2;
                        anazitisi = false;
                    }
                    else if ((position[0, 0] == 0) && (thesi == 2))//πανω αριστερη γωνια(κενο?)
                    {
                        position[0, 0] = 2;
                        k = 0;
                        l = 0;
                        anazitisi = false;
                    }
                    else if ((position[0, 4] == 0) && (thesi == 3))//κατω αριστερη γωνια(κενο?)
                    {
                        position[0, 4] = 2;
                        k = 0;
                        l = 4;
                        anazitisi = false;
                    }
                    else if ((position[4, 0] == 0) && (thesi == 4))//πανω δεξια γωνια(κενο?)
                    {
                        position[4, 0] = 2;
                        k = 4;
                        l = 0;
                        anazitisi = false;
                    }
                    else if ((position[4, 4] == 0) && (thesi == 5))//κατω δεξια γωνια(κενο?)
                    {
                        position[4, 4] = 2;
                        k = 4;
                        l = 4;
                        anazitisi = false;
                    }
                }
            }
            //δευτερη τυχαια Random 
            if (move_counter == 1)
            {
                Random deuteri = new Random();
                bool sinexise = true;
                while (sinexise)//συνεχιζει μεχρι να βρει κενο κουτί
                {
                    int line = deuteri.Next(0, 4);
                    int row = deuteri.Next(0, 4);
                    if (position[line, row] == 0)
                    {
                        position[line, row] = 2;
                        k = line;
                        l = row;
                        sinexise = false;
                    }
                }

                //Arxikopoihsh twn metavlitwn aminas
                for (int i = 0; i < 5; i++)
                {
                    counter_x_grammi[i] = 0;
                }

                for (int i = 0; i < 5; i++)
                {
                    counter_x_stili[i] = 0;
                }
               
            }
            if (move_counter > 1)
            {
                for (int i = 0; i < 12; i++)
                {
                    computer_check_offence[i] = false;
                    computer_check_defence[i] = false;
                }
                //ελεγχος για επομενη κινηση κατα γραμμη
                for (int i = 0; i < 5; i++)
                {
                    bool temp_x_grammi = false;//Μεταβλητη που λεει αν υπαρχει Χ στην γραμμη που κοιταμε
                    bool temp_o_grammi = false;//Μεταβλητη που λεει αν υπαρχει Ο στην γραμμη που κοιταμε
                    bool temp_zero_grammi = true;//Μεταβλητη που λεει αν η γραμμη ειναι κενη
                    //counter_x_grammi[i] = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (position[i, j] == 1)
                        {
                            x_sum[i]++;
                            temp_x_grammi = true;
                            temp_zero_grammi = false;
                        }
                        else if (position[i, j] == 2)
                        {
                            temp_o_grammi = true;
                            temp_zero_grammi = false;
                        }
                    }//Αν στην γραμμη δεν υπαρχει Χ, και υπαρχει Ο ή ειναι κενη
                    if ((temp_x_grammi == false) && ((temp_o_grammi == true) || (temp_zero_grammi == true)))
                    {
                        computer_check_offence[i] = true;//Τοτε η γραμμη αυτη ειναι καταλληλη για την επομενη κινηση του υπολογιστη
                    }
                    else if ((temp_x_grammi == true)&&(temp_o_grammi==false))
                    {
                        computer_check_defence[i] = true;
                    }
                }
                //στηλες
                for (int j = 0; j < 5; j++)
                {
                    bool temp_x_stili = false;//Μεταβλητη που λεει αν υπαρχει Χ στην στηλη που κοιταμε
                    bool temp_o_stili = false;//Μεταβλητη που λεει αν υπαρχει Ο στην στηλη που κοιταμε
                    bool temp_zero_stili = true;//Μεταβλητη που λεει αν η στηλη ειναι κενη
                    for (int i = 0; i < 5; i++)
                    {
                        if (position[i, j] == 1)
                        {
                            temp_x_stili = true;
                            temp_zero_stili = false;
                            x_sum[j+5]++;
                        }
                        else if (position[i, j] == 2)
                        {
                            temp_o_stili = true;
                            temp_zero_stili = false;
                        }
                    }//Αν στην στηλη δεν υπαρχει Χ, και υπαρχει Ο ή ειναι κενη
                    if ((temp_x_stili == false) && (temp_o_stili == true)||(temp_zero_stili==true))
                    {
                        computer_check_offence[j + 5] = true;//Τοτε η γραμμη αυτη ειναι καταλληλη για την επομενη κινηση του υπολογιστη
                    }
                    else if ((temp_x_stili == true)&&(temp_o_stili==false))
                    {
                        computer_check_defence[j + 5] = true;
                    }
                }
                //κυρια διαγωνιος
                bool temp_x_diag1 = false;//Μεταβλητη που λεει αν υπαρχει Χ στην διαγωνιο που κοιταμε
                bool temp_o_diag1 = false;//Μεταβλητη που λεει αν υπαρχει Ο στην διαγωνιο που κοιταμε
                bool temp_zero_diag1 = true;//Μεταβλητη που λεει αν η διαγωνιος ειναι κενη
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((i == j) && (position[i, j] == 1))
                        {
                            temp_x_diag1 = true;
                            temp_zero_diag1 = false;
                            x_sum[10]++;
                        }
                        else if ((i == j) && (position[i, j] == 2))
                        {
                            temp_o_diag1 = true;
                            temp_zero_diag1 = false;
                        }
                    }
                }
                if ((temp_x_diag1 == false) && (temp_o_diag1 == true)||(temp_zero_diag1==true))
                {
                    computer_check_offence[10] = true;
                }
                else if ((temp_x_diag1 == true)&&(temp_o_diag1==false))
                {
                    computer_check_defence[10] = true;
                }
                //δευτερευουσα διαγωνιος
                bool temp_x_diag2 = false;
                bool temp_o_diag2 = false;
                bool temp_zero_diag2 = true;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((i + j == 4) && (position[i, j] == 1))
                        {
                            temp_x_diag2 = true;
                            temp_zero_diag2 = false;
                            x_sum[11]++;
                        }
                        else if ((i + j == 4) && (position[i, j] == 2))
                        {
                            temp_o_diag2 = true;
                            temp_zero_diag2 = false;
                        }
                    }
                }
                if ((temp_x_diag2 == false) && (temp_o_diag2 == true)||(temp_zero_diag2==true))
                {
                    computer_check_offence[11] = true;
                }
                else if((temp_x_diag2 == true)&&(temp_o_diag2==false))
                {
                    computer_check_defence[11] = true;
                }

                
                //ληψη αποφασης 
                bool keep_rolling = true;
                while (keep_rolling)
                {
                    int flag_offence = -1;//Επιλογη θεσης χτυπηματος(Το κουτακι που θα παιξει ο υπολογιστης)
                    int flag_defence = -1;//Επιλογη θεσης αμυνας(Το κουτακι που θα παιξει ο υπολογιστης για να μην κανει 5αδα ο παικτης)
                    for (int i = 0; i < 12; i++)
                    {
                        if (computer_check_offence[i] == true)
                        {
                            flag_offence = i;    
                            break;
                        }    
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        if ((x_sum[i] > 3)&&(computer_check_defence[i]==true))
                        {
                            flag_defence = i;
                        }
                    }
                    //-----------------------------------
                    if (flag_defence > -1)
                    {
                        if (flag_defence < 5)//Αν flag<5 σημαινει οτι εχει τιμη του x (Πινακας x,y)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (position[flag_defence, j] == 0)
                                {
                                    position[flag_defence, j] = 2;
                                    k = flag_defence;
                                    l = j;
                                   
                                    keep_rolling = false;
                                    break;
                                }
                            }
                        }
                        else if (flag_defence < 10)//Αν flag>5 flag<10 σημαινει οτι εχει τιμη του y (Πινακας x,y)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (position[i, flag_defence - 5] == 0)
                                {
                                    position[i, flag_defence - 5] = 2;
                                    k = i;
                                    l = flag_defence - 5;
                                    
                                    keep_rolling = false;
                                    break;
                                }
                            }
                        }
                        else if (flag_defence == 10)//Κυρια διαγωνιος
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (position[i, j] == 0 && i == j)
                                    {
                                        position[i, j] = 2;
                                        k = i;
                                        l = j;
                                       
                                        keep_rolling = false;
                                        break;
                                    }
                                }
                                if (keep_rolling == false)
                                {
                                    break;
                                }
                            }
                        }
                        else if (flag_defence == 11)//Δευτερευουσα διαγωνιος
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if ((position[i, j] == 0) && (i + j == 4))
                                    {
                                        position[i, j] = 2;
                                        k = i;
                                        l = j;
                                        
                                        keep_rolling = false;
                                        break;
                                    }
                                }
                                if (keep_rolling == false)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //-----------------------------------
                    else if (flag_offence > -1)
                    {
                        if (flag_offence < 5)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (position[flag_offence, j] == 0)
                                {
                                    position[flag_offence, j] = 2;
                                    k = flag_offence;
                                    l = j;
                                    
                                    keep_rolling = false;
                                    break;
                                 }
                            }
                        }
                        else if (flag_offence < 10)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (position[i, flag_offence - 5] == 0)
                                {
                                    position[i, flag_offence - 5] = 2;
                                    k = i;
                                    l = flag_offence - 5;
                                    
                                    keep_rolling = false;
                                    break;
                                }
                            }
                        }
                        else if (flag_offence == 10)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (position[i, j] == 0 && i == j)
                                    {
                                        position[i, j] = 2;
                                        k = i;
                                        l = j;
                                        
                                        keep_rolling = false;
                                        break;
                                     }
                                }
                                if (keep_rolling == false)
                                {
                                    break;
                                }
                            }
                        }
                        else if (flag_offence == 11)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if ((position[i, j] == 0) && (i + j == 4))
                                    {
                                        position[i, j] = 2;
                                        k = i;
                                        l = j;
                                        keep_rolling = false;
                                        break;
                                    }
                                }
                                if (keep_rolling == false)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else//Αν για καποιον λογο δεν εχει αλλαξει ουτε το flag offence ουτε το flag defence, κανει κινηση στο πρωτο κενο κουτακι που θα βρει(Προληπτικο)
                    {
                        for(int i=0;i<5; i++)
                        {
                            for(int j = 0; j < 5; j++)
                            {
                                if (position[i, j] == 0)
                                {
                                    position[i, j] = 2;
                                    k = i;
                                    l = j;
                                    keep_rolling = false;
                                    break;
                                }
                            }
                            if (keep_rolling == false)
                            {
                                break;
                            }
                        }
                    }
                }  
            }
            move_counter++;
        }
    }
}

