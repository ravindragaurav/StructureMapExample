using System;

namespace StructureMapExample.Classes
{
    public class Tasks : ITasks
    {
        public void PerformTask(string taskName)
        {
            Console.WriteLine("Currently Performing Task : " + taskName);
        }
    }
}
