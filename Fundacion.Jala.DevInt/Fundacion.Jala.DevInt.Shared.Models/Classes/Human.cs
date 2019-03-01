using System;
using System.Collections.Generic;

namespace Fundacion.Jala.DevInt.Shared.Models.Classes
{
    /// <summary>
    /// Defines a human being.
    /// </summary>
    public partial class Human
    {
        public Human()
        {
            this.inventory = new List<Item>();
        }
        public Point2D position;
        private string _name;
        protected List<Item> inventory;
        /// <summary>
        /// Gets or sets the Human Name.
        /// </summary>
        public string Name
        {
            get
            {
                return "SS" + _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Gets the Age in years.
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Gets the Birthday date.
        /// </summary>
        internal DateTime BirthDay { get; set; }

        public Item this [int index]
        {
            get { return this.inventory[index]; }
            set { this.inventory[index] = value; }
        }
        
    }
}
