using System;

namespace Fundacion.Jala.DevInt.Shared.Models.Classes
{
    public class Vector2D : Point2D
    {
        public Vector2D(float x, float y)
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

        public float Length => (float)Math.Sqrt(this.X * this.X + this.Y * this.Y);
        public static Vector2D operator +(Vector2D vectorA, Vector2D vectorB)
        {
            return new Vector2D(vectorA.X + vectorB.X, vectorA.Y + vectorB.Y);
        }

        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
    }
}
