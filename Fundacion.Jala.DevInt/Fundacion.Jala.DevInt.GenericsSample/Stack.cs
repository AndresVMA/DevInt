    using System;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public struct DataDisplay
    {

    }
    public class CustomStack<T>  : IPushable<T>, IPopable<T>
    {
        private T[] _stack;
        private int _currentPosition;
        public CustomStack()
        {
            _currentPosition = 0;
            _stack = new T[100];
        }

        public void Push(T value)
        {
            _stack[_currentPosition] = value;
            _currentPosition++;
        }

        public T Pop()
        {
            if (_currentPosition >= 0)
            {
                return _stack[--_currentPosition];
            }
            return default(T);
        }
    }
}
