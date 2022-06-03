using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        bool turn = true; //true = x turn; false = y turn
        int turn_count = 0; 
  
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            Winnercheck();
        }

        private void Winnercheck()
        {
           bool there_is_a_winner = false;

            //horizontal checks
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                there_is_a_winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                there_is_a_winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                there_is_a_winner = true;

            //vertical checks
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                there_is_a_winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                there_is_a_winner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                there_is_a_winner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {


                DisableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " wins!", "Congratulations");
                     
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();

            
            }

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("It's a draw!", "Hmm..");
            }

        }//end Winnercheck

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            }//end foreach

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
