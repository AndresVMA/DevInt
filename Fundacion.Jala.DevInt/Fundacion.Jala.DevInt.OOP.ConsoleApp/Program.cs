using Fundacion.Jala.DevInt.OOP.Vehicles;
using System;

namespace Fundacion.Jala.DevInt.OOP.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UpcastDownCast();
        }

        static void OverrideVsNew()
        {
            var autobot = new Autobot();
            autobot.DisplayPosition("Initial Position");
            autobot.Walk();
            autobot.DisplayPosition("After Walk");
            autobot.Run();
            autobot.DisplayPosition("After Run");

            HumanoidBot humanoid = autobot;
            humanoid.DisplayPosition("Humanoid Position");
            humanoid.Walk();
            autobot.DisplayPosition("After Walk");
            humanoid.Run();
            humanoid.DisplayPosition("After Run");
        }

        static void UpcastDownCast()
        {
            var autobot = new Autobot();
            HumanoidBot humanoid = autobot; // upcast
            var transformer = (Autobot)humanoid; // downcast
            try
            {
                var decepticon = (Decepticon)humanoid;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception casting");
            }

            var decepticonBot = humanoid as Decepticon;
            if (decepticonBot != null)
            {
                //do some logic
            }

            decepticonBot?.DisplayPosition("DecepticonPosition");
            var vehicle = humanoid as Autobot;
            vehicle?.DisplayPosition("AutobotPosition");

        }
    }
}
