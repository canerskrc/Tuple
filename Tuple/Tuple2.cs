using System;

namespace TupleExample
{
    class Program1
    {
        static Tuple<string, int> GetPersonInfo()
        {
            return Tuple.Create("Ali", 25);
        }

        static void Main(string[] args)
        {
            var person = GetPersonInfo();
            Console.WriteLine($"Ad: {person.Item1}, Yaş: {person.Item2}");
        }
    }
}
