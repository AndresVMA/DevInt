using Fundacion.Jala.DevInt.OOP.Parts;
using Fundacion.Jala.DevInt.OOP.Transformer;
using Fundacion.Jala.DevInt.OOP.Vehicles;

namespace Fundacion.Jala.DevInt.OOP
{
    public class Autobot : HumanoidBot, IVehicle, ITransformer
    {
        private Engine _engine;
        public bool IsOnVehicleMode { get; private set; } = true;
        public Autobot()
        {
            _engine = new Engine(1200);

        }
        public void MoveBackWard() => this.Position.X -= 1;

        public void MoveForward() => this.Position.X += 1;

        public void StartEngine() => _engine.Start();

        public void StopEngine() => _engine.Stop();

        public override void Walk() => Position.X += 5;

        public new void Run() => Position.X += 10;

        public void Transform() => IsOnVehicleMode = !IsOnVehicleMode;

        ~Autobot()
        {

        }
    }
}
