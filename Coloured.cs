using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyApp
{
    internal class Coloured : Properties
    {
        /*Class Attributes:
         * houses       {int}   Number of houses built on the property.
         * hotel        {bool}  Whether the property has a hotel on it (5 houses).
         * buildCost    {int}   Cost to build a house/hotel.
         * set          {bool}  Whether this property is in a set.
         * rent1        {int}   Rent for 1 house.
         * rent2        {int}   Rent for 2 houses.
         * rent3        {int}   Rent for 3 houses.
         * rent4        {int}   Rent for 4 houses.
         * rentHotel    {int}   Rent for hotel.
        */
        private int houses = 0;
        private bool hotel = false;
        private int buildCost = 0;
        private bool set = false;
        private int rent1 = 0;
        private int rent2 = 0;
        private int rent3 = 0;
        private int rent4 = 0;
        private int rentHotel = 0;


        //Constructor:
        /// <summary>
        /// Create a new instance of a coloured property.
        /// </summary>
        /// <param name="board">The board this property belongs to.</param>
        /// <param name="x">The x-axis coordinate of the property.</param>
        /// <param name="y">The y-axis coordinate of the property.</param>
        /// <param name="colour">The colour of the property.</param>
        /// <param name="name">The name of the property.</param>
        /// <param name="cost">The cost to buy the property.</param>
        /// <param name="baseRent">The base rent of the property.</param>
        /// <param name="buildCost">The cost to build a house or hotel.</param>
        /// <param name="rent1">The rent for 1 house.</param>
        /// <param name="rent2">The rent for 2 houses.</param>
        /// <param name="rent3">The rent for 3 houses.</param>
        /// <param name="rent4">The rent for 4 houses.</param>
        /// <param name="rentHotel">The rent for a hotel.</param>
        public Coloured(Board board, int x, int y, string colour,                       //Squares class attributes.
            string name, int cost, int baseRent,                                        //Properties class attributes.
            int buildCost, int rent1, int rent2, int rent3, int rent4, int rentHotel)   //Coloured class attributes.
            :base(board, x, y, colour, name, cost, baseRent)                            //Attributes passed to superclass.
        {
            this.houses = 0;
            this.hotel = false;
            this.buildCost = buildCost;
            this.set = false;
            this.rent1 = rent1;
            this.rent2 = rent2;
            this.rent3 = rent3;
            this.rent4 = rent4;
            this.rentHotel = rentHotel;
        }
    }
}
