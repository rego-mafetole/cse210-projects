using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Dance Tutorial", "Kananelo Mihla", 460);
        v1.Comments.Add(new Comment("Amogelang", "Nice Moves!"));
        v1.Comments.Add(new Comment("Kim", "This was very helpful."));
        v1.Comments.Add(new Comment("Cynthia", "How did you do the third?"));
        videos.Add(v1);

        Video v2 = new Video("Javascript Basics", "Alice Wonder", 360);
        v2.Comments.Add(new Comment("Katlego", "Very Informative."));
        v2.Comments.Add(new Comment("Amber", "Nice Video."));
        v2.Comments.Add(new Comment("Annah", "I would like to see more video of this."));
        videos.Add(v2);

        Video v3 = new Video("How to crochet", "Katlego", 500);
        v3.Comments.Add(new Comment("Lola", "I love the colors you used."));
        v3.Comments.Add(new Comment("Saseka", "Where can I get the wool that you are using?"));
        v3.Comments.Add(new Comment("Lwethu", "Can you make long dresses?"));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} sec");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment._commenterName}: {comment._text}");
            }
            Console.WriteLine();
        }

    }
}