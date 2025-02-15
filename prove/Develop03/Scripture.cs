public class Scripture
{
    public Reference Ref { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Ref = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        var wordsToHide = Words.Where(word => !word.IsHidden).OrderBy(x => random.Next()).Take(count);
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public override string ToString()
    {
        return $"{Ref}\n{string.Join(" ", Words)}";
    }

    public bool AreAllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}


