namespace Fundacion.Jala.DevInt.Shared.Models.Classes
{
    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point2D point)
            {
                return X == point.X && Y == point.Y;
            }
            return false;
        }

        public Point2D Clone()
        {
            return MemberwiseClone() as Point2D;
        }
    }
}
