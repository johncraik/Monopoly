using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace MonopolyApp
{
    internal class PlayerItem
    {
        /*Class Attributes:
         *  name    {string}    The name of the player item.
         *  img     {string}    The file location of the image of the player item.
        */
        private string name = "";
        private string img = "";


        //Constructor:
        /// <summary>
        /// Create a new instance of a Player's item on the board.
        /// </summary>
        /// <param name="name">Name of the item.</param>
        /// <param name="img">File location of the image of the item.</param>
        public PlayerItem(string name, string img)
        {
            this.name = name;
            this.img = img;
        }
    }
}
