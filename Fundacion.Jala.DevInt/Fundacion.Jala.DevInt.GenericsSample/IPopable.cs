using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public interface IPopable<out T>
    {
        T Pop();
    }
}
