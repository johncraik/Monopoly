using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyApp
{
    internal class Utility : Properties
    {
        /*Class Attributes:
         * set          {bool}  Whether this property is in a set.
         * rentSingle   {int}   Multiplier value for rent for owning 1 utility.
         * rentMultiple {int}   Multiplier value for rent for owning both utilities.
        */
        private bool set = false;
        private readonly int rentSingle = 4;
        private readonly int rentMultiple = 10;


        //Constructor:
        public Utility(Board board, int x, int y, string colour,    //Squares class attributes.
            string name, int cost, int baseRent)                    //Properties class attributes.
            :base(board, x, y, colour, name, cost, baseRent)        //Attributes passed to superclass.
        {
            this.set = false;
        }
    }
}
