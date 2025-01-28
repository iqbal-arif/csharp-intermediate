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
        public int Vote { get; private set; } = 0;
        public DateTime PostTime { get; set; }
        public DateTime VoteTime { get; set; }


        public Post(string title, string description, DateTime postTime)
        {
            Title = title;
            Description = description;
            PostTime = postTime;
        }


        public void UpVote() 
        {
            Vote++;
            VoteTime = DateTime.Now;
            Console.WriteLine($"Your Current UpVote : {Vote}\n");
        }


        public void DownVote() 
        { 
            Vote--;
            VoteTime = DateTime.Now;
            Console.WriteLine($"Your Current DownVote : {Vote}\n");
        } 

        public void PostDisplay() 
        {
            Console.WriteLine($"\n{PostTime}\n{Title}\n{Description}\n");
        }

        public void VoteDisplay()
        {
            Console.WriteLine($"The Current Vote Value is : '{Vote}' at {VoteTime}");
        }
    }
}
