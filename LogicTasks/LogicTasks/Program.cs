using System;

namespace LogicTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var minimal = new MinimalInteger();
            Console.WriteLine(minimal.MinimalNumber(36));
            Console.ReadKey();
        }
    }
}
