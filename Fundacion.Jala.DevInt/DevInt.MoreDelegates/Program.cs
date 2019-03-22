using System;

namespace DevInt.MoreDelegates
{
    class Program
    {
        /**
         * Func - funcion que retorna valor
         * Action - void function.
         * **/
        delegate void Save(string data);
        delegate int Read(string stream);
        static void Main(string[] args)
        {
            Save saver = SaveData;
            Action<string> actionSaver = SaveData;
            saver("cualquier cosa");
            actionSaver("otro valor");
            Read reader = ReadData;
            Func<string, int> read = ReadData;
            Console.WriteLine(reader("cadena"));
            Console.WriteLine(read("readValues"));
        }

        public static int ReadData(string stream)
        {
            return stream.Length;
        }
        public static void SaveData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
