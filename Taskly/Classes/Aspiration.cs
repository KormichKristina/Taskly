using System;

namespace Taskly.Classes
{
    public abstract class Aspiration
    {
        public int Id { get; set; }
        public DateOnly DateOfCreate { get; }
        public int UserId { get; set; }
        public bool IsComplete { get; set; }
        public string MyColor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Aspiration(string name, string description,  bool isComplete = false) 
        {
            Name = name;
            Description = description;
            IsComplete = isComplete;
            DateOfCreate = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);


        }


    }
}
