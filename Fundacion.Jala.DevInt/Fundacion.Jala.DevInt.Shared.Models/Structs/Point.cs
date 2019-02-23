using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.Shared.Models.Structs
{
    /*
     * - A struct defines a new Value type that is stored in the Stack.
     * - Value Types are immutable.
     * 
     * Use structs if?
     * -> The struct is going to store small amount of data.
     * -> the struct is commonly embedded in another type.
     * -> the values are not supposed to change (immutable)
     * */

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
