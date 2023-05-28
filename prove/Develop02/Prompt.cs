public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("What did you do today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What annoying things happened today?");
        _prompts.Add("What do you hope to accomplish tomorrow");
    }

    public int GetRandomPrompt()
    {
        var Random = new Random();
        int index = Random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]); 
    }


}