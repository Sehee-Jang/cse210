public class Video
{
    // Getters & Setters
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Methods
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetNumberOFComment()
    {
        return Comments.Count;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOFComment()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Commenter}: {comment.Text}");
        }
        Console.WriteLine();
    }

}