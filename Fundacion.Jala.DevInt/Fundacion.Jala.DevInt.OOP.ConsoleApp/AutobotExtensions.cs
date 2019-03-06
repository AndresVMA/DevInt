using System;

namespace Fundacion.Jala.DevInt.OOP.ConsoleApp
{
    public static class AutobotExtensions
    {
        public static void DisplayPosition(this HumanoidBot autobot, string additionalInformation)
        {
            Console.Write($"{additionalInformation}:");
            Console.WriteLine(autobot.Position.ToString());
        }
    }
}
