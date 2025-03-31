using System;


class Program {
    static void Main(string[] commandLineArguments)
    {
        

        // Initialize 
        List<Video> videos = new List<Video>{};
       
        
        AddVideos();
        
        // display video
        Console.Clear();
        foreach (Video video in videos){
            
            video.Videoinfomation();
        }
        
        
        void AddVideos(){
            Video video1 = new Video();
            video1._title = "Electrical circuit analysis 1";
            video1._lenght = 13.04;
            video1._author = "Koxhi varuval";
            video1._comments.Add(new addcomment { _Comment = "Good info about circuits.", _Name = "miare" });
            video1._comments.Add(new addcomment {  _Comment = "Very helpful tutorial.", _Name = "mutal" });
            videos.Add(video1);
            
            Video video2 = new Video();
            video2._title = "Microcontroller Programming for Beginners";
            video2._lenght = 15.04;
            video2._author = "kadava paretal";
            video2._comments.Add(new addcomment {  _Comment = "Great Arduino tutorial.", _Name = "hilvin" });
            video2._comments.Add(new addcomment {  _Comment = "This helped me with my project.", _Name = "Kumar" });
            video2._comments.Add(new addcomment {  _Comment = "Clear explanation of microcontrollers.", _Name = "kokoi"});
            videos.Add(video2);
            
            Video video3 = new Video();
            video3._title = "Power Electronics: MOSFET Applications";
            video3._lenght = 20.00;
            video3._author = "Intel";
            video3._comments.Add(new addcomment {  _Comment = "Good MOSFET examples." , _Name = "kundi" });
            video3._comments.Add(new addcomment {  _Comment = "Helpful for my design project.", _Name = "naiye" });
            videos.Add(video3);
        }
        
    }
} 