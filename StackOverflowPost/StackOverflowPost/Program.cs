namespace StackOverflowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StackOverflow Post!\n");

            bool loopCondition = true;

            


            Post firstPost = new Post("CSharp","Beginner Course Drill", new DateTime());


            do
            {
                Console.WriteLine("Please UpVote or DownVote the follow Post!\n");

                firstPost.PostDisplay();

                Console.WriteLine("Enter '1' for 'Up Vote' OR '0' for 'Down Vote' :\n");

                int.Parse(Console.ReadLine());

                int voteIndicator;

                if (voteIndicator == 1)
                {
                    firstPost.UpVote();
                }
                


                
            }
            while (true);
            firstPost.UpVote();

        }
    }
}
