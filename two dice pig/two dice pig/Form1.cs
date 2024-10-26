using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_dice_pig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randomGenerator = new Random();
        //random number generator for dice rolls

        public struct Player
        //player structure for first,second rolls and turntotal,gametotal
        {
            public int firstRoll;
            public int secondRoll;
            public int turnTotal;
            public int gameTotal;
            public string playerName;
        }

        Player p1, p2;

        public void UpdateScoreboard(Player p1, Player p2)
        //updates the scoreboard for each player 
        {
            txtGameScP1.Text = p1.gameTotal.ToString();
            txtTurnScP1.Text = p1.turnTotal.ToString();

            txtGameScP2.Text = p2.gameTotal.ToString();
            txtTurnScP2.Text = p2.turnTotal.ToString();
        }


        public void UpdatePictureBoxes(Player p)
        //creates method for either player to update dicerolls
        {
            if (p.firstRoll == 1 && p.secondRoll == 1)
                //if roll is snake eyes, display a unique dice 
            {
                pbDice1.BackgroundImage = Image.FromFile("dicesnake.png");
                pbDice2.BackgroundImage = Image.FromFile("dicesnake.png");
            }
            else
            {
                pbDice1.BackgroundImage = Image.FromFile("dice0" + p.firstRoll + ".png");
                pbDice2.BackgroundImage = Image.FromFile("dice0" + p.secondRoll + ".png");
            }
            //updates first and second dice roll picture
        }

        public void DEButton()
        //method to disable and enable buttons 
        {
            if (btnHoldP1.Enabled == true && btnRollP1.Enabled == true)
            //if player 1 buttons are enabled, disable player 1 roll and hold, enable player 2 roll
            {
                btnRollP1.Enabled = false;
                btnHoldP1.Enabled = false;
                btnRollP2.Enabled = true;

            }
            else
            //if player 2 buttons are enabled, disable player 2 roll and hold, enable player 1 roll
            {
                btnRollP2.Enabled = false;
                btnHoldP2.Enabled = false;
                btnRollP1.Enabled = true;

            }
        }

        public void Winner(Player p)
            //initiates win conditions for respective player
        {
            if (p.turnTotal + p.gameTotal >= 100)
                //if player turn total and game total are equal to or above 100 (and pressed hold)
            {
                MessageBox.Show(p.playerName.ToString() + " wins!");
                //display user name and winning statement
                btnRollP1.Enabled = false;
                btnRollP2.Enabled = false;
                btnHoldP2.Enabled = false;
                btnHoldP1.Enabled = false;
                //disable buttons to prevent further play 
                pbDice1.BackgroundImage = null;
                pbDice2.BackgroundImage = null;
                //resets dice picturebox
                p1.turnTotal = 0;
                p1.gameTotal = 0;
                p2.turnTotal = 0;
                p2.gameTotal = 0;
                UpdateScoreboard(p1, p2);
                //resets all player values
                txtPlayer1.Enabled = true;
                txtPlayer2.Enabled = true;
                //allows players to put in a name for new game

                lblWinCheckP1.Text = "";
                lblWinCheckP2.Text = "";
                lblRollAnnouncer.Text = "";
                //clears wincheck label and counter display
            }
        }

        public void PName(ref Player p, int playernumber)
        //cleans the name for each player 
        {
            if (p.playerName.Trim() == "")
                //trims the player name to check if name is blank
            {
                p.playerName = "Player " + playernumber.ToString();
                //if blank, set a default playername (Player 1 / 2)
            }
            else if (p.playerName.Length > 10)
                //if player input a name, max the name by 10 characters
            {
                p.playerName = p.playerName.Remove(9, p.playerName.Length - 10);
                //removes extra characters
            }
        }

        public void RollDice(ref Player p, int playernumber)
        {
            if (p.firstRoll == 1 && p.secondRoll == 1)
            //if player rolls ones on each dice (snake eyes)
            {
                p.turnTotal = 0;
                p.gameTotal = 0;
                //clears both turn and game total
                DEButton();
                //force change turn
            }
            else if (p.firstRoll == 1 || p.secondRoll == 1)
            //if either dice lands on a one
            {
                p.turnTotal = 0;
                DEButton();
                //remove turn total and change the players turn
            }
            else if (p.firstRoll == p.secondRoll)
            //if the player rolls the same number on each dice
            {
                p.turnTotal = p.turnTotal + p.firstRoll + p.secondRoll;
                //adds their first, second, and prior score to new score
                if (playernumber == 1)
                    //if it is player 1
                {
                    btnHoldP1.Enabled = false;
                    //disable player 1 button hold
                }
                else
                {
                    btnHoldP2.Enabled = false;
                    //else disable the player 2 button hold
                }
            }
            else
            {
                p.turnTotal = p.turnTotal + p.firstRoll + p.secondRoll;
                //else its a normal roll and add the totals all together
            }
            UpdateScoreboard(p1, p2);
            //calls method to update the scoreboard
        }

        public void NumAnnouncer(Player p)
        {
            int Sum;
            Sum = p.firstRoll + p.secondRoll;
            if (p.firstRoll == 1 && p.secondRoll == 1)
            //if roll is snake eyes
            {
                lblRollAnnouncer.Text = "Snake Eyes!";
            }
            else
            {
                lblRollAnnouncer.Text = Sum.ToString();
                //showcase roll total
            }
        }

        public void ButtonColour()
            /*changes button colour based on button being disabled/enabled for clarity
             * palegreen = enabled
             * lightcoral = disabled
             */
        {
            if (btnHoldP1.Enabled == true)
            {
                btnHoldP1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnHoldP1.BackColor = Color.LightCoral;
            }

            if (btnHoldP2.Enabled == true)
            {
                btnHoldP2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnHoldP2.BackColor = Color.LightCoral;
            }

            if (btnRollP1.Enabled == true)
            {
                btnRollP1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnRollP1.BackColor = Color.LightCoral;
            }

            if (btnRollP2.Enabled == true)
            {
                btnRollP2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnRollP2.BackColor = Color.LightCoral;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //disables and clears all buttons, textbox, and label values to begin a new game
            try
            {
                btnRollP1.Enabled = true;
                btnRollP2.Enabled = false;
                btnHoldP2.Enabled = false;
                btnHoldP1.Enabled = false;
                p1.turnTotal = 0;
                p1.gameTotal = 0;
                p2.turnTotal = 0;
                p2.gameTotal = 0;
                txtPlayer1.Enabled = false;
                txtPlayer2.Enabled = false;
                UpdateScoreboard(p1, p2);
                pbDice1.BackgroundImage = null;
                pbDice2.BackgroundImage = null;
                lblWinCheckP1.Text = "";
                lblWinCheckP2.Text = "";
                lblRollAnnouncer.Text = "";
                ButtonColour();
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void btnRollP1_Click(object sender, EventArgs e)
        {
            try
            {
                p1.playerName = txtPlayer1.Text;
                //inputs the txt player 1 name into the struct
                PName(ref p1, 1);
                //cleans the name of player
                p1.firstRoll = randomGenerator.Next(1, 7);
                p1.secondRoll = randomGenerator.Next(1, 7);
                //generates separate random numbers between 1-6 
                btnHoldP1.Enabled = true;
                //enables the hold button at start of roll
                UpdatePictureBoxes(p1);
                //updates the picture box to the dice roll
                RollDice(ref p1, 1);
                //rolls the dice for player 1 

                if (btnHoldP1.Enabled == false)
                    //if the button hold for player 1 is false, remove any text present in wincheck label
                {
                    lblWinCheckP1.Text = " ";
                }
                else if (p1.turnTotal + p1.gameTotal >= 100)
                    //else notify the player they can hold to win
                {
                    lblWinCheckP1.Text = "Winning total! \r\n Press hold to win!";
                }

                NumAnnouncer(p1);
                //displays the roll total 
                ButtonColour();
                //sets the button colour if they are disabled or enabled
            }
            catch
            {
                MessageBox.Show("Error! Try Again");
                return;
            }
        }

        private void btnRollP2_Click(object sender, EventArgs e)
        {
            try
            {
                p2.playerName = txtPlayer2.Text;
                //adds the player name to struct
                PName(ref p2, 2);
                //cleans the name of player
                p2.firstRoll = randomGenerator.Next(1, 7);
                p2.secondRoll = randomGenerator.Next(1, 7);
                //generates separate random numbers between 1-6 
                btnHoldP2.Enabled = true;
                //enables button to hold after first roll on turn
                UpdatePictureBoxes(p2);
                //updates the picture box to the dice roll
                RollDice(ref p2, 2);
                //rolls the dice for player 2

                if (btnHoldP2.Enabled == false)
                //if the button hold for player 1 is false, remove any text present in wincheck label
                {
                    lblWinCheckP2.Text = " ";
                }
                else if (p2.turnTotal + p2.gameTotal >= 100)
                //if player turn total and game total equal 100 or greater, notifies the player to hold to win
                {
                    lblWinCheckP2.Text = "Winning total! \r\n Press hold to win!";
                }
                NumAnnouncer(p2);
                //displays the roll total 
                ButtonColour();
                //sets the button colour if they are disabled or enabled
            }
            catch
            {
                MessageBox.Show("Error! Try Again");
                return;
            }
        }
        private void btnHoldP2_Click(object sender, EventArgs e)
        {
            try
            {
                p2.gameTotal = p2.turnTotal + p2.gameTotal;
                //adds the turn total and prior game total to the game total 
                p2.turnTotal = 0;
                //clears the players turn total
                DEButton();
                //calls disable and enable buttons
                UpdateScoreboard(p1, p2);
                //updates scoreboard
                Winner(p2);
                //checks to see if p2 has 100 points in game total or more to win the game
                ButtonColour();
                //sets the button colour if they are disabled or enabled
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }
        private void btnHoldP1_Click(object sender, EventArgs e)
        {
            try
            {
                p1.gameTotal = p1.turnTotal + p1.gameTotal;
                //adds the turn total and prior game total to the game total 
                p1.turnTotal = 0;
                //clears the players turn total
                DEButton();
                //calls disable and enable buttons
                UpdateScoreboard(p1, p2);
                //updates scoreboard
                Winner(p1);
                //checks to see if p1 has 100 points in game total or more to win the game
                ButtonColour();
                //sets the button colour if they are disabled or enabled
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }
    }
}



