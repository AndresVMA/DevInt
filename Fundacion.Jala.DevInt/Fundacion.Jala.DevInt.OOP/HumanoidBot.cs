using Fundacion.Jala.DevInt.OOP.Parts;
using Fundacion.Jala.DevInt.Shared.Models.Classes;

namespace Fundacion.Jala.DevInt.OOP
{
    public class HumanoidBot
    {
        protected MetalArm _leftArm;
        protected MetalArm _rightArm;
        protected MetalLeg _leftLeg;
        protected MetalLeg _rightLeg;
        protected MetalHead _head;
        public Point2D Position { get; private set; }
        public HumanoidBot()
        {
            _leftArm = new MetalArm(PartSide.Left);
            _rightArm = new MetalArm(PartSide.Right);
            _leftLeg = new MetalLeg(PartSide.Left);
            _rightLeg = new MetalLeg(PartSide.Right);
            _head = new MetalHead();
            Position = new Point2D() { X = 0, Y = 0 };
        }

        public virtual void Walk()
        {
            Position.X += 1;
        }

        public virtual void Run()
        {
            Position.X += 2;
        }

    }
}
