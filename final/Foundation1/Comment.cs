using System;

public class addcomment {

    
   public addcomment() {
        // Default constructor
    }


     public string _Name = "";
    public string _Comment = "";
    
    public addcomment(string personName, string textComment) {
        _Name = personName;
        _Comment = textComment;
    }
    
    // Methods
    public string DisplayComment() {
        return $"{_Name}: {_Comment}";
    }
}