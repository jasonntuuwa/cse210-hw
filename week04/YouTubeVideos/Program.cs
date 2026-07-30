using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("USA vs Paraguay - World Cup Highlights", "FIFA", 1404);
        video1.AddComment(new Comment("Laidback_616", "Almost shed a tear of joy when Almiron received a yellow for that dive."));
        video1.AddComment(new Comment("remontada_szn", "Those who watched our last 2 friendlies would know this result isn't a surprise. We have massively improved."));
        video1.AddComment(new Comment("Footballwatchesme", "I love how VAR went back to check that dive by Almiron. We need this in the European football leagues."));
        video1.AddComment(new Comment("Howlingburd19", "You gotta give credit to the crowd, who was hella loud, very supportive, and burning with American pride."));
        video1.AddComment(new Comment("samroe4294", "So, I'm almost 30 and this is the first time I have ever watched Team USA without being nervous the entire time."));

        Video video2 = new Video("I Granted 100 Kids Their Biggest Wish!", "MrBeast", 875);
        video2.AddComment(new Comment("TheTechnoHX75ZR9official", "\"Why do you like MrBeast?\" - This is why"));
        video2.AddComment(new Comment("SammyStayBlink", "I almost cried when I saw SKZ. Thank you Mr. Beast for fulfilling those children's dreams, you have a big heart"));
        video2.AddComment(new Comment("SafullahMaster", "MrBeast got LeBron, Rock, KSI & Stray Kids to make 100 kids cry. I can't even get a text back. GOAT."));
        video2.AddComment(new Comment("SamaraAyesha-f4w", "straykids appearing in a mrbeast video was def not in my 2026 bingo list but this is soo wholesome"));

        Video video3 = new Video("I Toured Los Angeles's Most EXPENSIVE Homes..", "PlaqueBoyMaxLive", 2807);
        video3.AddComment(new Comment("sceneitallbefore-n5f", "playin in his face known he boutta be homeless"));
        video3.AddComment(new Comment("xd_razer0217", "Somebody in the stream prolly saw him tour 5 big ahh house and still donated a lil 5 dollars thinking he needs it btw"));
        video3.AddComment(new Comment("gottalovecox", "lowk gonna miss this house. legendary in the booths in here."));
        video3.AddComment(new Comment("itzamr69", "this video feels lieke a gta cutscene ong"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}