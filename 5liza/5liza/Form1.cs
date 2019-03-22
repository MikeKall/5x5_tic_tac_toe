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
    public partial class Form1 : Form
    {
        //----------------------------------------------------------
        //δηλωση public static bool μεταβλητών οι οποίες είναι ορατές απο 
        //όλες τις φόρμες και συνεισφέρουν στην λειτουργικότητα του παιχνιδιού
        //Βασικές επιλογές: 
        //Κλασσικό παιχνιδί(ένα παιχνιδι)
        //Arcade παιχνίδι(κερδίζει όποιος κερδίσει πρώτος 3 παιχνιδια
        //εχουμε λογικές μεταβλητές που είναι συσχετιζόμενες με τα 
        //radio button τα οποία είναι υποεπιλογές των βασικών επιλογων
        //Υποεπιλογες:
        //Να παίξεις κλασικό παιχνίδι με αντίπαλο παίχτη
        //Να παιξεις κλασσικό με αντιπαλό υπολογιστή
        //Να παίξεις arcade παιχνιδι με αντιπαλο παίχτη
        //Να παίξεις arcade παιχνιδι με αντιπαλο υπολογιστή
        public static bool classic_player_radio = false;
        public static bool classic_computer_radio = false;
        public static bool arcade_player_radio = false;
        public static bool arcade_computer_radio = false;
        //-------------------------------------------------------------------
        //κάθε κλίκ(επιλογή των εκάστοτε κουμπιων/radio button) συσχετίζεται άμμεσα με την 
        //επαλήθευση ή μη των εκάστοτε λογικών επιλογών
        //Επιπρόσθετα γίνεται enable η επιλογή ο χρήστης να πατήσει το κουμπί 
        //εκκίνησης του παιχνιδιού

        //Radio Button: Classic Computer
        private void Classic_Computer_Radio_CheckedChanged(object sender, EventArgs e)
        {
            classic_player_radio = false;
            classic_computer_radio = true;
            arcade_player_radio = false;
            arcade_computer_radio = false;
            Start_Game.Enabled = true;
        }

        //Radio Button: Arcade Player
        private void Arcade_Player_Radio_CheckedChanged(object sender, EventArgs e)
        {
            classic_player_radio = false;
            classic_computer_radio = false;
            arcade_player_radio = true;
            arcade_computer_radio = false;
            Start_Game.Enabled = true;
        }

        //Radio Button: Arcade Computer
        private void Arcade_Computer_Radio_CheckedChanged(object sender, EventArgs e)
        {
            classic_player_radio = false;
            classic_computer_radio = false;
            arcade_player_radio = false;
            arcade_computer_radio = true;
            Start_Game.Enabled = true;
        }

        //Εκκίνηση του παιχνιδιού η οποία έχει γίνει ενεργοποίηση ανν γίνει επιλογή
        //απο κάποιο radio button
        private void Start_Game_Click(object sender, EventArgs e)
        {
            //Δημιουργούμε και εμφανίζουμε μια άλλη φόρμα η οποία χρησιμοποιείται 
            //για την συλλογή κατάλληλω δεδομένων απο τον χρήστη
            UserData user_data_form = new UserData();
            user_data_form.ShowDialog();
        }    

        //Επιλογή τερματισμού παιχνιδιού η οποία καλείται απο την Environment->Exit
        //η οποία κάνει τερματισμό της καλλούσας διεργασίας και επιστρέφει στο Λ.Σ.
        //κάποια τιμή επιτυχούς η μη τερματισμού διεργασίας
        private void QuitMenuBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //Radio Button: Arcade Player
        private void Classic_Player_Radio_CheckedChanged(object sender, EventArgs e)
        {
            classic_player_radio = true;
            classic_computer_radio = false;
            arcade_player_radio = false;
            arcade_computer_radio = false;
            Start_Game.Enabled = true;
        }

        //Button: Arcade
        private void Arcade_Btn_Click(object sender, EventArgs e)
        {
            Start_Game.Enabled = false;
            Classic_Player_Radio.Visible = false;
            Classic_Computer_Radio.Visible = false;
            Arcade_Player_Radio.Visible = true;
            Arcade_Computer_Radio.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();

            Start_Game.Enabled = false;
        }
        //Button: Classic
        private void Classic_Btn_Click(object sender, EventArgs e)
        {
            Start_Game.Enabled = false;
            Classic_Player_Radio.Visible = true;
            Classic_Computer_Radio.Visible = true;
            Arcade_Player_Radio.Visible = false;
            Arcade_Computer_Radio.Visible = false;
        }
        
    }
}
