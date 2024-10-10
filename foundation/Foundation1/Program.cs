using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //naming the totally legitimate vids
        Video video1 = new Video("Krazy Kat Khaos", "Jimble the Nimble", 31);
        Video video2 = new Video("Surviving Christmas with your in-laws", "Ronald Johnald", 450);
        Video video3 = new Video("Intro to Piracy: An In-Depth Look", "Davy Jones", 2770);

        //creating legitimate comments to Krazy Kat Khaos
        video1.Comments.Add(new Comment("CatMuncher97", "yum..."));
        video1.Comments.Add(new Comment("mark19", "much wow, very cool"));
        video1.Comments.Add(new Comment("xx_Tenta_xx", "depression = cured"));

        //creating legitimate comments for Surviving Christmas with in-laws
        video2.Comments.Add(new Comment("Davidthe1st", "I can't wait to try these out!"));
        video2.Comments.Add(new Comment("Granny", "Alexa, compliment this young man for his wonderful video. Ok. Send. Alexa, send message. Write comment. Alexa? Alexa send. Send the message you stu--"));
        video2.Comments.Add(new Comment("AliceLicorice", "Y'all need better in-laws"));

        //creating even more legitimate comments for an intro to piracy
        video3.Comments.Add(new Comment("CPTJack1", "Comment blocked by Video Creator."));
        video3.Comments.Add(new Comment("Thugdog103", "This video was great, thanks!"));
        video3.Comments.Add(new Comment("Isla18", "I cannot wait to become ungovernable"));

        //now that vids are made with comments added, put them in a list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //iterate through list and get the deets
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}