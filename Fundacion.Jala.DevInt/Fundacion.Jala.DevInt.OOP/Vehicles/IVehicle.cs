using Fundacion.Jala.DevInt.Shared.Models.Classes;

namespace Fundacion.Jala.DevInt.OOP.Vehicles
{
    public interface IVehicle
    {
        Point2D Position { get; }
        void StartEngine();
        void StopEngine();
        void MoveForward();
        void MoveBackWard();
    }
}
