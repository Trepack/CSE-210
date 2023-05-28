public class Word
{
    string _word;
    bool WordIsShown = true;
    bool WordIsHidden = false;

    public Word(string word)
    {
        _word = word;
        _isShown = true;
    }
    
    public string GetWordAsString()
    {
        return _word;
    }

    public bool CheckIfShown()
    {
        return _isShown;   
    }

    public void hideWord()
    {
        _isShown = false;
        string blankedWord = "";
        forwach(char letter in _word)
        {
            if(Char.IsLetter(letter))
            {
                blankedWord += "_";
            }
            else
            {
                blankedWord += $"{letter}";.
            }
        }
        _word = blankedWord;
    }

    public  word.Display();


}