using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyApp
{
    internal class Board
    {
        /*Class Attributes:
         *  active  {bool}          Used to determine whether the board is being used or not.
         *  players {List<Player>}  List of players currently using the board.
        */
        private bool active = false;
        private List<Player> players = new List<Player>();


        //Get Methods:
        //--------------

        /// <summary>
        /// Get the boolean for active which determines whether the board is being used or not.
        /// </summary>
        /// <returns></returns>
        public bool GetActive()
        {
            return this.active;
        }

        /// <summary>
        /// Get the list of players using the board.
        /// </summary>
        /// <returns></returns>
        public List<Player> GetPlayers()
        {
            return this.players;
        }


        //Set Methods:
        //--------------

        /// <summary>
        /// Set the boolean active which determines whether the board is being used or not.
        /// </summary>
        /// <param name="active"></param>
        public void SetActive(bool active)
        {
            this.active = active;
        }

        /// <summary>
        /// Sets the players using the board. Returns false if the list given is empty.
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public bool SetPlayers(List<Player> players)
        {
            if(players != null)
            {
                this.players = players;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a player to the list of current players using the board.
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
