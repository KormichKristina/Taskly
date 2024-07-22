using System;

namespace Taskly.Classes
{
    public class Wish:Aspiration
    {
        public string HowWillYouAchive { get; set; }
        public Wish(string name,string description,string howWillYouAchive,bool isComplete=false) : base(name, description,isComplete)
        {
            HowWillYouAchive = howWillYouAchive;
        }

    }
}
