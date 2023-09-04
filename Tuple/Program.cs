using System;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int> kisiler = Tuple.Create("Caner", 27);
            Console.WriteLine($"Ad: {kisiler.Item1}, Yaş: {kisiler.Item2}");
        }
    }
}
