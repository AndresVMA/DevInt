using Fundacion.Jala.DevInt.Shared.Models.Classes;
namespace Fundacion.Jala.DevInt.Shared.Models.Extensions
{
    public static class Vector2DExtensions
    {
        public static float Dot(this Vector2D vectorA, Vector2D vectorB)
        {
            return vectorA.X * vectorB.X + vectorA.Y * vectorB.Y;
        }
    }
}
