using System;

namespace Fundacion.Jala.DevInt.NetFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var adapter = new InputAdapter(args);
                var vectorA = adapter.VectorA;
                var vectorB = adapter.VectorB;
                var vectorResultDisplay = vectorA + vectorB;
                Console.WriteLine($"Result: {vectorResultDisplay.ToString()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
