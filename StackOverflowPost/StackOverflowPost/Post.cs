using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Vote { get; private set; }
        public DateTime VoteTime { get; set; }

        
        public void UpVote()
        {
            VoteTime = DateTime.Now;
        }


    }
}
