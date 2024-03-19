using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        //Reference is from Reference, text is from Program (?) for 
        //forming List of Words.
        _reference = Reference;
        string[] split_text = text.Split();
        for (int i = 0; i < split_text.Length; i++)
        {
            Word newN = new Word(split_text[i]);
            _words.Add(newN);
        }
        
    }
    
    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();

    }
    public string GetDisplayText()
    {
        //display text(scripture).
        List<string> list = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            list.Add(_words[i].GetDisplayText());
        }
        string text = String.Join(",", list);
        return text;
    }
    public bool IsCompletelyHidden()
    {
        bool re = false;
        int count = 0;
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden())
            {
                count++;
            }
        }
        if (count == _words.Count)
        {
            re = true;
        }
        return re;
    }
}