using System;

public class Reference
{
    private string _chapter;
    private string _book;
    private string _singleVerse;
    private string _startingVerse;
    private string _endingVerse;

    public Reference(string book, string chapter, string verse)
    {
        _chapter = chapter;
        _book = book;
        _singleVerse = verse;
    }

    public Reference(string book, string chapter, string startingVerse, string endingVerse)
    {
        _chapter = chapter;
        _book = book;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }

    public string GetReference()
    {
        if (_singleVerse != null)
        {
            return $"{_book} {_chapter}:{_singleVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startingVerse}-{_endingVerse}";
        }
    }
}