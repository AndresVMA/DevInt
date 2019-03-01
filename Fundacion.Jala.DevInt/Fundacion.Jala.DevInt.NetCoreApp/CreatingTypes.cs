using Fundacion.Jala.DevInt.Shared.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.NetCoreApp
{
    public static class CreatingTypes
    {
        static void CreateHumanCharacter()
        {
            var human = new Human();
            human.Name = "Goku";
            var x = human.Name;
            human.Jump(20, 2);
            human[0] = new Item();
            Item sword = human[1];
        }
    }
}
