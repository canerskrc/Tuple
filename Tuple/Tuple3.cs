using System;

namespace TupleExample
{
    class Program2
    {
        static void Main(string[] args)
        {
            var person1 = Tuple.Create("Caner", 27);
            var person2 = Tuple.Create("Ahmet", "Marketing");
            var person3 = Tuple.Create("Mehmet", true);

            Console.WriteLine($"Ad: {person1.Item1}, Yaş: {person1.Item2}");
            Console.WriteLine($"Ad: {person2.Item1}, Departman: {person2.Item2}");
            Console.WriteLine($"Ad: {person3.Item1}, Aktif mi? {person3.Item2}");
        }
    }
}
