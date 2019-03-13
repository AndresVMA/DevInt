using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public interface IPushable<in T>
    {
        void Push(T value);
    }
}
