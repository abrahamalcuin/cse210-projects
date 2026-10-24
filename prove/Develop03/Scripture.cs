using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();


    public Scripture(Reference reference, string scripturetext)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] scriptureWords = scripturetext.Split(' ');

        foreach (string scriptureWord in scriptureWords)
        {
            _words.Add(new Word(scriptureWord));
        }

    }

    public void HideWord()
    {
        List<int> notHidden = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].GetHiddenState())
            {
                notHidden.Add(i);
            }
        }

        if (notHidden.Count > 0)
        {
            int randomInList = _random.Next(notHidden.Count);
            int wordIndex = notHidden[randomInList];

            _words[wordIndex].Hide();

        }
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetHiddenState())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayScripture()
    {
        string scriptureText = _reference.GetReference() + " ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayWord() + " "; 
        }

        return scriptureText;
    }
}


