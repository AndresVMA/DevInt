using Fundacion.Jala.DevInt.OOP.Parts;
using Fundacion.Jala.DevInt.OOP.Transformer;
using Fundacion.Jala.DevInt.OOP.Vehicles;
using Fundacion.Jala.DevInt.Shared.Models.Classes;

namespace Fundacion.Jala.DevInt.OOP
{
    public class Autobot : VechicleBase, ITransformer
    {
        private HumanoidBot _humanoid;
        private Engine _engine;
        public bool IsOnVehicleMode { get; private set; } = true;
        public Autobot()
        {
            _humanoid = new HumanoidBot();
            Position = _humanoid.Position;
            _engine = new Engine(1200);

        }
        public new void MoveBackWard() => Position.X -= 5;

        public override void MoveForward() => Position.X += 5;

        public override void StartEngine() => _engine.Start();

        public override void StopEngine() => _engine.Stop();

        public void Walk() => Position.X += 3;

        public void Run() => Position.X += 4;

        public void Transform() => IsOnVehicleMode = !IsOnVehicleMode;

        ~Autobot()
        {

        }
    }
}
