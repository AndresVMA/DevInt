using Fundacion.Jala.DevInt.OOP.Vehicles;
using System;

namespace Fundacion.Jala.DevInt.OOP.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OverrideVsNew();
            //UpcastDownCast();
        }

        static void OverrideVsNew()
        {
            var autobot = new Autobot();
            autobot.DisplayPosition("Initial Position");
            autobot.Walk();
            autobot.DisplayPosition("After Walk");
            autobot.Run();
            autobot.DisplayPosition("After Run");

            IVehicle vehicle = autobot;
            vehicle.DisplayPosition("Vechicle Position");
            vehicle.MoveForward();
            vehicle.DisplayPosition("After Move Forward");
            vehicle.MoveBackWard();
            vehicle.DisplayPosition("After Move Backward");
        }

        static void UpcastDownCast()
        {
            var autobot = new Autobot();
            IVehicle vechicle = autobot; // upcast
            var transformer = (Autobot)vechicle; // downcast
            try
            {
                var decepticon = (Decepticon)vechicle;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception casting");
            }

            var decepticonBot = vechicle as Decepticon;
            if (decepticonBot != null)
            {
                //do some logic
            }

            decepticonBot?.DisplayPosition("DecepticonPosition");

            var x = decepticonBot != null ? 2 : 1;
            var vehicle = vechicle as Autobot;
            var decepticon2 = vechicle.Position ?? new Shared.Models.Classes.Point2D();
            //var decepticon = humanoid != null ? humanoid :  new Decepticon();
            if (vechicle is Decepticon decept)
            {
            }
            vehicle?.DisplayPosition("AutobotPosition");

        }
    }
}
