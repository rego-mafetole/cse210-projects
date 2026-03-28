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
        videos.Add(v1);

        Video v2 = new Video("Javascript Basics", "Alice Wonder", 360);
        v2.Comments.Add(new Comment("Katlego", "Very Informative."));
        v2.Comments.Add(new Comment("Amber", "Nice Video"));
        videos.Add(v2);

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

    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public List<Comment> Comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            Comments = new List<Comment>();
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }
    }

    public class Comment
    {
        public string _commenterName;
        public string _text;

        public Comment(string name, string text)
        {
            _commenterName = name;
            _text = text;
        }
    }
}