using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFlip
{
    class Board
    {
        public int currentScore;      //keeps track of the score
        public List<Tile> tilesList;   //a list of Tile objects that make up the board
        public int[] sumRows;          //holds values for each column/row total
        public int[] sumCols;
        public int[] bombRows;         ////holds values for each column/row bombs
        public int[] bombCols;
        private bool isComplete;       //shows whether the board is complete or not


        public Board()          //default constructor
        {
            currentScore = 1;
            tilesList = new List<Tile>();   //instatiate the list
            isComplete = false;
            sumRows = new int[5];           //hold totals for each row/col
            sumCols = new int[5];
            bombRows = new int[5];
            bombCols = new int[5];
        }

        public void PopulateBoard()
        {
            Random rand = new Random();    //create a random object to populate the board

            for(int i = 0; i < 25; i++)     //loop that populates the board
            {
                tilesList.Add(new Tile(rand.Next(0,4)));
            }

            //THIS SECTION WORKS OUT TOTALS FOR ROWS
            int rowTotal = 0;
            int rowBombs = 0;
            //work out total for row 1
            for (int i = 0; i <= 4; i++)
            {
                rowTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    rowBombs++;
                }
            }
            sumRows[0] = rowTotal;  //add totals to array,
            bombRows[0] = rowBombs;

            //total needs to be reset for next row
            rowTotal = 0;
            rowBombs = 0;

            //work out total for row 2
            for (int i = 5; i <= 9; i++)
            {
                rowTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    rowBombs++;
                }
            }
            sumRows[1] = rowTotal;
            bombRows[1] = rowBombs;

            //total needs to be reset for next row
            rowTotal = 0;
            rowBombs = 0;

            //work out total for row 3
            for (int i = 10; i <= 14; i++)
            {
                rowTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    rowBombs++;
                }
            }
            sumRows[2] = rowTotal;
            bombRows[2] = rowBombs;

            //total needs to be reset for next row
            rowTotal = 0;
            rowBombs = 0;

            //work out total for row 4
            for (int i = 15; i <= 19; i++)
            {
                rowTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    rowBombs++;
                }
            }
            sumRows[3] = rowTotal;
            bombRows[3] = rowBombs;

            //total needs to be reset for next row
            rowTotal = 0;
            rowBombs = 0;

            //work out total for row 5
            for (int i = 20; i <= 24; i++)
            {
                rowTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    rowBombs++;
                }
            }
            sumRows[4] = rowTotal;
            bombRows[4] = rowBombs;

            //total needs to be reset for next row
            rowTotal = 0;
            rowBombs = 0;

            //THIS SECTION WORKS OUT TOTALS FOR COLUMNS
            int colTotal = 0;
            int colBombs = 0;
            //work out total for col 1
            for (int i = 0; i <=20 ; i=i+5)
            {
                colTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    colBombs++;
                }
            }
            sumCols[0] = colTotal;
            bombCols[0] = colBombs;

            //total needs to be reset for next col
            colTotal = 0;
            colBombs = 0;

            //work out total for col 2
            for (int i = 1; i <= 21; i = i + 5)
            {
                colTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    colBombs++;
                }
            }
            sumCols[1] = colTotal;
            bombCols[1] = colBombs;

            //total needs to be reset for next row
            colTotal = 0;
            colBombs = 0;

            //work out total for col 3
            for (int i = 2; i <= 22; i = i + 5)
            {
                colTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    colBombs++;
                }
            }
            sumCols[2] = colTotal;
            bombCols[2] = colBombs;

            //total needs to be reset for next row
            colTotal = 0;
            colBombs = 0;
            //work out total for col 4
            for (int i = 3; i <= 23; i = i + 5)
            {
                colTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    colBombs++;
                }
            }
            sumCols[3] = colTotal;
            bombCols[3] = colBombs;

            //total needs to be reset for next row
            colTotal = 0;
            colBombs = 0;

            //work out total for col 5
            for (int i = 4; i <= 24; i = i + 5)
            {
                colTotal += tilesList[i].getValue();
                if (tilesList[i].getValue() == 0)       //check if value is a bomb and keep a counter
                {
                    colBombs++;
                }
            }
            sumCols[4] = colTotal;
            bombCols[4] = colBombs;

            //total needs to be reset for next row
            colTotal = 0;
            colBombs = 0;

        }


    }
}
