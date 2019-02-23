using Fundacion.Jala.DevInt.Shared.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundacion.Jala.DevInt.NetFrameworkApp
{
    public class InputAdapter
    {
        private const string InvalidArgumentsMessage = "Vector Arguments are not valid, the correct Format is x1,y2 x2,y2";
        private const string InvalidNumberMessage = "Vector Arguments must supply valid numbers.";
        public Vector2D VectorA { get; private set; }
        public Vector2D VectorB { get; private set; }

        public InputAdapter(string[] args)
        {
            if (args.Length == 2)
            {
                var argumentsA = args[0].Split(',');
                var argumentsB = args[1].Split(',');

                this.VectorA = new Vector2D(TryGetInteger(argumentsA[0]), TryGetInteger(argumentsA[1]));
                this.VectorB = new Vector2D(TryGetInteger(argumentsB[0]), TryGetInteger(argumentsB[1]));
                
            }
            else
            {
                throw new ArgumentException(InvalidArgumentsMessage);
            }
        }

        private void ValidateVectorFormat(string[] arguments)
        {
            if (arguments.Length != 2)
            {
                throw new ArgumentException(InvalidArgumentsMessage);
            }
        }

        private int TryGetInteger(string value)
        {
            if (!int.TryParse(value, out var parsedValue))
            {
                throw new ArgumentException(InvalidNumberMessage);
            }
            return parsedValue;
        }
    }
}
