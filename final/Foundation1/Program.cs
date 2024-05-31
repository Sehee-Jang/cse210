using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Vacation in Cancun", "Sehee Jang", 300);
        Video video2 = new Video("Best Gumbo Recipe", "Smokin&Grilln", 550);
        Video video3 = new Video("Playlist | Paris Jazz", "Mood is Jazz", 1100);

        // Add comments to the videos
        video1.AddComment(new Comment("John", "Great Video!"));
        video1.AddComment(new Comment("Judy", "Amazing View!"));
        video1.AddComment(new Comment("Charlie", "Helped me decide on my next vacation."));

        video2.AddComment(new Comment("Oscar", "Looks yummy!"));
        video2.AddComment(new Comment("Seon", "Can't wait to try this out."));
        video2.AddComment(new Comment("Dave", "Loved the recipe!"));
        video2.AddComment(new Comment("Jayd", "I'll try this recipe this weekend."));

        video3.AddComment(new Comment("Happy", "Love Paris so much! Thank you for doing this!"));
        video3.AddComment(new Comment("Chillcafe", "Wonderful!"));
        video3.AddComment(new Comment("WildMusicArt", "Love this music video!"));
        video3.AddComment(new Comment("DreamCoffeeShop", "So relax when I play this music. Thanks for sharing!"));
        video3.AddComment(new Comment("SmileyJ", "What's the name of this song?"));


        // Add vidoes to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list and display vidoe details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}