    using System;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public class IntStack
    {
        private int[] _stack;
        private int _currentPosition;
        public IntStack()
        {
            _currentPosition = 0;
            _stack = new int[100];
        }

        public void Push(int value)
        {
            _stack[_currentPosition] = value;
            _currentPosition++;
        }

        public int Pop()
        {
            if (_currentPosition >= 0)
            {
                return _stack[--_currentPosition];
            }
            return 0;
        }
    }
}
