using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Practicing
{
    public interface IPart
    {
        string Id { get; set; }
    }

    public abstract class PartBase : IPart
    {
        public string Id { get; set; }
    }

    public class Wheel : PartBase
    {
        public Wheel()
        {
            Radio = 20;
        }
        public int Radio { get; set; }
        public override string ToString()
        {
            return $"{nameof(Id)}={Id}, {nameof(Radio)}={Radio}";
        }
    }

    public class Door : PartBase
    {
        public Door()
        {
            Height = 2000;
            Width = 700;
        }
        public float Height { get; set; }
        public float Width { get; set; }
        public override string ToString()
        {
            return $"{nameof(Id)}={Id}, {nameof(Width)}={Width}, {nameof(Height)}={Height}";
        }
    }

    public class Window : PartBase
    {
        public string GlassType { get; set; } = "SimpleGlass";
        public override string ToString()
        {
            return $"{nameof(Id)}={Id}, {nameof(GlassType)}={GlassType}";
        }
    }


    public class DataOperations<T> where T : IPart
    {
        public IList<string> Data { get; private set; }
        public DataOperations()
        {
            Data = new List<string>();
        }
        public void Save(T record)
        {
            Data.Add(record.ToString());
        }

        public P Create<P>() where P : new()
        {
            return new P();
        }
    }
        


    

    public class Class1
    {
        
    }
}
