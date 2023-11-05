using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyApp
{
    internal class Player
    {
        /*Class Attributes:
         *  name    {string}            The name of the player.
         *  item    {PlayerItem}        The player's item piece on the board.
         *  money   {int}               Amount of money the player owns.
         *  owned   {List<Properties>}  List of properties owned by the player.
        */
        private string name = "";
        private PlayerItem? item;
        private int money = 0;
        private List<Properties> owned = new List<Properties>();


        //Constructor:
        /// <summary>
        /// Construct a new instance of Player.
        /// </summary>
        /// <param name="name">The name of the Player.</param>
        /// <param name="item">The Player's item on the board.</param>
        /// <param name="money">The amount of money the Player starts with.</param>
        /// <param name="owned">List of Properties owned by the Player.</param>
        public Player(string name, PlayerItem? item, int money, List<Properties> owned)
        {
            this.name = name;
            this.item = item;
            this.money = money;
            this.owned = owned;
        }


        //Get Methods:
        //--------------

        /// <summary>
        /// Get the name of the player.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Get the player's item piece used on the board.
        /// </summary>
        /// <returns></returns>
        public PlayerItem? GetItem()
        {
            return item;
        }

        /// <summary>
        /// Get the amount of money owned by the player.
        /// </summary>
        /// <returns></returns>
        public int GetMoney()
        {
            return this.money;
        }

        /// <summary>
        /// Get the list of all owned properties by the player.
        /// </summary>
        /// <returns></returns>
        public List<Properties> GetOwned()
        {
            return this.owned;
        }

        /// <summary>
        /// Get a specified property owned by this player.
        /// </summary>
        /// <param name="propNmae"></param>
        /// <returns></returns>
        public Properties GetOwnedProperty(string propNmae)
        {
            return null;
        }


        //Set Methods:
        //--------------

        /// <summary>
        /// Set the name of the player
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Set the item piece used by the player on the board.
        /// </summary>
        /// <param name="item"></param>
        public void SetItem(PlayerItem item)
        {
            this.item = item;
        }

        /// <summary>
        /// Set the amount of money owned by the player.
        /// </summary>
        /// <param name="money"></param>
        public void SetMoney(int money)
        {
            this.money = money;
        }
        /// <summary>
        /// Add money the amount of money currently owned by the player.
        /// </summary>
        /// <param name="money"></param>
        public void AddMoney(int money)
        {
            this.money += money;
        }
        /// <summary>
        /// Remove money from the amount currently owned by the player. Returns false if the player goes below 0.
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool RemoveMoney(int money)
        {
            this.money -= money;
            if(this.money < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        /// <summary>
        /// Set the list of properties owned by the player.
        /// </summary>
        /// <param name="properties"></param>
        public void SetProperties(List<Properties> properties)
        {
            this.owned = properties;
        }

        /// <summary>
        /// Add a property to the list of properties owned by the player.
        /// </summary>
        /// <param name="property"></param>
        public void AddProperty(Properties property)
        {
            this.owned.Add(property);
        }
    }
}
