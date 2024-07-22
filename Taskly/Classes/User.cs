using System;

namespace Taskly.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int TasksCompleted { get; set; }
        public int WishesFulfilled { get; set; }
        public List<int> WishesId { get; set; }
        public List<int> TasksId { get; set; }

    }
}
