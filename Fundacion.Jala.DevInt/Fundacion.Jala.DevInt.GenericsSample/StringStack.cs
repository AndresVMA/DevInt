using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public class StringStack
    {
        private string[] _stack;
        private int _currentPosition;
        public StringStack()
        {
            _currentPosition = 0;
            _stack = new string[100];
        }

        public void Push(string value)
        {
            _stack[_currentPosition] = value;
            _currentPosition++;
        }

        public string Pop()
        {
            if (_currentPosition >= 0)
            {
                return _stack[--_currentPosition];
            }
            return string.Empty;
        }
    }
}
