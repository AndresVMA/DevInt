namespace Fundacion.Jala.DevInt.Shared.Models.Classes
{
    public partial class Human
    {
        /// <summary>
        /// Gets or sets the amount of energy that the human has.
        /// </summary>
        public decimal Energy { get; set; }

        /// <summary>
        /// Gets or sets the amount of Strength. 
        /// </summary>
        public double Strength { get; set; }

        /// <summary>
        /// Gets or sets the Agility.
        /// </summary>
        public float Agility { get; set; }

        public virtual void Jump()
        {
            this.Energy--;
        }

        public virtual void Jump(float height, float velocity = 1)
        {
            this.Jump();
            this.position.Y += height;
        }
        public virtual void Run()
        {

        }

        public virtual void Kick()
        {

        }

        public virtual void Punch()
        {

        }
    }
}
