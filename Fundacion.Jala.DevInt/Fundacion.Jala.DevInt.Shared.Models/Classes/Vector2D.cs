using System;

namespace Fundacion.Jala.DevInt.Shared.Models.Classes
{
    public class Vector2D : Point2D
    {
        public Vector2D(int x, int y)
        {
            this.Origin = new Point2D
            {
                X = 0,
                Y = 0
            };
            this.X = x;
            this.Y = y;

        }
        public Point2D Origin { get; set; }

        public Vector2D Add(Vector2D vectorB)
        {
            return new Vector2D(this.X + vectorB.X, this.Y + vectorB.Y);
        }

        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
    }
}
