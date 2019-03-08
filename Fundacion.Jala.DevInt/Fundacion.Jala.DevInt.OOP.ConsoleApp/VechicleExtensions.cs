using Fundacion.Jala.DevInt.OOP.Vehicles;
using System;

namespace Fundacion.Jala.DevInt.OOP.ConsoleApp
{
    public static class VechicleExtensions
    {
        public static void DisplayPosition(this IVehicle vechicle, string additionalInformation)
        {
            Console.Write($"{additionalInformation}:");
            Console.WriteLine(vechicle.Position.ToString());
        }
    }
}
