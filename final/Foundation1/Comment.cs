using System;

public class Comment {
    // Attributes
    public string _Name = "";
    public string _Comment = "";
    
    // Constructors
    public Comment() {
        // Default constructor
    }
    
    public Comment(string personName, string textComment) {
        _Name = personName;
        _Comment = textComment;
    }
    
    // Methods
    public string DisplayComment() {
        return $"{_Name}: {_Comment}";
    }
}