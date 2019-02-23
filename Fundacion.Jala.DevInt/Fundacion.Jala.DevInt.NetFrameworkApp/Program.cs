using System;

namespace Fundacion.Jala.DevInt.NetFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new InputAdapter(args);
            var vectorA = adapter.VectorA;
            var vectorB = adapter.VectorB;
            var vectorResultDisplay = vectorA.Add(vectorB);
            Console.WriteLine($"Result: {vectorResultDisplay.ToString()}");
        }
    }
}
