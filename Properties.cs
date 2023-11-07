using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyApp
{
    internal class Properties : Squares
    {
        /*Class Attributes:
         * name         {string}    The name of the property.
         * player       {Player}    The player owning the property.
         * cost         {int}       The cost of the property.
         * baseRent     {int}       The base rent cost for someone landing on it.
         * mortgaged    {bool}      Whether the property is mortgaged.
        */
        private string name = "";
        private Player? player = null;
        private int cost = 0;
        private int baseRent = 0;
        private bool mortgaged = false;


        //Construtor:
        /// <summary>
        /// Create a new instance of a property.
        /// </summary>
        /// <param name="board">The board this property belongs to.</param>
        /// <param name="x">The x-axis coordinate of the property.</param>
        /// <param name="y">The y-axis coordinate of the property.</param>
        /// <param name="colour">The colour of the property</param>
        /// <param name="name">The name of the property.</param>
        /// <param name="player">The player owning the property.</param>
        /// <param name="cost">The cost to buy the property.</param>
        /// <param name="baseRent">The base rent of the property.</param>
        /// <param name="mortgaged">Whether the property is mortgaged or not.</param>
        public Properties(Board board, int x, int y, string colour, string name, Player player, int cost, int baseRent, bool mortgaged):base(board, x, y, colour)
        {
            this.name = name;
            this.player = player;
            this.cost = cost;
            this.baseRent = baseRent;
            this.mortgaged = mortgaged;
        }
    }
}
