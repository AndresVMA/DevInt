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
    }
}
