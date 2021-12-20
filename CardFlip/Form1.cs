using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardFlip
{
    public partial class CardFlip : Form
    {

        Board gameBoard;
        public CardFlip()
        {
            InitializeComponent();
        }
        void changeButtonColour(Color colour)
        {
            buttonTile1.ForeColor = colour;
            buttonTile2.ForeColor = colour;
            buttonTile3.ForeColor = colour;
            buttonTile4.ForeColor = colour;
            buttonTile5.ForeColor = colour;
            buttonTile6.ForeColor = colour;
            buttonTile7.ForeColor = colour;
            buttonTile8.ForeColor = colour;
            buttonTile9.ForeColor = colour;
            buttonTile10.ForeColor = colour;
            buttonTile11.ForeColor = colour;
            buttonTile12.ForeColor = colour;
            buttonTile13.ForeColor = colour;
            buttonTile14.ForeColor = colour;
            buttonTile15.ForeColor = colour;
            buttonTile16.ForeColor = colour;
            buttonTile17.ForeColor = colour;
            buttonTile18.ForeColor = colour;
            buttonTile19.ForeColor = colour;
            buttonTile20.ForeColor = colour;
            buttonTile21.ForeColor = colour;
            buttonTile22.ForeColor = colour;
            buttonTile23.ForeColor = colour;
            buttonTile24.ForeColor = colour;
            buttonTile25.ForeColor = colour;
        }

        void endGame()
        {
            changeButtonColour(Color.White);
            gameBoard.currentScore = 0;
            MessageBox.Show("Game over");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameBoard = new Board();    //create and populate the board

            gameBoard.PopulateBoard();
            //reflect the populated bord in the UI (CAN LIKELY BE DONE EASIER)
            buttonTile1.Text = Convert.ToString(gameBoard.tilesList[0].getValue());
            buttonTile2.Text = Convert.ToString(gameBoard.tilesList[1].getValue());
            buttonTile3.Text = Convert.ToString(gameBoard.tilesList[2].getValue());
            buttonTile4.Text = Convert.ToString(gameBoard.tilesList[3].getValue());
            buttonTile5.Text = Convert.ToString(gameBoard.tilesList[4].getValue());
            buttonTile6.Text = Convert.ToString(gameBoard.tilesList[5].getValue());
            buttonTile7.Text = Convert.ToString(gameBoard.tilesList[6].getValue());
            buttonTile8.Text = Convert.ToString(gameBoard.tilesList[7].getValue());
            buttonTile9.Text = Convert.ToString(gameBoard.tilesList[8].getValue());
            buttonTile10.Text = Convert.ToString(gameBoard.tilesList[9].getValue());
            buttonTile11.Text = Convert.ToString(gameBoard.tilesList[10].getValue());
            buttonTile12.Text = Convert.ToString(gameBoard.tilesList[11].getValue());
            buttonTile13.Text = Convert.ToString(gameBoard.tilesList[12].getValue());
            buttonTile14.Text = Convert.ToString(gameBoard.tilesList[13].getValue());
            buttonTile15.Text = Convert.ToString(gameBoard.tilesList[14].getValue());
            buttonTile16.Text = Convert.ToString(gameBoard.tilesList[15].getValue());
            buttonTile17.Text = Convert.ToString(gameBoard.tilesList[16].getValue());
            buttonTile18.Text = Convert.ToString(gameBoard.tilesList[17].getValue());
            buttonTile19.Text = Convert.ToString(gameBoard.tilesList[18].getValue());
            buttonTile20.Text = Convert.ToString(gameBoard.tilesList[19].getValue());
            buttonTile21.Text = Convert.ToString(gameBoard.tilesList[20].getValue());
            buttonTile22.Text = Convert.ToString(gameBoard.tilesList[21].getValue());
            buttonTile23.Text = Convert.ToString(gameBoard.tilesList[22].getValue());
            buttonTile24.Text = Convert.ToString(gameBoard.tilesList[23].getValue());
            buttonTile25.Text = Convert.ToString(gameBoard.tilesList[24].getValue());

            //Hide all values to begin with(CAN LIKELY BE DONE EASIER)
            changeButtonColour(System.Drawing.Color.Gray);
            


            //retrieve values for total row labels
            labelRowTotal1.Text = "Total: " + Convert.ToString(gameBoard.sumRows[0]);
            labelRowTotal2.Text = "Total: " + Convert.ToString(gameBoard.sumRows[1]);
            labelRowTotal3.Text = "Total: " + Convert.ToString(gameBoard.sumRows[2]);
            labelRowTotal4.Text = "Total: " + Convert.ToString(gameBoard.sumRows[3]);
            labelRowTotal5.Text = "Total: " + Convert.ToString(gameBoard.sumRows[4]);

            //do the same for bomb totals
            labelRowBombs1.Text = "Bombs: " + Convert.ToString(gameBoard.bombRows[0]);
            labelRowBombs2.Text = "Bombs: " + Convert.ToString(gameBoard.bombRows[1]);
            labelRowBombs3.Text = "Bombs: " + Convert.ToString(gameBoard.bombRows[2]);
            labelRowBombs4.Text = "Bombs: " + Convert.ToString(gameBoard.bombRows[3]);
            labelRowBombs5.Text = "Bombs: " + Convert.ToString(gameBoard.bombRows[4]);

            //retrieve values for total col labels
            labelColTotal1.Text = "Total: " + Convert.ToString(gameBoard.sumCols[0]);
            labelColTotal2.Text = "Total: " + Convert.ToString(gameBoard.sumCols[1]);
            labelColTotal3.Text = "Total: " + Convert.ToString(gameBoard.sumCols[2]);
            labelColTotal4.Text = "Total: " + Convert.ToString(gameBoard.sumCols[3]);
            labelColTotal5.Text = "Total: " + Convert.ToString(gameBoard.sumCols[4]);

            //do the same for bomb totals
            labelColBombs1.Text = "Bombs: " + Convert.ToString(gameBoard.bombCols[0]);
            labelColBombs2.Text = "Bombs: " + Convert.ToString(gameBoard.bombCols[1]);
            labelColBombs3.Text = "Bombs: " + Convert.ToString(gameBoard.bombCols[2]);
            labelColBombs4.Text = "Bombs: " + Convert.ToString(gameBoard.bombCols[3]);
            labelColBombs5.Text = "Bombs: " + Convert.ToString(gameBoard.bombCols[4]);
        }

        private void buttonTile1_Click(object sender, EventArgs e )
        {
            if (buttonTile1.Text == "0") //if it is a bomb end the game
            {
                buttonTile1.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile1.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile1.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
            }
        }

        private void buttonTile2_Click(object sender, EventArgs e)
        {
            if (buttonTile2.Text == "0") //if it is a bomb end the game
            {
                buttonTile2.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile2.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile2.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
            }
        }

        private void buttonTile3_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile3.BackColor == Color.Green)
            {
                buttonTile3.BackColor = Color.Gray;
                buttonTile3.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile3.BackColor == Color.Gray)
            {
                buttonTile3.BackColor = Color.Green;
                buttonTile3.ForeColor = Color.Green;
            }
            else if (buttonTile3.Text == "0") //if it is a bomb end the game
            {
                buttonTile3.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile3.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile3.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile3.Enabled = false;
            }
        }

        private void buttonTile4_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile4.BackColor == Color.Green)
            {
                buttonTile4.BackColor = Color.Gray;
                buttonTile4.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile4.BackColor == Color.Gray)
            {
                buttonTile4.BackColor = Color.Green;
                buttonTile4.ForeColor = Color.Green;
            }
            else if (buttonTile4.Text == "0") //if it is a bomb end the game
            {
                buttonTile4.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile4.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile4.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile4.Enabled = false;
            }
        }

        private void buttonTile5_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile5.BackColor == Color.Green)
            {
                buttonTile5.BackColor = Color.Gray;
                buttonTile5.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile5.BackColor == Color.Gray)
            {
                buttonTile5.BackColor = Color.Green;
                buttonTile5.ForeColor = Color.Green;
            }
            else if (buttonTile5.Text == "0") //if it is a bomb end the game
            {
                buttonTile5.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile5.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile5.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile5.Enabled = false;
            }
        }

        private void buttonTile6_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile6.BackColor == Color.Green)
            {
                buttonTile6.BackColor = Color.Gray;
                buttonTile6.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile6.BackColor == Color.Gray)
            {
                buttonTile6.BackColor = Color.Green;
                buttonTile6.ForeColor = Color.Green;
            }

            else if (buttonTile6.Text == "0") //if it is a bomb end the game
            {
                buttonTile6.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile6.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile6.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile6.Enabled = false;
            }
        }

        private void buttonTile7_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile7.BackColor == Color.Green)
            {
                buttonTile7.BackColor = Color.Gray;
                buttonTile7.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile7.BackColor == Color.Gray)
            {
                buttonTile7.BackColor = Color.Green;
                buttonTile7.ForeColor = Color.Green;
            }

            else if (buttonTile7.Text == "0") //if it is a bomb end the game
            {
                buttonTile7.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile7.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile7.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile7.Enabled = false;
            }
        }

        private void buttonTile8_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile8.BackColor == Color.Green)
            {
                buttonTile8.BackColor = Color.Gray;
                buttonTile8.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile8.BackColor == Color.Gray)
            {
                buttonTile8.BackColor = Color.Green;
                buttonTile8.ForeColor = Color.Green;
            }

            else if (buttonTile8.Text == "0") //if it is a bomb end the game
            {
                buttonTile8.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile8.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile8.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile8.Enabled = false;
            }
        }

        private void buttonTile9_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile9.BackColor == Color.Green)
            {
                buttonTile9.BackColor = Color.Gray;
                buttonTile9.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile9.BackColor == Color.Gray)
            {
                buttonTile9.BackColor = Color.Green;
                buttonTile9.ForeColor = Color.Green;
            }

            else if (buttonTile9.Text == "0") //if it is a bomb end the game
            {
                buttonTile9.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile9.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile9.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile9.Enabled = false;
            }
        }

        private void buttonTile10_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile10.BackColor == Color.Green)
            {
                buttonTile10.BackColor = Color.Gray;
                buttonTile10.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile10.BackColor == Color.Gray)
            {
                buttonTile10.BackColor = Color.Green;
                buttonTile10.ForeColor = Color.Green;
            }

            else if (buttonTile10.Text == "0") //if it is a bomb end the game
            {
                buttonTile10.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile10.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile10.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile10.Enabled = false;
            }
        }

        private void buttonTile11_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile11.BackColor == Color.Green)
            {
                buttonTile11.BackColor = Color.Gray;
                buttonTile11.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile11.BackColor == Color.Gray)
            {
                buttonTile11.BackColor = Color.Green;
                buttonTile11.ForeColor = Color.Green;
            }

            else if (buttonTile11.Text == "0") //if it is a bomb end the game
            {
                buttonTile11.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile11.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile11.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile11.Enabled = false;
            }
        }

        private void buttonTile12_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile12.BackColor == Color.Green)
            {
                buttonTile12.BackColor = Color.Gray;
                buttonTile12.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile12.BackColor == Color.Gray)
            {
                buttonTile12.BackColor = Color.Green;
                buttonTile12.ForeColor = Color.Green;
            }
            else if (buttonTile12.Text == "0") //if it is a bomb end the game
            {
                buttonTile12.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile12.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile12.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile12.Enabled = false;
            }
        }

        private void buttonTile13_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile13.BackColor == Color.Green)
            {
                buttonTile13.BackColor = Color.Gray;
                buttonTile13.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile13.BackColor == Color.Gray)
            {
                buttonTile13.BackColor = Color.Green;
                buttonTile13.ForeColor = Color.Green;
            }

            else if (buttonTile13.Text == "0") //if it is a bomb end the game
            {
                buttonTile13.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile13.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile13.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile13.Enabled = false;
            }
        }

        private void buttonTile14_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile14.BackColor == Color.Green)
            {
                buttonTile14.BackColor = Color.Gray;
                buttonTile14.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile14.BackColor == Color.Gray)
            {
                buttonTile14.BackColor = Color.Green;
                buttonTile14.ForeColor = Color.Green;
            }

            else if (buttonTile14.Text == "0") //if it is a bomb end the game
            {
                buttonTile14.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile14.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile14.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile14.Enabled = false;
            }
        }

        private void buttonTile15_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile15.BackColor == Color.Green)
            {
                buttonTile15.BackColor = Color.Gray;
                buttonTile15.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile15.BackColor == Color.Gray)
            {
                buttonTile15.BackColor = Color.Green;
                buttonTile15.ForeColor = Color.Green;
            }

            else if (buttonTile15.Text == "0") //if it is a bomb end the game
            {
                buttonTile15.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile15.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile15.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile15.Enabled = false;
            }
        }

        private void buttonTile16_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile16.BackColor == Color.Green)
            {
                buttonTile16.BackColor = Color.Gray;
                buttonTile16.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile16.BackColor == Color.Gray)
            {
                buttonTile16.BackColor = Color.Green;
                buttonTile16.ForeColor = Color.Green;
            }

            else if (buttonTile16.Text == "0") //if it is a bomb end the game
            {
                buttonTile16.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile16.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile16.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile16.Enabled = false;
            }
        }

        private void buttonTile17_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile17.BackColor == Color.Green)
            {
                buttonTile17.BackColor = Color.Gray;
                buttonTile17.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile17.BackColor == Color.Gray)
            {
                buttonTile17.BackColor = Color.Green;
                buttonTile17.ForeColor = Color.Green;
            }

            else if (buttonTile17.Text == "0") //if it is a bomb end the game
            {
                buttonTile17.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile17.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile17.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile17.Enabled = false;
            }
        }

        private void buttonTile18_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile18.BackColor == Color.Green)
            {
                buttonTile18.BackColor = Color.Gray;
                buttonTile18.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile18.BackColor == Color.Gray)
            {
                buttonTile18.BackColor = Color.Green;
                buttonTile18.ForeColor = Color.Green;
            }

            else if (buttonTile18.Text == "0") //if it is a bomb end the game
            {
                buttonTile18.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile18.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile18.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile18.Enabled = false;
            }
        }

        private void buttonTile19_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile19.BackColor == Color.Green)
            {
                buttonTile19.BackColor = Color.Gray;
                buttonTile19.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile19.BackColor == Color.Gray)
            {
                buttonTile19.BackColor = Color.Green;
                buttonTile19.ForeColor = Color.Green;
            }

            else if (buttonTile19.Text == "0") //if it is a bomb end the game
            {
                buttonTile19.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile19.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile19.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile19.Enabled = false;
            }
        }

        private void buttonTile20_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile20.BackColor == Color.Green)
            {
                buttonTile20.BackColor = Color.Gray;
                buttonTile20.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile20.BackColor == Color.Gray)
            {
                buttonTile20.BackColor = Color.Green;
                buttonTile20.ForeColor = Color.Green;
            }

            else if (buttonTile20.Text == "0") //if it is a bomb end the game
            {
                buttonTile20.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile20.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile20.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile20.Enabled = false;
            }
        }

        private void buttonTile21_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile21.BackColor == Color.Green)
            {
                buttonTile21.BackColor = Color.Gray;
                buttonTile21.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile21.BackColor == Color.Gray)
            {
                buttonTile21.BackColor = Color.Green;
                buttonTile21.ForeColor = Color.Green;
            }

            else if (buttonTile21.Text == "0") //if it is a bomb end the game
            {
                buttonTile21.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile21.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile21.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile21.Enabled = false;
            }
        }

        private void buttonTile22_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile22.BackColor == Color.Green)
            {
                buttonTile22.BackColor = Color.Gray;
                buttonTile22.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile22.BackColor == Color.Gray)
            {
                buttonTile22.BackColor = Color.Green;
                buttonTile22.ForeColor = Color.Green;
            }

            else if (buttonTile22.Text == "0") //if it is a bomb end the game
            {
                buttonTile22.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile22.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile22.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile22.Enabled = false;
            }
        }

        private void buttonTile23_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile23.BackColor == Color.Green)
            {
                buttonTile23.BackColor = Color.Gray;
                buttonTile23.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile23.BackColor == Color.Gray)
            {
                buttonTile23.BackColor = Color.Green;
                buttonTile23.ForeColor = Color.Green;
            }

            else if (buttonTile23.Text == "0") //if it is a bomb end the game
            {
                buttonTile23.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile23.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile23.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile23.Enabled = false;
            }
        }

        private void buttonTile24_Click(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile24.BackColor == Color.Green)
            {
                buttonTile24.BackColor = Color.Gray;
                buttonTile24.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile24.BackColor == Color.Gray)
            {
                buttonTile24.BackColor = Color.Green;
                buttonTile24.ForeColor = Color.Green;
            }

            else if (buttonTile24.Text == "0") //if it is a bomb end the game
            {
                buttonTile24.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile24.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile24.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile24.Enabled = false;
            }
        }

        private void buttonTile25_Click(object sender, EventArgs e)
        {
            if(checkMarkMode.Checked == true && buttonTile25.BackColor == Color.Green)
            {
                buttonTile25.BackColor = Color.Gray;
                buttonTile25.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile25.BackColor == Color.Gray)
            {
                buttonTile25.BackColor = Color.Green;
                buttonTile25.ForeColor = Color.Green;
            }

            else if (buttonTile25.Text == "0") //if it is a bomb end the game
            {
                buttonTile25.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile25.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile25.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile25.Enabled = false;
            }
        }

        private void buttonTile2_Click_1(object sender, EventArgs e)
        {
            if (checkMarkMode.Checked == true && buttonTile2.BackColor == Color.Green)
            {
                buttonTile2.BackColor = Color.Gray;
                buttonTile2.ForeColor = Color.Gray;
            }
            else if (checkMarkMode.Checked == true && buttonTile2.BackColor == Color.Gray)
            {
                buttonTile2.BackColor = Color.Green;
                buttonTile2.ForeColor = Color.Green;
            }
            else if (buttonTile2.Text == "0") //if it is a bomb end the game
            {
                buttonTile2.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile2.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile2.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile2.Enabled = false;
            }
        }

        private void buttonTile1_Click_1(object sender, EventArgs e)
        {
            //if already marked change back
            if (checkMarkMode.Checked == true && buttonTile1.BackColor == Color.Green)
            {
                buttonTile1.BackColor = Color.Gray;
                buttonTile1.ForeColor = Color.Gray;
            }
            //if not marked change to marked
            else if (checkMarkMode.Checked == true && buttonTile1.BackColor == Color.Gray)
            {
                buttonTile1.BackColor = Color.Green;
                buttonTile1.ForeColor = Color.Green;
            }

            else if (buttonTile1.Text == "0") //if it is a bomb end the game
            {
                buttonTile1.ForeColor = System.Drawing.Color.Red;
                endGame();
            }
            //else multiply the score 
            else
            {
                buttonTile1.ForeColor = System.Drawing.Color.White;
                gameBoard.currentScore *= Convert.ToInt32(buttonTile1.Text);
                labelScore.Text = "Score: " + gameBoard.currentScore;
                buttonTile1.Enabled = false;
            }
        }

        private void CheckMarkMode_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
