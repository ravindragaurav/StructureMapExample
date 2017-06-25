using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapExample.Classes
{
    class Duties : ITasks
    {
        public void PerformTask(string taskName)
        {
            Console.WriteLine("Performing Compulsory Task: " + taskName);
        }
    }
}
