using System;

namespace Fundacion.Jala.DevInt.Shared.Models.Classes
{
    /// <summary>
    /// Defines a human being.
    /// </summary>
    public partial class Human
    {
        /// <summary>
        /// Gets or sets the Human Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Age in years.
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Gets the Birthday date.
        /// </summary>
        public DateTime BirthDay { get; private set; }
        
    }
}
