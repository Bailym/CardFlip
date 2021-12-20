using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFlip
{
    class Tile
    {
        private int value;      //a value given to the tile and a boolean to see if the tile is marked 
        private bool isMarked;

        public Tile(int value)         //basic constructor
        {
            this.value = value;
            this.isMarked = false;
        }

        public int getValue()
        {
            return value;
        }
        
    }
}
