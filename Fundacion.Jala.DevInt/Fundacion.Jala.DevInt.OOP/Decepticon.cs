using Fundacion.Jala.DevInt.OOP.Parts;
using Fundacion.Jala.DevInt.OOP.Transformer;
using Fundacion.Jala.DevInt.OOP.Vehicles;
using Fundacion.Jala.DevInt.Shared.Models.Classes;

namespace Fundacion.Jala.DevInt.OOP
{
    public class Decepticon : HumanoidBot, IAirCraft, ITransformer
    {
        private Engine _engine;
        private Point2D _position;
        public void MoveBackWard()
        {
            this._position.X -= 1;
        }

        public void MoveDown()
        {
            this._position.Y -= 1;
        }

        public void MoveForward()
        {
            this._position.X += 1;
        }

        public void MoveUp()
        {
            this._position.Y += 1;
        }

        public void StartEngine()
        {
            _engine.Start();
        }

        public void StopEngine()
        {
            _engine.Stop();
        }

        public void Transform()
        {

        }
    }
}
