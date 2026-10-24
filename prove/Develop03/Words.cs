using System;


public class Word
{
    private string _word;
    private bool _hiddenState;

    public Word(string word)
    {
        _word = word;
        _hiddenState = false;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool GetHiddenState()
    {
        return _hiddenState;
    }

    public void Hide()
    {
        _hiddenState = true; 
    }

    public string GetDisplayWord()
    {
        if (_hiddenState == true)
        {
            string hiddenWord = "";

            foreach(char character in _word)
            {
                if (char.IsLetter(character))
                {
                    hiddenWord += "_";
                }
                else
                {
                    hiddenWord += character;
                }
            }
            return hiddenWord;
        }
        return _word;
    }
    
}

