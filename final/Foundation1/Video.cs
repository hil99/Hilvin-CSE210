using System;
using System.Collections.Generic;

public class Video {
    // Attributes
    public string _title = "";
    public string _author = "";
    public double _lenght = 0;
    public List<addcomment> _comments = new List<addcomment>{};
    
    // Constructors
    public Video() {
        _comments = new List<addcomment>();
    }
    
    public Video(string title, string author, double lenght, List<addcomment> comments) {
        _title = title;
        _comments = comments;
        _lenght = lenght;
        _author = author;
        }
    
    // Methods
    public void Videoinfomation(){
        int index = 1;
        Console.WriteLine("");
        Console.WriteLine("-------------");
        Console.Write($"Video title: {_title.ToUpper()} ");
        Console.Write($"Length {_lenght} by {_author}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine($"There is {NumberOfComments()} COMMENTS in this Video:");
        foreach (addcomment c in _comments){
            Console.WriteLine($"{index}. {c.DisplayComment()}");       
            index++;
        ;
        }
    }
    
    private int NumberOfComments(){
        return _comments.Count();
    }
} 