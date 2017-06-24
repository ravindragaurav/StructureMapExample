namespace StructureMapExample.Classes
{
    public class Employee
    {
        private ITasks _tasks;
        public Employee(ITasks tasks)
        {
            _tasks = tasks;
        }

        public void PerformTask(string taskName)
        {
            _tasks.PerformTask(taskName);
        }
    }
}
