using System;
using System.Collections.Generic;
using Fundacion.Jala.DevInt.GenericsSample;

namespace Fundacion.Jala.DevInt.GenericsSampleTests
{
    internal class ScenarioContext<T>
    {
        public ScenarioContext()
        {
        }

        internal void SetList<T>(List<Book> list)
        {
            throw new NotImplementedException();
        }

        internal List<T> GetList<T>()
        {
            throw new NotImplementedException();
        }
    }
}