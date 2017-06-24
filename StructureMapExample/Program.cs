using StructureMapExample.Classes;
using System;

namespace StructureMapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ITasks tasks = new Tasks();
            Employee e = new Employee(tasks);
            e.PerformTask("Coding");
            Console.ReadLine();

        }
    }
}
