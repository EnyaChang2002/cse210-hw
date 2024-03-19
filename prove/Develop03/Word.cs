using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _text = "___";
    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        _isHidden = false;
        if (_text == "___")
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}   