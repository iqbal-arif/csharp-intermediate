namespace StackOverflowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StackOverflow Post!\n");

            bool loopCondition = true;

            string voteIndicator;
            


            Post firstPost = new Post("CSharp","Beginner Course Drill", new DateTime());


                Console.WriteLine("Please UpVote or DownVote the follow Post!\n");

                firstPost.PostDisplay();


            do
            {
                Console.WriteLine("****************************************************");

                Console.WriteLine("\nEnter 'U' for 'Up Vote' OR 'D' for 'Down Vote' :\n");

                voteIndicator = Console.ReadLine().ToLower();

                if(string.IsNullOrEmpty(voteIndicator) || voteIndicator == "e")
                {
                    loopCondition = false;
                    break;

                }else if (voteIndicator == "u")
                {
                    firstPost.UpVote();
                    firstPost.VoteDisplay();

                }else if(voteIndicator == "d")
                {
                    firstPost.DownVote();
                    firstPost.VoteDisplay();
                }
                                
            }
            while (true);
            


        }
    }
}
