using StructureMap;
using StructureMapExample.Classes;
using System;

namespace StructureMapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITasks tasks = new Tasks();
            //Employee e = new Employee(tasks);
            //e.PerformTask("Coding");

            var container = new Container();
            container.Configure(x => x.For<ITasks>().Use<Tasks>().Named("Normal Tasks"));
            container.Configure(x => x.For<ITasks>().Use<Duties>().Named("Compulsory Tasks"));

            var shopper = container.GetInstance<Employee>();
            shopper.PerformTask("test"); //should be compulsory since registered last and using without name
            Console.ReadLine();

            //cant get named instance, have to pass in to Employee constructor to somehow know which one to use.
        }
    }
}
