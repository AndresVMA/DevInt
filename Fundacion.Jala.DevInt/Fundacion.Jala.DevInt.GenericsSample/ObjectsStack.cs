using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public class ObjectsStack
    {
        private Type[] types;
        private object[] stack;
        private int currentPosition;
        public ObjectsStack()
        {
            currentPosition = 0;
            stack = new object[100];
            types = new Type[100];

        }

        public void Push(object value)
        {
            stack[currentPosition] = value;
            types[currentPosition] = value.GetType();
            currentPosition++;
        }

        public object Pop()
        {
            if (currentPosition >= 0)
            {
                return stack[--currentPosition];
            }
            throw new IndexOutOfRangeException();
        }

        public object CreateNew(Type type)
        {
            return Activator.CreateInstance(type);
        }

    }
}
