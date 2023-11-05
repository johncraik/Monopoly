using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyApp
{
    internal class Squares : Board
    {
        /*Class Attributes:
         * board    {Board}     Board object the square belongs to.  
         * x        {int}       x-axis coordinate for the location of the square on the board.
         * y        {int}       y-axis coordinate for the location of the square on the board.
         * colour   {string}    Colour of the square; "BLACK"=Station, "WHITE"=Utility, "NONE"=Other Square.
        */
        private readonly Board board;
        private readonly int x = 0;
        private readonly int y = 0;
        private readonly string colour = "";


        //Constructor:
        /// <summary>
        /// Create a new instance of a square.
        /// </summary>
        /// <param name="active">x-axis coordinate for the location of the square on the board.</param>
        /// <param name="players">y-axis coordinate for the location of the square on the board.</param>
        public Squares(Board board, int x, int y, string colour):base()
        {
            this.board = board;
            this.x = x;
            this.y = y;
            this.colour = colour;
        }


        //Get Methods:
        //--------------

        /// <summary>
        /// Get the board associated with the square.
        /// </summary>
        /// <returns></returns>
        public Board GetBoard()
        {
            return this.board;
        }

        /// <summary>
        /// Get the coordinates (both x and y) of the square's location.
        /// </summary>
        /// <returns></returns>
        public int[] GetCoordinates()
        {
            int[] coords = {this.x,this.y};
            return coords;
        }

        /// <summary>
        /// Get the x-axis coordinate of the square's location.
        /// </summary>
        /// <returns></returns>
        public int GetX()
        {
            return this.x;
        }

        /// <summary>
        /// Get the y-axis coordinate of the square's location.
        /// </summary>
        /// <returns></returns>
        public int GetY()
        {
            return this.y;
        }

        /// <summary>
        /// Gets the colour of the square.
        /// </summary>
        /// <returns></returns>
        public string GetColour()
        {
            return this.colour;
        }
    }
}
