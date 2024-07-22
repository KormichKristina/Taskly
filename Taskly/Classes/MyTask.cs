using System;

namespace Taskly.Classes
{
    public class MyTask:Aspiration
    {
        public DateTime Deadline { get; set; }
        public MyTask(string name, string description, DateTime deadline, bool isComplete = false):base(name,description,isComplete) 
        {
            Deadline = deadline;

        }
    
    }
}
