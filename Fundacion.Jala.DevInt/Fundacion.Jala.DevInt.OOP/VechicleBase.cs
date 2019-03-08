using Fundacion.Jala.DevInt.OOP.Vehicles;
using Fundacion.Jala.DevInt.Shared.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundacion.Jala.DevInt.OOP
{
    public abstract class VechicleBase : IVehicle
    {
        public VechicleBase()
        {
            Position = new Point2D() { X = 0, Y = 0 };
        }

        public virtual Point2D Position { get; protected set; }

        public virtual void MoveBackWard()
        {
            Position.X -= 1;
        }

        public virtual void MoveForward()
        {
            Position.X += 1;
        }

        public abstract void StartEngine();

        public abstract void StopEngine();
    }
}
