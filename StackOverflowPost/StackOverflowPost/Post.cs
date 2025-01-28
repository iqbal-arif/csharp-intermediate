using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //public int Vote { get; private set; }
        public DateTime PostTime { get; set; }
        public DateTime VoteTime { get; set; }

        public int UpVoteValue { get; private set; } = 0;
        public int DownVoteValue { get; private set; } = 0;


        public Post(string title, string description, DateTime postTime)
        {
            Title = title;
            Description = description;
            PostTime = postTime;
        }


        public void UpVote() 
        {
            UpVoteValue++;
            VoteTime = DateTime.Now;
            Console.WriteLine($"Your Current UpVote : {UpVoteValue}\n");
        }

        public void PostDisplay() 
        {
            Console.WriteLine($"\n{PostTime}\n{Title}\n{Description}\n");
        }
    }
}
