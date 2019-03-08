using Fundacion.Jala.DevInt.OOP;
using Fundacion.Jala.DevInt.OOP.Vehicles;
using Fundacion.Jala.DevInt.Shared.Models.Classes;

namespace Fundacion.Jala.DevInt.ObjectTypeApp
{
    static class BoxingUnboxing
    {
        public static void SampleBoxingUnboxingValueTypes()
        {
            int size = 20;
            object wrapper = size;
            int wrapperValue = (int)wrapper;
            double wrapDouble = (double)(int)wrapper;
        }

        public static void SampleBoxingReferenceTypes()
        {
            var customForm = new CustomForm(10);
            customForm.AddValue(10);
            customForm.AddValue(21m);
            customForm.AddValue(7.5f);
            customForm.AddValue("Text");
            customForm.AddValue(new Point2D() { X = 10, Y = 7 });
            IVehicle autobot = new Autobot();
            customForm.AddValue(autobot);

            object textField = customForm.GetValue(3);
            if (textField.GetType() == typeof(string))
            {
                var textValue = (string)textField;
            }
        }
    }
}
