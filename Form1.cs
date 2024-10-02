using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        bool isPlayerXTurn = true;  // to keep track of current player's turn
        int movesCount = 0;       // to keep track of the number of moves
        string winner = "";       // store the winner
        int X_score = 0;           // Track the score of player X
        int O_score = 0;        // Keep track of score of player y
        int currentRound = 1;


        // check for button1
        private void button1_Click(object sender, EventArgs e)
        {
            // Handle the click for button 1
            if (isPlayerXTurn)
            {
                button1.Text = "X"; 
            }
            else
            {
                button1.Text = "O";
            }
            button1.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  // switch turns between player x and player o
            movesCount++;

            checkForWinner1();
        }

        private void checkForWinner1()
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
               )
            {
                winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
            }
            else if (movesCount == 9)     // If all buttons are clicked and no winner
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
            
        }


        // check for button2
        private void button2_Click(object sender, EventArgs e)
        {
            if (isPlayerXTurn)
            {
                button2.Text = "X"; 
            }
            else
            {
                button2.Text = "O";
            }
            button2.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner2();
        }
        private void checkForWinner2()
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
               )
            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
            }
            else if (movesCount == 9)     
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }


        // Check for Button3
        private void button3_Click(object sender, EventArgs e)
        {
            if (isPlayerXTurn)
            {
                button3.Text = "X"; 
            }
            else
            {
                button3.Text = "O";
            }
            button3.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner3();
            
        }
        private void checkForWinner3()
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
               )
            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
            }
            else if (movesCount == 9)     
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }


        // Check for Button4
        private void button4_Click(object sender, EventArgs e)
        {
            if (isPlayerXTurn)
            {
                button4.Text = "X"; 
            }
            else
            {
                button4.Text = "O";
            }
            button4.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner4();
        }
        private void checkForWinner4()
        {
            if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") 
               )
                        
            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
            }
            else if (movesCount == 9)     
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }


        // Check for Button5
        private void button5_Click(object sender, EventArgs e)
        {    
            if (isPlayerXTurn)
            {
                button5.Text = "X"; 
            }
            else
            {
                button5.Text = "O";
            }
            button5.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner5();
        }
        private void checkForWinner5()
        {
            if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
               )

            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
                
            }
            else if (movesCount == 9)     
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }



        // check for Button6
        private void button6_Click(object sender, EventArgs e)
        {
           
            if (isPlayerXTurn)
            {
                button6.Text = "X"; 
            }
            else
            {
                button6.Text = "O";
            }
            button6.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner6();
        }
        private void checkForWinner6()
        {
            if (
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
               )

            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
                
            }
            else if (movesCount == 9)    
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }



        // Check for Button7
        private void button7_Click(object sender, EventArgs e)
        {
            if (isPlayerXTurn)
            {
                button7.Text = "X"; 
            }
            else
            {
                button7.Text = "O";
            }
            button7.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner7();
        }
        private void checkForWinner7()
        {
            if (
                (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
               )

            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
            }
            else if (movesCount == 9)     
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }



        // Check for Button8
        private void button8_Click(object sender, EventArgs e)
        {
            
            if (isPlayerXTurn)
            {
                button8.Text = "X"; 
            }
            else
            {
                button8.Text = "O";
            }
            button8.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner8();
        }
        private void checkForWinner8()
        {
            if (
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
               )

            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
                
            }
            else if (movesCount == 9)    
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }
        }


        // check for Button9
        private void button9_Click(object sender, EventArgs e)
        {
            if (isPlayerXTurn)
            {
                button9.Text = "X"; 
            }
            else
            {
                button9.Text = "O";
            }
            button9.Enabled = false; 
            isPlayerXTurn = !isPlayerXTurn;  
            movesCount++;

            checkForWinner9();
        }
        
        private void checkForWinner9()
        {
            if (
                (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
               )

            {
                 winner = isPlayerXTurn ? "O" : "X";
                MessageBox.Show($"Player {winner} wins.");
                updateScore(winner);
                disableButtons();
                updateRound();
                ClearBoard();
                
            }
            else if (movesCount == 9)    
            {
                MessageBox.Show("It's a draw!");
                updateRound();
                ClearBoard();
            }

        }



        // Code for disable Buttons
        private void disableButtons()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
        }


        // Update The Score Of each Player
        private void updateScore(string winner)
        {
            if (winner == "X")
            {
                X_score += 1;
                label_X_score.Text = X_score.ToString();
            }
            if (winner == "O")
            {
                O_score += 1;
                label_O_score.Text = O_score.ToString();
            }
        }


        // Update the Round
        
        private void updateRound()
        {
            if (winner == "X")
            {
                currentRound += 1;
                round_Updater.Text = currentRound.ToString();
            }
            else if(winner == "O")
            {
                currentRound += 1;
                round_Updater.Text = currentRound.ToString();
            }
            else if (movesCount == 9)
            {
                currentRound += 1;
                round_Updater.Text = currentRound.ToString();
            }
        }



        // Clear the current entries and go for the next round
        private void ClearBoard()
        {
            // Loop through all the controls in the form
            foreach (Control control in this.Controls)
            {
                if (control is Button) // Ensure the control is a Button
                {
                    Button btn = (Button)control;

                    // Check if the button is part of the game (exclude other buttons like a reset button)
                    if (btn.Name.StartsWith("button"))
                    {
                        btn.Text = "";    
                        btn.Enabled = true; 
                    }
                }
            }

            // Reset the game variables
            isPlayerXTurn = true;  
            movesCount = 0;        
            winner = "";           
        }


    }
}
