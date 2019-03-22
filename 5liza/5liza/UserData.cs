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
    public partial class UserData : Form
    {
        //Η φόρμα συλλογής στοιχείων παίχτη η οποία εμφανίζεται στον χρήστη όταν
        //έχει πατήσει το κουμπί ενεργοποίησης του παιχνιδιού
        //-------------------------------------------------------
        //Δηλώνουμε δύο public static string μεταβλητές οι οποίες είναι ορατές απο 
        //όλες τις φόρμες και περιέχουν 
        //Επιλογή 1: Το όνομα/ματα του παίχτη/των που θα παίξουν 
        //Επιλογή 2: Το αλφαριθμητικό Computer 
        //επιλογές οι οποίες επιλέγονται κατάλληλα βάση των καθολικών λογικών 
        //επιλογών της κύριας (εισαγωγικής) φορμας 
        public static string player1;
        public static string player2;
        //----------------------------------------------------------

        public UserData()
        {
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            //Γίνονται οι κατάλληλες επιλογές:
            //---------------------------------------------------
            //Αν έχει επιλεχθεί μια απο τις δυο βασικές επιλογές classic/arcade
            //με αντίπαλο παίχτη
            if (Form1.classic_player_radio || Form1.arcade_player_radio)
            {
                //εμφανίζουμε και τα δύο textbox τα οποία κατα την διάρκεια 
                //φορτωσης του προγράμματος ήταν αόρατα
                //διότι παίζουν δυο παίχτες
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            //σε διαφορετική περίπτωση ο αντίπαλος θα είναι υπολογιστής 
            else 
            {
                //συνεπώς εμφανίζουμε μόνο την μια απο τις δυο επιλογές
                textBox1.Visible = true;
                textBox2.Visible = false;
                //αποκρύπτουμε επίσης το Label που αναφέρεται στον δεύτερο παίχτη
                pictureBox2.Visible = false;
            }
        }
        //Κουμπί συνέχειας στο βασικό παιχνίδι αν και εφόσον έχουν πραγματοποιηθεί 
        //επιτυχώς κάποιοι έλεγχοι
        private void Cont_btn_Click(object sender, EventArgs e)
        {
            //Αν το πρώτο textbox δεν είναι κενό και το δεύτερο  textbox δεν είναι κενό
            //και έχει γίνει επιλογή παιχνιδιού απο την βασική φορμα μια απο 
            //τις δύο επιλογες με αντίπαλο χρήστη
            if ((!(String.IsNullOrEmpty(textBox1.Text)) && (!(String.IsNullOrEmpty(textBox2.Text))) && (Form1.classic_player_radio || Form1.arcade_player_radio)))
            {
                //εκχωρούμε τα αλφαριθμητικά στις καθολικές μεταβλητές
                player1 = textBox1.Text;
                player2 = textBox2.Text;
                //δημιουργούμε καινούριο αντικείμενο τύπου παιχνιδι
                Game game_form = new Game();
                //κλήση μεθοδων που κλείνουν την υπάρχουσα φόρμα
                this.Close();
                this.Dispose();
                //εμφάνιση της φόρμας του βασικού παιχνιδιου
                game_form.ShowDialog();
            }
            //Αν το πρώτο textbox δεν είναι κενό 
            //και έχει γίνει επιλογή παιχνιδιού απο την βασική φορμα μια απο 
            //τις δύο επιλογες με αντίπαλο υπολογιστή
            else if ((!(String.IsNullOrEmpty(textBox1.Text)) && (Form1.classic_computer_radio || Form1.arcade_computer_radio)))
            {
                //εκχωρούμε τα αλφαριθμητικά στην καθολικη μεταβλητη
                player1 = textBox1.Text;
                //εκχωρούμε στην δευτερη μεταβλητη το αλφαριθμητικό Computer
                player2 = "Computer";
                //δημιουργούμε καινούριο αντικείμενο τύπου παιχνιδι
                Game game_form = new Game();
                //κλήση μεθοδων που κλείνουν την υπάρχουσα φόρμα
                this.Close();
                this.Dispose();
                //εμφάνιση της φόρμας του βασικού παιχνιδιου
                game_form.ShowDialog();
            }
        }
    }
}
